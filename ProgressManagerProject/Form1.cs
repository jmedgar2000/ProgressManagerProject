
using ProgressManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressManagerProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ts = new TimeSpan(10, 0, 1); // DateTime.Now.TimeOfDay;
            var tx = TimeSpan.FromMilliseconds(ts.TotalMilliseconds - 2000);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // List<string> l = File.ReadLines("words.txt").ToList();
            // l = l.Where(x => x == "junior").ToList();
            // var masterWords = l.Distinct().ToList();
            // Random rnd = new Random();

            // var pm = new ProgressManager(masterWords.Count);

            // pm.ProgressBar = progressBar1;
            // pm.NumberOfDecimalsForProgress = 2;

            //var subTask = pm.CreateSubProgressTask(0);
            // //subTask.CurrentItemIndexLabel = label10;
            // //subTask.RemainingItemsCountLabel = label5;
            // //subTask.ProgressLabel = label6;
            // subTask.ProgressBar = progressBar2;

            // foreach (var mw in masterWords)
            // {
            //     //pm.WriteValueLabel(mw);
            //     var words = (from w in l where w == mw select w).ToList();

            //     subTask.ResetTask();
            //     subTask.ItemsCount = words.Count();

            //     for(int i=0; i<words.Count; i++)
            //     {
            //         System.Threading.Thread.Sleep(rnd.Next(250, 450));
            //         subTask.PerformStep();

            //         subTask.SetControlText(label12, "Procesado {cii} de {ic} ({prog} %)");
            //         subTask.SetControlText(label4, "Tiempo restante: {et}");
            //         subTask.SetControlText(label13, "Tiempo transcurrido: {ts}");

            //     }

            // }

            List<string> l = File.ReadLines("words.txt").ToList();
            //l = l.Where(x => x == "crio").ToList();
            var masterWords = l.Distinct().ToList();
            Random rnd = new Random();

            var pm = new Progress(masterWords.Count);
            
            pm.ProgressBar = progressBar3;
            pm.NumberOfDecimalsForProgress = 2;
            pm.ProgressTickEvent += Pm_ProgressTickEvent;
            pm.ProcessCompletedEvent += Pm_ProcessCompletedEvent;

            //var subTask = pm.CreateSubProgressTask(0);

            //subTask.ProgressBar = progressBarEx2;

            foreach (var mw in masterWords)
            {
                var words = (from w in l where w == mw select w).ToList();

                //pm.ResetTask();
                pm.SetStartTime();
                pm.ItemsCount = words.Count();

                pm.SetControlText(lblElapsedTime, "{et}");
                pm.SetControlText(lblRemainingTime, "{rt}");

                for (int i = 0; i < words.Count; i++)
                {
                    System.Threading.Thread.Sleep(rnd.Next(100, 400));
                    pm.PerformStep();
                    pm.SetControlText(label14, "{prog} %");
                    pm.SetControlText(label16, "Procesando {cii} de {ic} archivos");
                }
            }
        }

        private void Pm_ProcessCompletedEvent(object sender)
        {
            var progressMan = sender as Progress;

            progressMan.SetControlText(lblElapsedTime, "{et}");
            progressMan.SetControlText(lblRemainingTime, "{rt}");
        }

        private void Pm_ProgressTickEvent(object sender)
        {
            var progressMan = sender as Progress;

            progressMan.SetControlText(lblElapsedTime, "{et}");
            progressMan.SetControlText(lblRemainingTime, "{rt}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("TEst");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            backgroundWorker2.RunWorkerAsync();
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            Random rnd = new Random();

            var pm = new Progress();

            pm.ProgressBar = progressBar3;
            pm.NumberOfDecimalsForProgress = 2;
            pm.ProgressTickEvent += Pm_ProgressTickEvent;
            pm.ProcessCompletedEvent += Pm_ProcessCompletedEvent;

            //var subTask = pm.CreateSubProgressTask(0);

            //subTask.ProgressBar = progressBarEx2;
            var totalProgress = 0F;
            var progress = 0F;

            pm.SetStartTime();

            while (totalProgress<101F)
            {
                progress = rnd.Next(5, 30) / 10F;
                totalProgress += progress;

                pm.SetControlText(lblElapsedTime, "{et}");
                pm.SetControlText(lblRemainingTime, "{rt}");
                               
                //IMPORTANTE: El tiempo que demora en procesar un pedazo de todo el Proceso esta relacionado
                //con el tiempo de procesado por eso se multiplican
                System.Threading.Thread.Sleep((int)(progress * rnd.Next(200 , 400)));

                Console.WriteLine(totalProgress.ToString());
                pm.PerformStep(totalProgress);
                pm.SetControlText(label14, "{prog} %");


            }

        }
    }
}
