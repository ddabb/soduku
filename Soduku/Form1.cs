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
                    testBox.Dock = DockStyle.Fill;
                    testBox.Margin = new Padding(0);
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

        private void MouseEntere(object sender, EventArgs e)
        {
            var ctx = (TextBox) sender;
            resultMessage.Text = ctx.Text;
            var thisValue = ctx.Text;
            resultMessage.Text = thisValue;
            if (string.IsNullOrEmpty(thisValue)) return;

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