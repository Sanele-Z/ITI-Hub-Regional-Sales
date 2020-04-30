namespace Total_Sales_App
{
    partial class frmTotal_Sales
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
            this.lstRegionalSales = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRegionalSales = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstRegionalSales
            // 
            this.lstRegionalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRegionalSales.FormattingEnabled = true;
            this.lstRegionalSales.ItemHeight = 16;
            this.lstRegionalSales.Location = new System.Drawing.Point(12, 80);
            this.lstRegionalSales.Name = "lstRegionalSales";
            this.lstRegionalSales.Size = new System.Drawing.Size(764, 164);
            this.lstRegionalSales.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(689, 272);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 43);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRegionalSales
            // 
            this.lblRegionalSales.AutoSize = true;
            this.lblRegionalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegionalSales.Location = new System.Drawing.Point(12, 44);
            this.lblRegionalSales.Name = "lblRegionalSales";
            this.lblRegionalSales.Size = new System.Drawing.Size(202, 20);
            this.lblRegionalSales.TabIndex = 2;
            this.lblRegionalSales.Text = "ITI Hub Regional Sales";
            // 
            // frmTotal_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 333);
            this.Controls.Add(this.lblRegionalSales);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lstRegionalSales);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmTotal_Sales";
            this.Text = "ITI Hub Regional Sales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstRegionalSales;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRegionalSales;
    }
}

