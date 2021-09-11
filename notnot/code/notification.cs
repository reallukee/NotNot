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
    public partial class Notification : Form
    {
        public Notification(string Text)
        {
            // Notification(string Text)
            InitializeComponent();
            Info.Text = Text;
        }


        private void Notification_Shown(object Sender, EventArgs E)
        {
            // Notification_Shown(object Sender, EventArgs E)
            Expiration.Enabled = true;
            Expiration.Start();
        }


        private void Expiration_Tick(object Sender, EventArgs E)
        {
            // Expiration_Tick(object Sender, EventArgs E)
            if (Expiration.Interval == 500)
            {
                // true
                Expiration.Interval = 50;
            }
            else
            {
                // false
                if (Opacity >= 0.1)
                {
                    // true
                    Opacity -= 0.05;
                }
                else
                {
                    // false
                    Dispose();
                }
            }
        }
    }
}
