using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SodukuUserControls
{
  public  class EllipseButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath gPath = new GraphicsPath();
            // 绘制椭圆形区域
            gPath.AddEllipse(0, 0, this.ClientSize.Width, this.ClientSize.Height);

            // 将区域赋值给Region
            this.Region = new System.Drawing.Region(gPath);

            base.OnPaint(pevent);
        }

    }
}
