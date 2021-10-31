
namespace NotNot
{
    partial class DragAndDrop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DragAndDrop));
            this.Info = new System.Windows.Forms.Label();
            this.Info_Panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Viewers = new System.Windows.Forms.TableLayoutPanel();
            this.Viewer6 = new System.Windows.Forms.Label();
            this.Viewer5 = new System.Windows.Forms.Label();
            this.Viewer4 = new System.Windows.Forms.Label();
            this.Viewer3 = new System.Windows.Forms.Label();
            this.Viewer2 = new System.Windows.Forms.Label();
            this.Viewer1 = new System.Windows.Forms.Label();
            this.Info_Panel.SuspendLayout();
            this.Viewers.SuspendLayout();
            this.SuspendLayout();
            // 
            // Info
            // 
            this.Info.AllowDrop = true;
            this.Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(226)))));
            this.Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Info.Location = new System.Drawing.Point(0, 0);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(432, 150);
            this.Info.TabIndex = 0;
            this.Info.Text = "Drag and Drop...";
            this.Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Info.DragDrop += new System.Windows.Forms.DragEventHandler(this.Info_DragDrop);
            this.Info.DragEnter += new System.Windows.Forms.DragEventHandler(this.Info_DragEnter);
            this.Info.DragOver += new System.Windows.Forms.DragEventHandler(this.Info_DragOver);
            this.Info.DragLeave += new System.EventHandler(this.Info_DragLeave);
            // 
            // Info_Panel
            // 
            this.Info_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Info_Panel.Controls.Add(this.Info);
            this.Info_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Info_Panel.Location = new System.Drawing.Point(0, 0);
            this.Info_Panel.Name = "Info_Panel";
            this.Info_Panel.Size = new System.Drawing.Size(432, 150);
            this.Info_Panel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 1);
            this.panel1.TabIndex = 3;
            // 
            // Viewers
            // 
            this.Viewers.ColumnCount = 3;
            this.Viewers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Viewers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Viewers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Viewers.Controls.Add(this.Viewer6, 2, 1);
            this.Viewers.Controls.Add(this.Viewer5, 1, 1);
            this.Viewers.Controls.Add(this.Viewer4, 0, 1);
            this.Viewers.Controls.Add(this.Viewer3, 2, 0);
            this.Viewers.Controls.Add(this.Viewer2, 1, 0);
            this.Viewers.Controls.Add(this.Viewer1, 0, 0);
            this.Viewers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Viewers.Location = new System.Drawing.Point(0, 151);
            this.Viewers.Margin = new System.Windows.Forms.Padding(0);
            this.Viewers.Name = "Viewers";
            this.Viewers.RowCount = 2;
            this.Viewers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Viewers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Viewers.Size = new System.Drawing.Size(432, 127);
            this.Viewers.TabIndex = 4;
            // 
            // Viewer6
            // 
            this.Viewer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Viewer6.Location = new System.Drawing.Point(288, 98);
            this.Viewer6.Margin = new System.Windows.Forms.Padding(0);
            this.Viewer6.Name = "Viewer6";
            this.Viewer6.Size = new System.Drawing.Size(144, 99);
            this.Viewer6.TabIndex = 5;
            this.Viewer6.Text = "Viewer 6";
            this.Viewer6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Viewer5
            // 
            this.Viewer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Viewer5.Location = new System.Drawing.Point(144, 98);
            this.Viewer5.Margin = new System.Windows.Forms.Padding(0);
            this.Viewer5.Name = "Viewer5";
            this.Viewer5.Size = new System.Drawing.Size(144, 99);
            this.Viewer5.TabIndex = 4;
            this.Viewer5.Text = "Viewer 5";
            this.Viewer5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Viewer4
            // 
            this.Viewer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Viewer4.Location = new System.Drawing.Point(0, 98);
            this.Viewer4.Margin = new System.Windows.Forms.Padding(0);
            this.Viewer4.Name = "Viewer4";
            this.Viewer4.Size = new System.Drawing.Size(144, 99);
            this.Viewer4.TabIndex = 3;
            this.Viewer4.Text = "Viewer 4";
            this.Viewer4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Viewer3
            // 
            this.Viewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Viewer3.Location = new System.Drawing.Point(288, 0);
            this.Viewer3.Margin = new System.Windows.Forms.Padding(0);
            this.Viewer3.Name = "Viewer3";
            this.Viewer3.Size = new System.Drawing.Size(144, 98);
            this.Viewer3.TabIndex = 2;
            this.Viewer3.Text = "Viewer 3";
            this.Viewer3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Viewer2
            // 
            this.Viewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Viewer2.Location = new System.Drawing.Point(144, 0);
            this.Viewer2.Margin = new System.Windows.Forms.Padding(0);
            this.Viewer2.Name = "Viewer2";
            this.Viewer2.Size = new System.Drawing.Size(144, 98);
            this.Viewer2.TabIndex = 1;
            this.Viewer2.Text = "Viewer 2";
            this.Viewer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Viewer1
            // 
            this.Viewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Viewer1.Location = new System.Drawing.Point(0, 0);
            this.Viewer1.Margin = new System.Windows.Forms.Padding(0);
            this.Viewer1.Name = "Viewer1";
            this.Viewer1.Size = new System.Drawing.Size(144, 98);
            this.Viewer1.TabIndex = 0;
            this.Viewer1.Text = "Viewer 1";
            this.Viewer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Viewer1.Click += new System.EventHandler(this.Viewer1_Click);
            // 
            // DragAndDrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 278);
            this.Controls.Add(this.Viewers);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Info_Panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "DragAndDrop";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "NotNot";
            this.TopMost = true;
            this.Info_Panel.ResumeLayout(false);
            this.Viewers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Panel Info_Panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel Viewers;
        private System.Windows.Forms.Label Viewer6;
        private System.Windows.Forms.Label Viewer5;
        private System.Windows.Forms.Label Viewer4;
        private System.Windows.Forms.Label Viewer3;
        private System.Windows.Forms.Label Viewer2;
        private System.Windows.Forms.Label Viewer1;
    }
}