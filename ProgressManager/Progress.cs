using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressManager
{
    public class Progress
    {
        private int currentItemIndex = 0;
        private int numberOfDecimalsForProgress;
        private int remainingItemsCount;
        private float avgTaskTime;
        private float progress;
        private TimeSpan remainingTime;
        private TimeSpan estimatedTime;
        private TimeSpan elapsedtime;
        private DateTime? startDateTime;
        private System.Timers.Timer timer;

        public int ItemsCount { get; set; }
        public ProgressBar ProgressBar { get; set; }
        public Progress ParentProgressManager { get; set; }
        public List<Progress> SubProgressManagers { get; }

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

        public Progress()
        {
            numberOfDecimalsForProgress = 2;

            timer = new System.Timers.Timer(1000);
            timer.Elapsed += Timer_Elapsed;
            //timer.Enabled = true;

            SubProgressManagers = new List<Progress>();
        }

        public Progress(int itemsCount):this()
        {
            ItemsCount = itemsCount;
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (startDateTime.HasValue == false)
            {
                throw new ArgumentException("Call SetStartTime before call PerformStep");
            }

            if (ProgressTickEvent != null)
            {
                Console.WriteLine(DateTime.Now.ToLongTimeString());
                elapsedtime = DateTime.Now.Subtract(startDateTime.Value);
                remainingTime = TimeSpan.FromMilliseconds(remainingTime.TotalMilliseconds - 1000);
                ProgressTickEvent(this);
            }
        }

        public Progress CreateSubProgressTask(int itemsCount)
        {
            Progress progressManager = new Progress(itemsCount)
            {
                ParentProgressManager = this,
                NumberOfDecimalsForProgress = this.NumberOfDecimalsForProgress
            };

            progressManager.ProcessCompletedEvent += ProgressManager_ProcessCompletedEvent;

            SubProgressManagers.Add(progressManager);

            return progressManager;
        }

        private void ProgressManager_ProcessCompletedEvent(object sender)
        {
            PerformStep();
        }

        public void SetStartTime()
        {
            startDateTime = DateTime.Now;
            timer.Enabled = true;
            timer.Start();

            //Cuando inicia el proceso y tiempo mandamos el evento tick aunque tenga 0 
            ProgressTickEvent(this);
        }

        public void SetControlText(Label label, string text)
        {
            label.Invoke((MethodInvoker)delegate
            {
                label.Text = GetRawText(text);
                label.Update();
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
            if (ItemsCount <= 0)
            {
                throw new ArgumentOutOfRangeException("ItemsCount can not be less or equal than 0");
            }

            if (startDateTime.HasValue==false)
            {
                throw new ArgumentException("Call SetStartTime before call PerformStep");
            }
            
            currentItemIndex++;
            avgTaskTime = (float)DateTime.Now.Subtract(startDateTime.Value).TotalMilliseconds / currentItemIndex;
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
            estimatedTime = TimeSpan.FromMilliseconds(ItemsCount * avgTaskTime);
            //Console.WriteLine("index: " + currentItemIndex + "  AvgTaskTime: " + avgTaskTime 
            //    + "  Remaining items: " + remainingItemsCount  + "   elapsedTime: " + elapsedTime);

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

        public void PerformStep(float progress)
        {
            if (progress == 0) return;

            if (startDateTime.HasValue == false)
            {
                throw new ArgumentException("Call SetStartTime before call PerformStep");
            }

            this.progress = progress;

            if (ProgressBar != null)
            {
                ProgressBar.Invoke((MethodInvoker)delegate
                {
                    if (progress > 0F )
                    {
                        if (progress <= 100F)
                            ProgressBar.Value = (int)progress;
                        else
                            ProgressBar.Value = 100;
                    }
                });
            }

            //remainingTime = TimeSpan.FromMilliseconds(((float)DateTime.Now.TimeOfDay.Subtract(startTime).TotalMilliseconds * 
            //    (100F - progress)) / progress);

            remainingTime = TimeSpan.FromMilliseconds(((float)DateTime.Now.Subtract(startDateTime.Value).TotalMilliseconds *
                (100F - progress)) / progress);
            //estimatedTime = TimeSpan.FromMilliseconds(ItemsCount * avgTaskTime);
            //Console.WriteLine("index: " + currentItemIndex + "  AvgTaskTime: " + avgTaskTime 
            //    + "  Remaining items: " + remainingItemsCount  + "   elapsedTime: " + elapsedTime);

            if ((int)progress >= 100)
            {
                ResetTask();
                timer.Stop();

                if (ProcessCompletedEvent != null)
                {
                    ProcessCompletedEvent(this);
                }
            }
        }


        private double ConverToMilliseconds(DateTime dateTime)
        {
            return dateTime.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
        }

        public void ResetTask()
        {
           
            remainingTime = new TimeSpan();
            estimatedTime = new TimeSpan();
            elapsedtime = new TimeSpan();
            startDateTime = null;
            remainingItemsCount = 0;
            currentItemIndex = 0;
            avgTaskTime = 0;
            ItemsCount = 0;
            progress = 0;
        }
    }
}
