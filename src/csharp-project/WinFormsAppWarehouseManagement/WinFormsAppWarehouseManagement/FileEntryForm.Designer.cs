
namespace WinFormsAppWarehouseManagement
{
    partial class FileEntryForm
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
            this.FileEntry = new System.Windows.Forms.Label();
            this.BackToMainFE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FileEntry
            // 
            this.FileEntry.AutoSize = true;
            this.FileEntry.BackColor = System.Drawing.SystemColors.Control;
            this.FileEntry.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FileEntry.Location = new System.Drawing.Point(312, 60);
            this.FileEntry.Name = "FileEntry";
            this.FileEntry.Size = new System.Drawing.Size(138, 41);
            this.FileEntry.TabIndex = 0;
            this.FileEntry.Text = "File Entry";
            // 
            // BackToMainFE
            // 
            this.BackToMainFE.Location = new System.Drawing.Point(304, 341);
            this.BackToMainFE.Name = "BackToMainFE";
            this.BackToMainFE.Size = new System.Drawing.Size(288, 58);
            this.BackToMainFE.TabIndex = 1;
            this.BackToMainFE.Text = "Back To Main";
            this.BackToMainFE.UseVisualStyleBackColor = true;
            this.BackToMainFE.Click += new System.EventHandler(this.BackToMainFE_Click);
            // 
            // FileEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.BackToMainFE);
            this.Controls.Add(this.FileEntry);
            this.Name = "FileEntryForm";
            this.Text = "FileEntryForm";
            this.Load += new System.EventHandler(this.FileEntryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FileEntry;
        private System.Windows.Forms.Button BackToMainFE;
    }
}