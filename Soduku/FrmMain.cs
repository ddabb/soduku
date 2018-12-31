using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using SodukuBase;
using SodukuFactory;
using SodukuGenerator;
using System.Runtime.InteropServices;
using System.Text;
using SodukuUserControls;


using System.Xml.Serialization;
using SodukuConfig.Config;

namespace SodukuUI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
        
            InitializeComponent();
        }

        private static readonly int numbers = 9;

        private static Soduku sdk = new Soduku();

        private static SodukuBuilder sdkBuilder = new SodukuBuilder();

        private static SodukuQuestion sdkGenerator = new SodukuQuestion();

        private static SodukuMarket currentMarket;

        private static List<List<int>> questions;

        private static readonly List<string> vaildValues =
            new List<string> {"1", "2", "3", "4", "5", "6", "7", "8", "9"};


        private void noticeNumberChanged(object sender, EventArgs e)
        {
            //if (String.IsNullOrEmpty(noticeNumber.Text))
            //{
            //    noticeNumber.Text = "30";
            //}

            //int value = 0;
            //if (int.TryParse(noticeNumber.Text,out value))
            //{
            //    if (value<17)
            //    {
            //        noticeNumber.Text += "17";
            //    }

            //    if (value > 81)
            //    {
            //        noticeNumber.Text += "80";
            //    }
            //}
            //else
            //{
            //    noticeNumber.Text = "30";
            //}
        }

        private ClsAllConfig _config;

        private void Form1_Load(object sender, EventArgs e)
        {
         

            GetType()
                .GetProperty("DoubleBuffered",
                    System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                ?.SetValue(this, true, null);
            locationClues = new Dictionary<string, CtlNoticePanel>();
            this.tableLayoutPanel1.GetType()
                .GetProperty("DoubleBuffered",
                    System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                ?.SetValue(tableLayoutPanel1, true, null);
            helpMessage.Text = null;
            resultMessage.Text = null;
            TextBoxdic.Add("postion_0_0", postion_0_0);
            TextBoxdic.Add("postion_0_1", postion_0_1);
            TextBoxdic.Add("postion_0_2", postion_0_2);
            TextBoxdic.Add("postion_0_3", postion_0_3);
            TextBoxdic.Add("postion_0_4", postion_0_4);
            TextBoxdic.Add("postion_0_5", postion_0_5);
            TextBoxdic.Add("postion_0_6", postion_0_6);
            TextBoxdic.Add("postion_0_7", postion_0_7);
            TextBoxdic.Add("postion_0_8", postion_0_8);
            TextBoxdic.Add("postion_1_0", postion_1_0);
            TextBoxdic.Add("postion_1_1", postion_1_1);
            TextBoxdic.Add("postion_1_2", postion_1_2);
            TextBoxdic.Add("postion_1_3", postion_1_3);
            TextBoxdic.Add("postion_1_4", postion_1_4);
            TextBoxdic.Add("postion_1_5", postion_1_5);
            TextBoxdic.Add("postion_1_6", postion_1_6);
            TextBoxdic.Add("postion_1_7", postion_1_7);
            TextBoxdic.Add("postion_1_8", postion_1_8);
            TextBoxdic.Add("postion_2_0", postion_2_0);
            TextBoxdic.Add("postion_2_1", postion_2_1);
            TextBoxdic.Add("postion_2_2", postion_2_2);
            TextBoxdic.Add("postion_2_3", postion_2_3);
            TextBoxdic.Add("postion_2_4", postion_2_4);
            TextBoxdic.Add("postion_2_5", postion_2_5);
            TextBoxdic.Add("postion_2_6", postion_2_6);
            TextBoxdic.Add("postion_2_7", postion_2_7);
            TextBoxdic.Add("postion_2_8", postion_2_8);
            TextBoxdic.Add("postion_3_0", postion_3_0);
            TextBoxdic.Add("postion_3_1", postion_3_1);
            TextBoxdic.Add("postion_3_2", postion_3_2);
            TextBoxdic.Add("postion_3_3", postion_3_3);
            TextBoxdic.Add("postion_3_4", postion_3_4);
            TextBoxdic.Add("postion_3_5", postion_3_5);
            TextBoxdic.Add("postion_3_6", postion_3_6);
            TextBoxdic.Add("postion_3_7", postion_3_7);
            TextBoxdic.Add("postion_3_8", postion_3_8);
            TextBoxdic.Add("postion_4_0", postion_4_0);
            TextBoxdic.Add("postion_4_1", postion_4_1);
            TextBoxdic.Add("postion_4_2", postion_4_2);
            TextBoxdic.Add("postion_4_3", postion_4_3);
            TextBoxdic.Add("postion_4_4", postion_4_4);
            TextBoxdic.Add("postion_4_5", postion_4_5);
            TextBoxdic.Add("postion_4_6", postion_4_6);
            TextBoxdic.Add("postion_4_7", postion_4_7);
            TextBoxdic.Add("postion_4_8", postion_4_8);
            TextBoxdic.Add("postion_5_0", postion_5_0);
            TextBoxdic.Add("postion_5_1", postion_5_1);
            TextBoxdic.Add("postion_5_2", postion_5_2);
            TextBoxdic.Add("postion_5_3", postion_5_3);
            TextBoxdic.Add("postion_5_4", postion_5_4);
            TextBoxdic.Add("postion_5_5", postion_5_5);
            TextBoxdic.Add("postion_5_6", postion_5_6);
            TextBoxdic.Add("postion_5_7", postion_5_7);
            TextBoxdic.Add("postion_5_8", postion_5_8);
            TextBoxdic.Add("postion_6_0", postion_6_0);
            TextBoxdic.Add("postion_6_1", postion_6_1);
            TextBoxdic.Add("postion_6_2", postion_6_2);
            TextBoxdic.Add("postion_6_3", postion_6_3);
            TextBoxdic.Add("postion_6_4", postion_6_4);
            TextBoxdic.Add("postion_6_5", postion_6_5);
            TextBoxdic.Add("postion_6_6", postion_6_6);
            TextBoxdic.Add("postion_6_7", postion_6_7);
            TextBoxdic.Add("postion_6_8", postion_6_8);
            TextBoxdic.Add("postion_7_0", postion_7_0);
            TextBoxdic.Add("postion_7_1", postion_7_1);
            TextBoxdic.Add("postion_7_2", postion_7_2);
            TextBoxdic.Add("postion_7_3", postion_7_3);
            TextBoxdic.Add("postion_7_4", postion_7_4);
            TextBoxdic.Add("postion_7_5", postion_7_5);
            TextBoxdic.Add("postion_7_6", postion_7_6);
            TextBoxdic.Add("postion_7_7", postion_7_7);
            TextBoxdic.Add("postion_7_8", postion_7_8);
            TextBoxdic.Add("postion_8_0", postion_8_0);
            TextBoxdic.Add("postion_8_1", postion_8_1);
            TextBoxdic.Add("postion_8_2", postion_8_2);
            TextBoxdic.Add("postion_8_3", postion_8_3);
            TextBoxdic.Add("postion_8_4", postion_8_4);
            TextBoxdic.Add("postion_8_5", postion_8_5);
            TextBoxdic.Add("postion_8_6", postion_8_6);
            TextBoxdic.Add("postion_8_7", postion_8_7);
            TextBoxdic.Add("postion_8_8", postion_8_8);
            locationClues.Add("postion_0_0", clue_0_0);
            locationClues.Add("postion_0_1", clue_0_1);
            locationClues.Add("postion_0_2", clue_0_2);
            locationClues.Add("postion_0_3", clue_0_3);
            locationClues.Add("postion_0_4", clue_0_4);
            locationClues.Add("postion_0_5", clue_0_5);
            locationClues.Add("postion_0_6", clue_0_6);
            locationClues.Add("postion_0_7", clue_0_7);
            locationClues.Add("postion_0_8", clue_0_8);
            locationClues.Add("postion_1_0", clue_1_0);
            locationClues.Add("postion_1_1", clue_1_1);
            locationClues.Add("postion_1_2", clue_1_2);
            locationClues.Add("postion_1_3", clue_1_3);
            locationClues.Add("postion_1_4", clue_1_4);
            locationClues.Add("postion_1_5", clue_1_5);
            locationClues.Add("postion_1_6", clue_1_6);
            locationClues.Add("postion_1_7", clue_1_7);
            locationClues.Add("postion_1_8", clue_1_8);
            locationClues.Add("postion_2_0", clue_2_0);
            locationClues.Add("postion_2_1", clue_2_1);
            locationClues.Add("postion_2_2", clue_2_2);
            locationClues.Add("postion_2_3", clue_2_3);
            locationClues.Add("postion_2_4", clue_2_4);
            locationClues.Add("postion_2_5", clue_2_5);
            locationClues.Add("postion_2_6", clue_2_6);
            locationClues.Add("postion_2_7", clue_2_7);
            locationClues.Add("postion_2_8", clue_2_8);
            locationClues.Add("postion_3_0", clue_3_0);
            locationClues.Add("postion_3_1", clue_3_1);
            locationClues.Add("postion_3_2", clue_3_2);
            locationClues.Add("postion_3_3", clue_3_3);
            locationClues.Add("postion_3_4", clue_3_4);
            locationClues.Add("postion_3_5", clue_3_5);
            locationClues.Add("postion_3_6", clue_3_6);
            locationClues.Add("postion_3_7", clue_3_7);
            locationClues.Add("postion_3_8", clue_3_8);
            locationClues.Add("postion_4_0", clue_4_0);
            locationClues.Add("postion_4_1", clue_4_1);
            locationClues.Add("postion_4_2", clue_4_2);
            locationClues.Add("postion_4_3", clue_4_3);
            locationClues.Add("postion_4_4", clue_4_4);
            locationClues.Add("postion_4_5", clue_4_5);
            locationClues.Add("postion_4_6", clue_4_6);
            locationClues.Add("postion_4_7", clue_4_7);
            locationClues.Add("postion_4_8", clue_4_8);
            locationClues.Add("postion_5_0", clue_5_0);
            locationClues.Add("postion_5_1", clue_5_1);
            locationClues.Add("postion_5_2", clue_5_2);
            locationClues.Add("postion_5_3", clue_5_3);
            locationClues.Add("postion_5_4", clue_5_4);
            locationClues.Add("postion_5_5", clue_5_5);
            locationClues.Add("postion_5_6", clue_5_6);
            locationClues.Add("postion_5_7", clue_5_7);
            locationClues.Add("postion_5_8", clue_5_8);
            locationClues.Add("postion_6_0", clue_6_0);
            locationClues.Add("postion_6_1", clue_6_1);
            locationClues.Add("postion_6_2", clue_6_2);
            locationClues.Add("postion_6_3", clue_6_3);
            locationClues.Add("postion_6_4", clue_6_4);
            locationClues.Add("postion_6_5", clue_6_5);
            locationClues.Add("postion_6_6", clue_6_6);
            locationClues.Add("postion_6_7", clue_6_7);
            locationClues.Add("postion_6_8", clue_6_8);
            locationClues.Add("postion_7_0", clue_7_0);
            locationClues.Add("postion_7_1", clue_7_1);
            locationClues.Add("postion_7_2", clue_7_2);
            locationClues.Add("postion_7_3", clue_7_3);
            locationClues.Add("postion_7_4", clue_7_4);
            locationClues.Add("postion_7_5", clue_7_5);
            locationClues.Add("postion_7_6", clue_7_6);
            locationClues.Add("postion_7_7", clue_7_7);
            locationClues.Add("postion_7_8", clue_7_8);
            locationClues.Add("postion_8_0", clue_8_0);
            locationClues.Add("postion_8_1", clue_8_1);
            locationClues.Add("postion_8_2", clue_8_2);
            locationClues.Add("postion_8_3", clue_8_3);
            locationClues.Add("postion_8_4", clue_8_4);
            locationClues.Add("postion_8_5", clue_8_5);
            locationClues.Add("postion_8_6", clue_8_6);
            locationClues.Add("postion_8_7", clue_8_7);
            locationClues.Add("postion_8_8", clue_8_8);

            InitConfig();
            for (int i = 0; i < numbers; i++)
            {
                for (int j = 0; j < numbers; j++)
                {
                    var location = "postion_" + i + "_" + j;
                    TextBox testBox = TextBoxdic[location];
                    testBox.Dock = DockStyle.Fill;
                    testBox.Margin = new Padding(2);
                    testBox.BorderStyle = BorderStyle.None;
                    testBox.Multiline = true;
                    testBox.Size = new Size(75, 75);
                    testBox.TabIndex = 0;
                    testBox.TextAlign = HorizontalAlignment.Center;
                    testBox.Font = new Font("Dotum", 30f, FontStyle.Regular, GraphicsUnit.Point, ((byte) (134)));
                    testBox.TextChanged += new EventHandler(textChanged);
                    
                    testBox.MouseEnter += new EventHandler(MouseEntere);
                    CtlNoticePanel cluePanel = locationClues[location];
                    cluePanel.Dock = DockStyle.Fill;
                    cluePanel.Margin = new Padding(2);
                    cluePanel.BorderStyle = BorderStyle.None;
                    cluePanel.SetColors(_config);
                    cluePanel.Size = new Size(75, 75);
                    cluePanel.TabIndex = 0;
                    cluePanel.Visible = false;
                }
            }

            //this.tableLayoutPanel1.Controls.Find("postion_8_8", true).First().Visible = false;
        }

        private void InitConfig()
        {
            string dir = AppDomain.CurrentDomain.BaseDirectory;
            string configName = Path.Combine(dir, "config.json");

            if (File.Exists(configName))
            {
                string json = File.ReadAllText(configName);
      
                 _config = JsonConvert.DeserializeObject<ClsAllConfig>(json);
            }
            else
            {
                var colorConfig = new ClsColorConfig
                {
                    AnswerForeColor = Color.Blue,
                    FrmColor = Color.Gainsboro,
                    PanelMouseMoveColor = Color.Orange,
                    NoticeBackColor = Color.Gold,
                    QuestionForeColor = Color.Black,
                    NoticeForeColor = Color.BurlyWood
                };
                var genConfig = new ClsGenConfig
                {
                    ShowHelp = true,
                    NoticesCount = 25
                };

                _config = new ClsAllConfig
                {
                    ColorConfig = colorConfig,
                    GenConfig = genConfig
                };
                _config.SaveToFile();

            }
        }

        /// <summary>
        /// 提示面板的缓存
        /// </summary>
        public Dictionary<string, CtlNoticePanel> locationClues = new Dictionary<string, CtlNoticePanel>();

        private Dictionary<string, TextBox> TextBoxdic = new Dictionary<string, TextBox>();


        /// <summary>
        /// 刷新面板
        /// </summary>
        private void RefreshPanel()
        {
            var config = _config.ColorConfig;
            this.BackColor = config.FrmColor;
            if (currentMarket==null)
            {
                return;
            }

            UpdateCurrentSodukuInfo();
            Dictionary<string, CellInfo> cells = currentMarket.GetCellInfos();
            this.BackColor = _config.ColorConfig.FrmColor;
            foreach (KeyValuePair<string, CellInfo> kv in cells)
            {
                var location = kv.Key;
                CellInfo cell = kv.Value;
                var clue = locationClues[location];
                var text = TextBoxdic[location];
                clue.SetColors(_config);
                if (cell.Value!=0)
                {
                    text.Visible = true;
                    clue.Visible = false;
                    text.Text = "" + cell.Value;
                    text.ForeColor = cell.isInit ? config.QuestionForeColor : config.AnswerForeColor;
                }
                else
                {
                    clue.SetClues(cell.initrest);
                    clue.Visible = showhelp;
                    text.Visible =  !showhelp;
                }

                //if (!cell.isInit)
                //{
             
                //    clue.SetClues(cell.initrest);
                //    clue.Visible = showhelp;
                //    text.Visible = cell.Value!=0|| !showhelp;
                //    text.Text = "" + cell.Value;
                //}
                //else
                //{
                //    clue.Visible = false;
                //    text.Visible = true;
                //    text.Text = "" + cell.Value;
                //    text.Enabled = true;
                //}
            }
            this.tableLayoutPanel1.Refresh();
          
        }



        private Color borderColor = Color.Black;


        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; }
        }

        private void MouseEntere(object sender, EventArgs e)
        {
            var ctx = (TextBox) sender;
            var keyword = ctx.Name;
            var thisValue = ctx.Text;

            if (sdk != null && string.IsNullOrEmpty(thisValue) && sdk.IsQuestion)
            {
                var cell = sdk.GetCellInfo(keyword);
                var rests = cell.GetRest();
                var message = "";
                foreach (var variable in rests)
                {
                    message += variable + ",";
                }

                if (message.Contains(","))
                {
                    message = message.Remove(message.LastIndexOf(","));
                }

            }
            else
            {
                helpMessage.Text = null;
            }

            //if (string.IsNullOrEmpty(thisValue)) return;

            //var postion=    this.tableLayoutPanel1.GetCellPosition(ctx);


            for (int i = 0; i < numbers; i++)
            {
                for (int j = 0; j < numbers; j++)
                {

                    TextBox testBox = TextBoxdic["postion_" + i + "_" + j];
                    if (testBox == null) continue;


                    testBox.BackColor = !string.IsNullOrEmpty(thisValue) && thisValue == testBox.Text.Trim()
                        ? _config.ColorConfig.PanelMouseMoveColor
                        : Color.White;
                }
            }
        }

        private void textChanged(object sender, EventArgs e)
        {
            var ctx = (TextBox) sender;
            if (!vaildValues.Contains(ctx.Text.Trim()))
            {
                ctx.Text = null;
            }
        }
       
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //常量
            int WM_SYSCOMMAND = 0x0112;

            //窗体移动
            int SC_MOVE = 0xF010;
            int HTCAPTION = 0x0002;

            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Row == 2 || e.Row == 5)
            {
                ControlPaint.DrawBorder(e.Graphics,
                    e.CellBounds,
                    Color.Black,
                    0,
                    ButtonBorderStyle.Solid,
                    Color.Black,
                    0,
                    ButtonBorderStyle.Solid,
                    Color.Black,
                    0,
                    ButtonBorderStyle.Solid,
                    Color.Black,
                    2,
                    ButtonBorderStyle.Solid);
            }

            if (e.Column == 2 || e.Column == 5)
            {
                ControlPaint.DrawBorder(e.Graphics,
                    e.CellBounds,
                    Color.Black,
                    0,
                    ButtonBorderStyle.Solid,
                    Color.Black,
                    0,
                    ButtonBorderStyle.Solid,
                    Color.Black,
                    2,
                    ButtonBorderStyle.Solid,
                    Color.Black,
                    0,
                    ButtonBorderStyle.Solid);
            }
        }

        private void DrawBorder(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics,
                tableLayoutPanel1.ClientRectangle,
                Color.Black,
                2,
                ButtonBorderStyle.Solid,
                Color.Black,
                2,
                ButtonBorderStyle.Solid,
                Color.Black,
                2,
                ButtonBorderStyle.Solid,
                Color.Black,
                2,
                ButtonBorderStyle.Solid);
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = sdkBuilder.MakeSoduku();
            for (int i = 0; i < result.Count; i++)
            {
                var list = result[i];
                for (int j = 0; j < list.Count; j++)
                {
                    var value = list[j];
                    TextBox testBox = TextBoxdic["postion_" + i + "_" + j];
                    if (testBox == null) continue;
                    testBox.Text = "" + value;
                    testBox.BackColor = Color.White;
                    resultMessage.Text = null;
                }
            }

            var breakouot = 0;
        }


        private void makeQuestion_Click(object sender, EventArgs e)
        {
        }

        private void SolveSoduku_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void isShowHelp_CheckedChanged(object sender, EventArgs e)
        {
            RefreshPanel();
        }

        private void 开始游戏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GenWholeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = sdkBuilder.MakeSoduku();
            for (int i = 0; i < result.Count; i++)
            {
                var list = result[i];
                for (int j = 0; j < list.Count; j++)
                {
                    var value = list[j];

                       TextBox testBox = TextBoxdic["postion_" + i + "_" + j];
                    if (testBox == null) continue;
                    testBox.Text = "" + value;
                    testBox.BackColor = Color.White;
                    resultMessage.Text = null;
                }
            }

            var breakouot = 0;
        }

        private void NormalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool istest = false;
            if(!istest)
            { currentMarket = sdkGenerator.AutoQuestion(sdkBuilder.MakeSoduku(), int.Parse(noticeNumber.Text));
            }
            else
            {
                List<List<int>> param = new List<List<int>>()

                {
                    new List<int> {0, 0, 0, 0, 2, 0, 0, 8, 0,},
                    new List<int> {0, 4, 0, 0, 0, 9, 0, 0, 3,},
                    new List<int> {0, 0, 0, 0, 0, 5, 7, 0, 0,},
                    new List<int> {0, 0, 0, 0, 0, 0, 0, 0, 0,},
                    new List<int> {8, 0, 5, 0, 7, 0, 0, 2, 0,},
                    new List<int> {0, 3, 7, 0, 0, 4, 0, 0, 0,},
                    new List<int> {0, 7, 0, 0, 8, 0, 0, 5, 6,},
                    new List<int> {0, 9, 0, 0, 0, 0, 3, 0, 0,},
                    new List<int> {1, 0, 0, 0, 4, 0, 0, 0, 0,}
                };
                currentMarket = new SodukuMarket(param);
            }
            questions = currentMarket.initValues;
            UpdateCurrentSodukuInfo();
            showhelp = this.ShowHelpToolStripMenuItem.Checked;
            for (int i = 0; i < questions.Count; i++)
            {
                var list = questions[i];
                for (int j = 0; j < list.Count; j++)
                {
                    var value = list[j];
                    TextBox testBox = TextBoxdic["postion_" + i + "_" + j];
                    if (testBox == null) continue;
                    testBox.Text = "" + value;
                    testBox.ForeColor =_config.ColorConfig.QuestionForeColor;
                    testBox.BackColor = Color.White;
                    resultMessage.Text = null;
                }
            }

            RefreshPanel();
            var breakouot = 0;
        }

        private void UpdateCurrentSodukuInfo()
        {
            label4.Text = "共同位置加权值：  " + Math.Round(currentMarket.Common, 2);
            label5.Text = "实际提示数个数为:   " + currentMarket.initLists.Count;
        }

        private void 锯齿数独ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void ExportPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var kv in locationClues)
                {
                    kv.Value.Visible = false;
                }
                foreach (var kv in TextBoxdic)
                {
                    kv.Value.Visible = true;
                }
                Bitmap bit = new Bitmap(tableLayoutPanel1.Width, tableLayoutPanel1.Height); //实例化一个和窗体一样大的bitmap

                tableLayoutPanel1.DrawToBitmap(bit,
                    new Rectangle(0, 0, tableLayoutPanel1.Width, tableLayoutPanel1.Height));
                var time = DateTime.Now.ToString("yyyyMMddHHmmss");
                var warpath =  AppDomain.CurrentDomain.BaseDirectory + "QuestionImages";
                var path = warpath+"/" + time + ".png";
                if (!Directory.Exists(warpath))
                    Directory.CreateDirectory(warpath);
                bit.Save(path, ImageFormat.Png);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw new Exception("请检查文件夹权限！");
            }
        }

        private void 理论求解ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentMarket == null)
            {
                helpMessage.Text = "请提供数独题目";
                return;
            }

            new SodukuSolver.SodukuSolver().Solve(currentMarket);
            sdk.Solve(questions, true);
            for (int i = 0; i < questions.Count; i++)
            {
                var list = questions[i];
                for (int j = 0; j < list.Count; j++)
                {
                    var value = list[j];
                    var location = "postion_" + i + "_" + j;
                    var cellinfo = sdk.GetCellInfo(location);
                    TextBox testBox = TextBoxdic[location];
                    if (testBox == null) continue;
                    testBox.Text = "" + cellinfo.Value;
                    testBox.ForeColor = cellinfo.isInit ? Color.Black : Color.Blue;
                    testBox.BackColor = Color.White;
                }
            }

            resultMessage.Text = sdk.SolveMessage;
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }
        private bool showhelp ;
        private void ShowHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {

          
            showhelp = !this.ShowHelpToolStripMenuItem.Checked;
            RefreshPanel();
            this.ShowHelpToolStripMenuItem.Checked = showhelp;
 


        }

        private void exportTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(currentMarket==null) return;
            var express = currentMarket.StrExpress;
            string dir = AppDomain.CurrentDomain.BaseDirectory;
            var time = DateTime.Now.ToString("yyyyMMddHHmmss");
            string configName = Path.Combine(dir, time+"_"+ noticeNumber.Text + ".txt");
            File.WriteAllText(configName, express, Encoding.UTF8);
        }

        private void importTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "数独文件(* .txt)|* .txt";
            dlg.FilterIndex = 0;
            dlg.Title = "选择数独文件";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string express = File.ReadAllText(dlg.FileName, Encoding.UTF8);
                if (express.Length<81)
                {
                   return;
                }
                currentMarket=new SodukuMarket(StaticTools.StringToList(express));
                RefreshPanel();
            }
        }

        private void colorSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmColorConfig f2 = new FrmColorConfig(_config);
            f2.StartPosition = FormStartPosition.CenterScreen;

            f2.ShowDialog();
            RefreshPanel();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (var variable in TextBoxdic)
            {
                variable.Value.Text = null;
            }
            currentMarket = currentMarket.LessNoticeNumber();
            RefreshPanel();
        }

        private void ForceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentMarket.GetAnswerByForce();
            RefreshPanel();
        }
    }
}