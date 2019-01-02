using SodukuConfig.Config;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SodukuUserControls
{
    public partial class CtlNoticePanel : UserControl
    {
        public CtlNoticePanel()
        {
            InitializeComponent();
            this.tableLayoutPanel1.GetType()
                .GetProperty("DoubleBuffered",
                    System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                ?.SetValue(tableLayoutPanel1, true, null);
            Init();
        }

        private void Init()
        {
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

        public void SetColors(ClsAllConfig allConfig)
        {
            _allConfig = allConfig;
            foreach (var variable in controlDic)
            {
                var panel = variable.Value;
                panel.BackColor = allConfig.ColorConfig.NoticeBackColor;
                panel.label1.BackColor = allConfig.ColorConfig.NoticeBackColor;
                panel.label1.ForeColor = allConfig.ColorConfig.NoticeForeColor;
                panel.Refresh();
            }
        }

        private ClsAllConfig _allConfig;


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

        private Dictionary<string, ctlRoundPanel> controlDic = new Dictionary<string, ctlRoundPanel>();


        public void SetClues(List<int> list)
        {
            this.tableLayoutPanel1.SuspendLayout();
            foreach (var kv in controlDic)
            {
                var control = controlDic[kv.Key];
                control.label1.Text = "";
                control.Visible = false;
            }

            foreach (var notice in list)
            {
                var control = controlDic["notice" + notice];
                control.label1.Text = "" + notice;
                control.Visible = true;
            }
            this.tableLayoutPanel1.ResumeLayout();
      
        }


    }
}