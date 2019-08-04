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
        public Service1()
        {
            InitializeComponent();
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
