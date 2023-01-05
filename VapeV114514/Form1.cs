using System;
using LogSystem;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using System.Media;

namespace VapeV114514
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        Log log = new Log();
        SoundPlayer sp = new SoundPlayer(Properties.Resource.g);
        private void button1_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(progress);
            th.Start();
        }
        public bool FindThread(string threadName)
        {
            Process[] processList = Process.GetProcesses();
            foreach (Process process in processList)
            {
                if (process.ProcessName.ToLower() == threadName.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        private void progress()
        {
            button1.Enabled = false;
            button1.Text = "Injecting...";
            int i = 0;
            while (true)
            {
                progressBar1.Value = i;
                i++;
                Thread.Sleep(100);
                if (progressBar1.Value >= 100)
                {
                    OpenMedia();
                    log.Error("2333333333333333333333333333333333333");
                    break;
                }
            }
        }
        void OpenMedia()
        {
            sp.PlayLooping();
        }

        void CloseMedia()
        {
            sp.Stop();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseMedia();
        }
    }
}
