namespace sreenshot2file___
{
    partial class Form1
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
            this.installBtn = new System.Windows.Forms.Button();
            this.uninstallBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // installBtn
            // 
            this.installBtn.Location = new System.Drawing.Point(27, 22);
            this.installBtn.Name = "installBtn";
            this.installBtn.Size = new System.Drawing.Size(72, 27);
            this.installBtn.TabIndex = 0;
            this.installBtn.Text = "install";
            this.installBtn.UseVisualStyleBackColor = true;
            this.installBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // uninstallBtn
            // 
            this.uninstallBtn.Location = new System.Drawing.Point(115, 22);
            this.uninstallBtn.Name = "uninstallBtn";
            this.uninstallBtn.Size = new System.Drawing.Size(72, 27);
            this.uninstallBtn.TabIndex = 1;
            this.uninstallBtn.Text = "uninstall";
            this.uninstallBtn.UseVisualStyleBackColor = true;
            this.uninstallBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 76);
            this.Controls.Add(this.uninstallBtn);
            this.Controls.Add(this.installBtn);
            this.Name = "Form1";
            this.Text = "screen2file";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button installBtn;
        private System.Windows.Forms.Button uninstallBtn;

        #endregion
    }
}