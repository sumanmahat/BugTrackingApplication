using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracking_Aplication_suman_mahat.Views
{
    public partial class Notification : Form
    {
        public Notification()
        {
            InitializeComponent();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Notification_Move(object sender, EventArgs e)
        {
           
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            using (System.Net.WebClient client = new System.Net.WebClient())
            {
                try
                {
                    string url = "http://smsc.vianett.no/v3/send.ashx?" +
                        "src=" + txtphone.Text + "&" +
                        "dst=" + txtphone.Text + "&" +
                       "msg=" + System.Web.HttpUtility.UrlEncode(txt_message.Text, System.Text.Encoding.GetEncoding("ISO-8859-1")) + "&" +
                        "username=" + System.Web.HttpUtility.UrlEncode(txt_username.Text) + "&" +
                        "password=" + System.Web.HttpUtility.UrlEncode(txt_password.Text);
                    string result = client.DownloadString(url);
                    {
                        if (result.Contains("OK"))
                        {
                            MessageBox.Show("your message has been successfully sent.", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("unsuccesful to send message", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            }
        }
    }
