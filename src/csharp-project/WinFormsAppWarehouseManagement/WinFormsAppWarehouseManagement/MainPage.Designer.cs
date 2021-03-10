
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
            this.label1 = new System.Windows.Forms.Label();
            this.FileEntry = new System.Windows.Forms.Label();
            this.ShippingReceivingCommand = new System.Windows.Forms.Label();
            this.Report = new System.Windows.Forms.Label();
            this.SaveFile = new System.Windows.Forms.Label();
            this.Help = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(105, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(629, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Warehouse Management software";
            // 
            // FileEntry
            // 
            this.FileEntry.AutoSize = true;
            this.FileEntry.Location = new System.Drawing.Point(147, 138);
            this.FileEntry.Name = "FileEntry";
            this.FileEntry.Size = new System.Drawing.Size(169, 41);
            this.FileEntry.TabIndex = 1;
            this.FileEntry.Text = "1. File Entry";
            this.FileEntry.Click += new System.EventHandler(this.FileEntry_Click);
            // 
            // ShippingReceivingCommand
            // 
            this.ShippingReceivingCommand.AutoSize = true;
            this.ShippingReceivingCommand.Location = new System.Drawing.Point(146, 201);
            this.ShippingReceivingCommand.Name = "ShippingReceivingCommand";
            this.ShippingReceivingCommand.Size = new System.Drawing.Size(463, 41);
            this.ShippingReceivingCommand.TabIndex = 2;
            this.ShippingReceivingCommand.Text = "2. Shipping / Receiving command";
            this.ShippingReceivingCommand.Click += new System.EventHandler(this.ShippingReceivingCommand_Click);
            // 
            // Report
            // 
            this.Report.AutoSize = true;
            this.Report.Location = new System.Drawing.Point(146, 261);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(138, 41);
            this.Report.TabIndex = 3;
            this.Report.Text = "3. Report";
            this.Report.Click += new System.EventHandler(this.Report_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.AutoSize = true;
            this.SaveFile.Location = new System.Drawing.Point(146, 321);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(163, 41);
            this.SaveFile.TabIndex = 4;
            this.SaveFile.Text = "4. Save File";
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // Help
            // 
            this.Help.AutoSize = true;
            this.Help.Location = new System.Drawing.Point(148, 389);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(469, 41);
            this.Help.TabIndex = 5;
            this.Help.Text = "5. Help : How to use this software ";
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.ShippingReceivingCommand);
            this.Controls.Add(this.FileEntry);
            this.Controls.Add(this.label1);
            this.Name = "MainPage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FileEntry;
        private System.Windows.Forms.Label ShippingReceivingCommand;
        private System.Windows.Forms.Label Report;
        private System.Windows.Forms.Label SaveFile;
        private System.Windows.Forms.Label Help;
    }
}

