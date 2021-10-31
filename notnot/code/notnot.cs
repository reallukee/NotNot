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
            InitializeComponent();
        }


        protected override void OnLoad(EventArgs E)
        {
            base.OnLoad(E);

            if (Environment.GetCommandLineArgs().Count() > 1)
            {
                FromMy(Environment.GetCommandLineArgs()[1]);
            }
            else
            {
                Show();
                BringToFront();
                return;
            }
        }


        public void FromMy(string Args)
        {
            int TempViewer = 1;

            if (char.IsNumber(Args[0]))
            {
                TempViewer = (int)char.GetNumericValue(Args[0]);
            }
            else
            {
                if (Args == "DragAndDrop")
                {

                }
                else
                {
                    Show();
                    BringToFront();
                    return;
                }
            }


            while (Viewers.Controls.Count < TempViewer)
            {
                Viewer2 NewViewer = new Viewer2();
                NewViewer.Name = $"{ViewerCount}";
                Viewers.Controls.Add(NewViewer);
                ViewerCount++;
            }


            try
            {
                if (Path.GetExtension(Strings.Mid(Args, 2)) == ".rtf")
                {
                    Viewer2 Temp = Viewers.Controls[TempViewer - 1] as Viewer2;
                    Temp.ViewerRichTextBox.LoadFile(Strings.Mid(Args, 2));
                    Temp.Controls["Viewer"].Controls.Clear();
                    Temp.Controls["Viewer"].Controls.Add(Temp.ViewerRichTextBox);
                    MenuStrip M = (MenuStrip)Temp.Controls["Action_Panel"].Controls["Action_Menu"];
                    M.Items["Action_Menu_Undo"].Enabled = true;
                    M.Items["Action_Menu_Redo"].Enabled = true;
                    M.Items["Action_Menu_Cut"].Enabled = true;
                    M.Items["Action_Menu_Copy"].Enabled = true;
                    M.Items["Action_Menu_Paste"].Enabled = true;
                    M.Items["Action_Menu_Delete"].Enabled = true;
                    M.Items["Action_Menu_MoreZoom"].Enabled = true;
                    M.Items["Action_Menu_LessZoom"].Enabled = true;
                }
                else
                {
                    Viewer2 Temp = Viewers.Controls[TempViewer - 1] as Viewer2;
                    Temp.ViewerPictureBox.Image = Image.FromFile(Strings.Mid(Args, 2));
                    Temp.Controls["Viewer"].Controls.Clear();
                    Temp.Controls["Viewer"].Controls.Add(Temp.ViewerPictureBox);
                    MenuStrip M = (MenuStrip)Temp.Controls["Action_Panel"].Controls["Action_Menu"];
                    M.Items["Action_Menu_Undo"].Enabled = false;
                    M.Items["Action_Menu_Redo"].Enabled = false;
                    M.Items["Action_Menu_Cut"].Enabled = false;
                    M.Items["Action_Menu_Copy"].Enabled = false;
                    M.Items["Action_Menu_Paste"].Enabled = false;
                    M.Items["Action_Menu_Delete"].Enabled = false;
                    M.Items["Action_Menu_MoreZoom"].Enabled = false;
                    M.Items["Action_Menu_LessZoom"].Enabled = false;
                }
            }
            catch
            {
                Viewer2 Temp = Viewers.Controls[TempViewer - 1] as Viewer2;
                Temp.ViewerTextBox.Text = File.ReadAllText(Strings.Mid(Args, 2));
                Temp.Controls["Viewer"].Controls.Clear();
                Temp.Controls["Viewer"].Controls.Add(Temp.ViewerTextBox);
                MenuStrip M = (MenuStrip)Temp.Controls["Action_Panel"].Controls["Action_Menu"];
                M.Items["Action_Menu_Undo"].Enabled = true;
                M.Items["Action_Menu_Redo"].Enabled = false;
                M.Items["Action_Menu_Cut"].Enabled = true;
                M.Items["Action_Menu_Copy"].Enabled = true;
                M.Items["Action_Menu_Paste"].Enabled = true;
                M.Items["Action_Menu_Delete"].Enabled = true;
                M.Items["Action_Menu_MoreZoom"].Enabled = false;
                M.Items["Action_Menu_LessZoom"].Enabled = false;
            }

            Show();
            BringToFront();
            return;
        }

        public int ViewerCount = 1;

        private void NotNot_Load(object Sender, EventArgs E)
        {
            Viewer2 NewViewer = new Viewer2();
            NewViewer.Name = $"{ViewerCount}";
            Viewers.Controls.Add(NewViewer);
            ViewerCount++;
        }


        private void Action_Menu_AddViewer_Click(object Sender, EventArgs E)
        {
            Viewer2 NewViewer = new Viewer2();
            NewViewer.Name = $"{ViewerCount}";
            Viewers.Controls.Add(NewViewer);
            ViewerCount++;
        }


        private void Action_Menu_DragAndDrop_Click(object Sender, EventArgs E)
        {
            foreach (Form F in Application.OpenForms)
            {
                if (F.Name == "DragAndDrop")
                {
                    F.Dispose();
                    break;
                }
            }

            Form DragAndDrop = new DragAndDrop();
            DragAndDrop.Name = "DragAndDrop";
            DragAndDrop.Location = new Point(32, 32);
            DragAndDrop.Opacity = Opacity;
            DragAndDrop.Show();
        }


        private void NI_Menu_DragAndDrop_Click(object Sender, EventArgs E)
        {
            foreach (Form F in Application.OpenForms)
            {
                if (F.Name == "DragAndDrop")
                {
                    F.Dispose();
                    break;
                }
            }

            Form DragAndDrop = new DragAndDrop();
            DragAndDrop.Name = "DragAndDrop";
            DragAndDrop.Location = new Point(32, 32);
            DragAndDrop.Opacity = Opacity;
            DragAndDrop.Show();
        }


        private void Action_Menu_MoreOpacity_Click(object Sender, EventArgs E)
        {
            if (Opacity <= 1.0)
            {
                if (Action_Menu_LessOpacity.Enabled == false)
                {
                    Action_Menu_LessOpacity.Enabled = true;
                }

                
                foreach (Form F in Application.OpenForms)
                {
                    if (F.Name == "Notification")
                    {
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
                    Action_Menu_MoreOpacity.Enabled = false;
                }
            }
        }


        private void Action_Menu_LessOpacity_Click(object Sender, EventArgs E)
        {
            if (Opacity >= 0.3)
            {
                if (Action_Menu_MoreOpacity.Enabled == false)
                {
                    Action_Menu_MoreOpacity.Enabled = true;
                }


                foreach (Form F in Application.OpenForms)
                {
                    if (F.Name == "Notification")
                    {
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
                    Action_Menu_LessOpacity.Enabled = false;
                }
            }
        }


        private void Action_Menu_AlwaysOnTop_Click(object Sender, EventArgs E)
        {
            if (TopMost == true)
            {
                Action_Menu_AlwaysOnTop.Text = "";
                TopMost = false;
            }
            else
            {
                Action_Menu_AlwaysOnTop.Text = "";
                TopMost = true;
            }


            foreach (Form F in Application.OpenForms)
            {
                if (F.Name == "Notification")
                {
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
            if (FormBorderStyle == FormBorderStyle.Sizable)
            {
                Action_Menu_FullScreen.Text = "";
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                Action_Menu_FullScreen.Text = "";
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
            }


            foreach (Form F in Application.OpenForms)
            {
                if (F.Name == "Notification")
                {
                    F.Dispose();
                    break;
                }
            }


            if (FormBorderStyle == FormBorderStyle.None && WindowState == FormWindowState.Maximized)
            {
                Form Notify = new Notification($"Full screen: TRUE", 500);
                Notify.Name = "Notification";
                Rectangle R = Screen.PrimaryScreen.Bounds;
                Notify.Location = new Point(R.Width - Notify.Width - 16, R.Height - Notify.Height - 16);
                Notify.Opacity = Opacity;
                Notify.Show();
            }
            else
            {
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
            if (Viewers.Controls.Count >= 1)
            {
                if (Viewers.Controls.Count <= 3)
                {
                    foreach (Control C in Viewers.Controls)
                    {
                        C.Size = new Size(Viewers.Width / Viewers.Controls.Count, Viewers.Height);
                    }

                    MinimumSize = new Size(525 * Viewers.Controls.Count, 525 + 50 * Viewers.Controls.Count);
                }
                else
                {
                    foreach (Control C in Viewers.Controls)
                    {
                        C.Size = new Size(Viewers.Width / 3, Viewers.Height / 2);
                    }


                    switch (Viewers.Controls.Count)
                    {
                        case 4:
                            Viewers.Controls[3].Size = new Size(Viewers.Width, Viewers.Height / 2);
                            break;

                        case 5:
                            Viewers.Controls[4].Size = new Size(Viewers.Width / 3 * 2, Viewers.Height / 2);
                            break;
                    }

                    MinimumSize = new Size(1575, 850);
                }
            }
            else
            {
                MinimumSize = new Size(525, 525);
            }


            foreach (Control C in Viewers.Controls)
            {
                Control ViewerTemp = C.Controls["Viewer"];

                foreach (Control Child in ViewerTemp.Controls)
                {
                    if (Child.Name == "Info")
                    {
                        Child.Location = new Point((ViewerTemp.Width - Child.Width) / 2, (ViewerTemp.Height - Child.Height) / 2);
                    }
                }
            }
        }


        private void Viewers_ControlAdded(object Sender, ControlEventArgs E)
        {
            if (Viewers.Controls.Count >= 6)
            {
                Action_Menu_AddViewer.Enabled = false;
            }


            if (Viewers.Controls.Count >= 0)
            {
                Version.Visible = false;
                Shortcurts.Visible = false;
                MinimumSize = new Size(525, 525);
            }


            if (Viewers.Controls.Count >= 1)
            {
                if (Viewers.Controls.Count <= 3)
                {
                    foreach (Control C in Viewers.Controls)
                    {
                        C.Size = new Size(Viewers.Width / Viewers.Controls.Count, Viewers.Height);
                    }

                    MinimumSize = new Size(525 * Viewers.Controls.Count, 525 + 50 * Viewers.Controls.Count);
                }
                else
                {
                    foreach (Control C in Viewers.Controls)
                    {
                        C.Size = new Size(Viewers.Width / 3, Viewers.Height / 2);
                    }


                    switch (Viewers.Controls.Count)
                    {
                        case 4:
                            Viewers.Controls[3].Size = new Size(Viewers.Width, Viewers.Height / 2);
                            break;

                        case 5:
                            Viewers.Controls[4].Size = new Size(Viewers.Width / 3 * 2, Viewers.Height / 2);
                            break;
                    }

                    MinimumSize = new Size(1575, 850);
                }
            }
            else
            {
                MinimumSize = new Size(525, 525);
            }


            ViewerCount = 1;
            foreach (Control C in Viewers.Controls)
            {
                C.Name = $"{ViewerCount}";
                ViewerCount++;
            }


            foreach (Control C in Viewers.Controls)
            {
                Control ViewerTemp = C.Controls["Viewer"];

                foreach (Control Child in ViewerTemp.Controls)
                {
                    if (Child.Name == "Info")
                    {
                        Child.Location = new Point((ViewerTemp.Width - Child.Width) / 2, (ViewerTemp.Height - Child.Height) / 2);
                    }
                }
            }
        }


        private void Viewers_ControlRemoved(object Sender, ControlEventArgs E)
        {
            if (Viewers.Controls.Count <= 6)
            {
                Action_Menu_AddViewer.Enabled = true;             
            }


            if (Viewers.Controls.Count <= 0)
            {
                Version.Visible = true;
                Shortcurts.Visible = true;
                MinimumSize = new Size(525, 525);
            }


            if (Viewers.Controls.Count >= 1)
            {
                if (Viewers.Controls.Count <= 3)
                {
                    foreach (Control C in Viewers.Controls)
                    {
                        C.Size = new Size(Viewers.Width / Viewers.Controls.Count, Viewers.Height);
                    }

                    MinimumSize = new Size(525 * Viewers.Controls.Count, 525 + 50 * Viewers.Controls.Count);
                }
                else
                {
                    foreach (Control C in Viewers.Controls)
                    {
                        C.Size = new Size(Viewers.Width / 3, Viewers.Height / 2);
                    }


                    switch (Viewers.Controls.Count)
                    {
                        case 4:
                            Viewers.Controls[3].Size = new Size(Viewers.Width, Viewers.Height / 2);
                            break;

                        case 5:
                            Viewers.Controls[4].Size = new Size(Viewers.Width / 3 * 2, Viewers.Height / 2);
                            break;
                    }

                    MinimumSize = new Size(1575, 850);
                }
            }
            else
            {
                MinimumSize = new Size(525, 525);
            }


            ViewerCount = 1;
            foreach (Control C in Viewers.Controls)
            {
                C.Name = $"{ViewerCount}";
                ViewerCount++;
            }


            foreach (Control C in Viewers.Controls)
            {
                Control ViewerTemp = C.Controls["Viewer"];

                foreach (Control Child in ViewerTemp.Controls)
                {
                    if (Child.Name == "Info")
                    {
                        Child.Location = new Point((ViewerTemp.Width - Child.Width) / 2, (ViewerTemp.Height - Child.Height) / 2);
                    }
                }
            }
        }


        private void NotNot_FormClosing(object Sender, FormClosingEventArgs E)
        {
            E.Cancel = true;
            Hide();
        }


        private void NI_DoubleClick(object Sender, EventArgs E)
        {
            Show();
            BringToFront();
        }


        private void NI_Menu_NotNot_Click(object Sender, EventArgs E)
        {
            Show();
            BringToFront();
        }


        private void NI_Menu_Hide_Click(object Sender, EventArgs E)
        {
            Hide();
        }


        private void NI_Menu_Close_Click(object Sender, EventArgs E)
        {
            Environment.Exit(0);
        }


        private void NotNot_VisibleChanged(object Sender, EventArgs E)
        {
            if (Visible == true)
            {
                // true
                NI_Menu_Show.Enabled = false;
                NI_Menu_Hide.Enabled = true;
            }
            else
            {
                // false
                NI_Menu_Show.Enabled = true;
                NI_Menu_Hide.Enabled = false;
            }
        }
    }
}
