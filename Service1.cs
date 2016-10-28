using System;
using System.ServiceProcess;
using System.IO;
using System.Threading;

namespace WindowsFileService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Time.txt";

            //string desktopPath = AppDomain.CurrentDomain.BaseDirectory + "Time.txt";

           // File.Create(desktopPath);

            do
            {
                Thread.Sleep(1200);
                try
                {
                    File.AppendAllText(desktopPath, DateTime.Now + "\n");
                }
                catch(Exception ex)
                {
                    //
                }
                
            } while (true);

        }

        protected override void OnStop()
        {

        }

        internal void OnDebag()
        {
            this.OnStart(null);
        }
    }
}
