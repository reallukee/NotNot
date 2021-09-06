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

                RichTextBox.ZoomFactor += 1;

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

                RichTextBox.ZoomFactor -= 1;

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

            foreach (Control C in Viewers.Controls)
            {
                // foreach
                C.Size = new Size(Viewers.Width / Viewers.Controls.Count, Viewers.Height);
            }


            if (Viewers.Controls.Count == 0)
            {
                // true
                NotNotForm.MinimumSize = new Size(500, 500);
            }
            else
            {
                // false
                NotNotForm.MinimumSize = new Size(500 * Viewers.Controls.Count, 500);
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
