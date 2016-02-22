using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.WindowsService
{
    public partial class CalculatorWindowsService : ServiceBase
    {
        public ServiceHost serviceHost = null;
        public CalculatorWindowsService()
        {
            InitializeComponent();

        }

        protected override void OnStart(string[] args)
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
            }

            // Create a ServiceHost for the CalculatorService type and 
            // provide the base address.
            serviceHost = new ServiceHost(typeof(CalculatorService));

            // Open the ServiceHostBase to create listeners and start 
            // listening for messages.
            serviceHost.Open(); 
        }

        protected override void OnStop()
        {
        }
    }
}
