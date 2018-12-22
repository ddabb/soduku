using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SodukuUI
{
    public partial class CtlNoticePanel : UserControl
    {
        public CtlNoticePanel(List<int> list)
        {
            InitializeComponent();
            foreach (var notice in list)
            {
                object obj = GetType().GetField("notice"+ notice,
                        System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance
                                                                 | System.Reflection.BindingFlags.IgnoreCase)
                    ?.GetValue(this);
                TextBox testBox = (TextBox)obj;
                if (testBox == null) continue;
                testBox.Text = "" + notice;
            }
        }

        private void CtlNoticePanel_Load(object sender, EventArgs e)
        {

        }
    }
}
