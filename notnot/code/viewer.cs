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
                Form Notify = new Notification($"Zoom: {RichTextBox.ZoomFactor}x", 500);
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
                Form Notify = new Notification($"Zoom: {RichTextBox.ZoomFactor}x", 500);
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
            Dispose();
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
                        RichTextBox.Visible = true;
                        PictureBox.Visible = false;
                        TextBox.Visible = false;
                        Action_Menu_Open.Enabled = true;
                        Action_Menu_Save.Enabled = true;
                        Action_Menu_Undo.Enabled = true;
                        Action_Menu_Redo.Enabled = true;
                        Action_Menu_Cut.Enabled = true;
                        Action_Menu_Copy.Enabled = true;
                        Action_Menu_Paste.Enabled = true;
                        Action_Menu_Delete.Enabled = true;
                        Action_Menu_MoreZoom.Enabled = true;
                        Action_Menu_LessZoom.Enabled = true;
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
                        PictureBox.Image = Image.FromFile(Ofd.FileName);
                        RichTextBox.Visible = false;
                        PictureBox.Visible = true;
                        TextBox.Visible = false;
                        Action_Menu_Open.Enabled = true;
                        Action_Menu_Save.Enabled = false;
                        Action_Menu_Undo.Enabled = false;
                        Action_Menu_Redo.Enabled = false;
                        Action_Menu_Cut.Enabled = false;
                        Action_Menu_Copy.Enabled = false;
                        Action_Menu_Paste.Enabled = false;
                        Action_Menu_Delete.Enabled = false;
                        Action_Menu_MoreZoom.Enabled = false;
                        Action_Menu_LessZoom.Enabled = false;
                    }
                    catch
                    {
                        // catch
                        try
                        {
                            // try
                            TextBox.Text = File.ReadAllText(Ofd.FileName);
                            RichTextBox.Visible = false;
                            PictureBox.Visible = false;
                            TextBox.Visible = true;
                            Action_Menu_Open.Enabled = true;
                            Action_Menu_Save.Enabled = true;
                            Action_Menu_Undo.Enabled = true;
                            Action_Menu_Redo.Enabled = false;
                            Action_Menu_Cut.Enabled = true;
                            Action_Menu_Copy.Enabled = true;
                            Action_Menu_Paste.Enabled = true;
                            Action_Menu_Delete.Enabled = true;
                            Action_Menu_MoreZoom.Enabled = false;
                            Action_Menu_LessZoom.Enabled = false;
                        }
                        catch
                        {
                            // catch
                            return;
                        }
                    }
                }
            }
        }


        private void Action_Menu_Save_Click(object Sender, EventArgs E)
        {
            // Action_Menu_Save_Click(object Sender, EventArgs E)
            if (RichTextBox.Visible == true)
            {
                if (Sfd.ShowDialog() == DialogResult.OK)
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
            }


            if (TextBox.Visible == true)
            {
                if (Sfd.ShowDialog() == DialogResult.OK)
                {
                    // true
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
            if (RichTextBox.Visible == true)
            {
                // true
                RichTextBox.Undo();
            }


            if (TextBox.Visible == true)
            {
                // true
                TextBox.Undo();
            }
        }


        private void Action_Menu_Redo_Click(object Sender, EventArgs E)
        {
            // Action_Menu_Redo_Click(object Sender, EventArgs E)
            if (RichTextBox.Visible == true)
            {
                // true
                RichTextBox.Redo();
            }
        }


        private void Action_Menu_Cut_Click(object Sender, EventArgs E)
        {
            // Action_Menu_Cut_Click(object Sender, EventArgs E)
            if (RichTextBox.Visible == true)
            {
                // true
                RichTextBox.Cut();
            }


            if (TextBox.Visible == true)
            {
                // true
                TextBox.Cut();
            }
        }


        private void Action_Menu_Copy_Click(object Sender, EventArgs E)
        {
            // Action_Menu_Copy_Click(object Sender, EventArgs E)
            if (RichTextBox.Visible == true)
            {
                // true
                RichTextBox.Copy();
            }


            if (TextBox.Visible == true)
            {
                // true
                TextBox.Copy();
            }
        }


        private void Action_Menu_Paste_Click(object Sender, EventArgs E)
        {
            // Action_Menu_Paste_Click(object Sender, EventArgs E)
            if (RichTextBox.Visible == true)
            {
                // true
                RichTextBox.Paste();
            }


            if (TextBox.Visible == true)
            {
                // true
                TextBox.Paste();
            }
        }


        private void Action_Menu_Delete_Click(object Sender, EventArgs E)
        {
            // Action_Menu_Delete_Click(object Sender, EventArgs E)
            if (RichTextBox.Visible == true)
            {
                // true
                RichTextBox.SelectedText = "";
            }


            if (TextBox.Visible == true)
            {
                // true
                TextBox.SelectedText = "";
            }
        }
    }
}
