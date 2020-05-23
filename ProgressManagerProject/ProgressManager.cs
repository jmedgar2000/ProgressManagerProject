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
        private int numberOfDecimalsForProgress;
        private int remainingItemsCount;
        public Label ValueLabel { get; set; }
        public int ItemsCount { get; set; }
        public Label CurrentItemIndexLabel { get; set; }
        public Label RemainingItemsCountLabel { get; set; }
        public Label ProgressLabel { get; set; }
        public ProgressBarEx ProgressBar { get; set; }
        private int currentItemIndex = 0;
        public ProgressManager ParentProgressManager { get; set; }
        public List<ProgressManager> SubProgressManagers { get; }
        private TimeSpan previousTime;
        private TimeSpan currentTime;
        private TimeSpan remainingTime;
        private TimeSpan estimatedTime;
        private TimeSpan elapsedtime;
        private double processTime;
        private float avgTaskTime;
        private float progress;

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

        public delegate void ProcessCompleted();
        public event ProcessCompleted ProcessCompletedEvent;

        public ProgressManager CreateSubProgressTask(int itemsCount)
        {
            ProgressManager progressManager = new ProgressManager(itemsCount);

            progressManager.ParentProgressManager = this;
            progressManager.NumberOfDecimalsForProgress = this.NumberOfDecimalsForProgress;
            progressManager.ProcessCompletedEvent += ProgressManager_ProcessCompletedEvent;

            SubProgressManagers.Add(progressManager);
            
            return progressManager;
        }

        private void ProgressManager_ProcessCompletedEvent()
        {
            PerformStep();
        }

        public ProgressManager(int itemsCount)
        {
            ItemsCount = itemsCount;
            numberOfDecimalsForProgress = 2;
            

            SubProgressManagers = new List<ProgressManager>();
        }

        public void WriteValueLabel(string text)
        {
            if (ValueLabel == null)
            {
                throw new ArgumentNullException("ValueLabel property is not set");

            }

            ValueLabel.Invoke((MethodInvoker)delegate
            {
                ValueLabel.Text = text;
            });

        }

        public void SetInitialTime()
        {
            previousTime = DateTime.Now.TimeOfDay;
        }

        public void PerformStep(string text)
        {
            //Es la misma que performStep notmal pero indicando que valor de texto esta siendo procesado
            if (ItemsCount <= 0) return;

            ValueLabel.Invoke((MethodInvoker)delegate
            {
                ValueLabel.Text = text;
            });

            PerformStep();

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
            //ItemsCount            ic
            //CurrentItemIndex      cii
            //RemainingItemsCount   ric
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

            if (currentItemIndex == 1)
            {
                currentTime = DateTime.Now.TimeOfDay;
                processTime = currentTime.Subtract(previousTime).TotalMilliseconds;
                avgTaskTime = (float)processTime;
            }
            else
            {
                previousTime = currentTime;
                currentTime = DateTime.Now.TimeOfDay;
                processTime += currentTime.Subtract(previousTime).TotalMilliseconds;
                avgTaskTime = (float)processTime / (currentItemIndex);
            }
                       
            progress = (currentItemIndex / (float)ItemsCount) * 100F;
            
            if (ProgressBar != null)
            {
                ProgressBar.Invoke((MethodInvoker)delegate
                {
                    ProgressBar.Value = (int)progress;
                });
            }

            if (currentItemIndex == 2)
            {
                var c = 0;
            }

            remainingItemsCount = (ItemsCount - currentItemIndex);
            elapsedtime = TimeSpan.FromMilliseconds(processTime);
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
                if (ProcessCompletedEvent != null)
                {
                    ProcessCompletedEvent();
                }
            }
        }

        public void ResetTask()
        {
            currentItemIndex = 0;
            remainingItemsCount = 0;
            processTime = 0;
            avgTaskTime = 0;
        }

    }
}
