using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSF_Join1
{
    public partial class Form1 : Form
    {

        private string folderName;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            folderName = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            DialogResult result = folderBrowserDialog1.ShowDialog();            
            if (result == DialogResult.OK)
            {
                folderName = folderBrowserDialog1.SelectedPath;
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] sff_files;
            string[] ssf_name;
            string temp = string.Empty;
            string[] temp2;

            sff_files = Directory.GetFiles(folderName, "*.ssf");

            ssf_name = new string[sff_files.Length];

            for (int i =0; i < sff_files.Length; i++)
            {
                ssf_name[i] = Path.GetFileNameWithoutExtension(sff_files[i]);
            }

            


            for (int i = 0; i < sff_files.Length; i++)
            {
                try
                {
                    using (StreamReader reader = new StreamReader(sff_files[i]) )
                    {
                        temp = reader.ReadToEnd();
                        temp2 = temp.Split(new[] { "\r\n", "\r", "\n" },StringSplitOptions.None);
                    }

                    using (StreamWriter writer = new StreamWriter(textBox1.Text + ".ssf1", true, Encoding.UTF8 ) )
                    {
                        if (temp != string.Empty)
                        {
                            writer.WriteLine(string.Join(",", temp2));
                        }
                            
                    }

                    IniFileHelper.WriteValue(textBox1.Text, ssf_name[i], string.Join(",", temp2), ".//" + textBox1.Text + ".ssf2");
                    

                }
                catch (Exception excp)
                {

                }
            }
        }


    }
}
