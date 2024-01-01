namespace DownloadManager
{
    partial class AddDownloadForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDownloadURL = new System.Windows.Forms.TextBox();
            this.txtDownloadDirectory = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnAddDownload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Save to:";
            // 
            // txtDownloadURL
            // 
            this.txtDownloadURL.Location = new System.Drawing.Point(63, 10);
            this.txtDownloadURL.Name = "txtDownloadURL";
            this.txtDownloadURL.Size = new System.Drawing.Size(192, 20);
            this.txtDownloadURL.TabIndex = 2;
            // 
            // txtDownloadDirectory
            // 
            this.txtDownloadDirectory.Location = new System.Drawing.Point(63, 42);
            this.txtDownloadDirectory.Name = "txtDownloadDirectory";
            this.txtDownloadDirectory.Size = new System.Drawing.Size(154, 20);
            this.txtDownloadDirectory.TabIndex = 3;
            this.txtDownloadDirectory.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(223, 40);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(32, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnAddDownload
            // 
            this.btnAddDownload.Location = new System.Drawing.Point(185, 68);
            this.btnAddDownload.Name = "btnAddDownload";
            this.btnAddDownload.Size = new System.Drawing.Size(70, 23);
            this.btnAddDownload.TabIndex = 5;
            this.btnAddDownload.Text = "Download";
            this.btnAddDownload.UseVisualStyleBackColor = true;
            this.btnAddDownload.Click += new System.EventHandler(this.btnAddDownload_Click);
            // 
            // AddDownloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 99);
            this.Controls.Add(this.btnAddDownload);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtDownloadDirectory);
            this.Controls.Add(this.txtDownloadURL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddDownloadForm";
            this.Text = "fDownloadURL";
            this.Load += new System.EventHandler(this.AddDownloadForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDownloadURL;
        private System.Windows.Forms.TextBox txtDownloadDirectory;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnAddDownload;
    }
}