namespace LargeFileCopy
{
    partial class Form1
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
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.lblSelectedFile = new System.Windows.Forms.Label();
            this.btnDistPath = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(175, 87);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(148, 23);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "选择要复制的文件";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // lblSelectedFile
            // 
            this.lblSelectedFile.AutoSize = true;
            this.lblSelectedFile.Location = new System.Drawing.Point(530, 217);
            this.lblSelectedFile.Name = "lblSelectedFile";
            this.lblSelectedFile.Size = new System.Drawing.Size(17, 12);
            this.lblSelectedFile.TabIndex = 1;
            this.lblSelectedFile.Text = "0%";
            // 
            // btnDistPath
            // 
            this.btnDistPath.Location = new System.Drawing.Point(434, 86);
            this.btnDistPath.Name = "btnDistPath";
            this.btnDistPath.Size = new System.Drawing.Size(146, 23);
            this.btnDistPath.TabIndex = 2;
            this.btnDistPath.Text = "选择复制路径";
            this.btnDistPath.UseVisualStyleBackColor = true;
            this.btnDistPath.Click += new System.EventHandler(this.btnDistPath_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(175, 208);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(349, 31);
            this.progressBar.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnDistPath);
            this.Controls.Add(this.lblSelectedFile);
            this.Controls.Add(this.btnOpenFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label lblSelectedFile;
        private System.Windows.Forms.Button btnDistPath;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

