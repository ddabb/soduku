using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SodukuUserControls;

namespace SodukuUI
{
    public partial class CtlNoticePanel : UserControl
    {
        public CtlNoticePanel()
        {
            InitializeComponent();
            controlDic.Add("notice1", notice1);
            controlDic.Add("notice2", notice2);
            controlDic.Add("notice3", notice3);
            controlDic.Add("notice4", notice4);
            controlDic.Add("notice5", notice5);
            controlDic.Add("notice6", notice6);
            controlDic.Add("notice7", notice7);
            controlDic.Add("notice8", notice8);
            controlDic.Add("notice9", notice9);


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

        private Dictionary<string, EllipseButton> controlDic = new Dictionary<string, EllipseButton>();

        public void SetClues(List<int> list)
        {

    
            foreach (var kv in controlDic)
            {
                kv.Value.Text = "";
                kv.Value.Visible = false;
            }

            foreach (var notice in list)
            {
              var control=  controlDic["notice" + notice];
                control.Text = "" + notice;
                control.Visible = true;
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
