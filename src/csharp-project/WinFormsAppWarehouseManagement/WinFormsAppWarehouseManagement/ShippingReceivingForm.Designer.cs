
namespace WinFormsAppWarehouseManagement
{
    partial class ShippingReceivingForm
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
            this.ShippingReceiving = new System.Windows.Forms.Label();
            this.BackToMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShippingReceiving
            // 
            this.ShippingReceiving.AutoSize = true;
            this.ShippingReceiving.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ShippingReceiving.Location = new System.Drawing.Point(196, 64);
            this.ShippingReceiving.Name = "ShippingReceiving";
            this.ShippingReceiving.Size = new System.Drawing.Size(437, 41);
            this.ShippingReceiving.TabIndex = 0;
            this.ShippingReceiving.Text = "Shipping / Receiving Command";
            // 
            // BackToMain
            // 
            this.BackToMain.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackToMain.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.BackToMain.Location = new System.Drawing.Point(273, 398);
            this.BackToMain.Name = "BackToMain";
            this.BackToMain.Size = new System.Drawing.Size(232, 36);
            this.BackToMain.TabIndex = 1;
            this.BackToMain.Text = "Back To Main";
            this.BackToMain.UseVisualStyleBackColor = true;
            this.BackToMain.Click += new System.EventHandler(this.BackToMain_Click);
            // 
            // ShippingReceivingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.BackToMain);
            this.Controls.Add(this.ShippingReceiving);
            this.Name = "ShippingReceivingForm";
            this.Text = "ShippingReceivingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ShippingReceiving;
        private System.Windows.Forms.Button BackToMain;
    }
}