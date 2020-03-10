using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Retag
{
    public partial class frmMain : Form
    {
        private SortedList<string, int> _tags;
        private List<Pin> _pins;
        private bool _disbleEventOnDelete = false;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadFilters();
        }

        private void LoadData()
        {
            lstUrl.Items.Clear();
            _tags = new SortedList<string, int>();
            _pins = new List<Pin>();

            using (StreamReader fs = new StreamReader(txtFilePath.Text))
            {
                var all = fs.ReadToEnd();
                Regex rx = new Regex(@"""href"":""(?<href>.*)""," +
                                        @"""description"":""(?<description>.*)""," +
                                        @"""extended"":""(?<extended>.*)""," +
                                        @"""meta"":""(?<meta>.*)""," +
                                        @"""hash"":""(?<hash>.*)""," +
                                        @"""time"":""(?<time>.*)""," +
                                        @"""shared"":""(?<shared>.*)""," +
                                        @"""toread"":""(?<toread>.*)""," +
                                        @"""tags"":""(?<tags>.*)"""
                                    );

                MatchCollection matches = rx.Matches(all);

                foreach (Match match in matches)
                {
                    GroupCollection groups = match.Groups;
                    if (optEverything.Checked)
                    { 
                        ProcessTag(groups["tags"].ToString());
                        AddPin(groups);
                    } else if (optNonTweets.Checked)
                    {
                        if (groups["description"].ToString() != "Twitter")
                        {
                            ProcessTag(groups["tags"].ToString());
                            AddPin(groups);
                        }
                    } else if (optTweets.Checked)
                    {
                        if (groups["description"].ToString() == "Twitter")
                        {
                            ProcessTag(groups["tags"].ToString());
                            AddPin(groups);
                        }
                    }
                }
                cboTagFilter.SelectedIndex = 4; // All
            }

            lstTags.BeginUpdate();
            lstTags.Items.Clear();
            foreach (var tag in _tags)
            {
                lstTags.Items.Add(tag.Key + "[" + tag.Value.ToString() + "]");
            }
            lstTags.EndUpdate();
        }

        private void ProcessTag(string tag)
        {
            if (tag.Length == 0)
            {
                tag = "NoTag";
            }

            var ts = tag.Split(' ');
            foreach (var t in ts)
            {
                if (_tags.ContainsKey(t))
                {
                    _tags[t]++;
                }
                else
                {
                    _tags.Add(t, 1);
                }
            }
        }

        private void AddPin(GroupCollection groups)
        {
            Pin p = new Pin();
            p.Description = groups["description"].ToString();
            p.Extended = groups["extended"].ToString();
            p.Href = groups["href"].ToString().Replace("\\", "");
            p.TagsText = groups["tags"].ToString();
            p.Tags = p.TagsText.Split(' ');
            _pins.Add(p);
        }

        private void LoadFilters()
        {
            cboTagFilter.Items.Add("Untagged");
            cboTagFilter.Items.Add("Once");
            cboTagFilter.Items.Add("Few");
            cboTagFilter.Items.Add("Popular");
            cboTagFilter.Items.Add("All");
        }

        private void CboTagFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstTags.BeginUpdate();
            lstTags.Items.Clear();
            switch (cboTagFilter.Text)
            {
                case "Untagged":
                    foreach (var tag in _tags)
                    {
                        if (tag.Key == "NoTag")
                        {
                            lstTags.Items.Add(tag.Key + "[" + tag.Value.ToString() + "]");
                        }
                    }
                    break;
                case "Once":
                    foreach (var tag in _tags)
                    {
                        if (tag.Value == 1)
                        {
                            lstTags.Items.Add(tag.Key + "[" + tag.Value.ToString() + "]");
                        }
                    }
                    break;
                case "Few":
                    foreach (var tag in _tags)
                    {
                        if (tag.Value > 1 && tag.Value < 5)
                        {
                            lstTags.Items.Add(tag.Key + "[" + tag.Value.ToString() + "]");
                        }
                    }
                    break;
                case "Popular":
                    foreach (var tag in _tags)
                    {
                        if (tag.Value >= 5)
                        {
                            lstTags.Items.Add(tag.Key + "[" + tag.Value.ToString() + "]");
                        }
                    }
                    break;
                default:
                    // load all
                    foreach (var tag in _tags)
                    {
                        lstTags.Items.Add(tag.Key + "[" + tag.Value.ToString() + "]");
                    }
                    break;
            }
            lstTags.EndUpdate();
        }

        private void LstTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            // see LstTags_KeyUp for why we need this
            if (_disbleEventOnDelete)
            {
                _disbleEventOnDelete = false;
                return;
            }

            lstUrl.Items.Clear();
            string tag = lstTags.Text.Split('[')[0];

            if (tag == "NoTag")
            {
                foreach (var p in _pins)
                {
                    if (p.TagsText == "")
                    {
                        lstUrl.Items.Add(p);
                    }
                }
            }
            else
            {
                foreach (var p in _pins)
                {
                    if (p.Tags.Contains(tag))
                    {
                        lstUrl.Items.Add(p);
                    }
                }
            }
        }

        private void OptTweets_CheckedChanged(object sender, EventArgs e)
        {
            if (txtFilePath.TextLength > 0)
            {
                LoadData();
            }

        }

        private void LstUrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pin p = (Pin) lstUrl.SelectedItem;
            ie.Navigate(p.Href);
        }

        private void OptEverything_CheckedChanged(object sender, EventArgs e)
        {
            if (txtFilePath.TextLength > 0)
            {
                LoadData();
            }
        }

        private void CmdBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result= dlgFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void DlgFile_FileOk(object sender, CancelEventArgs e)
        {
            txtFilePath.Text = dlgFile.FileName;
        }

        private void CmdLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void TxtFilePath_TextChanged(object sender, EventArgs e)
        {
        }

        private void OptNonTweets_CheckedChanged(object sender, EventArgs e)
        {
            if (txtFilePath.TextLength > 0)
            {
                LoadData();
            }
        }

        private void LstTags_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                // for some reason, changing the text of Items causes 
                // LstTags_SelectedIndexChanged event
                // using the flag to skip event processing
                _disbleEventOnDelete = true;
                
                if (lstTags.Text.EndsWith("[X]"))
                {
                    lstTags.Items[lstTags.SelectedIndex] = lstTags.Text.Substring(0, lstTags.Text.Length - 4);
                }
                else
                {
                    lstTags.Items[lstTags.SelectedIndex] += " [X]";
                }
            }
        }

        private void CmdShowChangeQueue_Click(object sender, EventArgs e)
        {
            var f = new frmChangeQueue
            {
                TagsToDelete = new List<string>()
            };

            foreach (var l in lstTags.Items)
            {
                if (l.ToString().EndsWith("[X]"))
                {
                    f.TagsToDelete.Add(l.ToString());
                }
            }
            f.ShowDialog(this);
            f.Dispose();
        }

        private void CmdHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click on Open to load the JSON file exported from https://pinboard.in/settings/backup\r\n" +
                "\r\n" +
                "Use the filters to make things manageable\r\n" +
                "\r\n" +
                "Press Delete to mark selected Tag for Deletion\r\n"  +
                "\r\n" +
                "When you are ready, click on Change Queue\r\n" +
                "\r\n" +
                "Review changes, then Click Apply to Pinboard to apply changes to Pinboard", 
                "How To", MessageBoxButtons.OK,  MessageBoxIcon.Information
                );
        }
    }
}
