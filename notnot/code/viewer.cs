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
            Form NotNotForm = Application.OpenForms["NotNot"];
            Control Viewers = NotNotForm.Controls["Viewers"];
            Viewers.Controls.Remove(Viewers.Controls[this.Name]);

            if (Viewers.Controls.Count <= 3)
            {
                // true
                foreach (Control C in Viewers.Controls)
                {
                    // foreach
                    C.Size = new Size(Viewers.Width / Viewers.Controls.Count, Viewers.Height);
                }

                MinimumSize = new Size(500 * Viewers.Controls.Count, 500);
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
                    case 4:
                        // case
                        Viewers.Controls[3].Size = new Size(Viewers.Width, Viewers.Height / 2);
                        break;

                    case 5:
                        // case
                        Viewers.Controls[4].Size = new Size(Viewers.Width / 3 * 2, Viewers.Height / 2);
                        break;
                }

                MinimumSize = new Size(1500, 800);
            }
        }


        private void Action_Menu_Open_Click(object Sender, EventArgs E)
        {
            // Action_Menu_Open_Click(object Sender, EventArgs E)
            if (Ofd.ShowDialog() == DialogResult.OK)
            {
                // true
                RichTextBox.Text = File.ReadAllText(Ofd.FileName);
            }
        }


        private void Action_Menu_Save_Click(object Sender, EventArgs E)
        {
            // Action_Menu_Save_Click(object Sender, EventArgs E)
            if (Sfd.ShowDialog() == DialogResult.OK)
            {
                // true
                File.WriteAllText(Sfd.FileName, RichTextBox.Text);
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
    }
}
