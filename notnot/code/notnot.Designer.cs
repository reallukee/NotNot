
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
            this.components = new System.ComponentModel.Container();
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
            this.Shortcurts = new System.Windows.Forms.RichTextBox();
            this.NI = new System.Windows.Forms.NotifyIcon(this.components);
            this.NI_Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NI_Menu_Show = new System.Windows.Forms.ToolStripMenuItem();
            this.NI_Menu_Separator = new System.Windows.Forms.ToolStripSeparator();
            this.NI_Menu_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.NI_Menu_Hide = new System.Windows.Forms.ToolStripMenuItem();
            this.Action_Panel.SuspendLayout();
            this.Action_Menu.SuspendLayout();
            this.NI_Menu.SuspendLayout();
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
            this.Version.Enabled = false;
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
            this.Separator.BackColor = System.Drawing.Color.Silver;
            this.Separator.Dock = System.Windows.Forms.DockStyle.Top;
            this.Separator.Location = new System.Drawing.Point(0, 61);
            this.Separator.Name = "Separator";
            this.Separator.Size = new System.Drawing.Size(1557, 1);
            this.Separator.TabIndex = 5;
            // 
            // Shortcurts
            // 
            this.Shortcurts.BackColor = System.Drawing.SystemColors.Control;
            this.Shortcurts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Shortcurts.DetectUrls = false;
            this.Shortcurts.Enabled = false;
            this.Shortcurts.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Shortcurts.HideSelection = false;
            this.Shortcurts.Location = new System.Drawing.Point(14, 74);
            this.Shortcurts.Margin = new System.Windows.Forms.Padding(5);
            this.Shortcurts.Name = "Shortcurts";
            this.Shortcurts.ReadOnly = true;
            this.Shortcurts.Size = new System.Drawing.Size(345, 345);
            this.Shortcurts.TabIndex = 6;
            this.Shortcurts.Text = resources.GetString("Shortcurts.Text");
            // 
            // NI
            // 
            this.NI.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.NI.BalloonTipText = "NotNot (Text)";
            this.NI.BalloonTipTitle = "NotNot (Title)";
            this.NI.ContextMenuStrip = this.NI_Menu;
            this.NI.Icon = ((System.Drawing.Icon)(resources.GetObject("NI.Icon")));
            this.NI.Text = "NotNot";
            this.NI.Visible = true;
            // 
            // NI_Menu
            // 
            this.NI_Menu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NI_Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.NI_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NI_Menu_Show,
            this.NI_Menu_Hide,
            this.NI_Menu_Separator,
            this.NI_Menu_Close});
            this.NI_Menu.Name = "NI_Menu";
            this.NI_Menu.Size = new System.Drawing.Size(211, 122);
            // 
            // NI_Menu_Show
            // 
            this.NI_Menu_Show.Name = "NI_Menu_Show";
            this.NI_Menu_Show.Size = new System.Drawing.Size(232, 28);
            this.NI_Menu_Show.Text = "Show";
            this.NI_Menu_Show.Click += new System.EventHandler(this.NI_Menu_NotNot_Click);
            // 
            // NI_Menu_Separator
            // 
            this.NI_Menu_Separator.Name = "NI_Menu_Separator";
            this.NI_Menu_Separator.Size = new System.Drawing.Size(229, 6);
            // 
            // NI_Menu_Close
            // 
            this.NI_Menu_Close.Name = "NI_Menu_Close";
            this.NI_Menu_Close.Size = new System.Drawing.Size(232, 28);
            this.NI_Menu_Close.Text = "Close";
            this.NI_Menu_Close.Click += new System.EventHandler(this.NI_Menu_Close_Click);
            // 
            // NI_Menu_Hide
            // 
            this.NI_Menu_Hide.Name = "NI_Menu_Hide";
            this.NI_Menu_Hide.Size = new System.Drawing.Size(210, 28);
            this.NI_Menu_Hide.Text = "Hide";
            this.NI_Menu_Hide.Click += new System.EventHandler(this.NI_Menu_Hide_Click);
            // 
            // NotNot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 803);
            this.Controls.Add(this.Shortcurts);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NotNot_FormClosing);
            this.Load += new System.EventHandler(this.NotNot_Load);
            this.Resize += new System.EventHandler(this.NotNot_Resize);
            this.Action_Panel.ResumeLayout(false);
            this.Action_Panel.PerformLayout();
            this.Action_Menu.ResumeLayout(false);
            this.Action_Menu.PerformLayout();
            this.NI_Menu.ResumeLayout(false);
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
        private System.Windows.Forms.Panel Separator;
        private System.Windows.Forms.RichTextBox Shortcurts;
        private System.Windows.Forms.FlowLayoutPanel Viewers;
        private System.Windows.Forms.NotifyIcon NI;
        private System.Windows.Forms.ContextMenuStrip NI_Menu;
        private System.Windows.Forms.ToolStripMenuItem NI_Menu_Show;
        private System.Windows.Forms.ToolStripSeparator NI_Menu_Separator;
        private System.Windows.Forms.ToolStripMenuItem NI_Menu_Close;
        private System.Windows.Forms.ToolStripMenuItem NI_Menu_Hide;
    }
}

