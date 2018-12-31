using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SodukuConfig.Config;

namespace SodukuUserControls
{
    public partial class CtlColorConfig : UserControl
    {
        public CtlColorConfig()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeButtonBackColor(sender);
        }

        private static void ChangeButtonBackColor(object sender)
        {
            ColorDialog colorDia = new ColorDialog();

            if (colorDia.ShowDialog() == DialogResult.OK)
            {
                //获取所选择的颜色
                Color colorChoosed = colorDia.Color;
                //改变panel的背景色
                ((Button) sender).BackColor = colorChoosed;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeButtonBackColor(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangeButtonBackColor(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChangeButtonBackColor(sender);
        }

        public void SetBackColor(ClsAllConfig config)
        {
            var c = config.ColorConfig;
            questionNumberButton.BackColor = c.QuestionForeColor;
            button5.BackColor = c.NoticeBackColor;
            NoticeNumberColorButton.BackColor = c.NoticeForeColor;
            button6.BackColor = c.FrmColor;
            button8.BackColor = c.NoticeForeColor;

            button9.BackColor = c.PanelMouseMoveColor;
            config.SaveToFile();
        }


        public void UpdateConfigInfo(ClsAllConfig config)
        {
            var c = config.ColorConfig;
            c.QuestionForeColor = questionNumberButton.BackColor;
            c.NoticeBackColor = button5.BackColor;
            c.NoticeForeColor = NoticeNumberColorButton.BackColor;
            c.FrmColor = button6.BackColor;


            c.PanelMouseMoveColor = button9.BackColor;
            config.SaveToFile();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangeButtonBackColor(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ChangeButtonBackColor(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ChangeButtonBackColor(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ChangeButtonBackColor(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ChangeButtonBackColor(sender);
        }
    }
}