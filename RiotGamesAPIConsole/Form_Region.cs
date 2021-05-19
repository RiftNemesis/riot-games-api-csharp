using System;
using System.Windows.Forms;
using RiotGamesAPI;

namespace RiotGamesAPIConsole
{
    public partial class Form_Region : Form
    {
        private static Form_Region _instance;
        public static Form_Region Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new Form_Region();
                }
                return _instance;
            }
        }

        public Form_Region()
        {
            InitializeComponent();
            foreach (ApiConnection.RegionCode region in Enum.GetValues(typeof(ApiConnection.RegionCode)))
            {
                comboBox_region.Items.Add(region);
            }
            comboBox_region.SelectedItem = Program.ApiConnection.Region;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            Program.ApiConnection.Region = (ApiConnection.RegionCode)comboBox_region.SelectedItem;
            Form_Main.Instance.UpdateControlsValues();
            Form_SummonerV3.Instance.UpdateControlsValues();
            this.Close();
        }
    }
}
