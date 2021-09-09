
namespace NotNot
{
    partial class Notification
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notification));
            this.Info = new System.Windows.Forms.Label();
            this.Expiration = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Info.ForeColor = System.Drawing.Color.Black;
            this.Info.Location = new System.Drawing.Point(11, 12);
            this.Info.Margin = new System.Windows.Forms.Padding(0);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(40, 23);
            this.Info.TabIndex = 0;
            this.Info.Text = "Info";
            // 
            // Expiration
            // 
            this.Expiration.Tick += new System.EventHandler(this.Expiration_Tick);
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(148, 43);
            this.ControlBox = false;
            this.Controls.Add(this.Info);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(32, 32);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Notification";
            this.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Notification";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.Notification_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Timer Expiration;
    }
}