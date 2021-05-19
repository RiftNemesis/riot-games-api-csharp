using System;
using System.Windows.Forms;
using RiotGamesAPI.API;
using RiotGamesAPI.DTO;

namespace RiotGamesAPIConsole
{
    public partial class Form_SummonerV3 : Form
    {
        public static Form_SummonerV3 _instance;
        public static Form_SummonerV3 Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new Form_SummonerV3();
                }
                return _instance;
            }
        }

        public Form_SummonerV3()
        {
            InitializeComponent();
            UpdateControlsValues();
            textBox_summonerName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox_summonerName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            foreach (SummonerDTO summonerDto in Program.SummonerDtoCacheList)
            {
                textBox_summonerName.AutoCompleteCustomSource.Add(summonerDto.Name);
            }
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            try
            {
                
                string summonerName = textBox_summonerName.Text.Trim();
                if (!SummonerV3.IsSummonerNameValid(summonerName))
                {
                    MessageBox.Show("Empty or Invalid Entry.", "Summoner Name");
                }
                else 
                {
                    int summonerIndex = Program.SummonerDtoCacheList.FindIndex(s => s.Name == summonerName);
                    if (summonerIndex >= 0)
                    {
                        summonerDTOBindingSource.DataSource = Program.SummonerDtoCacheList[summonerIndex];
                        linkLabel_refresh.Visible = true;
                    }
                    else
                    {
                        SummonerV3 summonerApi = new SummonerV3(Program.ApiConnection);
                        SummonerDTO summonerData = summonerApi.GetSummonerBySummonerName(summonerName);
                        summonerDTOBindingSource.DataSource = summonerData;
                        Program.SummonerDtoCacheList.Add(summonerData);
                        linkLabel_refresh.Visible = false;

                        string message = "The level of this summoner is " + summonerData.SummonerLevel;
                    }
                }
                
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, x.Source);
                summonerDTOBindingSource.DataSource = new SummonerDTO();
                textBox_summonerName.Select();
            }
        }

        private void linkLabel_refresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int summonerIndex = Program.SummonerDtoCacheList.FindIndex(s => s.Name == nameTextBox.Text.Trim());
            if (summonerIndex >= 0)
            {
                Program.SummonerDtoCacheList.RemoveAt(summonerIndex);
                linkLabel_refresh.Visible = true;
                button_OK.PerformClick();
            }
        }

        public void UpdateControlsValues()
        {
            textBox_region.Text = Program.ApiConnection.Region.ToString();
        }
    }
}
