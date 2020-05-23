using Harr;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            //HarrProgressBar pgb = new HarrProgressBar();
            //pgb.Padding = new Padding(5);
            //pgb.LeftText = "1";
            //pgb.MainText = "47x100x5400 - 20/100";
            //pgb.FillDegree = 20;
            //pgb.RightText = "1";
            //pgb.StatusText = "Raw";
            //pgb.StatusBarColor = 0;
            //pgb.Size = new Size(350,30);
            //pgb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            //flowLayoutPanel1.Controls.Add(pgb);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
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

            var pm = new ProgressManager(masterWords.Count);
            
            pm.ProgressBar = progressBarEx1;
            pm.NumberOfDecimalsForProgress = 2;

            var subTask = pm.CreateSubProgressTask(0);

            subTask.ProgressBar = progressBarEx2;

            foreach (var mw in masterWords)
            {
                //pm.WriteValueLabel(mw);
                var words = (from w in l where w == mw select w).ToList();

                pm.ResetTask();
                pm.SetInitialTime();
                pm.ItemsCount = words.Count();

                for (int i = 0; i < words.Count; i++)
                {
                    System.Threading.Thread.Sleep(rnd.Next(200, 400));
                    pm.PerformStep();
                    //subTask.SetControlText(label12, "Procesado {cii} de {ic} ({prog} %)");
                    //subTask.SetControlText(label4, "Tiempo restante: {et}");
                    //subTask.SetControlText(label13, "Tiempo transcurrido: {ts}");
                    pm.SetControlText(label14, "{prog} %");
                    pm.SetControlText(lblRemainingTime, "{rt}");
                    pm.SetControlText(label16, "Procesando {cii} de {ic} archivos");
                    pm.SetControlText(lblElapsedTime, "{et}");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        //private void panel1_Paint(object sender, PaintEventArgs e)
        //{
        //    ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        //}
    }
}
