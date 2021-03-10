
namespace WinFormsAppWarehouseManagement
{
    partial class HelpForm
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
            this.BackToMainH = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackToMainH
            // 
            this.BackToMainH.Location = new System.Drawing.Point(243, 338);
            this.BackToMainH.Name = "BackToMainH";
            this.BackToMainH.Size = new System.Drawing.Size(312, 42);
            this.BackToMainH.TabIndex = 0;
            this.BackToMainH.Text = "Back To Main";
            this.BackToMainH.UseVisualStyleBackColor = true;
            this.BackToMainH.Click += new System.EventHandler(this.BackToMainH_Click);
            // 
            // Help
            // 
            this.Help.AutoSize = true;
            this.Help.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Help.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Help.Location = new System.Drawing.Point(134, 64);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(592, 54);
            this.Help.TabIndex = 1;
            this.Help.Text = "Help : How To Use This Software";
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.BackToMainH);
            this.Name = "HelpForm";
            this.Text = "HelpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackToMainH;
        private System.Windows.Forms.Label Help;
    }
}