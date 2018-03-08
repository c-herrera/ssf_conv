namespace SSF_Concat
{
    partial class frm_Concatenate
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Concatenate));
            this.btn_open_folder = new System.Windows.Forms.Button();
            this.btn_process_files = new System.Windows.Forms.Button();
            this.txt_prefix_key = new System.Windows.Forms.TextBox();
            this.lbl_info1 = new System.Windows.Forms.Label();
            this.btn_quit_tool = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btn_open_folder
            // 
            this.btn_open_folder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_open_folder.ImageIndex = 2;
            this.btn_open_folder.ImageList = this.imageList1;
            this.btn_open_folder.Location = new System.Drawing.Point(47, 27);
            this.btn_open_folder.Name = "btn_open_folder";
            this.btn_open_folder.Size = new System.Drawing.Size(155, 23);
            this.btn_open_folder.TabIndex = 0;
            this.btn_open_folder.Text = "Search Folder";
            this.btn_open_folder.UseVisualStyleBackColor = true;
            this.btn_open_folder.Click += new System.EventHandler(this.btn_open_folder_Click);
            // 
            // btn_process_files
            // 
            this.btn_process_files.Enabled = false;
            this.btn_process_files.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_process_files.ImageIndex = 1;
            this.btn_process_files.ImageList = this.imageList1;
            this.btn_process_files.Location = new System.Drawing.Point(47, 155);
            this.btn_process_files.Name = "btn_process_files";
            this.btn_process_files.Size = new System.Drawing.Size(155, 23);
            this.btn_process_files.TabIndex = 1;
            this.btn_process_files.Text = "Process SSFs";
            this.btn_process_files.UseVisualStyleBackColor = true;
            this.btn_process_files.Click += new System.EventHandler(this.btn_process_files_Click);
            // 
            // txt_prefix_key
            // 
            this.txt_prefix_key.Location = new System.Drawing.Point(47, 109);
            this.txt_prefix_key.Name = "txt_prefix_key";
            this.txt_prefix_key.Size = new System.Drawing.Size(155, 20);
            this.txt_prefix_key.TabIndex = 2;
            // 
            // lbl_info1
            // 
            this.lbl_info1.AutoSize = true;
            this.lbl_info1.Location = new System.Drawing.Point(44, 81);
            this.lbl_info1.Name = "lbl_info1";
            this.lbl_info1.Size = new System.Drawing.Size(124, 13);
            this.lbl_info1.TabIndex = 3;
            this.lbl_info1.Text = "Type the Prefix of the file";
            // 
            // btn_quit_tool
            // 
            this.btn_quit_tool.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_quit_tool.ImageIndex = 0;
            this.btn_quit_tool.ImageList = this.imageList1;
            this.btn_quit_tool.Location = new System.Drawing.Point(127, 225);
            this.btn_quit_tool.Name = "btn_quit_tool";
            this.btn_quit_tool.Size = new System.Drawing.Size(75, 23);
            this.btn_quit_tool.TabIndex = 4;
            this.btn_quit_tool.Text = "Exit";
            this.btn_quit_tool.UseVisualStyleBackColor = true;
            this.btn_quit_tool.Click += new System.EventHandler(this.btn_quit_tool_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Apps-session-logout-icon.png");
            this.imageList1.Images.SetKeyName(1, "Gear-icon.png");
            this.imageList1.Images.SetKeyName(2, "Search-icon.png");
            this.imageList1.Images.SetKeyName(3, "symbol-check-icon.png");
            this.imageList1.Images.SetKeyName(4, "Tools-icon.png");
            // 
            // frm_Concatenate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 293);
            this.Controls.Add(this.btn_quit_tool);
            this.Controls.Add(this.lbl_info1);
            this.Controls.Add(this.txt_prefix_key);
            this.Controls.Add(this.btn_process_files);
            this.Controls.Add(this.btn_open_folder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_Concatenate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SSF Concatenate";
            this.Load += new System.EventHandler(this.frm_Concatenate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_open_folder;
        private System.Windows.Forms.Button btn_process_files;
        private System.Windows.Forms.TextBox txt_prefix_key;
        private System.Windows.Forms.Label lbl_info1;
        private System.Windows.Forms.Button btn_quit_tool;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

