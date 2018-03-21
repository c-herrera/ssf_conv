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

namespace SSF_Concat
{
    public partial class frm_Concatenate : Form
    {
        private string folderName; // Folder path
        SimpleLogger Log;


        /// <summary>
        /// Form constructor
        /// </summary>
        public frm_Concatenate()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form startup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_Concatenate_Load(object sender, EventArgs e)
        {
            folderName = string.Empty;
            Log = new SimpleLogger();
            Log.Info("Form load, seems ok!");

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_open_folder_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderName = folderBrowserDialog1.SelectedPath;
                Log.Info("Selected a folder " + folderName);
                btn_process_files.Enabled = true;
                
            }
            else
            {
                Log.Warning("Canceled the folder dialog, this does not look good!");
            }
        }

        /// <summary>
        /// Process ssf files button
        /// </summary>
        /// <param name="sender"> Object to process, optional</param>
        /// <param name="e">Arguments not used </param>
        private void btn_process_files_Click(object sender, EventArgs e)
        {
            string[] ssf_fullname;
            string[] ssf_name_key;
            string value_sline = string.Empty;
            string[] values_mline;

            ssf_fullname = Directory.GetFiles(folderName, "*.ssf");
            ssf_name_key = new string[ssf_fullname.Length];

            for (int i = 0; i < ssf_fullname.Length; i++)
            {
                ssf_name_key[i] = Path.GetFileNameWithoutExtension(ssf_fullname[i]);
            }

            for (int i = 0; i < ssf_fullname.Length; i++)
            {
                try
                {
                    using (StreamReader reader = new StreamReader(ssf_fullname[i]))
                    {
                        value_sline = reader.ReadToEnd();
                        values_mline = value_sline.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                    }
                    // Save the velues of the several strings into pne comma separate string.
                    IniFileHelper.WriteValue(txt_prefix_key.Text, ssf_name_key[i], string.Join(",", values_mline), ".//" + txt_prefix_key.Text + ".ssf");

                    Log.Info("Saved info from : " + folderName + " key :" + ssf_name_key[i] + " into " + txt_prefix_key.Text + ".ssf");
                }
                catch (Exception excp)
                {
                    MessageBox.Show("Error execption :" + excp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Log.Error("An exception ocurred "  + excp.Message);
                }
            }

            if (File.Exists(txt_prefix_key.Text + ".ssf"))
            {
                Log.Trace("Moving file to " + Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
                File.Move(".//" + txt_prefix_key.Text + ".ssf", Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//" + txt_prefix_key.Text + ".ssf");
            }

            btn_process_files.Enabled = false;
            txt_prefix_key.Text = String.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_quit_tool_Click(object sender, EventArgs e)
        {
            Log.Trace("Application Exit!");
            Log.Report("Error count    : " + Log.TotalErrors);
            Log.Report("Warnings count : " + Log.TotalWarnings);
            Log.Report("Failures count : " + Log.TotalFatalErrors);
            Application.Exit();
        }


    }
}
