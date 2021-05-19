using System;
using System.Windows.Forms;
using RiotGamesAPI.API;
using RiotGamesAPI.DTO;

namespace RiotGamesAPIConsole
{
    public partial class Form_ChampionV3 : Form
    {
        public static Form_ChampionV3 _instance;
        public static Form_ChampionV3 Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new Form_ChampionV3();
                }
                return _instance;
            }
        }

        public Form_ChampionV3()
        {
            InitializeComponent();
        }

        private void button_GET_Click(object sender, System.EventArgs e)
        {
            try
            {
                ChampionV3 championApi = new ChampionV3(Program.ApiConnection);
                ChampionInfo championData = championApi.GetChampionRotations();
                championInfoBindingSource.DataSource = championData;
                dataGridView1.Columns.Clear();
                dataGridView2.Columns.Clear();
                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();
                dataGridView1.Columns.Add("FreeChampionIds", "Free Champion Ids");
                dataGridView2.Columns.Add("FreeChampionIdsForNewPlayers", "Free Champion Ids For New Players");
                foreach (int id in championData.FreeChampionIds)
                {
                    dataGridView1.Rows.Add(id.ToString());
                }
                foreach (int id in championData.FreeChampionIdsForNewPlayers)
                {
                    dataGridView2.Rows.Add(id.ToString());
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, x.Source);
            }
        }
    }
}
