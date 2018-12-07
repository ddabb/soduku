using System;
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



        private void Form1_Load(object sender, EventArgs e)
        {
            int UPPER = 9;
            for (int i = 0; i < UPPER; i++)
            {
                for (int j = 0; j < UPPER; j++)
                {
                    object obj = GetType().GetField("postion_"+i+"_"+j,
                            System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance
                                                                     | System.Reflection.BindingFlags.IgnoreCase)
                        ?.GetValue(this);
                    TextBox testBox = (TextBox)obj;
                    testBox.Text = "" +(1+(i+j)%9);
                    testBox.Dock = DockStyle.Fill;

                    testBox.Margin = new Padding(0);
                    testBox.Multiline = true;

                    testBox.Size = new Size(50, 50);
                    testBox.TabIndex = 0;
                    testBox.TextAlign = HorizontalAlignment.Center;
                    testBox.Font = new Font("楷体", 40F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
                }
            }
      




        }
    }
}
