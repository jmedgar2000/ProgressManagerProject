using ProgressODoom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressManagerProject
{
    class ProgressManager
    {
        private int currentItemIndex = 0;
        private int numberOfDecimalsForProgress;
        private int remainingItemsCount;
        private float avgTaskTime;
        private float progress;
        private TimeSpan previousTime;
        private TimeSpan currentTime;
        private TimeSpan remainingTime;
        private TimeSpan estimatedTime;
        private TimeSpan elapsedtime;
        private TimeSpan startTime;
        private System.Timers.Timer timer;
        //private TimerEx timex;

        public int ItemsCount { get; set; }
        public Label ValueLabel { get; set; }
        public Label CurrentItemIndexLabel { get; set; }
        public Label RemainingItemsCountLabel { get; set; }
        public Label ProgressLabel { get; set; }
        public ProgressBarEx ProgressBar { get; set; }
        public ProgressManager ParentProgressManager { get; set; }
        public List<ProgressManager> SubProgressManagers { get; }

        public delegate void ProcessCompleted(object sender);
        public event ProcessCompleted ProcessCompletedEvent;
        public delegate void ProgressTick(object sender);
        public event ProgressTick ProgressTickEvent;

        public int NumberOfDecimalsForProgress
        {
            get
            {
                return numberOfDecimalsForProgress;
            }
            set
            {
                if (value < 0 || value > 5)
                {
                    throw new ArgumentException("NumberOfDecimalsForProgress value must be between 0 and 5");
                }
                else
                {
                    numberOfDecimalsForProgress = value;
                }
            }
        }
        
        public ProgressManager(int itemsCount)
        {
            
            ItemsCount = itemsCount;
            numberOfDecimalsForProgress = 2;

            timer = new System.Timers.Timer(1000);
            timer.Elapsed += Timer_Elapsed;

            SubProgressManagers = new List<ProgressManager>();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (ProgressTickEvent != null)
            {
                elapsedtime = DateTime.Now.Subtract(startTime).TimeOfDay;
                ProgressTickEvent(this);
            }
        }
          
        public ProgressManager CreateSubProgressTask(int itemsCount)
        {
            ProgressManager progressManager = new ProgressManager(itemsCount);

            progressManager.ParentProgressManager = this;
            progressManager.NumberOfDecimalsForProgress = this.NumberOfDecimalsForProgress;
            progressManager.ProcessCompletedEvent += ProgressManager_ProcessCompletedEvent;

            SubProgressManagers.Add(progressManager);
            
            return progressManager;
        }

        private void ProgressManager_ProcessCompletedEvent(object sender)
        {
            PerformStep();
        }
        
        public void SetInitialTime()
        {
            startTime = DateTime.Now.TimeOfDay;
            previousTime = DateTime.Now.TimeOfDay;
            timer.Enabled = true;
            timer.Start();
        }
        
        public void SetControlText(Label label, string text)
        {
            label.Invoke((MethodInvoker)delegate
            {
                label.Text = GetRawText(text);
            });
        }

        private string GetRawText(string text)
        {
            text = text.Replace("{ic}", ItemsCount.ToString());
            text = text.Replace("{cii}", currentItemIndex.ToString());
            text = text.Replace("{ric}", remainingItemsCount.ToString());
            text = text.Replace("{prog}", progress.ToString("f" + numberOfDecimalsForProgress));
            text = text.Replace("{rt}", remainingTime.ToString(@"hh\:mm\:ss")); //@"hh\:mm\:ss\.ff"
            text = text.Replace("{et}", elapsedtime.ToString(@"hh\:mm\:ss")); //@"hh\:mm\:ss\.ff"
            text = text.Replace("{estt}", estimatedTime.ToString(@"hh\:mm\:ss\.f")); //@"hh\:mm\:ss\.ff"

            return text;
        }

        public void PerformStep()
        {
            if (ItemsCount <= 0) return;

            currentItemIndex++;
            avgTaskTime = (float)DateTime.Now.Subtract(startTime).TimeOfDay.TotalMilliseconds / currentItemIndex; 
            progress = (currentItemIndex / (float)ItemsCount) * 100F;
            
            if (ProgressBar != null)
            {
                ProgressBar.Invoke((MethodInvoker)delegate
                {
                    ProgressBar.Value = (int)progress;
                });
            }

            remainingItemsCount = (ItemsCount - currentItemIndex);
            remainingTime = TimeSpan.FromMilliseconds(remainingItemsCount * avgTaskTime);
            estimatedTime= TimeSpan.FromMilliseconds(ItemsCount * avgTaskTime);
            //Console.WriteLine("index: " + currentItemIndex + "  AvgTaskTime: " + avgTaskTime 
            //    + "  Remaining items: " + remainingItemsCount  + "   elapsedTime: " + elapsedTime);

            if (CurrentItemIndexLabel != null)
            {
                CurrentItemIndexLabel.Invoke((MethodInvoker)delegate
                {
                    CurrentItemIndexLabel.Text = currentItemIndex.ToString();
                });
            }

            if (RemainingItemsCountLabel != null)
            {
                RemainingItemsCountLabel.Invoke((MethodInvoker)delegate
                {
                    RemainingItemsCountLabel.Text = (ItemsCount - currentItemIndex).ToString();
                });
            }

            if (ProgressLabel != null)
            {
                ProgressLabel.Invoke((MethodInvoker)delegate
                {
                    ProgressLabel.Text = progress.ToString("f" + numberOfDecimalsForProgress) + " %";

                });
            }
            
            if ((int)progress == 100)
            {
                ResetTask();
                timer.Stop();

                if (ProcessCompletedEvent != null)
                {
                    ProcessCompletedEvent(this);
                }
            }
        }

        public void ResetTask()
        {
            ItemsCount = 0;
            currentItemIndex = 0;
            remainingItemsCount = 0;
            avgTaskTime = 0;
            progress = 0;
            remainingTime = new TimeSpan(0);
            estimatedTime =new TimeSpan();
            elapsedtime = new TimeSpan();
        }
    }
}
