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


        protected override void OnLoad(EventArgs E)
        {
            // OnLoad(EventArgs E)
            base.OnLoad(E);

            if (Environment.GetCommandLineArgs().Count() > 1)
            {
                // true
                FromMy(Environment.GetCommandLineArgs()[1]);
            }

            BringToFront();
        }


        public void FromMy(string Args)
        {
            // FromMy(string Args)
            int Viewer = 1;

            if (char.IsNumber(Args[0]))
            {
                // true
                try
                {
                    // try
                    Viewer = (int)char.GetNumericValue(Args[0]);
                }
                catch
                {
                    // catch
                    return;
                }


                if (Viewer < 1 || Viewer > 6)
                {
                    // true
                    return;
                }
            }
            else
            {
                // false
                return;
            }


            while (Viewers.Controls.Count < Viewer)
            {
                // while
                Viewer NewViewer = new Viewer();
                NewViewer.Name = $"{ViewerCount}";
                Viewers.Controls.Add(NewViewer);
                ViewerCount++;
            }


            if (Path.GetExtension(Strings.Mid(Args, 2)) == ".rtf")
            {
                // true
                try
                {
                    // try
                    Viewer Temp = Viewers.Controls[Viewer - 1] as Viewer;
                    RichTextBox R = (RichTextBox)Temp.Controls["RichTextBox"];
                    R.LoadFile(Strings.Mid(Args, 2));
                    Temp.Controls["RichTextBox"].Visible = true;
                    Temp.Controls["PictureBox"].Visible = false;
                    Temp.Controls["TextBox"].Visible = false;
                    MenuStrip M = (MenuStrip)Temp.Controls["Action_Panel"].Controls["Action_Menu"];
                    M.Items["Action_Menu_Open"].Enabled = false;
                    M.Items["Action_Menu_Save"].Enabled = false;
                    M.Items["Action_Menu_Undo"].Enabled = false;
                    M.Items["Action_Menu_Redo"].Enabled = false;
                    M.Items["Action_Menu_Cut"].Enabled = false;
                    M.Items["Action_Menu_Copy"].Enabled = false;
                    M.Items["Action_Menu_Paste"].Enabled = false;
                    M.Items["Action_Menu_Delete"].Enabled = false;
                    M.Items["Action_Menu_MoreZoom"].Enabled = false;
                    M.Items["Action_Menu_LessZoom"].Enabled = false;
                }
                catch
                {
                    // catch
                    return;
                }
            }
            else
            {
                // false
                try
                {
                    // try
                    Viewer Temp = Viewers.Controls[Viewer - 1] as Viewer;
                    PictureBox R = (PictureBox)Temp.Controls["PictureBox"];
                    R.Image = Image.FromFile(Strings.Mid(Args, 2));
                    Temp.Controls["RichTextBox"].Visible = false;
                    Temp.Controls["PictureBox"].Visible = true;
                    Temp.Controls["TextBox"].Visible = false;
                    MenuStrip M = (MenuStrip)Temp.Controls["Action_Panel"].Controls["Action_Menu"];
                    M.Items["Action_Menu_Open"].Enabled = true;
                    M.Items["Action_Menu_Save"].Enabled = false;
                    M.Items["Action_Menu_Undo"].Enabled = false;
                    M.Items["Action_Menu_Redo"].Enabled = false;
                    M.Items["Action_Menu_Cut"].Enabled = false;
                    M.Items["Action_Menu_Copy"].Enabled = false;
                    M.Items["Action_Menu_Paste"].Enabled = false;
                    M.Items["Action_Menu_Delete"].Enabled = false;
                    M.Items["Action_Menu_MoreZoom"].Enabled = false;
                    M.Items["Action_Menu_LessZoom"].Enabled = false;
                }
                catch
                {
                    // catch
                    try
                    {
                        // try
                        Viewer Temp = Viewers.Controls[Viewer - 1] as Viewer;
                        TextBox R = (TextBox)Temp.Controls["TextBox"];
                        R.Text = File.ReadAllText(Strings.Mid(Args, 2));
                        Temp.Controls["RichTextBox"].Visible = false;
                        Temp.Controls["PictureBox"].Visible = false;
                        Temp.Controls["TextBox"].Visible = true;
                        MenuStrip M = (MenuStrip)Temp.Controls["Action_Panel"].Controls["Action_Menu"];
                        M.Items["Action_Menu_Open"].Enabled = true;
                        M.Items["Action_Menu_Save"].Enabled = true;
                        M.Items["Action_Menu_Undo"].Enabled = true;
                        M.Items["Action_Menu_Redo"].Enabled = false;
                        M.Items["Action_Menu_Cut"].Enabled = true;
                        M.Items["Action_Menu_Copy"].Enabled = true;
                        M.Items["Action_Menu_Paste"].Enabled = true;
                        M.Items["Action_Menu_Delete"].Enabled = true;
                        M.Items["Action_Menu_MoreZoom"].Enabled = false;
                        M.Items["Action_Menu_LessZoom"].Enabled = false;
                    }
                    catch
                    {
                        // catch
                        return;
                    }
                }
            }

            BringToFront();
        }

        public int ViewerCount = 1;

        private void NotNot_Load(object Sender, EventArgs E)
        {
            // NotNot_Load(object Sender, EventArgs E)
            Viewer NewViewer = new Viewer();
            NewViewer.Name = $"{ViewerCount}";
            Viewers.Controls.Add(NewViewer);
            ViewerCount++;
        }


        private void Action_Menu_AddViewer_Click(object Sender, EventArgs E)
        {
            // Action_Menu_AddViewer_Click(object Sender, EventArgs E)
            Viewer NewViewer = new Viewer();
            NewViewer.Name = $"{ViewerCount}";
            Viewers.Controls.Add(NewViewer);
            ViewerCount++;
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
                Form Notify = new Notification($"Opacity: {Math.Round(Opacity * 10)}0%", 500);
                Notify.Name = "Notification";
                Rectangle R = Screen.PrimaryScreen.Bounds;
                Notify.Location = new Point(R.Width - Notify.Width - 16, R.Height - Notify.Height - 16);
                Notify.Opacity = Opacity;
                Notify.Show();

                if (Opacity >= 1.0)
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
                Form Notify = new Notification($"Opacity: {Math.Round(Opacity * 10)}0%", 500);
                Notify.Name = "Notification";
                Rectangle R = Screen.PrimaryScreen.Bounds;
                Notify.Location = new Point(R.Width - Notify.Width - 16, R.Height - Notify.Height - 16);
                Notify.Opacity = Opacity;
                Notify.Show();

                if (Opacity <= 0.3)
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

            Form Notify = new Notification($"Always on top: {TopMost.ToString().ToUpper()}", 500);
            Notify.Name = "Notification";
            Rectangle R = Screen.PrimaryScreen.Bounds;
            Notify.Location = new Point(R.Width - Notify.Width - 16, R.Height - Notify.Height - 16);
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
                Form Notify = new Notification($"Full screen: TRUE", 500);
                Notify.Name = "Notification";
                Rectangle R = Screen.PrimaryScreen.Bounds;
                Notify.Location = new Point(R.Width - Notify.Width - 16, R.Height - Notify.Height - 16);
                Notify.Opacity = Opacity;
                Notify.Show();
            }
            else
            {
                // false
                Form Notify = new Notification($"Full screen: FALSE", 500);
                Notify.Name = "Notification";
                Rectangle R = Screen.PrimaryScreen.Bounds;
                Notify.Location = new Point(R.Width - Notify.Width - 16, R.Height - Notify.Height - 16);
                Notify.Opacity = Opacity;
                Notify.Show();
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


            if (Width < 1175 || Height < 600)
            {
                // true
                Shortcurts.Size = new Size(0, 0);
            }
            else
            {
                // false
                Shortcurts.Size = new Size(340, 340);
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


            if (Viewers.Controls.Count >= 0)
            {
                // true
                Version.Visible = false;
                Shortcurts.Visible = false;
                MinimumSize = new Size(525, 525);
            }


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


            ViewerCount = 1;
            foreach (Control C in Viewers.Controls)
            {
                // foreach
                C.Name = $"{ViewerCount}";
                ViewerCount++;
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
                Shortcurts.Visible = true;
                MinimumSize = new Size(525, 525);
            }


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


            ViewerCount = 1;
            foreach (Control C in Viewers.Controls)
            {
                // foreach
                C.Name = $"{ViewerCount}";
                ViewerCount++;
            }
        }


        private void NotNot_FormClosing(object Sender, FormClosingEventArgs E)
        {
            // NotNot_FormClosing(object Sender, FormClosingEventArgs E)ù
            E.Cancel = true;
            Hide();
        }


        private void NI_Menu_NotNot_Click(object Sender, EventArgs E)
        {
            // NI_Menu_NotNot_Click(object Sender, EventArgs E)
            if (Visible == true)
            {
                // true
                BringToFront();
            }
            else
            {
                // false
                Show();
            }
        }


        private void NI_Menu_Hide_Click(object Sender, EventArgs E)
        {
            // NI_Menu_Hide_Click(object Sender, EventArgs E)
            if (Visible == true)
            {
                // true
                Hide();
            }
        }


        private void NI_Menu_Close_Click(object Sender, EventArgs E)
        {
            // NI_Menu_Close_Click(object Sender, EventArgs E)
            Environment.Exit(0);
        }
    }
}
