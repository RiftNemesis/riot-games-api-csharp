using System;
using System.Windows.Forms;
using RiotGamesAPI.API;
using RiotGamesAPI.DTO;
using System.Collections.Generic;

namespace RiotGamesAPIConsole
{
    public partial class Form_SpectatorV3 : Form
    {
        public static Form_SpectatorV3 _instance;
        public static Form_SpectatorV3 Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new Form_SpectatorV3();
                }
                return _instance;
            }
        }

        public Form_SpectatorV3()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            try
            {
                string summonerName = textBox_summonerName.Text.Trim();
                if (!SummonerV3.IsSummonerNameValid(summonerName))
                {
                    MessageBox.Show("Empty or Invalid Summoner Name.", this.Text);
                }
                else
                {
                    SummonerDTO summonerData = Program.SummonerDtoCacheList.Find(s => s.Name == summonerName);
                    if (summonerData == null)
                    {
                        SummonerV3 summonerApi = new SummonerV3(Program.ApiConnection);
                        summonerData = summonerApi.GetSummonerBySummonerName(summonerName);
                    }
                    SpectatorV3 spectatorApi = new SpectatorV3(Program.ApiConnection);
                    CurrentGameInfo currentGameData = spectatorApi.GetCurrentGameInfo(summonerData.Id);
                    currentGameInfoBindingSource.DataSource = currentGameData;
                    participantsBindingSource.DataSource = currentGameData.Participants;
                    bannedChampionsBindingSource.DataSource = currentGameData.BannedChampions;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, x.Source);
            }
        }

        private void button_GET_Click(object sender, EventArgs e)
        {
            try
            {
                SpectatorV3 spectatorApi = new SpectatorV3(Program.ApiConnection);
                FeaturedGames featuredGames = spectatorApi.GetFeaturedGame();
                featuredGamesBindingSource.DataSource = featuredGames;
                gameListBindingSource.DataSource = featuredGames.GameList;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, x.Source);
            }
        }

        private void gameListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FeaturedGames featuredGames = (FeaturedGames)featuredGamesBindingSource.DataSource;
            int currentFeaturedGameIndex = featuredGames.GameList.IndexOf((FeaturedGameInfo)gameListBindingSource.Current);
            participantsBindingSource1.DataSource = featuredGames.GameList[currentFeaturedGameIndex].Participants;
            bannedChampionsDataGridView1.DataSource = featuredGames.GameList[currentFeaturedGameIndex].BannedChampions;
        }
    }
}
