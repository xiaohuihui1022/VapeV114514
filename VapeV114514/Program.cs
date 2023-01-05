using System.Windows.Forms;
using System.Text;
using LogSystem;
using System.Threading;

namespace VapeV114514
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread th = new Thread(SleepingThread);
            th.Start();
        }
        public static void SleepingThread()
        {
            Log log = new Log();
            int i = 0;
            while (i <= 48)
            {
                StringBuilder replacement = new StringBuilder(".");
                for (int q = 0; q < i; q++)
                {
                    replacement.Append(".");
                }
                Thread.Sleep(50);
                log.Info("Initializing VapeV114514" + replacement.ToString());
                i++;
            }
            log.Error("Find 6 errors in namesapce \"LogSystem\"");
            Thread.Sleep(2000);
            log.Error("Error log has been printed");
            Thread.Sleep(2000);
            log.Error("Error Code:114");
            Thread.Sleep(2000);
            log.Error("Please send this code to the operator who created LogSystem");
            Thread.Sleep(1000);
            log.Error("Or just expect that it will fixed by LogSys himself");
            Thread.Sleep(2000);
            log.Info("VapeV114514 has been Initialized");
            Thread.Sleep(2000);
            log.Warning("Althouth something in trouble, it can run!");
            Thread.Sleep(1000);
            log.Warning("Anyway, starting VapeV114514 now");
            Thread.Sleep(2000);
            log.Warning("It may take a while");
            Thread.Sleep(1000);
            log.Warning("please keep waiting");
            Thread.Sleep(3000);
            Application.Run(new Form1());
        }
    }
}
