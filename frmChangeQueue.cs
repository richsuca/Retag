using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace Retag
{
    public partial class frmChangeQueue : Form
    {
        public List<string> TagsToDelete;

        public frmChangeQueue()
        {
            InitializeComponent();
        }

        private void FrmChangeQueue_Load(object sender, EventArgs e)
        {
            lvChanges.Columns.Add("Tag", 600);
            lvChanges.Columns.Add("Result", 1200);

            foreach (string t in TagsToDelete)
            {
                ListViewItem l = lvChanges.Items.Add(t);
                l.SubItems.Add("");
            }
            ttApiToken.SetToolTip(txtAPIToken, "API Token from https://pinboard.in/settings/password");
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void CmdProcess_Click(object sender, EventArgs e)
        {
            if (txtAPIToken.Text.Length == 0)
            {
                MessageBox.Show("API Token is Empty. Please enter API Token from https://pinboard.in/settings/password", 
                                "API Token Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string apiToken = txtAPIToken.Text;

            string url = "https://api.pinboard.in/v1/tags/delete?auth_token=" + apiToken + "&tag=";

            foreach (ListViewItem l in lvChanges.Items)
            {
                string lItemText = l.SubItems[0].Text;
                string tagToDelete = lItemText.Substring(0, lItemText.IndexOf('['));

                l.SubItems[1].Text = "Deleting " + tagToDelete;

                // Call asynchronous network methods in a try/catch block to handle exceptions.
                try
                {
                    HttpResponseMessage response = await Program.webClient.GetAsync(url + tagToDelete);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    // Above three lines can be replaced with new helper method below
                    // string responseBody = await client.GetStringAsync(uri);

                    l.SubItems[1].Text = responseBody;
                }
                catch (HttpRequestException httpErr)
                {
                    l.SubItems[1].Text = httpErr.Message;
                }
            }
        }
    }
}
