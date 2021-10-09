namespace WebVideoPlayer
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnclswebsite = new System.Windows.Forms.Button();
            this.btnclslikelist = new System.Windows.Forms.Button();
            this.btnaddlikelist = new System.Windows.Forms.Button();
            this.btnclsvideo = new System.Windows.Forms.Button();
            this.btnclshistory = new System.Windows.Forms.Button();
            this.btnleave = new System.Windows.Forms.Button();
            this.likelist = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.histroylist = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 506);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Youtube網址:";
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.Chartreuse;
            this.btnGo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGo.Location = new System.Drawing.Point(555, 497);
            this.btnGo.Margin = new System.Windows.Forms.Padding(2);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(53, 31);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "&尋找";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(81, 503);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(2);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(470, 22);
            this.txtUrl.TabIndex = 2;
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(9, 11);
            this.webBrowser.Margin = new System.Windows.Forms.Padding(2);
            this.webBrowser.MinimumSize = new System.Drawing.Size(15, 16);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(599, 482);
            this.webBrowser.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnclswebsite);
            this.groupBox1.Controls.Add(this.btnclslikelist);
            this.groupBox1.Controls.Add(this.btnaddlikelist);
            this.groupBox1.Controls.Add(this.btnclsvideo);
            this.groupBox1.Controls.Add(this.btnclshistory);
            this.groupBox1.Location = new System.Drawing.Point(13, 529);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(595, 147);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "功能選單";
            // 
            // btnclswebsite
            // 
            this.btnclswebsite.Location = new System.Drawing.Point(428, 19);
            this.btnclswebsite.Margin = new System.Windows.Forms.Padding(2);
            this.btnclswebsite.Name = "btnclswebsite";
            this.btnclswebsite.Size = new System.Drawing.Size(66, 47);
            this.btnclswebsite.TabIndex = 4;
            this.btnclswebsite.Text = "   清除     網址";
            this.btnclswebsite.UseVisualStyleBackColor = true;
            this.btnclswebsite.Click += new System.EventHandler(this.btnclswebsite_Click);
            // 
            // btnclslikelist
            // 
            this.btnclslikelist.Location = new System.Drawing.Point(81, 82);
            this.btnclslikelist.Margin = new System.Windows.Forms.Padding(2);
            this.btnclslikelist.Name = "btnclslikelist";
            this.btnclslikelist.Size = new System.Drawing.Size(69, 47);
            this.btnclslikelist.TabIndex = 3;
            this.btnclslikelist.Text = "   清除    喜愛清單";
            this.btnclslikelist.UseVisualStyleBackColor = true;
            this.btnclslikelist.Click += new System.EventHandler(this.btnclslikelist_Click);
            // 
            // btnaddlikelist
            // 
            this.btnaddlikelist.Location = new System.Drawing.Point(81, 19);
            this.btnaddlikelist.Margin = new System.Windows.Forms.Padding(2);
            this.btnaddlikelist.Name = "btnaddlikelist";
            this.btnaddlikelist.Size = new System.Drawing.Size(69, 47);
            this.btnaddlikelist.TabIndex = 2;
            this.btnaddlikelist.Text = "   加入    喜愛清單";
            this.btnaddlikelist.UseVisualStyleBackColor = true;
            this.btnaddlikelist.Click += new System.EventHandler(this.btnaddlikelist_Click);
            // 
            // btnclsvideo
            // 
            this.btnclsvideo.Location = new System.Drawing.Point(268, 19);
            this.btnclsvideo.Margin = new System.Windows.Forms.Padding(2);
            this.btnclsvideo.Name = "btnclsvideo";
            this.btnclsvideo.Size = new System.Drawing.Size(65, 47);
            this.btnclsvideo.TabIndex = 1;
            this.btnclsvideo.Text = "   清除     影片";
            this.btnclsvideo.UseVisualStyleBackColor = true;
            this.btnclsvideo.Click += new System.EventHandler(this.btnclsvideo_Click);
            // 
            // btnclshistory
            // 
            this.btnclshistory.Location = new System.Drawing.Point(268, 79);
            this.btnclshistory.Margin = new System.Windows.Forms.Padding(2);
            this.btnclshistory.Name = "btnclshistory";
            this.btnclshistory.Size = new System.Drawing.Size(65, 50);
            this.btnclshistory.TabIndex = 0;
            this.btnclshistory.Text = "   清除    歷史紀錄";
            this.btnclshistory.UseVisualStyleBackColor = true;
            this.btnclshistory.Click += new System.EventHandler(this.btnclshistory_Click);
            // 
            // btnleave
            // 
            this.btnleave.Location = new System.Drawing.Point(441, 608);
            this.btnleave.Margin = new System.Windows.Forms.Padding(2);
            this.btnleave.Name = "btnleave";
            this.btnleave.Size = new System.Drawing.Size(66, 50);
            this.btnleave.TabIndex = 5;
            this.btnleave.Text = "離開";
            this.btnleave.UseVisualStyleBackColor = true;
            this.btnleave.Click += new System.EventHandler(this.btnleave_Click);
            // 
            // likelist
            // 
            this.likelist.FormattingEnabled = true;
            this.likelist.Location = new System.Drawing.Point(623, 300);
            this.likelist.Margin = new System.Windows.Forms.Padding(2);
            this.likelist.Name = "likelist";
            this.likelist.Size = new System.Drawing.Size(100, 20);
            this.likelist.TabIndex = 5;
            this.likelist.SelectedIndexChanged += new System.EventHandler(this.likelist_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(645, 286);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "喜好清單";
            // 
            // histroylist
            // 
            this.histroylist.FormattingEnabled = true;
            this.histroylist.Location = new System.Drawing.Point(623, 25);
            this.histroylist.Margin = new System.Windows.Forms.Padding(2);
            this.histroylist.Name = "histroylist";
            this.histroylist.Size = new System.Drawing.Size(100, 20);
            this.histroylist.TabIndex = 7;
            this.histroylist.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(645, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "歷史紀錄";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(734, 678);
            this.Controls.Add(this.btnleave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.histroylist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.likelist);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "網頁影片播放器";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnleave;
        private System.Windows.Forms.Button btnclswebsite;
        private System.Windows.Forms.Button btnclslikelist;
        private System.Windows.Forms.Button btnaddlikelist;
        private System.Windows.Forms.Button btnclsvideo;
        private System.Windows.Forms.Button btnclshistory;
        private System.Windows.Forms.ComboBox likelist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox histroylist;
        private System.Windows.Forms.Label label3;
    }
}

