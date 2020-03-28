using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace LargeFileCopy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private OpenFileDialog ofd;
        private SaveFileDialog sfd;
        /// <summary>
        /// 选择要拷贝的文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            //ofd.InitialDirectory = @"D:\迅雷下载";
            ofd.ShowDialog();
            lblSelectedFile.Text = ofd.FileName;

        }

        private void btnDistPath_Click(object sender, EventArgs e)
        {
            sfd = new SaveFileDialog();
            //sfd.InitialDirectory = @"C:\Users\15468\Desktop";
            sfd.ShowDialog();
            string distPath = sfd.FileName;
            Thread th = new Thread(() =>
            {
                CopyFile(ofd.FileName, sfd.FileName);
            });
            th.Start();
            th.IsBackground = true;

        }
        /// <summary>
        /// 复制文件
        /// </summary>
        /// <param name="source"></param>
        /// <param name="dist"></param>
        private void CopyFile(string source, string dist)
        {
            if (string.IsNullOrEmpty(source))
            {
                MessageBox.Show("请选择源文件");
                return;
            }
            if (string.IsNullOrEmpty(dist))
            {
                MessageBox.Show("请选择目标文件");
                return;
            }
            using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
            {
                using (FileStream fsWrite = new FileStream(dist, FileMode.Create, FileAccess.Write))
                {
                    byte[] buffer = new byte[1024 * 1024 * 5];
                    int r;
                    while ((r = fsRead.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        fsWrite.Write(buffer, 0, r);
                        double pos = (fsWrite.Position * 1.0 / fsRead.Length) * 100;
                        progressBar.Value = (int)pos;
                        lblSelectedFile.Text = progressBar.Value + "%";

                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
