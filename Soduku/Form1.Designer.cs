using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.ComponentModel;

namespace Soduku
{
   partial class Form1
    {

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.postion_0_0 = new System.Windows.Forms.TextBox();
            this.postion_0_1 = new System.Windows.Forms.TextBox();
            this.postion_0_2 = new System.Windows.Forms.TextBox();
            this.postion_0_3 = new System.Windows.Forms.TextBox();
            this.postion_0_4 = new System.Windows.Forms.TextBox();
            this.postion_0_5 = new System.Windows.Forms.TextBox();
            this.postion_0_6 = new System.Windows.Forms.TextBox();
            this.postion_0_7 = new System.Windows.Forms.TextBox();
            this.postion_0_8 = new System.Windows.Forms.TextBox();
            this.postion_1_0 = new System.Windows.Forms.TextBox();
            this.postion_1_1 = new System.Windows.Forms.TextBox();
            this.postion_1_2 = new System.Windows.Forms.TextBox();
            this.postion_1_3 = new System.Windows.Forms.TextBox();
            this.postion_1_4 = new System.Windows.Forms.TextBox();
            this.postion_1_5 = new System.Windows.Forms.TextBox();
            this.postion_1_6 = new System.Windows.Forms.TextBox();
            this.postion_1_7 = new System.Windows.Forms.TextBox();
            this.postion_1_8 = new System.Windows.Forms.TextBox();
            this.postion_2_0 = new System.Windows.Forms.TextBox();
            this.postion_2_1 = new System.Windows.Forms.TextBox();
            this.postion_2_2 = new System.Windows.Forms.TextBox();
            this.postion_2_3 = new System.Windows.Forms.TextBox();
            this.postion_2_4 = new System.Windows.Forms.TextBox();
            this.postion_2_5 = new System.Windows.Forms.TextBox();
            this.postion_2_6 = new System.Windows.Forms.TextBox();
            this.postion_2_7 = new System.Windows.Forms.TextBox();
            this.postion_2_8 = new System.Windows.Forms.TextBox();
            this.postion_3_0 = new System.Windows.Forms.TextBox();
            this.postion_3_1 = new System.Windows.Forms.TextBox();
            this.postion_3_2 = new System.Windows.Forms.TextBox();
            this.postion_3_3 = new System.Windows.Forms.TextBox();
            this.postion_3_4 = new System.Windows.Forms.TextBox();
            this.postion_3_5 = new System.Windows.Forms.TextBox();
            this.postion_3_6 = new System.Windows.Forms.TextBox();
            this.postion_3_7 = new System.Windows.Forms.TextBox();
            this.postion_3_8 = new System.Windows.Forms.TextBox();
            this.postion_4_0 = new System.Windows.Forms.TextBox();
            this.postion_4_1 = new System.Windows.Forms.TextBox();
            this.postion_4_2 = new System.Windows.Forms.TextBox();
            this.postion_4_3 = new System.Windows.Forms.TextBox();
            this.postion_4_4 = new System.Windows.Forms.TextBox();
            this.postion_4_5 = new System.Windows.Forms.TextBox();
            this.postion_4_6 = new System.Windows.Forms.TextBox();
            this.postion_4_7 = new System.Windows.Forms.TextBox();
            this.postion_4_8 = new System.Windows.Forms.TextBox();
            this.postion_5_0 = new System.Windows.Forms.TextBox();
            this.postion_5_1 = new System.Windows.Forms.TextBox();
            this.postion_5_2 = new System.Windows.Forms.TextBox();
            this.postion_5_3 = new System.Windows.Forms.TextBox();
            this.postion_5_4 = new System.Windows.Forms.TextBox();
            this.postion_5_5 = new System.Windows.Forms.TextBox();
            this.postion_5_6 = new System.Windows.Forms.TextBox();
            this.postion_5_7 = new System.Windows.Forms.TextBox();
            this.postion_5_8 = new System.Windows.Forms.TextBox();
            this.postion_6_0 = new System.Windows.Forms.TextBox();
            this.postion_6_1 = new System.Windows.Forms.TextBox();
            this.postion_6_2 = new System.Windows.Forms.TextBox();
            this.postion_6_3 = new System.Windows.Forms.TextBox();
            this.postion_6_4 = new System.Windows.Forms.TextBox();
            this.postion_6_5 = new System.Windows.Forms.TextBox();
            this.postion_6_6 = new System.Windows.Forms.TextBox();
            this.postion_6_7 = new System.Windows.Forms.TextBox();
            this.postion_6_8 = new System.Windows.Forms.TextBox();
            this.postion_7_0 = new System.Windows.Forms.TextBox();
            this.postion_7_1 = new System.Windows.Forms.TextBox();
            this.postion_7_2 = new System.Windows.Forms.TextBox();
            this.postion_7_3 = new System.Windows.Forms.TextBox();
            this.postion_7_4 = new System.Windows.Forms.TextBox();
            this.postion_7_5 = new System.Windows.Forms.TextBox();
            this.postion_7_6 = new System.Windows.Forms.TextBox();
            this.postion_7_7 = new System.Windows.Forms.TextBox();
            this.postion_7_8 = new System.Windows.Forms.TextBox();
            this.postion_8_0 = new System.Windows.Forms.TextBox();
            this.postion_8_1 = new System.Windows.Forms.TextBox();
            this.postion_8_2 = new System.Windows.Forms.TextBox();
            this.postion_8_3 = new System.Windows.Forms.TextBox();
            this.postion_8_4 = new System.Windows.Forms.TextBox();
            this.postion_8_5 = new System.Windows.Forms.TextBox();
            this.postion_8_6 = new System.Windows.Forms.TextBox();
            this.postion_8_7 = new System.Windows.Forms.TextBox();
            this.postion_8_8 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.postion_0_0, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.postion_0_1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.postion_0_2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.postion_0_3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.postion_0_4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.postion_0_5, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.postion_0_6, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.postion_0_7, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.postion_0_8, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.postion_1_0, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.postion_1_1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.postion_1_2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.postion_1_3, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.postion_1_4, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.postion_1_5, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.postion_1_6, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.postion_1_7, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.postion_1_8, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.postion_2_0, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.postion_2_1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.postion_2_2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.postion_2_3, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.postion_2_4, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.postion_2_5, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.postion_2_6, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.postion_2_7, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.postion_2_8, 8, 2);
            this.tableLayoutPanel1.Controls.Add(this.postion_3_0, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.postion_3_1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.postion_3_2, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.postion_3_3, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.postion_3_4, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.postion_3_5, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.postion_3_6, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.postion_3_7, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.postion_3_8, 8, 3);
            this.tableLayoutPanel1.Controls.Add(this.postion_4_0, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.postion_4_1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.postion_4_2, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.postion_4_3, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.postion_4_4, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.postion_4_5, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.postion_4_6, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.postion_4_7, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.postion_4_8, 8, 4);
            this.tableLayoutPanel1.Controls.Add(this.postion_5_0, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.postion_5_1, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.postion_5_2, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.postion_5_3, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.postion_5_4, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.postion_5_5, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.postion_5_6, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.postion_5_7, 7, 5);
            this.tableLayoutPanel1.Controls.Add(this.postion_5_8, 8, 5);
            this.tableLayoutPanel1.Controls.Add(this.postion_6_0, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.postion_6_1, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.postion_6_2, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.postion_6_3, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.postion_6_4, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.postion_6_5, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.postion_6_6, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.postion_6_7, 7, 6);
            this.tableLayoutPanel1.Controls.Add(this.postion_6_8, 8, 6);
            this.tableLayoutPanel1.Controls.Add(this.postion_7_0, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.postion_7_1, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.postion_7_2, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.postion_7_3, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.postion_7_4, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.postion_7_5, 5, 7);
            this.tableLayoutPanel1.Controls.Add(this.postion_7_6, 6, 7);
            this.tableLayoutPanel1.Controls.Add(this.postion_7_7, 7, 7);
            this.tableLayoutPanel1.Controls.Add(this.postion_7_8, 8, 7);
            this.tableLayoutPanel1.Controls.Add(this.postion_8_0, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.postion_8_1, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.postion_8_2, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.postion_8_3, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.postion_8_4, 4, 8);
            this.tableLayoutPanel1.Controls.Add(this.postion_8_5, 5, 8);
            this.tableLayoutPanel1.Controls.Add(this.postion_8_6, 6, 8);
            this.tableLayoutPanel1.Controls.Add(this.postion_8_7, 7, 8);
            this.tableLayoutPanel1.Controls.Add(this.postion_8_8, 8, 8);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(28, 118);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(460, 460);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // postion_0_0
            // 
            this.postion_0_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_0_0.Location = new System.Drawing.Point(1, 1);
            this.postion_0_0.Margin = new System.Windows.Forms.Padding(0);
            this.postion_0_0.Multiline = true;
            this.postion_0_0.Name = "postion_0_0";
            this.postion_0_0.Size = new System.Drawing.Size(50, 50);
            this.postion_0_0.TabIndex = 0;
            this.postion_0_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.postion_0_0.Font = new System.Drawing.Font("楷体", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
           
            // 
            // Form1
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(906, 749);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }
        private IContainer components = null;

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox postion_0_0;
        private TextBox postion_0_1;
        private TextBox postion_0_2;
        private TextBox postion_0_3;
        private TextBox postion_0_4;
        private TextBox postion_0_5;
        private TextBox postion_0_6;
        private TextBox postion_0_7;
        private TextBox postion_0_8;

