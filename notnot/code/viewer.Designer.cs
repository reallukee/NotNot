
namespace NotNot
{
    partial class Viewer
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
            this.RichTextBox = new System.Windows.Forms.RichTextBox();
            this.Action_Panel = new System.Windows.Forms.Panel();
            this.Action_Menu = new System.Windows.Forms.MenuStrip();
            this.Action_Menu_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.Action_Menu_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Action_Menu_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Action_Menu_Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.Action_Menu_Redo = new System.Windows.Forms.ToolStripMenuItem();
            this.Action_Menu_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.Action_Menu_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.Action_Menu_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.Action_Menu_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.Action_Menu_MoreZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.Action_Menu_LessZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator_Top = new System.Windows.Forms.Panel();
            this.Separator_Bottom = new System.Windows.Forms.Panel();
            this.Ofd = new System.Windows.Forms.OpenFileDialog();
            this.Sfd = new System.Windows.Forms.SaveFileDialog();
            this.Separator = new System.Windows.Forms.Panel();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.Action_Panel.SuspendLayout();
            this.Action_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RichTextBox
            // 
            this.RichTextBox.AcceptsTab = true;
            this.RichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RichTextBox.Location = new System.Drawing.Point(0, 0);
            this.RichTextBox.Name = "RichTextBox";
            this.RichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RichTextBox.Size = new System.Drawing.Size(524, 474);
            this.RichTextBox.TabIndex = 0;
            this.RichTextBox.Text = "";
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
            this.Action_Panel.TabIndex = 1;
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
            this.Action_Menu_Save,
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
            this.Action_Menu.Size = new System.Drawing.Size(524, 50);
            this.Action_Menu.TabIndex = 0;
            // 
            // Action_Menu_Close
            // 
            this.Action_Menu_Close.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Action_Menu_Close.Name = "Action_Menu_Close";
            this.Action_Menu_Close.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Action_Menu_Close.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.Action_Menu_Close.Size = new System.Drawing.Size(45, 46);
            this.Action_Menu_Close.Text = "";
            this.Action_Menu_Close.Click += new System.EventHandler(this.Action_Menu_Close_Click);
            // 
            // Action_Menu_Open
            // 
            this.Action_Menu_Open.Name = "Action_Menu_Open";
            this.Action_Menu_Open.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Action_Menu_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.Action_Menu_Open.Size = new System.Drawing.Size(45, 46);
            this.Action_Menu_Open.Text = "";
            this.Action_Menu_Open.Click += new System.EventHandler(this.Action_Menu_Open_Click);
            // 
            // Action_Menu_Save
            // 
            this.Action_Menu_Save.Name = "Action_Menu_Save";
            this.Action_Menu_Save.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Action_Menu_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Action_Menu_Save.Size = new System.Drawing.Size(45, 46);
            this.Action_Menu_Save.Text = "";
            this.Action_Menu_Save.Click += new System.EventHandler(this.Action_Menu_Save_Click);
            // 
            // Action_Menu_Undo
            // 
            this.Action_Menu_Undo.Name = "Action_Menu_Undo";
            this.Action_Menu_Undo.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Action_Menu_Undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.Action_Menu_Undo.Size = new System.Drawing.Size(45, 46);
            this.Action_Menu_Undo.Text = "";
            this.Action_Menu_Undo.Click += new System.EventHandler(this.Action_Menu_Undo_Click);
            // 
            // Action_Menu_Redo
            // 
            this.Action_Menu_Redo.Name = "Action_Menu_Redo";
            this.Action_Menu_Redo.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Action_Menu_Redo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.Action_Menu_Redo.Size = new System.Drawing.Size(45, 46);
            this.Action_Menu_Redo.Text = "";
            this.Action_Menu_Redo.Click += new System.EventHandler(this.Action_Menu_Redo_Click);
            // 
            // Action_Menu_Cut
            // 
            this.Action_Menu_Cut.Name = "Action_Menu_Cut";
            this.Action_Menu_Cut.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Action_Menu_Cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.Action_Menu_Cut.Size = new System.Drawing.Size(45, 46);
            this.Action_Menu_Cut.Text = "";
            this.Action_Menu_Cut.Click += new System.EventHandler(this.Action_Menu_Cut_Click);
            // 
            // Action_Menu_Copy
            // 
            this.Action_Menu_Copy.Name = "Action_Menu_Copy";
            this.Action_Menu_Copy.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Action_Menu_Copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.Action_Menu_Copy.Size = new System.Drawing.Size(45, 46);
            this.Action_Menu_Copy.Text = "";
            this.Action_Menu_Copy.Click += new System.EventHandler(this.Action_Menu_Copy_Click);
            // 
            // Action_Menu_Paste
            // 
            this.Action_Menu_Paste.Name = "Action_Menu_Paste";
            this.Action_Menu_Paste.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Action_Menu_Paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.Action_Menu_Paste.Size = new System.Drawing.Size(45, 46);
            this.Action_Menu_Paste.Text = "";
            this.Action_Menu_Paste.Click += new System.EventHandler(this.Action_Menu_Paste_Click);
            // 
            // Action_Menu_Delete
            // 
            this.Action_Menu_Delete.Name = "Action_Menu_Delete";
            this.Action_Menu_Delete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.Action_Menu_Delete.Size = new System.Drawing.Size(43, 46);
            this.Action_Menu_Delete.Text = "";
            this.Action_Menu_Delete.Click += new System.EventHandler(this.Action_Menu_Delete_Click);
            // 
            // Action_Menu_MoreZoom
            // 
            this.Action_Menu_MoreZoom.Name = "Action_Menu_MoreZoom";
            this.Action_Menu_MoreZoom.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Action_Menu_MoreZoom.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Up)));
            this.Action_Menu_MoreZoom.Size = new System.Drawing.Size(45, 46);
            this.Action_Menu_MoreZoom.Text = "";
            this.Action_Menu_MoreZoom.Click += new System.EventHandler(this.Action_Menu_MoreZoom_Click);
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
            this.Action_Menu_LessZoom.Click += new System.EventHandler(this.Action_Menu_LessZoom_Click);
            // 
            // Separator_Top
            // 
            this.Separator_Top.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Separator_Top.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Separator_Top.Location = new System.Drawing.Point(0, 473);
            this.Separator_Top.Name = "Separator_Top";
            this.Separator_Top.Size = new System.Drawing.Size(524, 1);
            this.Separator_Top.TabIndex = 2;
            // 
            // Separator_Bottom
            // 
            this.Separator_Bottom.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Separator_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Separator_Bottom.Location = new System.Drawing.Point(0, 524);
            this.Separator_Bottom.Name = "Separator_Bottom";
            this.Separator_Bottom.Size = new System.Drawing.Size(524, 1);
            this.Separator_Bottom.TabIndex = 3;
            // 
            // Ofd
            // 
            this.Ofd.DefaultExt = "*.*";
            this.Ofd.Filter = "TXT File|*.txt|RTF File|*.rtf|JPG File|*.jpg|PNG File|*.png|BMP File|*.bmp|All Fi" +
    "les|*.*";
            this.Ofd.FilterIndex = 6;
            this.Ofd.Title = "Open";
            // 
            // Sfd
            // 
            this.Sfd.DefaultExt = "*.*";
            this.Sfd.Filter = "TXT File|*.txt|RTF File|*.rtf|JPG File|*.jpg|PNG File|*.png|BMP File|*.bmp|All Fi" +
    "les|*.*";
            this.Sfd.FilterIndex = 6;
            this.Sfd.Title = "Save";
            // 
            // Separator
            // 
            this.Separator.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Separator.Dock = System.Windows.Forms.DockStyle.Right;
            this.Separator.Location = new System.Drawing.Point(524, 0);
            this.Separator.Name = "Separator";
            this.Separator.Size = new System.Drawing.Size(1, 525);
            this.Separator.TabIndex = 4;
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.Color.White;
            this.PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox.Location = new System.Drawing.Point(0, 0);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(524, 473);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 5;
            this.PictureBox.TabStop = false;
            this.PictureBox.Visible = false;
            // 
            // TextBox
            // 
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox.Location = new System.Drawing.Point(0, 0);
            this.TextBox.Margin = new System.Windows.Forms.Padding(0);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox.Size = new System.Drawing.Size(524, 473);
            this.TextBox.TabIndex = 6;
            this.TextBox.Visible = false;
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.Separator_Top);
            this.Controls.Add(this.RichTextBox);
            this.Controls.Add(this.Action_Panel);
            this.Controls.Add(this.Separator_Bottom);
            this.Controls.Add(this.Separator);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Viewer";
            this.Size = new System.Drawing.Size(525, 525);
            this.Action_Panel.ResumeLayout(false);
            this.Action_Panel.PerformLayout();
            this.Action_Menu.ResumeLayout(false);
            this.Action_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RichTextBox;
        private System.Windows.Forms.Panel Action_Panel;
        private System.Windows.Forms.MenuStrip Action_Menu;
        private System.Windows.Forms.ToolStripMenuItem Action_Menu_MoreZoom;
        private System.Windows.Forms.ToolStripMenuItem Action_Menu_LessZoom;
        private System.Windows.Forms.ToolStripMenuItem Action_Menu_Close;
        private System.Windows.Forms.Panel Separator_Top;
        private System.Windows.Forms.Panel Separator_Bottom;
        private System.Windows.Forms.ToolStripMenuItem Action_Menu_Open;
        private System.Windows.Forms.ToolStripMenuItem Action_Menu_Save;
        private System.Windows.Forms.ToolStripMenuItem Action_Menu_Undo;
        private System.Windows.Forms.ToolStripMenuItem Action_Menu_Redo;
        private System.Windows.Forms.ToolStripMenuItem Action_Menu_Cut;
        private System.Windows.Forms.ToolStripMenuItem Action_Menu_Copy;
        private System.Windows.Forms.ToolStripMenuItem Action_Menu_Paste;
        private System.Windows.Forms.OpenFileDialog Ofd;
        private System.Windows.Forms.SaveFileDialog Sfd;
        private System.Windows.Forms.ToolStripMenuItem Action_Menu_Delete;
        private System.Windows.Forms.Panel Separator;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.TextBox TextBox;
    }
}
