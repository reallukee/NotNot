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
    public partial class Viewer2 : UserControl
    {
        public Viewer2()
        {
            InitializeComponent();
        }


        public TextBox ViewerTextBox = new TextBox()
        {
            BorderStyle = BorderStyle.None,
            Dock = DockStyle.Fill,
            Multiline = true,
            ScrollBars = ScrollBars.Horizontal
        };


        public RichTextBox ViewerRichTextBox = new RichTextBox()
        {
            BorderStyle = BorderStyle.None,
            Dock = DockStyle.Fill,
            Multiline = true,
            ScrollBars = RichTextBoxScrollBars.ForcedVertical
        };


        public PictureBox ViewerPictureBox = new PictureBox()
        {
            BorderStyle = BorderStyle.None,
            Dock = DockStyle.Fill,
            SizeMode = PictureBoxSizeMode.Zoom
        };


        private void Action_Menu_MoreZoom_Click(object Sender, EventArgs E)
        {
            if (Viewer.Controls.Contains(ViewerRichTextBox))
            {
                if (ViewerRichTextBox.ZoomFactor < 5)
                {
                    if (Action_Menu_LessZoom.Enabled == false)
                    {
                        Action_Menu_LessZoom.Enabled = true;
                    }


                    foreach (Form F in Application.OpenForms)
                    {
                        if (F.Name == "Notification")
                        {
                            F.Dispose();
                            break;
                        }
                    }

                    ViewerRichTextBox.ZoomFactor += 1;
                    Form Notify = new Notification($"Zoom: {ViewerRichTextBox.ZoomFactor}x", 500);
                    Notify.Name = "Notification";
                    Rectangle R = Screen.PrimaryScreen.Bounds;
                    Notify.Location = new Point(R.Width - Notify.Width - 16, R.Height - Notify.Height - 16);
                    Notify.Opacity = Application.OpenForms["NotNot"].Opacity;
                    Notify.Show();

                    if (ViewerRichTextBox.ZoomFactor == 5)
                    {
                        // true
                        Action_Menu_MoreZoom.Enabled = false;
                    }
                }
            }
        }


        private void Action_Menu_LessZoom_Click(object Sender, EventArgs E)
        {
            if (Viewer.Controls.Contains(ViewerRichTextBox))
            {
                if (ViewerRichTextBox.ZoomFactor > 1)
                {
                    if (Action_Menu_MoreZoom.Enabled == false)
                    {
                        Action_Menu_MoreZoom.Enabled = true;
                    }


                    foreach (Form F in Application.OpenForms)
                    {
                        if (F.Name == "Notification")
                        {
                            F.Dispose();
                            break;
                        }
                    }

                    ViewerRichTextBox.ZoomFactor -= 1;
                    Form Notify = new Notification($"Zoom: {ViewerRichTextBox.ZoomFactor}x", 500);
                    Notify.Name = "Notification";
                    Rectangle R = Screen.PrimaryScreen.Bounds;
                    Notify.Location = new Point(R.Width - Notify.Width - 16, R.Height - Notify.Height - 16);
                    Notify.Opacity = Application.OpenForms["NotNot"].Opacity;
                    Notify.Show();

                    if (ViewerRichTextBox.ZoomFactor == 1)
                    {
                        Action_Menu_LessZoom.Enabled = false;
                    }
                }
            }
        }


        private void Action_Menu_Close_Click(object Sender, EventArgs E)
        {
            Dispose();
        }


        private void Action_Menu_Open_Click(object Sender, EventArgs E)
        {
            if (Ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    foreach (Control C in Controls)
                    {
                        if (C.Name == "Info")
                        {
                            continue;
                        }
                        else
                        {
                            Viewer.Controls.Remove(C);
                        }
                    }


                    if (Path.GetExtension(Ofd.FileName) == ".rtf")
                    {
                        ViewerRichTextBox.LoadFile(Ofd.FileName);
                        Viewer.Controls.Add(ViewerRichTextBox);
                        Action_Menu_Undo.Enabled = true;
                        Action_Menu_Redo.Enabled = true;
                        Action_Menu_Cut.Enabled = true;
                        Action_Menu_Copy.Enabled = true;
                        Action_Menu_Paste.Enabled = true;
                        Action_Menu_Delete.Enabled = true;
                        Action_Menu_MoreZoom.Enabled = true;
                        Action_Menu_LessZoom.Enabled = true;
                    }
                    else
                    {
                        ViewerPictureBox.Image = Image.FromFile(Ofd.FileName);
                        Viewer.Controls.Add(ViewerPictureBox);
                        Action_Menu_Undo.Enabled = false;
                        Action_Menu_Redo.Enabled = false;
                        Action_Menu_Cut.Enabled = false;
                        Action_Menu_Copy.Enabled = false;
                        Action_Menu_Paste.Enabled = false;
                        Action_Menu_Delete.Enabled = false;
                        Action_Menu_MoreZoom.Enabled = false;
                        Action_Menu_LessZoom.Enabled = false;
                    }
                }
                catch
                {
                    ViewerTextBox.Text = File.ReadAllText(Ofd.FileName);
                    Viewer.Controls.Add(ViewerTextBox);
                    Action_Menu_Undo.Enabled = true;
                    Action_Menu_Redo.Enabled = false;
                    Action_Menu_Cut.Enabled = true;
                    Action_Menu_Copy.Enabled = true;
                    Action_Menu_Paste.Enabled = true;
                    Action_Menu_Delete.Enabled = true;
                    Action_Menu_MoreZoom.Enabled = false;
                    Action_Menu_LessZoom.Enabled = false;
                }

                Action_Menu_View.Enabled = true;
                Info.Visible = false;
            }
        }


        private void Action_Menu_Undo_Click(object Sender, EventArgs E)
        {
            if (Viewer.Controls.Contains(ViewerRichTextBox))
            {
                if (ViewerRichTextBox.CanUndo == true)
                {
                    ViewerRichTextBox.Undo();
                }
            }
  

            if (Viewer.Controls.Contains(ViewerTextBox))
            {
                if (ViewerTextBox.CanUndo==true)
                {
                    ViewerTextBox.Undo();
                }
            }
        }


        private void Action_Menu_Redo_Click(object Sender, EventArgs E)
        {
            if (Viewer.Controls.Contains(ViewerRichTextBox))
            {
                if (ViewerRichTextBox.CanRedo == true)
                {
                    ViewerRichTextBox.Redo();
                }
            }
        }


        private void Action_Menu_View_Click(object Sender, EventArgs E)
        {
            ControlCollection Controls = Viewer.Controls;

            foreach (Control C in Controls)
            {
                if (C.Name == "Info")
                {
                    Info.Location = new Point((Viewer.Width - Info.Width) / 2, (Viewer.Height - Info.Height) / 2);
                    Info.Visible = true;
                    continue;
                }
                else
                {
                    Viewer.Controls.Remove(C);
                }
            }

            Action_Menu_View.Enabled = false;
        }


        private void Viewer_DragDrop(object Sender, DragEventArgs E)
        {


        }


        private void Viewer_DragEnter(object Sender, DragEventArgs E)
        {


        }


        private void Viewer_DragLeave(object Sender, EventArgs E)
        {


        }


        private void Viewer_DragOver(object Sender, DragEventArgs E)
        {


        }
    }
}
