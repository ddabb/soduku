using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soduku
{
    public class DemoTableLayoutPanel : TableLayoutPanel
    {
        protected override void OnCellPaint(TableLayoutCellPaintEventArgs e)
        {
            base.OnCellPaint(e);

            Control c = GetControlFromPosition(e.Column, e.Row);

            if (c != null)
            {
                Graphics g = e.Graphics;

                g.DrawRectangle(
                    Pens.Red,
                    e.CellBounds.Location.X + 1,
                    e.CellBounds.Location.Y + 1,
                    e.CellBounds.Width - 2, e.CellBounds.Height - 2);

                g.FillRectangle(
                    Brushes.Blue,
                    e.CellBounds.Location.X + 1,
                    e.CellBounds.Location.Y + 1,
                    e.CellBounds.Width - 2,
                    e.CellBounds.Height - 2);
            };
        }

    }
}
