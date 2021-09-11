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
    public partial class NotNot : Form
    {
        public NotNot()
        {
            // NotNotMain()
            InitializeComponent();
        }

        public Int32 ViewerCount = 1;

        private void NotNot_Load(object Sender, EventArgs E)
        {
            // NotNot_Load(object Sender, EventArgs E)
            Viewer NewViewer = new Viewer();
            NewViewer.Name = $"{ViewerCount}";
            Viewers.Controls.Add(NewViewer);
            ViewerCount++;

            if (Viewers.Controls.Count <= 3)
            {
                // true
                foreach (Control C in Viewers.Controls)
                {
                    // foreach
                    C.Size = new Size(Viewers.Width / Viewers.Controls.Count, Viewers.Height);
                }

                MinimumSize = new Size(525 * Viewers.Controls.Count, 525);
            }
            else
            {
                // false
                foreach (Control C in Viewers.Controls)
                {
                    // foreach
                    C.Size = new Size(Viewers.Width / 3, Viewers.Height / 2);
                }


                switch (Viewers.Controls.Count)
                {
                    // switch
                    case 4:
                        // case
                        Viewers.Controls[3].Size = new Size(Viewers.Width, Viewers.Height / 2);
                        break;

                    case 5:
                        // case
                        Viewers.Controls[4].Size = new Size(Viewers.Width / 3 * 2, Viewers.Height / 2);
                        break;
                }

                MinimumSize = new Size(1500, 850);
            }


            ViewerCount = 1;
            foreach (Control C in Viewers.Controls)
            {
                // foreach
                C.Name = $"{ViewerCount}";
                ViewerCount++;
            }
        }


        private void NotNot_Resize(object Sender, EventArgs E)
        {
            // NotNot_Resize(object Sender, EventArgs E)
            if (Viewers.Controls.Count >= 1)
            {
                // true
                if (Viewers.Controls.Count <= 3)
                {
                    // true
                    foreach (Control C in Viewers.Controls)
                    {
                        // foreach
                        C.Size = new Size(Viewers.Width / Viewers.Controls.Count, Viewers.Height);
                    }

                    MinimumSize = new Size(525 * Viewers.Controls.Count, 525);
                }
                else
                {
                    // false
                    foreach (Control C in Viewers.Controls)
                    {
                        // foreach
                        C.Size = new Size(Viewers.Width / 3, Viewers.Height / 2);
                    }


                    switch (Viewers.Controls.Count)
                    {
                        // switch
                        case 4:
                            // case
                            Viewers.Controls[3].Size = new Size(Viewers.Width, Viewers.Height / 2);
                            break;

                        case 5:
                            // case
                            Viewers.Controls[4].Size = new Size(Viewers.Width / 3 * 2, Viewers.Height / 2);
                            break;
                    }

                    MinimumSize = new Size(1575, 850);
                }
            }
            else
            {
                // false
                MinimumSize = new Size(525, 525);
            }
        }


        private void Action_Menu_MoreOpacity_Click(object Sender, EventArgs E)
        {
            // Action_Menu_MoreOpacity_Click(object Sender, EventArgs E)
            if (Opacity <= 1.0)
            {
                // true
                if (Action_Menu_LessOpacity.Enabled == false)
                {
                    // true
                    Action_Menu_LessOpacity.Enabled = true;
                }

                
                foreach (Form F in Application.OpenForms)
                {
                    // foreach
                    if (F.Name == "Notification")
                    {
                        // true
                        F.Dispose();
                        break;
                    }
                }

                Opacity += 0.1;
                Form Notify = new Notification($"Opacity: {Math.Round(Opacity * 10)}0%");
                Notify.Name = "Notification";
                Notify.Opacity = Opacity;
                Notify.Show();

                if (Opacity == 1.0)
                {
                    // true
                    Action_Menu_MoreOpacity.Enabled = false;
                }
            }
        }


        private void Action_Menu_LessOpacity_Click(object Sender, EventArgs E)
        {
            // Action_Menu_LessOpacity_Click(object Sender, EventArgs E)
            if (Opacity >= 0.3)
            {
                // true
                if (Action_Menu_MoreOpacity.Enabled == false)
                {
                    // true
                    Action_Menu_MoreOpacity.Enabled = true;
                }


                foreach (Form F in Application.OpenForms)
                {
                    // foreach
                    if (F.Name == "Notification")
                    {
                        // true
                        F.Dispose();
                        break;
                    }
                }

                Opacity -= 0.1;
                Form Notify = new Notification($"Opacity: {Math.Round(Opacity * 10)}0%");
                Notify.Name = "Notification";
                Notify.Opacity = Opacity;
                Notify.Show();

                if (Opacity == 0.3)
                {
                    // true
                    Action_Menu_LessOpacity.Enabled = false;
                }
            }
        }


        private void Action_Menu_AlwaysOnTop_Click(object Sender, EventArgs E)
        {
            // Action_Menu_AlwaysOnTop_Click(object Sender, EventArgs E)
            if (TopMost == true)
            {
                // true
                Action_Menu_AlwaysOnTop.Text = "";
                TopMost = false;
            }
            else
            {
                // false
                Action_Menu_AlwaysOnTop.Text = "";
                TopMost = true;
            }


            foreach (Form F in Application.OpenForms)
            {
                // foreach
                if (F.Name == "Notification")
                {
                    // true
                    F.Dispose();
                    break;
                }
            }

            Form Notify = new Notification($"Always on top: {TopMost.ToString().ToUpper()}");
            Notify.Name = "Notification";
            Notify.Opacity = Opacity;
            Notify.Show();
        }


        private void Action_Menu_FullScreen_Click(object Sender, EventArgs E)
        {
            // Action_Menu_FullScreen_Click(object Sender, EventArgs E)
            if (FormBorderStyle == FormBorderStyle.Sizable)
            {
                // true
                Action_Menu_FullScreen.Text = "";
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                // false
                Action_Menu_FullScreen.Text = "";
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
            }


            foreach (Form F in Application.OpenForms)
            {
                // foreach
                if (F.Name == "Notification")
                {
                    // true
                    F.Dispose();
                    break;
                }
            }


            if (FormBorderStyle == FormBorderStyle.None && WindowState == FormWindowState.Maximized)
            {
                // true
                Form Notify = new Notification($"Full screen: TRUE");
                Notify.Name = "Notification";
                Notify.Opacity = Opacity;
                Notify.Show();
            }
            else
            {
                // false
                Form Notify = new Notification($"Full screen: FALSE");
                Notify.Name = "Notification";
                Notify.Opacity = Opacity;
                Notify.Show();
            }      
        }


        private void Action_Menu_AddViewer_Click(object Sender, EventArgs E)
        {
            // Action_Menu_AddViewer_Click(object Sender, EventArgs E)
            Viewer NewViewer = new Viewer();
            NewViewer.Name = $"{ViewerCount}";
            Viewers.Controls.Add(NewViewer);
            ViewerCount++;

            if (Viewers.Controls.Count <= 3)
            {
                // true
                foreach (Control C in Viewers.Controls)
                {
                    // foreach
                    C.Size = new Size(Viewers.Width / Viewers.Controls.Count, Viewers.Height);
                }

                MinimumSize = new Size(525 * Viewers.Controls.Count, 525);
            }
            else
            {
                // false
                foreach (Control C in Viewers.Controls)
                {
                    // foreach
                    C.Size = new Size(Viewers.Width / 3, Viewers.Height / 2);
                }


                switch (Viewers.Controls.Count)
                {
                    // switch
                    case 4:
                        // case
                        Viewers.Controls[3].Size = new Size(Viewers.Width, Viewers.Height / 2);
                        break;

                    case 5:
                        // case
                        Viewers.Controls[4].Size = new Size(Viewers.Width / 3 * 2, Viewers.Height / 2);
                        break;
                }

                MinimumSize = new Size(1575, 850);
            }


            ViewerCount = 1;
            foreach (Control C in Viewers.Controls)
            {
                // foreach
                C.Name = $"{ViewerCount}";
                ViewerCount++;
            }
        }


        private void Viewers_ControlAdded(object Sender, ControlEventArgs E)
        {
            // Viewers_ControlAdded(object Sender, ControlEventArgs E)
            if (Viewers.Controls.Count >= 6)
            {
                // true
                Action_Menu_AddViewer.Enabled = false;
            }


            if (Viewers.Controls.Count >= 1)
            {
                // true
                Version.Visible = false;
            }
        }


        private void Viewers_ControlRemoved(object Sender, ControlEventArgs E)
        {
            // Viewers_ControlRemoved(object Sender, ControlEventArgs E)
            if (Viewers.Controls.Count <= 6)
            {
                // true
                Action_Menu_AddViewer.Enabled = true;
            }


            if (Viewers.Controls.Count <= 0)
            {
                // true
                Version.Visible = true;
            }
        }
    }
}
