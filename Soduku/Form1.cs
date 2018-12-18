using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using SodukuBase;
using SodukuFactory;
using SodukuGenerator;

namespace SodukuUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static readonly int numbers = 9;

        private static Soduku sdk = new Soduku();

        private static SodukuBuilder sdkBuilder = new SodukuBuilder();

        private static SodukuQuestion sdkGenerator = new SodukuQuestion();
        

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

        private void Form1_Load(object sender, EventArgs e)
        {
            GetType()
                .GetProperty("DoubleBuffered",
                    System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                ?.SetValue(this, true, null);
            helpMessage.Text = null;
            resultMessage.Text = null;
            for (int i = 0; i < numbers; i++)
            {
                for (int j = 0; j < numbers; j++)
                {
                    object obj = GetType().GetField("postion_" + i + "_" + j,
                            System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance
                                                                     | System.Reflection.BindingFlags.IgnoreCase)
                        ?.GetValue(this);
                    TextBox testBox = (TextBox) obj;
                    if (testBox == null) continue;
                    testBox.Dock = DockStyle.None;
                    testBox.Margin = new Padding(2);
                    testBox.BorderStyle = BorderStyle.None;
                    testBox.Multiline = true;
                    testBox.Size = new Size(50, 50);
                    testBox.TabIndex = 0;
                    testBox.TextAlign = HorizontalAlignment.Center;
                    testBox.Font = new Font("Dotum", 30f, FontStyle.Regular, GraphicsUnit.Point, ((byte) (134)));
                    testBox.TextChanged += new EventHandler(textChanged);
                    testBox.MouseEnter += new EventHandler(MouseEntere);
                }
            }
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

                Soduku.rowDatas[cell.row].Sort();
                Soduku.columnDatas[cell.column].Sort();
                Soduku.blockDatas[cell.block].Sort();
                var message2 = JsonConvert.SerializeObject(Soduku.rowDatas[cell.row]);
                var message3 = JsonConvert.SerializeObject(Soduku.columnDatas[cell.column]);
                var message4 = JsonConvert.SerializeObject(Soduku.blockDatas[cell.block]);
                helpMessage.Text = "当前鼠标位置为"+(cell.row+1)+"行"+ (cell.column + 1)+"列\r\n";
                helpMessage.Text += @"可选值范围为：" + message + "\r\n行已经填充" + message2 + "\r\n列已经填充" + message3 +
                                   "\r\n宫已经填充" + message4;
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
                    object obj = GetType().GetField("postion_" + i + "_" + j,
                            System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance
                                                                     | System.Reflection.BindingFlags.IgnoreCase)
                        ?.GetValue(this);
                    TextBox testBox = (TextBox) obj;
                    if (testBox == null) continue;


                    testBox.BackColor = !string.IsNullOrEmpty(thisValue)&& thisValue == testBox.Text.Trim() ? Color.Orange : Color.White;
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

                    object obj = GetType().GetField("postion_" + i + "_" + j,
                            System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance
                                                                     | System.Reflection.BindingFlags.IgnoreCase)
                        ?.GetValue(this);
                    TextBox testBox = (TextBox) obj;
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


            if (false)
            {
                questions = sdkGenerator.Question();
            }
            else
            {
                questions  = sdkGenerator.AutoQuestion(sdkBuilder.MakeSoduku(), int.Parse(noticeNumber.Text));
            }
      
            for (int i = 0; i < questions.Count; i++)
            {
                var list = questions[i];
                for (int j = 0; j < list.Count; j++)
                {
                    var value = list[j];

                    object obj = GetType().GetField("postion_" + i + "_" + j,
                            System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance
                                                                     | System.Reflection.BindingFlags.IgnoreCase)
                        ?.GetValue(this);
                    TextBox testBox = (TextBox) obj;
                    if (testBox == null) continue;
                    testBox.Text = "" + value;
                    testBox.ForeColor = Color.Black;
                    testBox.BackColor = Color.White;
                    resultMessage.Text = null;
                }
            }

            var breakouot = 0;
        }

        private void SolveSoduku_Click(object sender, EventArgs e)
        {
            if (questions == null)
            {
                helpMessage.Text = "请提供数独题目";
                return;
            }

            sdk.Solve(questions, true);
            for (int i = 0; i < questions.Count; i++)
            {
                var list = questions[i];
                for (int j = 0; j < list.Count; j++)
                {
                    var value = list[j];
                    var location = "postion_" + i + "_" + j;
                    var cellinfo = sdk.GetCellInfo(location);
                    object obj = GetType().GetField(location,
                            System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance
                                                                     | System.Reflection.BindingFlags.IgnoreCase)
                        ?.GetValue(this);
                    TextBox testBox = (TextBox) obj;
                    if (testBox == null) continue;
                    testBox.Text = "" + cellinfo.Value;
                    testBox.ForeColor = cellinfo.isInit ? Color.Black : Color.Blue;
                    testBox.BackColor = Color.White;
                }
            }

            resultMessage.Text = sdk.SolveMessage;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap bit = new Bitmap(tableLayoutPanel1.Width, tableLayoutPanel1.Bottom);//实例化一个和窗体一样大的bitmap
                tableLayoutPanel1.DrawToBitmap(bit, new Rectangle(0, tableLayoutPanel1.Top, tableLayoutPanel1.Width, tableLayoutPanel1.Bottom));
                var time = DateTime.Now.ToString("yyyyMMddhhmmss");
                var c = System.IO.Directory.GetCurrentDirectory();
              var path=  new DirectoryInfo("../../").FullName + "QuestionImages\\" + time + ".png";

                SaveBMP(ref bit, path);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw new Exception("请检查文件夹权限！");
            }

        }

        private void SaveBMP(ref Bitmap bmp,string path) // now 'ref' parameter
        {
            try
            {
                bmp.Save(path);
            }
            catch
            {
                Bitmap bitmap = new Bitmap(bmp.Width, bmp.Height, bmp.PixelFormat);
                Graphics g = Graphics.FromImage(bitmap);
                g.DrawImage(bmp, new Point(0, 0));
                g.Dispose();
                bmp.Dispose();
                bitmap.Save(path);
                bmp = bitmap; // preserve clone        
            }
        }
    }
}