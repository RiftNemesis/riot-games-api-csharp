using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using RiotGamesAPI;
using RiotGamesAPI.DTO;
using RiotGamesAPIConsole.Properties;


namespace RiotGamesAPIConsole
{
    static class Program
    {
        private static string _apiKey = Settings.Default.ApiKey;
        private static string _cacheFilePath = "cache.data"; 
        
        public static ApiConnection ApiConnection { get; set; }
        public static List<SummonerDTO> SummonerDtoCacheList { get; set; }

        [STAThread]
        static void Main()
        {
            ApiConnection = new ApiConnection(_apiKey, ApiConnection.RegionCode.euw1);
            LoadCacheData();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Form_Main.Instance);
        }

        public static void LoadCacheData()
        {
            try
            {
                if (File.Exists(_cacheFilePath))
                {
                    Stream stream = File.Open("cache.data", FileMode.Open);
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    Program.SummonerDtoCacheList = (List<SummonerDTO>)binaryFormatter.Deserialize(stream);
                    stream.Close();
                }
                else
                {
                    Program.SummonerDtoCacheList = new List<SummonerDTO>();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, x.Source);
            }
        }

        public static void SaveCacheData()
        {
            try
            {
                Stream stream = File.Open("cache.data", FileMode.Create);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, Program.SummonerDtoCacheList);
                stream.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, x.Source);
            }
        }
    }
}
