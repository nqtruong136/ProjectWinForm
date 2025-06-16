
namespace Project
{
    partial class TabItemControl
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
            this.lblClose = new System.Windows.Forms.Label();
            this.btnTab = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblClose
            // 
            this.lblClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblClose.Location = new System.Drawing.Point(0, 99);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(75, 52);
            this.lblClose.TabIndex = 0;
            this.lblClose.Text = "X";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // btnTab
            // 
            this.btnTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTab.Location = new System.Drawing.Point(0, 0);
            this.btnTab.Name = "btnTab";
            this.btnTab.Size = new System.Drawing.Size(75, 99);
            this.btnTab.TabIndex = 1;
            this.btnTab.Text = "button1";
            this.btnTab.UseVisualStyleBackColor = true;
            this.btnTab.Click += new System.EventHandler(this.btnTab_Click);
            // 
            // TabItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTab);
            this.Controls.Add(this.lblClose);
            this.Name = "TabItemControl";
            this.Size = new System.Drawing.Size(75, 151);
            this.Load += new System.EventHandler(this.TabItemControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Button btnTab;
    }
}
