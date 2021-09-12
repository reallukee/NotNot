using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;

namespace NotNot
{
    public class MyApplication : WindowsFormsApplicationBase
    {
        public MyApplication() : base(AuthenticationMode.Windows)
        {
            // MyApplication()
            IsSingleInstance = true;
            EnableVisualStyles = true;
            SaveMySettingsOnExit = true;
            ShutdownStyle = ShutdownMode.AfterMainFormCloses;
            MinimumSplashScreenDisplayTime = 1000;
            Startup += MyApplication_Startup;
            StartupNextInstance += MyApplication_StartupNextInstance;
            Shutdown += MyApplication_Shutdown;
            UnhandledException += MyApplication_UnhandledException;
            NetworkAvailabilityChanged += MyApplication_NetworkAvailabilityChanged;
        }


        protected override void OnCreateMainForm()
        {
            // OnCreteMainForm()
            MainForm = new NotNot();
        }


        protected override void OnCreateSplashScreen()
        {
            // OnCreateSplashScreen()
            // SplashScreen =
        }


        void MyApplication_Startup(Object Sender, StartupEventArgs E)
        {
            // MyApplication_Startup(Object Sender, StartupEventArgs E)
            NotNot Form = MainForm as NotNot;
        }


        void MyApplication_StartupNextInstance(Object Sender, StartupNextInstanceEventArgs E)
        {
            // MyApplication_StartupNextInstance(Object Sender, StartupNextInstanceEventArgs E)
            NotNot Form = MainForm as NotNot;

            if (E.CommandLine.Count > 1)
            {
                // true
                Form.FromMy(E.CommandLine[1]);
            }
        }


        void MyApplication_Shutdown(Object Sender, EventArgs E)
        {
            // MyApplication_Shutdown(Object Sender, EventArgs E)

        }


        void MyApplication_UnhandledException(Object Sender, Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs E)
        {
            // MyApplication_UnhandledException(Object Sender, UnhandledExceptionEventArgs E)

        }


        void MyApplication_NetworkAvailabilityChanged(Object Sender, NetworkAvailableEventArgs E)
        {
            // MyApplication_NetworkAvailabilityChanged(Object Sender, NetworkAvailableEventArgs E)

        }
    }
}
