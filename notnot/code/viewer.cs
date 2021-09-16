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
    public partial class Viewer : UserControl
    {
        public Viewer()
        {
            // Viewer()
            InitializeComponent();
        }


        private void Action_Menu_MoreZoom_Click(object Sender, EventArgs E)
        {
            // Action_Menu_MoreZoom_Click(object Sender, EventArgs E)
            if (RichTextBox.ZoomFactor < 5)
            {
                // true
                if (Action_Menu_LessZoom.Enabled == false)
                {
                    // true
                    Action_Menu_LessZoom.Enabled = true;
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

                RichTextBox.ZoomFactor += 1;
                Form Notify = new Notification($"Zoom: {RichTextBox.ZoomFactor}x");
                Notify.Name = "Notification";
                Rectangle R = Screen.PrimaryScreen.Bounds;
                Notify.Location = new Point(R.Width - Notify.Width - 16, R.Height - Notify.Height - 16);
                Notify.Opacity = Application.OpenForms["NotNot"].Opacity;
                Notify.Show();

                if (RichTextBox.ZoomFactor == 5)
                {
                    // true
                    Action_Menu_MoreZoom.Enabled = false;
                }
            }
        }


        private void Action_Menu_LessZoom_Click(object Sender, EventArgs E)
        {
            // Action_Menu_LessZoom_Click(object Sender, EventArgs E)
            if (RichTextBox.ZoomFactor > 1)
            {
                // true
                if (Action_Menu_MoreZoom.Enabled == false)
                {
                    // true
                    Action_Menu_MoreZoom.Enabled = true;
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

                RichTextBox.ZoomFactor -= 1;
                Form Notify = new Notification($"Zoom: {RichTextBox.ZoomFactor}x");
                Notify.Name = "Notification";
                Rectangle R = Screen.PrimaryScreen.Bounds;
                Notify.Location = new Point(R.Width - Notify.Width - 16, R.Height - Notify.Height - 16);
                Notify.Opacity = Application.OpenForms["NotNot"].Opacity;
                Notify.Show();

                if (RichTextBox.ZoomFactor == 1)
                {
                    // true
                    Action_Menu_LessZoom.Enabled = false;
                }
            }
        }


        private void Action_Menu_Close_Click(object Sender, EventArgs E)
        {
            // Action_Menu_Close_Click(object Sender, EventArgs E)
            Form Form = Application.OpenForms["NotNot"];
            Control Viewers = Form.Controls["Viewers"];
            Viewers.Controls.Remove(Viewers.Controls[Name]);
            Int32 ViewerCount = 1;

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


        private void Action_Menu_Open_Click(object Sender, EventArgs E)
        {
            // Action_Menu_Open_Click(object Sender, EventArgs E)
            if (Ofd.ShowDialog() == DialogResult.OK)
            {
                // true
                if (Path.GetExtension(Ofd.FileName) == ".rtf")
                {
                    // true
                    try
                    {
                        // try
                        RichTextBox.LoadFile(Ofd.FileName);
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
                        RichTextBox.Text = File.ReadAllText(Ofd.FileName);
                    }
                    catch
                    {
                        // catch
                        return;
                    }
                }
            }
        }


        private void Action_Menu_Save_Click(object Sender, EventArgs E)
        {
            // Action_Menu_Save_Click(object Sender, EventArgs E)
            if (Sfd.ShowDialog() == DialogResult.OK)
            {
                // true
                if (Path.GetExtension(Ofd.FileName) == ".rtf")
                {
                    // true
                    try
                    {
                        // try
                        RichTextBox.SaveFile(Ofd.FileName);
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
                        File.WriteAllText(Sfd.FileName, RichTextBox.Text);
                    }
                    catch
                    {
                        // catch
                        return;
                    }
                }
            }
        }


        private void Action_Menu_Undo_Click(object Sender, EventArgs E)
        {
            // Action_Menu_Undo_Click(object Sender, EventArgs E)
            RichTextBox.Undo();
        }


        private void Action_Menu_Redo_Click(object Sender, EventArgs E)
        {
            // Action_Menu_Redo_Click(object Sender, EventArgs E)
            RichTextBox.Redo();
        }


        private void Action_Menu_Cut_Click(object Sender, EventArgs E)
        {
            // Action_Menu_Cut_Click(object Sender, EventArgs E)
            RichTextBox.Cut();
        }


        private void Action_Menu_Copy_Click(object Sender, EventArgs E)
        {
            // Action_Menu_Copy_Click(object Sender, EventArgs E)
            RichTextBox.Copy();
        }


        private void Action_Menu_Paste_Click(object Sender, EventArgs E)
        {
            // Action_Menu_Paste_Click(object Sender, EventArgs E)
            RichTextBox.Paste();
        }


        private void Action_Menu_Delete_Click(object Sender, EventArgs E)
        {
            // Action_Menu_Delete_Click(object Sender, EventArgs E)
            RichTextBox.SelectedText = "";
        }
    }
}
