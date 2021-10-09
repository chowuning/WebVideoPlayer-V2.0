/*
 * File Name:WebVideoPalyer(WVP)
 * Designer Name:Lee Cheng Yu 
 * Designer Number:16(School Number)
 * Language Tools:C#
 */
using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WebVideoPlayer
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        string _ytUrl;
        private string VideoId
        {
            get
            {
                var ytMatch = new Regex(@"youtu(?:\.be|be\.com)/(?:.*v(?:/|=)|(?:.*/)?)([a-zA-Z0-9-_]+)").Match(_ytUrl);
                return ytMatch.Success ? ytMatch.Groups[1].Value : string.Empty;
            }
        }
        private void btnGo_Click(object sender, EventArgs e)
        {
            _ytUrl = txtUrl.Text;
            webBrowser.Navigate($"http://youtube.com/v/{VideoId}?version=3");

            //Add in history list.
            history = txtUrl.Text;
            histroylist.Items.Add(new MyItem("歷史紀錄" + historycount.ToString(), history));
            historycount++;


            //When I pressdown search,clean like list text.
            likelist.Text = "";
            //When I pressdown search,clean history list text.
            histroylist.Text = "";

        }
        //Change thread priority
        [DllImport("KERNEL32.DLL", EntryPoint = "SetProcessWorkingSetSize", SetLastError = true, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool SetProcessWorkingSetSize(IntPtr pProcess, int dwMinimumWorkingSetSize, int dwMaximumWorkingSetSize);

        [DllImport("KERNEL32.DLL", EntryPoint = "GetCurrentProcess", SetLastError = true, CallingConvention = CallingConvention.StdCall)]
        internal static extern IntPtr GetCurrentProcess();

        private void btnclswebsite_Click(object sender, EventArgs e)
        {
            txtUrl.Text="";
            MessageBox.Show("已成功清除網址。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnleave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        struct MyItem
        {
            public MyItem(string displayName, string realValue)
            {
                DisplayName = displayName;
                RealValue = realValue;
            }
            public string DisplayName { get; set; }
            public string RealValue { get; set; }
            // must have this override method to display the right string.
            public override string ToString()
            {
                return DisplayName;
            }
        }

        string like;
        int likecount = 1;

        private void btnaddlikelist_Click(object sender, EventArgs e)
        {
           like = txtUrl.Text;
           likelist.Items.Add(new MyItem("喜好" + likecount.ToString(), like));

            //message box
            MessageBox.Show("已成功加入喜好清單" + likecount + "。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

           likecount++;
        }

        private void likelist_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUrl.Text = ((MyItem)likelist.SelectedItem).RealValue;
        }
        private void btnclslikelist_Click(object sender, EventArgs e)
        {
            likelist.Items.Clear();
            likelist.Text = "";
            //message box
            MessageBox.Show("已成功清除喜好清單。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            likecount = 1;
        }
        string history;
        int historycount = 1;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUrl.Text = ((MyItem)histroylist.SelectedItem).RealValue;
        }

        private void btnclshistory_Click(object sender, EventArgs e)
        {
            histroylist.Items.Clear();
            histroylist.Text = "";

            //message box
            MessageBox.Show("已成功清除歷史紀錄。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            historycount = 1;
        }

        private void btnclsvideo_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate("about:blank");

            //message box
            MessageBox.Show("已成功清除影片。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }


    }
}
