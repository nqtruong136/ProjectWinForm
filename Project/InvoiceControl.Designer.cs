
namespace Project
{
    partial class InvoiceControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblThanhToan = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.timerColorChange = new System.Windows.Forms.Timer(this.components);
            this.cboKhuyenMai = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Location = new System.Drawing.Point(0, 0);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(0);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(448, 255);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            this.dgvProducts.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProducts_RowHeaderMouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvProducts);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 255);
            this.panel1.TabIndex = 2;
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(224, 76);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(124, 48);
            this.label.TabIndex = 1;
            this.label.Text = "Tong TIền";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.lblThanhToan);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.label);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(448, 161);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cboKhuyenMai);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(448, 55);
            this.panel3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Khuyến Mãi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(448, 55);
            this.panel4.TabIndex = 7;
            // 
            // lblThanhToan
            // 
            this.lblThanhToan.Font = new System.Drawing.Font("Open Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhToan.Location = new System.Drawing.Point(20, 91);
            this.lblThanhToan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThanhToan.Name = "lblThanhToan";
            this.lblThanhToan.Size = new System.Drawing.Size(176, 33);
            this.lblThanhToan.TabIndex = 3;
            this.lblThanhToan.Text = "Thanh Toán";
            this.lblThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblThanhToan.Click += new System.EventHandler(this.lblThanhToan_Click);
            this.lblThanhToan.Paint += new System.Windows.Forms.PaintEventHandler(this.lblThanhToan_Paint);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(352, 92);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(59, 22);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "label1";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // timerColorChange
            // 
            this.timerColorChange.Enabled = true;
            this.timerColorChange.Interval = 20;
            this.timerColorChange.Tick += new System.EventHandler(this.timerColorChange_Tick);
            // 
            // cboKhuyenMai
            // 
            this.cboKhuyenMai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhuyenMai.FormattingEnabled = true;
            this.cboKhuyenMai.Location = new System.Drawing.Point(204, 15);
            this.cboKhuyenMai.Name = "cboKhuyenMai";
            this.cboKhuyenMai.Size = new System.Drawing.Size(187, 24);
            this.cboKhuyenMai.TabIndex = 6;
            this.cboKhuyenMai.SelectedIndexChanged += new System.EventHandler(this.cboKhuyenMai_SelectedIndexChanged);
            // 
            // InvoiceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "InvoiceControl";
            this.Size = new System.Drawing.Size(448, 255);
            this.Load += new System.EventHandler(this.InvoiceControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblThanhToan;
        private System.Windows.Forms.Timer timerColorChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cboKhuyenMai;
    }
}