        private TextBox postion_1_0;
        private TextBox postion_1_1;
        private TextBox postion_1_2;
        private TextBox postion_1_3;
        private TextBox postion_1_4;
        private TextBox postion_1_5;
        private TextBox postion_1_6;
        private TextBox postion_1_7;
        private TextBox postion_1_8;

        private TextBox postion_2_0;
        private TextBox postion_2_1;
        private TextBox postion_2_2;
        private TextBox postion_2_3;
        private TextBox postion_2_4;
        private TextBox postion_2_5;
        private TextBox postion_2_6;
        private TextBox postion_2_7;
        private TextBox postion_2_8;

        private TextBox postion_3_0;
        private TextBox postion_3_1;
        private TextBox postion_3_2;
        private TextBox postion_3_3;
        private TextBox postion_3_4;
        private TextBox postion_3_5;
        private TextBox postion_3_6;
        private TextBox postion_3_7;
        private TextBox postion_3_8;

        private TextBox postion_4_0;
        private TextBox postion_4_1;
        private TextBox postion_4_2;
        private TextBox postion_4_3;
        private TextBox postion_4_4;
        private TextBox postion_4_5;
        private TextBox postion_4_6;
        private TextBox postion_4_7;
        private TextBox postion_4_8;

        private TextBox postion_5_0;
        private TextBox postion_5_1;
        private TextBox postion_5_2;
        private TextBox postion_5_3;
        private TextBox postion_5_4;
        private TextBox postion_5_5;
        private TextBox postion_5_6;
        private TextBox postion_5_7;
        private TextBox postion_5_8;

        private TextBox postion_6_0;
        private TextBox postion_6_1;
        private TextBox postion_6_2;
        private TextBox postion_6_3;
        private TextBox postion_6_4;
        private TextBox postion_6_5;
        private TextBox postion_6_6;
        private TextBox postion_6_7;
        private TextBox postion_6_8;

        private TextBox postion_7_0;
        private TextBox postion_7_1;
        private TextBox postion_7_2;
        private TextBox postion_7_3;
        private TextBox postion_7_4;
        private TextBox postion_7_5;
        private TextBox postion_7_6;
        private TextBox postion_7_7;
        private TextBox postion_7_8;

        private TextBox postion_8_0;
        private TextBox postion_8_1;
        private TextBox postion_8_2;
        private TextBox postion_8_3;
        private TextBox postion_8_4;
        private TextBox postion_8_5;
        private TextBox postion_8_6;
        private TextBox postion_8_7;
        private TextBox postion_8_8;


    }
}
