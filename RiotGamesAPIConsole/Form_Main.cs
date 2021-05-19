using System;
using System.Windows.Forms;
using RiotGamesAPIConsole.Properties;
using System.Text.RegularExpressions;

namespace RiotGamesAPIConsole
{
    public partial class Form_Main : Form
    {
        private static Form_Main _instance;
        public static Form_Main Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new Form_Main();
                }
                return _instance;
            }
        }

        public Form_Main()
        {
            InitializeComponent();
            Program.LoadCacheData();
            UpdateControlsValues();
        }

        public void UpdateControlsValues()
        {
            button_Region.Text = string.Format("REGION : {0}", Program.ApiConnection.Region.ToString());
            textBox_apiKey.Text = Settings.Default.ApiKey;
        }

        private void FormOpen(Form form)
        {
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Text = this.Text;
            form.Show();
        }

        private void button_championMasteryV3_Click(object sender, EventArgs e)
        {
            FormOpen(Form_ChampionMasteryV3.Instance);
        }

        private void button_championV3_Click(object sender, EventArgs e)
        {
            FormOpen(Form_ChampionV3.Instance);
        }

        private void button_leagueV3_Click(object sender, EventArgs e)
        {
            FormOpen(Form_LeagueV3.Instance);
        }

        private void button_lolStatusV3_Click(object sender, EventArgs e)
        {
            FormOpen(Form_LolStatusV3.Instance);
        }

        private void button_matchV3_Click(object sender, EventArgs e)
        {
            FormOpen(Form_MatchV3.Instance);
        }

        private void button_spectatorV3_Click(object sender, EventArgs e)
        {
            FormOpen(Form_SpectatorV3.Instance);
        }

        private void button_summonerV3_Click(object sender, EventArgs e)
        {
            FormOpen(Form_SummonerV3.Instance);
        }

        private void button_thirdPartyCodeV3_Click(object sender, EventArgs e)
        {
            FormOpen(Form_ThirdPartyCodeV3.Instance);
        }

        private void button_tournamentStubV3_Click(object sender, EventArgs e)
        {
            FormOpen(Form_TournamentStubV3.Instance);
        }

        private void button_tournamentV3_Click(object sender, EventArgs e)
        {
            FormOpen(Form_TournamentV3.Instance);
        }

        private void button_Region_Click(object sender, EventArgs e)
        {
            Form_Region.Instance.ShowDialog();
        }

        private void Form_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.SaveCacheData();
        }

        private void textBox_apiKey_Click(object sender, EventArgs e)
        {
            textBox_apiKey.SelectAll();
        }

        private void textBox_apiKey_TextChanged(object sender, EventArgs e)
        {
            string apiKey = textBox_apiKey.Text.Trim();
            if (!Regex.IsMatch(apiKey, @"^RGAPI-\w{8}-\w{4}-\w{4}-\w{4}-\w{12}$"))
            {
                textBox_apiKey.ForeColor = System.Drawing.Color.Red;
            } 
            else
	        {
                textBox_apiKey.ForeColor = System.Drawing.Color.Green;
                Settings.Default.ApiKey = Program.ApiConnection.ApiKey = apiKey;
                Settings.Default.Save();
	        }
        }

        private void textBox_apiKey_Leave(object sender, EventArgs e)
        {
            textBox_apiKey.Text = Settings.Default.ApiKey;
        }
    }
}
