using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace servicio1
{
    public partial class Service1 : ServiceBase
    {
        private static System.Windows.Forms.Timer timer;
        private static System.Timers.Timer timerTask;
        public Service1()
        {
            InitializeComponent();
        }

        public void init()
        {
            timerTask = new System.Timers.Timer();
            timerTask.Enabled = false;
            timerTask.Interval = 1000;
            timerTask.Elapsed += OnTimedEvent;
            timerTask.Start();
            //timer = new System.Windows.Forms.Timer();
            //timer.Enabled = false;
            //timer.Interval = 1000;
            //timer.Tick += System.EventHandler(this.hello);
        }

        private static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0}", e.SignalTime);
        }

        private void hello(object sender, EventArgs e)
        {

        }

        protected override void OnStart(string[] args)
        {
            //AddingNewEventHandler timer1, AddressOf(HagoAlgo)
            timer1.Start();
        }

        protected override void OnStop()
        {
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //StreamWriter wt = new StreamWriter();
            Console.WriteLine($"{DateTime.Now.ToString("dd/MM/yyyy")}");
        }
    }
}
