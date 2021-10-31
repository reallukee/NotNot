
namespace NotNot
{
    partial class Viewer2
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.Separator = new System.Windows.Forms.Panel();
            this.Ofd = new System.Windows.Forms.OpenFileDialog();
            this.Separator_Top = new System.Windows.Forms.Panel();
            this.Separator_Bottom = new System.Windows.Forms.Panel();
            this.Action_Menu_LessZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.Action_Menu_MoreZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.Action_Menu_Redo = new System.Windows.Forms.ToolStripMenuItem();
            this.Action_Menu_Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.Action_Menu_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Action_Menu_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.Action_Menu = new System.Windows.Forms.MenuStrip();
            this.Action_Menu_View = new System.Windows.Forms.ToolStripMenuItem();
            this.Action_Menu_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.Action_Menu_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.Action_Menu_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.Action_Menu_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.Action_Panel = new System.Windows.Forms.Panel();
            this.Viewer = new System.Windows.Forms.Panel();
            this.Info = new System.Windows.Forms.Label();
            this.Action_Menu.SuspendLayout();
            this.Action_Panel.SuspendLayout();
            this.Viewer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Separator
            // 
            this.Separator.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Separator.Dock = System.Windows.Forms.DockStyle.Right;
            this.Separator.Location = new System.Drawing.Point(524, 0);
            this.Separator.Name = "Separator";
            this.Separator.Size = new System.Drawing.Size(1, 525);
            this.Separator.TabIndex = 11;
            // 
            // Ofd
            // 
            this.Ofd.DefaultExt = "*.*";
            this.Ofd.Filter = "TXT File|*.txt|RTF File|*.rtf|JPG File|*.jpg|PNG File|*.png|BMP File|*.bmp|All Fi" +
    "les|*.*";
            this.Ofd.FilterIndex = 6;
            this.Ofd.Title = "Open";
            // 
            // Separator_Top
            // 
            this.Separator_Top.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Separator_Top.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Separator_Top.Location = new System.Drawing.Point(0, 473);
            this.Separator_Top.Name = "Separator_Top";
            this.Separator_Top.Size = new System.Drawing.Size(524, 1);
            this.Separator_Top.TabIndex = 9;
            // 
            // Separator_Bottom
            // 
            this.Separator_Bottom.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Separator_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Separator_Bottom.Location = new System.Drawing.Point(0, 524);
            this.Separator_Bottom.Name = "Separator_Bottom";
            this.Separator_Bottom.Size = new System.Drawing.Size(524, 1);
            this.Separator_Bottom.TabIndex = 10;
            // 
            // Action_Menu_LessZoom
            // 
            this.Action_Menu_LessZoom.Enabled = false;
            this.Action_Menu_LessZoom.Name = "Action_Menu_LessZoom";
            this.Action_Menu_LessZoom.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Action_Menu_LessZoom.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Down)));
            this.Action_Menu_LessZoom.Size = new System.Drawing.Size(45, 46);
            this.Action_Menu_LessZoom.Text = "";
            this.Action_Menu_LessZoom.ToolTipText = "Less more (CTRL+ALT+DOWN)";
            this.Action_Menu_LessZoom.Click += new System.EventHandler(this.Action_Menu_LessZoom_Click);
            // 
            // Action_Menu_MoreZoom
            // 
            this.Action_Menu_MoreZoom.Name = "Action_Menu_MoreZoom";
            this.Action_Menu_MoreZoom.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Action_Menu_MoreZoom.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Up)));
            this.Action_Menu_MoreZoom.Size = new System.Drawing.Size(45, 46);
            this.Action_Menu_MoreZoom.Text = "";
            this.Action_Menu_MoreZoom.ToolTipText = "More zoom (CTRL+ALT+UP)";
            this.Action_Menu_MoreZoom.Click += new System.EventHandler(this.Action_Menu_MoreZoom_Click);
            // 
            // Action_Menu_Redo
            // 
            this.Action_Menu_Redo.Enabled = false;
            this.Action_Menu_Redo.Name = "Action_Menu_Redo";
            this.Action_Menu_Redo.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Action_Menu_Redo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.Action_Menu_Redo.Size = new System.Drawing.Size(45, 46);
            this.Action_Menu_Redo.Text = "";
            this.Action_Menu_Redo.ToolTipText = "Redo (CTRL+Y)";
            this.Action_Menu_Redo.Click += new System.EventHandler(this.Action_Menu_Redo_Click);
            // 
            // Action_Menu_Undo
            // 
            this.Action_Menu_Undo.Enabled = false;
            this.Action_Menu_Undo.Name = "Action_Menu_Undo";
            this.Action_Menu_Undo.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Action_Menu_Undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.Action_Menu_Undo.Size = new System.Drawing.Size(45, 46);
            this.Action_Menu_Undo.Text = "";
            this.Action_Menu_Undo.ToolTipText = "Undo (CTRL+Z)";
            this.Action_Menu_Undo.Click += new System.EventHandler(this.Action_Menu_Undo_Click);
            // 
            // Action_Menu_Open
            // 
            this.Action_Menu_Open.Name = "Action_Menu_Open";
            this.Action_Menu_Open.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Action_Menu_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.Action_Menu_Open.Size = new System.Drawing.Size(45, 46);
            this.Action_Menu_Open.Text = "";
            this.Action_Menu_Open.ToolTipText = "Open (CTRL+O)";
            this.Action_Menu_Open.Click += new System.EventHandler(this.Action_Menu_Open_Click);
            // 
            // Action_Menu_Close
            // 
            this.Action_Menu_Close.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Action_Menu_Close.Name = "Action_Menu_Close";
            this.Action_Menu_Close.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Action_Menu_Close.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.Action_Menu_Close.Size = new System.Drawing.Size(45, 46);
            this.Action_Menu_Close.Text = "";
            this.Action_Menu_Close.ToolTipText = "Close (CTRL+W)";
            this.Action_Menu_Close.Click += new System.EventHandler(this.Action_Menu_Close_Click);
            // 
            // Action_Menu
            // 
            this.Action_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(226)))));
            this.Action_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Action_Menu.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Action_Menu.GripMargin = new System.Windows.Forms.Padding(2);
            this.Action_Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Action_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Action_Menu_Close,
            this.Action_Menu_Open,
            this.Action_Menu_View,
            this.Action_Menu_Undo,
            this.Action_Menu_Redo,
            this.Action_Menu_Cut,
            this.Action_Menu_Copy,
            this.Action_Menu_Paste,
            this.Action_Menu_Delete,
            this.Action_Menu_MoreZoom,
            this.Action_Menu_LessZoom});
            this.Action_Menu.Location = new System.Drawing.Point(0, 0);
            this.Action_Menu.Name = "Action_Menu";
            this.Action_Menu.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.Action_Menu.ShowItemToolTips = true;
            this.Action_Menu.Size = new System.Drawing.Size(524, 50);
            this.Action_Menu.TabIndex = 0;
            // 
            // Action_Menu_View
            // 
            this.Action_Menu_View.Enabled = false;
            this.Action_Menu_View.Name = "Action_Menu_View";
            this.Action_Menu_View.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.Action_Menu_View.Size = new System.Drawing.Size(43, 46);
            this.Action_Menu_View.Text = "";
            this.Action_Menu_View.ToolTipText = "View (CTRL+H)";
            this.Action_Menu_View.Click += new System.EventHandler(this.Action_Menu_View_Click);
            // 
            // Action_Menu_Cut
            // 
            this.Action_Menu_Cut.Name = "Action_Menu_Cut";
            this.Action_Menu_Cut.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Action_Menu_Cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.Action_Menu_Cut.Size = new System.Drawing.Size(45, 46);
            this.Action_Menu_Cut.Text = "";
            this.Action_Menu_Cut.ToolTipText = "Cut (CTRL+X)";
            // 
            // Action_Menu_Copy
            // 
            this.Action_Menu_Copy.Name = "Action_Menu_Copy";
            this.Action_Menu_Copy.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Action_Menu_Copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.Action_Menu_Copy.Size = new System.Drawing.Size(45, 46);
            this.Action_Menu_Copy.Text = "";
            this.Action_Menu_Copy.ToolTipText = "Copy (CTRL+C)";
            // 
            // Action_Menu_Paste
            // 
            this.Action_Menu_Paste.Name = "Action_Menu_Paste";
            this.Action_Menu_Paste.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Action_Menu_Paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.Action_Menu_Paste.Size = new System.Drawing.Size(45, 46);
            this.Action_Menu_Paste.Text = "";
            this.Action_Menu_Paste.ToolTipText = "Paste (CTRL+V)";
            // 
            // Action_Menu_Delete
            // 
            this.Action_Menu_Delete.Name = "Action_Menu_Delete";
            this.Action_Menu_Delete.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Action_Menu_Delete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.Action_Menu_Delete.Size = new System.Drawing.Size(45, 46);
            this.Action_Menu_Delete.Text = "";
            this.Action_Menu_Delete.ToolTipText = "Delete (CANC)";
            // 
            // Action_Panel
            // 
            this.Action_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(226)))));
            this.Action_Panel.Controls.Add(this.Action_Menu);
            this.Action_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Action_Panel.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Action_Panel.Location = new System.Drawing.Point(0, 474);
            this.Action_Panel.Name = "Action_Panel";
            this.Action_Panel.Size = new System.Drawing.Size(524, 50);
            this.Action_Panel.TabIndex = 8;
            // 
            // Viewer
            // 
            this.Viewer.AllowDrop = true;
            this.Viewer.BackColor = System.Drawing.Color.White;
            this.Viewer.Controls.Add(this.Info);
            this.Viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Viewer.Location = new System.Drawing.Point(0, 0);
            this.Viewer.Margin = new System.Windows.Forms.Padding(0);
            this.Viewer.Name = "Viewer";
            this.Viewer.Size = new System.Drawing.Size(524, 473);
            this.Viewer.TabIndex = 13;
            this.Viewer.DragDrop += new System.Windows.Forms.DragEventHandler(this.Viewer_DragDrop);
            this.Viewer.DragEnter += new System.Windows.Forms.DragEventHandler(this.Viewer_DragEnter);
            this.Viewer.DragOver += new System.Windows.Forms.DragEventHandler(this.Viewer_DragOver);
            this.Viewer.DragLeave += new System.EventHandler(this.Viewer_DragLeave);
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Location = new System.Drawing.Point(0, 0);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(113, 20);
            this.Info.TabIndex = 0;
            this.Info.Text = "Drag and Drop!";
            // 
            // Viewer2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Viewer);
            this.Controls.Add(this.Separator_Top);
            this.Controls.Add(this.Action_Panel);
            this.Controls.Add(this.Separator_Bottom);
            this.Controls.Add(this.Separator);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Viewer2";
            this.Size = new System.Drawing.Size(525, 525);
            this.Action_Menu.ResumeLayout(false);
            this.Action_Menu.PerformLayout();
            this.Action_Panel.ResumeLayout(false);
            this.Action_Panel.PerformLayout();
            this.Viewer.ResumeLayout(false);
            this.Viewer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Separator;
        private System.Windows.Forms.OpenFileDialog Ofd;
        private System.Windows.Forms.Panel Separator_Top;
        private System.Windows.Forms.Panel Separator_Bottom;
        private System.Windows.Forms.ToolStripMenuItem Action_Menu_LessZoom;
        private System.Windows.Forms.ToolStripMenuItem Action_Menu_MoreZoom;
        private System.Windows.Forms.ToolStripMenuItem Action_Menu_Redo;
        private System.Windows.Forms.ToolStripMenuItem Action_Menu_Undo;
        private System.Windows.Forms.ToolStripMenuItem Action_Menu_Open;
        private System.Windows.Forms.ToolStripMenuItem Action_Menu_Close;
        private System.Windows.Forms.MenuStrip Action_Menu;
        private System.Windows.Forms.Panel Action_Panel;
        private System.Windows.Forms.Panel Viewer;
        private System.Windows.Forms.ToolStripMenuItem Action_Menu_View;
        private System.Windows.Forms.ToolStripMenuItem Action_Menu_Cut;
        private System.Windows.Forms.ToolStripMenuItem Action_Menu_Copy;
        private System.Windows.Forms.ToolStripMenuItem Action_Menu_Paste;
        private System.Windows.Forms.ToolStripMenuItem Action_Menu_Delete;
        private System.Windows.Forms.Label Info;
    }
}
