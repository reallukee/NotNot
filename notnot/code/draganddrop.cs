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
    public partial class DragAndDrop : Form
    {
        public DragAndDrop()
        {
            // DragAndDrop()
            InitializeComponent();
        }


        private void Info_DragDrop(object Sender, DragEventArgs E)
        {
            // Info_DragDrop(object Sender, DragEventArgs E)
            Info.BackColor = Color.FromArgb(255, 243, 226);
            Info.Text = "Click one viewer!";
        }


        private void Info_DragEnter(object Sender, DragEventArgs E)
        {
            // Info_DragEnter(object Sender, DragEventArgs E)
            Info.BackColor = Color.FromArgb(255, 233, 201);
            E.Effect = DragDropEffects.Copy;
        }


        private void Info_DragLeave(object Sender, EventArgs E)
        {
            // Info_DragLeave(object Sender, EventArgs E)
            Info.BackColor = Color.FromArgb(255, 243, 226);
            Info.Text = "Drag and Drop...";
        }


        private void Info_DragOver(object Sender, DragEventArgs E)
        {
            // Info_DragOver(object Sender, DragEventArgs E)

        }


        private void Viewer1_Click(object Sender, EventArgs E)
        {
            // Viewer1_Click(object Sender, EventArgs E)
        }
    }
}
