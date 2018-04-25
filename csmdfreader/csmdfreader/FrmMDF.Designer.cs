namespace csmdfreader
{
    partial class FrmMDF
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMDF = new System.Windows.Forms.Button();
            this.txtMDF = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMDF
            // 
            this.btnMDF.Location = new System.Drawing.Point(12, 12);
            this.btnMDF.Name = "btnMDF";
            this.btnMDF.Size = new System.Drawing.Size(75, 23);
            this.btnMDF.TabIndex = 0;
            this.btnMDF.Text = "MDF";
            this.btnMDF.UseVisualStyleBackColor = true;
            this.btnMDF.Click += new System.EventHandler(this.btnMDF_Click);
            // 
            // txtMDF
            // 
            this.txtMDF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMDF.Location = new System.Drawing.Point(12, 41);
            this.txtMDF.Multiline = true;
            this.txtMDF.Name = "txtMDF";
            this.txtMDF.ReadOnly = true;
            this.txtMDF.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMDF.Size = new System.Drawing.Size(389, 301);
            this.txtMDF.TabIndex = 1;
            // 
            // FrmMDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 354);
            this.Controls.Add(this.txtMDF);
            this.Controls.Add(this.btnMDF);
            this.Name = "FrmMDF";
            this.Text = "csmdfreader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMDF;
        private System.Windows.Forms.TextBox txtMDF;
    }
}

