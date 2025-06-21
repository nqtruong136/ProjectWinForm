
namespace Project
{
    partial class FormHD
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblTB = new System.Windows.Forms.Label();
            this.ProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ProductBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Product_DataSet";
            reportDataSource1.Value = this.ProductBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Project.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(40, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(505, 485);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(570, 249);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(82, 38);
            this.btnIn.TabIndex = 1;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(696, 249);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(82, 38);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lblTB
            // 
            this.lblTB.AutoSize = true;
            this.lblTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTB.Location = new System.Drawing.Point(593, 187);
            this.lblTB.Name = "lblTB";
            this.lblTB.Size = new System.Drawing.Size(59, 20);
            this.lblTB.TabIndex = 2;
            this.lblTB.Text = "label1";
            // 
            // ProductBindingSource
            // 
            this.ProductBindingSource.DataSource = typeof(Project.Product);
            // 
            // FormHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.lblTB);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormHD";
            this.Text = "Chi Tiết Hóa Đơn";
            this.Load += new System.EventHandler(this.FormHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lblTB;
        private System.Windows.Forms.BindingSource ProductBindingSource;
    }
}