
namespace Project
{
    partial class UserControl_Pos
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.Cate4 = new System.Windows.Forms.Label();
            this.Cate3 = new System.Windows.Forms.Label();
            this.Cate2 = new System.Windows.Forms.Label();
            this.Cate1 = new System.Windows.Forms.Label();
            this.pnlCate = new System.Windows.Forms.Panel();
            this.pnlMainHD = new System.Windows.Forms.Panel();
            this.tabPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddTab = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitContainer1.Panel2.Controls.Add(this.pnlMainHD);
            this.splitContainer1.Panel2.Controls.Add(this.tabPanel);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1099, 571);
            this.splitContainer1.SplitterDistance = 806;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.HotPink;
            this.splitContainer2.Panel1.Controls.Add(this.Cate4);
            this.splitContainer2.Panel1.Controls.Add(this.Cate3);
            this.splitContainer2.Panel1.Controls.Add(this.Cate2);
            this.splitContainer2.Panel1.Controls.Add(this.Cate1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.pnlCate);
            this.splitContainer2.Size = new System.Drawing.Size(806, 571);
            this.splitContainer2.SplitterDistance = 47;
            this.splitContainer2.TabIndex = 0;
            // 
            // Cate4
            // 
            this.Cate4.Location = new System.Drawing.Point(459, 4);
            this.Cate4.Name = "Cate4";
            this.Cate4.Size = new System.Drawing.Size(146, 43);
            this.Cate4.TabIndex = 3;
            this.Cate4.Text = "Nước";
            this.Cate4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cate4.Click += new System.EventHandler(this.Cate4_Click);
            // 
            // Cate3
            // 
            this.Cate3.Location = new System.Drawing.Point(307, 4);
            this.Cate3.Name = "Cate3";
            this.Cate3.Size = new System.Drawing.Size(146, 43);
            this.Cate3.TabIndex = 2;
            this.Cate3.Text = "Món Ăn Kèm";
            this.Cate3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cate3.Click += new System.EventHandler(this.Cate3_Click);
            // 
            // Cate2
            // 
            this.Cate2.Location = new System.Drawing.Point(155, 4);
            this.Cate2.Name = "Cate2";
            this.Cate2.Size = new System.Drawing.Size(146, 43);
            this.Cate2.TabIndex = 1;
            this.Cate2.Text = "Gà Rán Lẻ";
            this.Cate2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cate2.Click += new System.EventHandler(this.Cate2_Click);
            // 
            // Cate1
            // 
            this.Cate1.Location = new System.Drawing.Point(3, 4);
            this.Cate1.Name = "Cate1";
            this.Cate1.Size = new System.Drawing.Size(146, 43);
            this.Cate1.TabIndex = 0;
            this.Cate1.Text = "Combo Gà Rán";
            this.Cate1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cate1.Click += new System.EventHandler(this.Cate1_Click);
            // 
            // pnlCate
            // 
            this.pnlCate.BackColor = System.Drawing.SystemColors.Menu;
            this.pnlCate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCate.Location = new System.Drawing.Point(0, 0);
            this.pnlCate.Name = "pnlCate";
            this.pnlCate.Size = new System.Drawing.Size(806, 520);
            this.pnlCate.TabIndex = 0;
            this.pnlCate.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCate_Paint);
            // 
            // pnlMainHD
            // 
            this.pnlMainHD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMainHD.Location = new System.Drawing.Point(45, 0);
            this.pnlMainHD.Name = "pnlMainHD";
            this.pnlMainHD.Size = new System.Drawing.Size(244, 571);
            this.pnlMainHD.TabIndex = 1;
            // 
            // tabPanel
            // 
            this.tabPanel.Controls.Add(this.btnAddTab);
            this.tabPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.tabPanel.Location = new System.Drawing.Point(0, 0);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.Size = new System.Drawing.Size(50, 571);
            this.tabPanel.TabIndex = 0;
            // 
            // btnAddTab
            // 
            this.btnAddTab.Location = new System.Drawing.Point(3, 3);
            this.btnAddTab.Name = "btnAddTab";
            this.btnAddTab.Size = new System.Drawing.Size(36, 35);
            this.btnAddTab.TabIndex = 0;
            this.btnAddTab.Text = "+";
            this.btnAddTab.UseVisualStyleBackColor = true;
            this.btnAddTab.Click += new System.EventHandler(this.btnAddTab_Click);
            // 
            // UserControl_Pos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UserControl_Pos";
            this.Size = new System.Drawing.Size(1099, 571);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label Cate3;
        private System.Windows.Forms.Label Cate2;
        private System.Windows.Forms.Label Cate1;
        private System.Windows.Forms.Label Cate4;
        private System.Windows.Forms.Panel pnlCate;
        private System.Windows.Forms.FlowLayoutPanel tabPanel;
        private System.Windows.Forms.Button btnAddTab;
        private System.Windows.Forms.Panel pnlMainHD;
    }
}
