using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Soduku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static readonly int numbers = 9;

        private static readonly Soduku sdk = new Soduku();

        private static readonly List<string> vaildValues  = new List<string>{"1","2","3","4","5","6","7","8","9"};
 
        private void Form1_Load(object sender, EventArgs e)
        {
            this.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this, true, null);

            for (int i = 0; i < numbers; i++)
            {
                for (int j = 0; j < numbers; j++)
                {
                    object obj = GetType().GetField("postion_" + i + "_" + j,
                            System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance
                                                                     | System.Reflection.BindingFlags.IgnoreCase)
                        ?.GetValue(this);
                    TextBox testBox = (TextBox)obj;
                    if (testBox == null) continue;
                    testBox.Dock = DockStyle.None;
                    testBox.Margin = new Padding(2);
                    testBox.BorderStyle = BorderStyle.None;
                    testBox.Multiline = true;
                    testBox.Size = new Size(50, 50);
                    testBox.TabIndex = 0;
                    testBox.TextAlign = HorizontalAlignment.Center;
                    testBox.Font = new Font("Dotum", 30f, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
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
            resultMessage.Text = ctx.Text;
            var thisValue = ctx.Text;
            resultMessage.Text = thisValue;
            if (string.IsNullOrEmpty(thisValue)) return;

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


                    testBox.BackColor = thisValue == testBox.Text.Trim() ? Color.Orange : Color.White;
                }
            }
        }

        private void textChanged(object sender, EventArgs e)
        {
            var ctx = (TextBox)sender;
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
                    Color.Black,//7f9db9
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

            if (e.Column == 2||e.Column==5)
            {
                ControlPaint.DrawBorder(e.Graphics,
                    e.CellBounds,
                    Color.Black,//7f9db9
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
                this.tableLayoutPanel1.ClientRectangle,
                Color.Black,//7f9db9
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
        
            var result = sdk.MakeSoduku();
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
            var result = sdk.Question();
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
                    TextBox testBox = (TextBox)obj;
                    if (testBox == null) continue;
                    testBox.Text = "" + value;
                    testBox.BackColor = Color.White;
                    resultMessage.Text = null;
                }
            }

            var breakouot = 0;
        }
    }
}