using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;
using ICSharpCode.SharpZipLib.Zip;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxMinecraftFolder.Text == "")
            {
                MessageBox.Show("Please Select Your Minecraft .minecraft folder!!!","Warn",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            if (textBoxHackedClient.Text == "")
            {
                MessageBox.Show("Please Select Your HACKED CLIENT zip file!!!","Warn",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            FastZip Zip = new FastZip();
            File.Copy(@textBoxHackedClient.Text ,@textBoxMinecraftFolder + @"\versions",true);
            Zip.ExtractZip(@textBoxHackedClient.Text, @textBoxMinecraftFolder.Text + @"versions", "");
            string FileName = Path.GetFileName(@textBoxHackedClient.Text);
            if (File.Exists(@textBoxMinecraftFolder.Text + @"\versions" + FileName) == true)
            {
                MessageBox.Show("Instll done!", "Gooooood job");
                File.Delete(@textBoxMinecraftFolder.Text + @"\versions" + FileName);
            }
            else
            {
                MessageBox.Show("Sorry......It failed...you can try again or install by hand.");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBoxHackedClient.Text = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBoxMinecraftFolder.Text = folderBrowserDialog1.SelectedPath;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to use this program!It Code by AHpx,and using C#,67 lines code.","about...",MessageBoxButtons .OK,MessageBoxIcon.Warning);
            textBoxMinecraftFolder.Text = @"C:\Users\AHpx\AppData\Roaming\.minecraft";
            openFileDialog1.InitialDirectory = @"C:\Users\Administrator\Downloads";
        }
    }
}
