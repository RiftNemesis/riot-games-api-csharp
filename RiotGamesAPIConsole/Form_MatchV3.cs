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
    public partial class Form_MatchV3 : Form
    {
        public static Form_MatchV3 _instance;
        public static Form_MatchV3 Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new Form_MatchV3();
                }
                return _instance;
            }
        }

        public Form_MatchV3()
        {
            InitializeComponent();
        }
    }
}
