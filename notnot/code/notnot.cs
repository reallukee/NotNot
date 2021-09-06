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
    public partial class NotNot : Form
    {
        public NotNot()
        {
            // NotNotMain()
            InitializeComponent();
        }


        Int32 Index = 0;


        private void NotNot_Load(object Sender, EventArgs E)
        {
            // NotNot_Load(object Sender, EventArgs E)
            Viewers.Controls.Add(new Viewer());

            foreach (Control C in Viewers.Controls)
            {
                // foreach
                C.Size = new Size(Viewers.Width / Viewers.Controls.Count, Viewers.Height);
            }


            if (Viewers.Controls.Count == 0)
            {
                // true
                MinimumSize = new Size(500, 500);
            }
            else
            {
                // false
                MinimumSize = new Size(500 * Viewers.Controls.Count, 500);
            }
        }


        private void NotNot_Resize(object Sender, EventArgs E)
        {
            // NotNot_Resize(object Sender, EventArgs E)
            foreach (Control C in Viewers.Controls)
            {
                // foreach
                C.Size = new Size(Viewers.Width / Viewers.Controls.Count, Viewers.Height);
            }


            if (Viewers.Controls.Count == 0)
            {
                // true
                MinimumSize = new Size(500, 500);
            }
            else
            {
                // false
                MinimumSize = new Size(500 * Viewers.Controls.Count, 500);
            }
        }


        private void Action_Menu_MoreOpacity_Click(object Sender, EventArgs E)
        {
            // Action_Menu_MoreOpacity_Click(object Sender, EventArgs E)
            if (Opacity < 1.0)
            {
                // true
                if (Action_Menu_LessOpacity.Enabled == false)
                {
                    // true
                    Action_Menu_LessOpacity.Enabled = true;
                }

                Opacity += 0.1;

                if (Opacity == 100)
                {
                    // true
                    Action_Menu_MoreOpacity.Enabled = false;
                }
            }
        }


        private void Action_Menu_LessOpacity_Click(object Sender, EventArgs E)
        {
            // Action_Menu_LessOpacity_Click(object Sender, EventArgs E)
            if (Opacity > 0.3)
            {
                // true
                if (Action_Menu_MoreOpacity.Enabled == false)
                {
                    // true
                    Action_Menu_MoreOpacity.Enabled = true;
                }

                Opacity -= 0.1;

                if (Opacity == 30)
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
                WindowState = FormWindowState.Maximized;
            }
        }


        private void Action_Menu_AddViewer_Click(object Sender, EventArgs E)
        {
            // Action_Menu_AddViewer_Click(object Sender, EventArgs E)
            Viewer NewViewer = new Viewer();
            NewViewer.Name = $"{Index}";
            Viewers.Controls.Add(NewViewer);
            Index++;

            foreach (Control C in Viewers.Controls)
            {
                // foreach
                C.Size = new Size(Viewers.Width / Viewers.Controls.Count, Viewers.Height);
            }

            MinimumSize = new Size(500 * Viewers.Controls.Count, 500);
        }


        private void Viewers_ControlAdded(object Sender, ControlEventArgs E)
        {
            // Viewers_ControlAdded(object Sender, ControlEventArgs E)
            if (Viewers.Controls.Count >= 3)
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
            if (Viewers.Controls.Count <= 3)
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
