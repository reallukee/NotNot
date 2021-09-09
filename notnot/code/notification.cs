using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

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


        Int32 Time = 0;


        private void Notification_Shown(object Sender, EventArgs E)
        {
            // Notification_Shown(object Sender, EventArgs E)
            Expiration.Enabled = true;
            Expiration.Start();
        }


        private void Expiration_Tick(object Sender, EventArgs E)
        {
            // Expiration_Tick(object Sender, EventArgs E)
            if (Time == 5)
            {
                // true
                Dispose();
            }
            else
            {
                // false
                Time += 1;
            }
        }
    }
}
