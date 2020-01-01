using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace SudokuUserControls
{
    public partial class ctlRoundPanel : UserControl
    {
        public ctlRoundPanel()
        {
            InitializeComponent();

        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath gPath = new GraphicsPath();
            // 绘制椭圆形区域
            gPath.AddEllipse(0, 0, this.ClientSize.Width, this.ClientSize.Height);

            // 将区域赋值给Region
            this.Region = new System.Drawing.Region(gPath);

            base.OnPaint(pevent);
        }


        //参考 原文：https://blog.csdn.net/thanks_hck/article/details/81475378 
    }
}
