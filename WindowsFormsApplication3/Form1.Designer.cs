namespace WindowsFormsApplication3
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labalClientZip = new System.Windows.Forms.Label();
            this.textBoxHackedClient = new System.Windows.Forms.TextBox();
            this.textBoxMinecraftFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // labalClientZip
            // 
            this.labalClientZip.AutoSize = true;
            this.labalClientZip.Location = new System.Drawing.Point(16, 15);
            this.labalClientZip.Name = "labalClientZip";
            this.labalClientZip.Size = new System.Drawing.Size(59, 12);
            this.labalClientZip.TabIndex = 0;
            this.labalClientZip.Text = "ClientZip";
            // 
            // textBoxHackedClient
            // 
            this.textBoxHackedClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHackedClient.Location = new System.Drawing.Point(81, 15);
            this.textBoxHackedClient.Name = "textBoxHackedClient";
            this.textBoxHackedClient.Size = new System.Drawing.Size(231, 14);
            this.textBoxHackedClient.TabIndex = 1;
            // 
            // textBoxMinecraftFolder
            // 
            this.textBoxMinecraftFolder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMinecraftFolder.Location = new System.Drawing.Point(81, 35);
            this.textBoxMinecraftFolder.Name = "textBoxMinecraftFolder";
            this.textBoxMinecraftFolder.Size = new System.Drawing.Size(231, 14);
            this.textBoxMinecraftFolder.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = ".minecraft";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Install!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(318, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 16);
            this.button3.TabIndex = 6;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(318, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 16);
            this.button2.TabIndex = 7;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "zip|*.zip";
            this.openFileDialog1.InitialDirectory = "C:\\";
            this.openFileDialog1.Title = "Browse zip File";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Browser .minecraft folder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 105);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxMinecraftFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxHackedClient);
            this.Controls.Add(this.labalClientZip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Hacked Client Installer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labalClientZip;
        private System.Windows.Forms.TextBox textBoxHackedClient;
        private System.Windows.Forms.TextBox textBoxMinecraftFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

