
namespace WinFormsAppWarehouseManagement
{
    partial class MainPage
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
            this.FileEntyBt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainTitle = new System.Windows.Forms.Label();
            this.ShipReceiveBt = new System.Windows.Forms.Button();
            this.ReportBt = new System.Windows.Forms.Button();
            this.SaveFileBt = new System.Windows.Forms.Button();
            this.HelpBt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileEntyBt
            // 
            this.FileEntyBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.FileEntyBt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FileEntyBt.Location = new System.Drawing.Point(108, 171);
            this.FileEntyBt.Name = "FileEntyBt";
            this.FileEntyBt.Size = new System.Drawing.Size(1075, 80);
            this.FileEntyBt.TabIndex = 6;
            this.FileEntyBt.Text = "1. File Entry";
            this.FileEntyBt.UseVisualStyleBackColor = false;
            this.FileEntyBt.Click += new System.EventHandler(this.FileEntyBt_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.MainTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1326, 110);
            this.panel1.TabIndex = 7;
            // 
            // MainTitle
            // 
            this.MainTitle.AutoSize = true;
            this.MainTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainTitle.ForeColor = System.Drawing.Color.White;
            this.MainTitle.Location = new System.Drawing.Point(329, 22);
            this.MainTitle.Name = "MainTitle";
            this.MainTitle.Size = new System.Drawing.Size(633, 54);
            this.MainTitle.TabIndex = 0;
            this.MainTitle.Text = "Warehouse Management Software";
            // 
            // ShipReceiveBt
            // 
            this.ShipReceiveBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ShipReceiveBt.Location = new System.Drawing.Point(108, 279);
            this.ShipReceiveBt.Name = "ShipReceiveBt";
            this.ShipReceiveBt.Size = new System.Drawing.Size(1075, 80);
            this.ShipReceiveBt.TabIndex = 8;
            this.ShipReceiveBt.Text = "2. Shipping / Receiving Command";
            this.ShipReceiveBt.UseVisualStyleBackColor = false;
            this.ShipReceiveBt.Click += new System.EventHandler(this.ShipReceiveBt_Click);
            // 
            // ReportBt
            // 
            this.ReportBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ReportBt.Location = new System.Drawing.Point(107, 388);
            this.ReportBt.Name = "ReportBt";
            this.ReportBt.Size = new System.Drawing.Size(1075, 80);
            this.ReportBt.TabIndex = 9;
            this.ReportBt.Text = "3. Report";
            this.ReportBt.UseVisualStyleBackColor = false;
            this.ReportBt.Click += new System.EventHandler(this.ReportBt_Click);
            // 
            // SaveFileBt
            // 
            this.SaveFileBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SaveFileBt.Location = new System.Drawing.Point(110, 489);
            this.SaveFileBt.Name = "SaveFileBt";
            this.SaveFileBt.Size = new System.Drawing.Size(1075, 80);
            this.SaveFileBt.TabIndex = 10;
            this.SaveFileBt.Text = "4. Save File";
            this.SaveFileBt.UseVisualStyleBackColor = false;
            this.SaveFileBt.Click += new System.EventHandler(this.SaveFileBt_Click);
            // 
            // HelpBt
            // 
            this.HelpBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.HelpBt.Location = new System.Drawing.Point(107, 601);
            this.HelpBt.Name = "HelpBt";
            this.HelpBt.Size = new System.Drawing.Size(1075, 80);
            this.HelpBt.TabIndex = 11;
            this.HelpBt.Text = "5. Help : How to use this software";
            this.HelpBt.UseVisualStyleBackColor = false;
            this.HelpBt.Click += new System.EventHandler(this.HelpBt_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1326, 755);
            this.Controls.Add(this.HelpBt);
            this.Controls.Add(this.SaveFileBt);
            this.Controls.Add(this.ReportBt);
            this.Controls.Add(this.ShipReceiveBt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FileEntyBt);
            this.Name = "MainPage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button FileEntyBt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label MainTitle;
        private System.Windows.Forms.Button ShipReceiveBt;
        private System.Windows.Forms.Button ReportBt;
        private System.Windows.Forms.Button SaveFileBt;
        private System.Windows.Forms.Button HelpBt;
    }
}

