
namespace NotNot
{
    partial class NotNot
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotNot));
            this.Action_Panel = new System.Windows.Forms.Panel();
            this.Action_Menu = new System.Windows.Forms.MenuStrip();
            this.Action_Menu_AlwaysOnTop = new System.Windows.Forms.ToolStripMenuItem();
            this.Action_Menu_FullScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.Action_Menu_LessOpacity = new System.Windows.Forms.ToolStripMenuItem();
            this.Action_Menu_MoreOpacity = new System.Windows.Forms.ToolStripMenuItem();
            this.Action_Menu_AddViewer = new System.Windows.Forms.ToolStripMenuItem();
            this.Viewers = new System.Windows.Forms.FlowLayoutPanel();
            this.Version = new System.Windows.Forms.Label();
            this.Separator = new System.Windows.Forms.Panel();
            this.Action_Panel.SuspendLayout();
            this.Action_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Action_Panel
            // 
            this.Action_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(150)))));
            this.Action_Panel.Controls.Add(this.Action_Menu);
            this.Action_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Action_Panel.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Action_Panel.Location = new System.Drawing.Point(0, 0);
            this.Action_Panel.Name = "Action_Panel";
            this.Action_Panel.Size = new System.Drawing.Size(1557, 61);
            this.Action_Panel.TabIndex = 0;
            // 
            // Action_Menu
            // 
            this.Action_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(150)))));
            this.Action_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Action_Menu.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Action_Menu.GripMargin = new System.Windows.Forms.Padding(2);
            this.Action_Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Action_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Action_Menu_AlwaysOnTop,
            this.Action_Menu_FullScreen,
            this.Action_Menu_LessOpacity,
            this.Action_Menu_MoreOpacity,
            this.Action_Menu_AddViewer});
            this.Action_Menu.Location = new System.Drawing.Point(0, 0);
            this.Action_Menu.Name = "Action_Menu";
            this.Action_Menu.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.Action_Menu.Size = new System.Drawing.Size(1557, 61);
            this.Action_Menu.TabIndex = 0;
            // 
            // Action_Menu_AlwaysOnTop
            // 
            this.Action_Menu_AlwaysOnTop.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Action_Menu_AlwaysOnTop.Name = "Action_Menu_AlwaysOnTop";
            this.Action_Menu_AlwaysOnTop.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Action_Menu_AlwaysOnTop.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.Action_Menu_AlwaysOnTop.Size = new System.Drawing.Size(45, 57);
            this.Action_Menu_AlwaysOnTop.Text = "";
            this.Action_Menu_AlwaysOnTop.Click += new System.EventHandler(this.Action_Menu_AlwaysOnTop_Click);
            // 
            // Action_Menu_FullScreen
            // 
            this.Action_Menu_FullScreen.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Action_Menu_FullScreen.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Action_Menu_FullScreen.Name = "Action_Menu_FullScreen";
            this.Action_Menu_FullScreen.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Action_Menu_FullScreen.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.Action_Menu_FullScreen.Size = new System.Drawing.Size(42, 57);
            this.Action_Menu_FullScreen.Text = "";
            this.Action_Menu_FullScreen.Click += new System.EventHandler(this.Action_Menu_FullScreen_Click);
            // 
            // Action_Menu_LessOpacity
            // 
            this.Action_Menu_LessOpacity.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Action_Menu_LessOpacity.Name = "Action_Menu_LessOpacity";
            this.Action_Menu_LessOpacity.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Action_Menu_LessOpacity.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.Action_Menu_LessOpacity.Size = new System.Drawing.Size(45, 57);
            this.Action_Menu_LessOpacity.Text = "";
            this.Action_Menu_LessOpacity.Click += new System.EventHandler(this.Action_Menu_LessOpacity_Click);
            // 
            // Action_Menu_MoreOpacity
            // 
            this.Action_Menu_MoreOpacity.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Action_Menu_MoreOpacity.Enabled = false;
            this.Action_Menu_MoreOpacity.Name = "Action_Menu_MoreOpacity";
            this.Action_Menu_MoreOpacity.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Action_Menu_MoreOpacity.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.Action_Menu_MoreOpacity.Size = new System.Drawing.Size(45, 57);
            this.Action_Menu_MoreOpacity.Text = "";
            this.Action_Menu_MoreOpacity.Click += new System.EventHandler(this.Action_Menu_MoreOpacity_Click);
            // 
            // Action_Menu_AddViewer
            // 
            this.Action_Menu_AddViewer.Name = "Action_Menu_AddViewer";
            this.Action_Menu_AddViewer.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Action_Menu_AddViewer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.Action_Menu_AddViewer.Size = new System.Drawing.Size(45, 57);
            this.Action_Menu_AddViewer.Text = "";
            this.Action_Menu_AddViewer.Click += new System.EventHandler(this.Action_Menu_AddViewer_Click);
            // 
            // Viewers
            // 
            this.Viewers.BackgroundImage = global::NotNot.Properties.Resources.NotNot_Icon64;
            this.Viewers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Viewers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Viewers.Location = new System.Drawing.Point(0, 62);
            this.Viewers.Margin = new System.Windows.Forms.Padding(0);
            this.Viewers.Name = "Viewers";
            this.Viewers.Size = new System.Drawing.Size(1557, 741);
            this.Viewers.TabIndex = 2;
            this.Viewers.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.Viewers_ControlAdded);
            this.Viewers.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.Viewers_ControlRemoved);
            // 
            // Version
            // 
            this.Version.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Version.AutoSize = true;
            this.Version.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Version.ForeColor = System.Drawing.Color.Black;
            this.Version.Location = new System.Drawing.Point(14, 769);
            this.Version.Margin = new System.Windows.Forms.Padding(5);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(173, 20);
            this.Version.TabIndex = 3;
            this.Version.Text = "NotNot 1.1.0 by Realluke";
            // 
            // Separator
            // 
            this.Separator.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Separator.Dock = System.Windows.Forms.DockStyle.Top;
            this.Separator.Location = new System.Drawing.Point(0, 61);
            this.Separator.Name = "Separator";
            this.Separator.Size = new System.Drawing.Size(1557, 1);
            this.Separator.TabIndex = 5;
            // 
            // NotNot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 803);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.Viewers);
            this.Controls.Add(this.Separator);
            this.Controls.Add(this.Action_Panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Action_Menu;
            this.MinimumSize = new System.Drawing.Size(525, 525);
            this.Name = "NotNot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotNot";
            this.Load += new System.EventHandler(this.NotNot_Load);
            this.Resize += new System.EventHandler(this.NotNot_Resize);
            this.Action_Panel.ResumeLayout(false);
            this.Action_Panel.PerformLayout();
            this.Action_Menu.ResumeLayout(false);
            this.Action_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Action_Panel;
        private System.Windows.Forms.MenuStrip Action_Menu;
        private System.Windows.Forms.ToolStripMenuItem Action_Menu_MoreOpacity;
        private System.Windows.Forms.ToolStripMenuItem Action_Menu_LessOpacity;
        private System.Windows.Forms.ToolStripMenuItem Action_Menu_AlwaysOnTop;
        private System.Windows.Forms.ToolStripMenuItem Action_Menu_FullScreen;
        private System.Windows.Forms.ToolStripMenuItem Action_Menu_AddViewer;
        private System.Windows.Forms.Label Version;
        public System.Windows.Forms.FlowLayoutPanel Viewers;
        private System.Windows.Forms.Panel Separator;
    }
}

