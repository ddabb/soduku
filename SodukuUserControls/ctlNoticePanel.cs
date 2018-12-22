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
        public CtlNoticePanel()
        {
            InitializeComponent();
  
        }

        private static readonly List<string> clueList = new List<string>
        {

            "notice1",
            "notice2",
            "notice3",
            "notice4",
            "notice5",
            "notice6",
            "notice7",
            "notice8",
            "notice9",
        };
        public void SetClues(List<int> list)
        {
      
            //先全部清空
            foreach (var filedname in clueList)
            {
                object obj = GetType().GetField(filedname,
                        System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance
                                                                 | System.Reflection.BindingFlags.IgnoreCase)
                    ?.GetValue(this);
                TextBox testBox = (TextBox)obj;
                if (testBox == null) continue;
                testBox.Text = "" ;
            }

            foreach (var notice in list)
            {
                object obj = GetType().GetField("notice" + notice,
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
            this.tableLayoutPanel1.GetType()
                .GetProperty("DoubleBuffered",
                    System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                ?.SetValue(tableLayoutPanel1, true, null);

        }

  
    }
}
