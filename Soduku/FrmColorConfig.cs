using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SodukuConfig.Config;

namespace SodukuUI
{
    public partial class FrmColorConfig : Form
    {
        private ClsAllConfig Config;
        public FrmColorConfig(ClsAllConfig Config)
        {
            InitializeComponent();
            this.Config = Config;
            this.ctlColorConfig1.SetBackColor(Config);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ctlColorConfig1.UpdateConfigInfo(Config);

            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ctlColorConfig1_Load(object sender, EventArgs e)
        {

        }


    }
}
