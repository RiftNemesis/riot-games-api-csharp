using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RiotGamesAPIConsole
{
    public partial class Form_LolStatusV3 : Form
    {
        public static Form_LolStatusV3 _instance;
        public static Form_LolStatusV3 Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new Form_LolStatusV3();
                }
                return _instance;
            }
        }

        public Form_LolStatusV3()
        {
            InitializeComponent();
        }
    }
}
