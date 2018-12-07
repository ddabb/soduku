using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soduku
{
    public class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            // postion_0_1
            // 
            this.postion_0_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_0_1.Location = new System.Drawing.Point(52, 1);
            this.postion_0_1.Margin = new System.Windows.Forms.Padding(0);
            this.postion_0_1.Multiline = true;
            this.postion_0_1.Name = "postion_0_1";
            this.postion_0_1.Size = new System.Drawing.Size(50, 50);
            this.postion_0_1.TabIndex = 0;
            this.postion_0_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.postion_0_1.Font = new System.Drawing.Font("楷体", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // postion_0_2
            // 
            this.postion_0_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_0_2.Location = new System.Drawing.Point(103, 1);
            this.postion_0_2.Margin = new System.Windows.Forms.Padding(0);
            this.postion_0_2.Multiline = true;
            this.postion_0_2.Name = "postion_0_2";
            this.postion_0_2.Size = new System.Drawing.Size(50, 50);
            this.postion_0_2.TabIndex = 0;
            this.postion_0_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.postion_0_2.Font = new System.Drawing.Font("楷体", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // postion_0_3
            // 
            this.postion_0_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_0_3.Location = new System.Drawing.Point(154, 1);
            this.postion_0_3.Margin = new System.Windows.Forms.Padding(0);
            this.postion_0_3.Multiline = true;
            this.postion_0_3.Name = "postion_0_3";
            this.postion_0_3.Size = new System.Drawing.Size(50, 50);
            this.postion_0_3.TabIndex = 0;
            this.postion_0_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.postion_0_3.Font = new System.Drawing.Font("楷体", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // postion_0_4
            // 
            this.postion_0_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_0_4.Location = new System.Drawing.Point(205, 1);
            this.postion_0_4.Margin = new System.Windows.Forms.Padding(0);
            this.postion_0_4.Multiline = true;
            this.postion_0_4.Name = "postion_0_4";
            this.postion_0_4.Size = new System.Drawing.Size(50, 50);
            this.postion_0_4.TabIndex = 0;
            this.postion_0_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.postion_0_4.Font = new System.Drawing.Font("楷体", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // postion_0_5
            // 
            this.postion_0_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_0_5.Location = new System.Drawing.Point(256, 1);
            this.postion_0_5.Margin = new System.Windows.Forms.Padding(0);
            this.postion_0_5.Multiline = true;
            this.postion_0_5.Name = "postion_0_5";
            this.postion_0_5.Size = new System.Drawing.Size(50, 50);
            this.postion_0_5.TabIndex = 0;
            this.postion_0_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.postion_0_5.Font = new System.Drawing.Font("楷体", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // postion_0_6
            // 
            this.postion_0_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_0_6.Location = new System.Drawing.Point(307, 1);
            this.postion_0_6.Margin = new System.Windows.Forms.Padding(0);
            this.postion_0_6.Multiline = true;
            this.postion_0_6.Name = "postion_0_6";
            this.postion_0_6.Size = new System.Drawing.Size(50, 50);
            this.postion_0_6.TabIndex = 0;
            this.postion_0_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.postion_0_6.Font = new System.Drawing.Font("楷体", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // postion_0_7
            // 
            this.postion_0_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_0_7.Location = new System.Drawing.Point(358, 1);
            this.postion_0_7.Margin = new System.Windows.Forms.Padding(0);
            this.postion_0_7.Multiline = true;
            this.postion_0_7.Name = "postion_0_7";
            this.postion_0_7.Size = new System.Drawing.Size(50, 50);
            this.postion_0_7.TabIndex = 0;
            this.postion_0_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.postion_0_7.Font = new System.Drawing.Font("楷体", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // postion_0_8
            // 
            this.postion_0_8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_0_8.Location = new System.Drawing.Point(409, 1);
            this.postion_0_8.Margin = new System.Windows.Forms.Padding(0);
            this.postion_0_8.Multiline = true;
            this.postion_0_8.Name = "postion_0_8";
            this.postion_0_8.Size = new System.Drawing.Size(50, 50);
            this.postion_0_8.TabIndex = 0;
            this.postion_0_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.postion_0_8.Font = new System.Drawing.Font("楷体", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // postion_1_0
            // 
            this.postion_1_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_1_0.Location = new System.Drawing.Point(1, 52);
            this.postion_1_0.Margin = new System.Windows.Forms.Padding(0);
            this.postion_1_0.Multiline = true;
            this.postion_1_0.Name = "postion_1_0";
            this.postion_1_0.Size = new System.Drawing.Size(50, 50);
            this.postion_1_0.TabIndex = 0;
            this.postion_1_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.postion_1_0.Font = new System.Drawing.Font("楷体", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // postion_1_1
            // 
            this.postion_1_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_1_1.Location = new System.Drawing.Point(52, 52);
            this.postion_1_1.Margin = new System.Windows.Forms.Padding(0);
            this.postion_1_1.Multiline = true;
            this.postion_1_1.Name = "postion_1_1";
            this.postion_1_1.Size = new System.Drawing.Size(50, 50);
            this.postion_1_1.TabIndex = 0;
            this.postion_1_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.postion_1_1.Font = new System.Drawing.Font("楷体", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // postion_1_2
            // 
            this.postion_1_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_1_2.Location = new System.Drawing.Point(103, 52);
            this.postion_1_2.Margin = new System.Windows.Forms.Padding(0);
            this.postion_1_2.Multiline = true;
            this.postion_1_2.Name = "postion_1_2";
            this.postion_1_2.Size = new System.Drawing.Size(50, 50);
            this.postion_1_2.TabIndex = 0;
            this.postion_1_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.postion_1_2.Font = new System.Drawing.Font("楷体", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // postion_1_3
            // 
            this.postion_1_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_1_3.Location = new System.Drawing.Point(154, 52);
            this.postion_1_3.Margin = new System.Windows.Forms.Padding(0);
            this.postion_1_3.Multiline = true;
            this.postion_1_3.Name = "postion_1_3";
            this.postion_1_3.Size = new System.Drawing.Size(50, 50);
            this.postion_1_3.TabIndex = 0;
            this.postion_1_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.postion_1_3.Font = new System.Drawing.Font("楷体", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // postion_1_4
            // 
            this.postion_1_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_1_4.Location = new System.Drawing.Point(205, 52);
            this.postion_1_4.Margin = new System.Windows.Forms.Padding(0);
            this.postion_1_4.Multiline = true;
            this.postion_1_4.Name = "postion_1_4";
            this.postion_1_4.Size = new System.Drawing.Size(50, 50);
            this.postion_1_4.TabIndex = 0;
            this.postion_1_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.postion_1_4.Font = new System.Drawing.Font("楷体", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // postion_1_5
            // 
            this.postion_1_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_1_5.Location = new System.Drawing.Point(256, 52);
            this.postion_1_5.Margin = new System.Windows.Forms.Padding(0);
            this.postion_1_5.Multiline = true;
            this.postion_1_5.Name = "postion_1_5";
            this.postion_1_5.Size = new System.Drawing.Size(50, 50);
            this.postion_1_5.TabIndex = 0;
            this.postion_1_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.postion_1_5.Font = new System.Drawing.Font("楷体", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // postion_1_6
            // 
            this.postion_1_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_1_6.Location = new System.Drawing.Point(307, 52);
            this.postion_1_6.Margin = new System.Windows.Forms.Padding(0);
            this.postion_1_6.Multiline = true;
            this.postion_1_6.Name = "postion_1_6";
            this.postion_1_6.Size = new System.Drawing.Size(50, 50);
            this.postion_1_6.TabIndex = 0;
            this.postion_1_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.postion_1_6.Font = new System.Drawing.Font("楷体", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // postion_1_7
            // 
            this.postion_1_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_1_7.Location = new System.Drawing.Point(358, 52);
            this.postion_1_7.Margin = new System.Windows.Forms.Padding(0);
            this.postion_1_7.Multiline = true;
            this.postion_1_7.Name = "postion_1_7";
            this.postion_1_7.Size = new System.Drawing.Size(50, 50);
            this.postion_1_7.TabIndex = 0;
            this.postion_1_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.postion_1_7.Font = new System.Drawing.Font("楷体", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // postion_1_8
            // 
            this.postion_1_8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_1_8.Location = new System.Drawing.Point(409, 52);
            this.postion_1_8.Margin = new System.Windows.Forms.Padding(0);
            this.postion_1_8.Multiline = true;
            this.postion_1_8.Name = "postion_1_8";
            this.postion_1_8.Size = new System.Drawing.Size(50, 50);
            this.postion_1_8.TabIndex = 0;
            this.postion_1_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.postion_1_8.Font = new System.Drawing.Font("楷体", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // postion_2_0
            // 
            this.postion_2_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_2_0.Location = new System.Drawing.Point(1, 103);
            this.postion_2_0.Margin = new System.Windows.Forms.Padding(0);
            this.postion_2_0.Multiline = true;
            this.postion_2_0.Name = "postion_2_0";
            this.postion_2_0.Size = new System.Drawing.Size(50, 50);
            this.postion_2_0.TabIndex = 0;
            this.postion_2_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.postion_2_0.Font = new System.Drawing.Font("楷体", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // postion_2_1
            // 
            this.postion_2_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_2_1.Location = new System.Drawing.Point(52, 103);
            this.postion_2_1.Margin = new System.Windows.Forms.Padding(0);
            this.postion_2_1.Multiline = true;
            this.postion_2_1.Name = "postion_2_1";
            this.postion_2_1.Size = new System.Drawing.Size(50, 50);
            this.postion_2_1.TabIndex = 0;
            // 
            // postion_2_2
            // 
            this.postion_2_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_2_2.Location = new System.Drawing.Point(103, 103);
            this.postion_2_2.Margin = new System.Windows.Forms.Padding(0);
            this.postion_2_2.Multiline = true;
            this.postion_2_2.Name = "postion_2_2";
            this.postion_2_2.Size = new System.Drawing.Size(50, 50);
            this.postion_2_2.TabIndex = 0;
            // 
            // postion_2_3
            // 
            this.postion_2_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_2_3.Location = new System.Drawing.Point(154, 103);
            this.postion_2_3.Margin = new System.Windows.Forms.Padding(0);
            this.postion_2_3.Multiline = true;
            this.postion_2_3.Name = "postion_2_3";
            this.postion_2_3.Size = new System.Drawing.Size(50, 50);
            this.postion_2_3.TabIndex = 0;
            // 
            // postion_2_4
            // 
            this.postion_2_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_2_4.Location = new System.Drawing.Point(205, 103);
            this.postion_2_4.Margin = new System.Windows.Forms.Padding(0);
            this.postion_2_4.Multiline = true;
            this.postion_2_4.Name = "postion_2_4";
            this.postion_2_4.Size = new System.Drawing.Size(50, 50);
            this.postion_2_4.TabIndex = 0;
            // 
            // postion_2_5
            // 
            this.postion_2_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_2_5.Location = new System.Drawing.Point(256, 103);
            this.postion_2_5.Margin = new System.Windows.Forms.Padding(0);
            this.postion_2_5.Multiline = true;
            this.postion_2_5.Name = "postion_2_5";
            this.postion_2_5.Size = new System.Drawing.Size(50, 50);
            this.postion_2_5.TabIndex = 0;
            // 
            // postion_2_6
            // 
            this.postion_2_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_2_6.Location = new System.Drawing.Point(307, 103);
            this.postion_2_6.Margin = new System.Windows.Forms.Padding(0);
            this.postion_2_6.Multiline = true;
            this.postion_2_6.Name = "postion_2_6";
            this.postion_2_6.Size = new System.Drawing.Size(50, 50);
            this.postion_2_6.TabIndex = 0;
            // 
            // postion_2_7
            // 
            this.postion_2_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_2_7.Location = new System.Drawing.Point(358, 103);
            this.postion_2_7.Margin = new System.Windows.Forms.Padding(0);
            this.postion_2_7.Multiline = true;
            this.postion_2_7.Name = "postion_2_7";
            this.postion_2_7.Size = new System.Drawing.Size(50, 50);
            this.postion_2_7.TabIndex = 0;
            // 
            // postion_2_8
            // 
            this.postion_2_8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_2_8.Location = new System.Drawing.Point(409, 103);
            this.postion_2_8.Margin = new System.Windows.Forms.Padding(0);
            this.postion_2_8.Multiline = true;
            this.postion_2_8.Name = "postion_2_8";
            this.postion_2_8.Size = new System.Drawing.Size(50, 50);
            this.postion_2_8.TabIndex = 0;
            // 
            // postion_3_0
            // 
            this.postion_3_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_3_0.Location = new System.Drawing.Point(1, 154);
            this.postion_3_0.Margin = new System.Windows.Forms.Padding(0);
            this.postion_3_0.Multiline = true;
            this.postion_3_0.Name = "postion_3_0";
            this.postion_3_0.Size = new System.Drawing.Size(50, 50);
            this.postion_3_0.TabIndex = 0;
            // 
            // postion_3_1
            // 
            this.postion_3_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_3_1.Location = new System.Drawing.Point(52, 154);
            this.postion_3_1.Margin = new System.Windows.Forms.Padding(0);
            this.postion_3_1.Multiline = true;
            this.postion_3_1.Name = "postion_3_1";
            this.postion_3_1.Size = new System.Drawing.Size(50, 50);
            this.postion_3_1.TabIndex = 0;
            // 
            // postion_3_2
            // 
            this.postion_3_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_3_2.Location = new System.Drawing.Point(103, 154);
            this.postion_3_2.Margin = new System.Windows.Forms.Padding(0);
            this.postion_3_2.Multiline = true;
            this.postion_3_2.Name = "postion_3_2";
            this.postion_3_2.Size = new System.Drawing.Size(50, 50);
            this.postion_3_2.TabIndex = 0;
            // 
            // postion_3_3
            // 
            this.postion_3_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_3_3.Location = new System.Drawing.Point(154, 154);
            this.postion_3_3.Margin = new System.Windows.Forms.Padding(0);
            this.postion_3_3.Multiline = true;
            this.postion_3_3.Name = "postion_3_3";
            this.postion_3_3.Size = new System.Drawing.Size(50, 50);
            this.postion_3_3.TabIndex = 0;
            // 
            // postion_3_4
            // 
            this.postion_3_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_3_4.Location = new System.Drawing.Point(205, 154);
            this.postion_3_4.Margin = new System.Windows.Forms.Padding(0);
            this.postion_3_4.Multiline = true;
            this.postion_3_4.Name = "postion_3_4";
            this.postion_3_4.Size = new System.Drawing.Size(50, 50);
            this.postion_3_4.TabIndex = 0;
            this.postion_3_4.Text = "3";
            // 
            // postion_3_5
            // 
            this.postion_3_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_3_5.Location = new System.Drawing.Point(256, 154);
            this.postion_3_5.Margin = new System.Windows.Forms.Padding(0);
            this.postion_3_5.Multiline = true;
            this.postion_3_5.Name = "postion_3_5";
            this.postion_3_5.Size = new System.Drawing.Size(50, 50);
            this.postion_3_5.TabIndex = 0;
            // 
            // postion_3_6
            // 
            this.postion_3_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_3_6.Location = new System.Drawing.Point(307, 154);
            this.postion_3_6.Margin = new System.Windows.Forms.Padding(0);
            this.postion_3_6.Multiline = true;
            this.postion_3_6.Name = "postion_3_6";
            this.postion_3_6.Size = new System.Drawing.Size(50, 50);
            this.postion_3_6.TabIndex = 0;
            // 
            // postion_3_7
            // 
            this.postion_3_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_3_7.Location = new System.Drawing.Point(358, 154);
            this.postion_3_7.Margin = new System.Windows.Forms.Padding(0);
            this.postion_3_7.Multiline = true;
            this.postion_3_7.Name = "postion_3_7";
            this.postion_3_7.Size = new System.Drawing.Size(50, 50);
            this.postion_3_7.TabIndex = 0;
            // 
            // postion_3_8
            // 
            this.postion_3_8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_3_8.Location = new System.Drawing.Point(409, 154);
            this.postion_3_8.Margin = new System.Windows.Forms.Padding(0);
            this.postion_3_8.Multiline = true;
            this.postion_3_8.Name = "postion_3_8";
            this.postion_3_8.Size = new System.Drawing.Size(50, 50);
            this.postion_3_8.TabIndex = 0;
            // 
            // postion_4_0
            // 
            this.postion_4_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_4_0.Location = new System.Drawing.Point(1, 205);
            this.postion_4_0.Margin = new System.Windows.Forms.Padding(0);
            this.postion_4_0.Multiline = true;
            this.postion_4_0.Name = "postion_4_0";
            this.postion_4_0.Size = new System.Drawing.Size(50, 50);
            this.postion_4_0.TabIndex = 0;
            // 
            // postion_4_1
            // 
            this.postion_4_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_4_1.Location = new System.Drawing.Point(52, 205);
            this.postion_4_1.Margin = new System.Windows.Forms.Padding(0);
            this.postion_4_1.Multiline = true;
            this.postion_4_1.Name = "postion_4_1";
            this.postion_4_1.Size = new System.Drawing.Size(50, 50);
            this.postion_4_1.TabIndex = 0;
            // 
            // postion_4_2
            // 
            this.postion_4_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_4_2.Location = new System.Drawing.Point(103, 205);
            this.postion_4_2.Margin = new System.Windows.Forms.Padding(0);
            this.postion_4_2.Multiline = true;
            this.postion_4_2.Name = "postion_4_2";
            this.postion_4_2.Size = new System.Drawing.Size(50, 50);
            this.postion_4_2.TabIndex = 0;
            // 
            // postion_4_3
            // 
            this.postion_4_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_4_3.Location = new System.Drawing.Point(154, 205);
            this.postion_4_3.Margin = new System.Windows.Forms.Padding(0);
            this.postion_4_3.Multiline = true;
            this.postion_4_3.Name = "postion_4_3";
            this.postion_4_3.Size = new System.Drawing.Size(50, 50);
            this.postion_4_3.TabIndex = 0;
            // 
            // postion_4_4
            // 
            this.postion_4_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_4_4.Location = new System.Drawing.Point(205, 205);
            this.postion_4_4.Margin = new System.Windows.Forms.Padding(0);
            this.postion_4_4.Multiline = true;
            this.postion_4_4.Name = "postion_4_4";
            this.postion_4_4.Size = new System.Drawing.Size(50, 50);
            this.postion_4_4.TabIndex = 0;
            // 
            // postion_4_5
            // 
            this.postion_4_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_4_5.Location = new System.Drawing.Point(256, 205);
            this.postion_4_5.Margin = new System.Windows.Forms.Padding(0);
            this.postion_4_5.Multiline = true;
            this.postion_4_5.Name = "postion_4_5";
            this.postion_4_5.Size = new System.Drawing.Size(50, 50);
            this.postion_4_5.TabIndex = 0;
            // 
            // postion_4_6
            // 
            this.postion_4_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_4_6.Location = new System.Drawing.Point(307, 205);
            this.postion_4_6.Margin = new System.Windows.Forms.Padding(0);
            this.postion_4_6.Multiline = true;
            this.postion_4_6.Name = "postion_4_6";
            this.postion_4_6.Size = new System.Drawing.Size(50, 50);
            this.postion_4_6.TabIndex = 0;
            // 
            // postion_4_7
            // 
            this.postion_4_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_4_7.Location = new System.Drawing.Point(358, 205);
            this.postion_4_7.Margin = new System.Windows.Forms.Padding(0);
            this.postion_4_7.Multiline = true;
            this.postion_4_7.Name = "postion_4_7";
            this.postion_4_7.Size = new System.Drawing.Size(50, 50);
            this.postion_4_7.TabIndex = 0;
            // 
            // postion_4_8
            // 
            this.postion_4_8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_4_8.Location = new System.Drawing.Point(409, 205);
            this.postion_4_8.Margin = new System.Windows.Forms.Padding(0);
            this.postion_4_8.Multiline = true;
            this.postion_4_8.Name = "postion_4_8";
            this.postion_4_8.Size = new System.Drawing.Size(50, 50);
            this.postion_4_8.TabIndex = 0;
            // 
            // postion_5_0
            // 
            this.postion_5_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_5_0.Location = new System.Drawing.Point(1, 256);
            this.postion_5_0.Margin = new System.Windows.Forms.Padding(0);
            this.postion_5_0.Multiline = true;
            this.postion_5_0.Name = "postion_5_0";
            this.postion_5_0.Size = new System.Drawing.Size(50, 50);
            this.postion_5_0.TabIndex = 0;
            // 
            // postion_5_1
            // 
            this.postion_5_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_5_1.Location = new System.Drawing.Point(52, 256);
            this.postion_5_1.Margin = new System.Windows.Forms.Padding(0);
            this.postion_5_1.Multiline = true;
            this.postion_5_1.Name = "postion_5_1";
            this.postion_5_1.Size = new System.Drawing.Size(50, 50);
            this.postion_5_1.TabIndex = 0;
            // 
            // postion_5_2
            // 
            this.postion_5_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_5_2.Location = new System.Drawing.Point(103, 256);
            this.postion_5_2.Margin = new System.Windows.Forms.Padding(0);
            this.postion_5_2.Multiline = true;
            this.postion_5_2.Name = "postion_5_2";
            this.postion_5_2.Size = new System.Drawing.Size(50, 50);
            this.postion_5_2.TabIndex = 0;
            // 
            // postion_5_3
            // 
            this.postion_5_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_5_3.Location = new System.Drawing.Point(154, 256);
            this.postion_5_3.Margin = new System.Windows.Forms.Padding(0);
            this.postion_5_3.Multiline = true;
            this.postion_5_3.Name = "postion_5_3";
            this.postion_5_3.Size = new System.Drawing.Size(50, 50);
            this.postion_5_3.TabIndex = 0;
            // 
            // postion_5_4
            // 
            this.postion_5_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_5_4.Location = new System.Drawing.Point(205, 256);
            this.postion_5_4.Margin = new System.Windows.Forms.Padding(0);
            this.postion_5_4.Multiline = true;
            this.postion_5_4.Name = "postion_5_4";
            this.postion_5_4.Size = new System.Drawing.Size(50, 50);
            this.postion_5_4.TabIndex = 0;
            // 
            // postion_5_5
            // 
            this.postion_5_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_5_5.Location = new System.Drawing.Point(256, 256);
            this.postion_5_5.Margin = new System.Windows.Forms.Padding(0);
            this.postion_5_5.Multiline = true;
            this.postion_5_5.Name = "postion_5_5";
            this.postion_5_5.Size = new System.Drawing.Size(50, 50);
            this.postion_5_5.TabIndex = 0;
            // 
            // postion_5_6
            // 
            this.postion_5_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_5_6.Location = new System.Drawing.Point(307, 256);
            this.postion_5_6.Margin = new System.Windows.Forms.Padding(0);
            this.postion_5_6.Multiline = true;
            this.postion_5_6.Name = "postion_5_6";
            this.postion_5_6.Size = new System.Drawing.Size(50, 50);
            this.postion_5_6.TabIndex = 0;
            // 
            // postion_5_7
            // 
            this.postion_5_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_5_7.Location = new System.Drawing.Point(358, 256);
            this.postion_5_7.Margin = new System.Windows.Forms.Padding(0);
            this.postion_5_7.Multiline = true;
            this.postion_5_7.Name = "postion_5_7";
            this.postion_5_7.Size = new System.Drawing.Size(50, 50);
            this.postion_5_7.TabIndex = 0;
            // 
            // postion_5_8
            // 
            this.postion_5_8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_5_8.Location = new System.Drawing.Point(409, 256);
            this.postion_5_8.Margin = new System.Windows.Forms.Padding(0);
            this.postion_5_8.Multiline = true;
            this.postion_5_8.Name = "postion_5_8";
            this.postion_5_8.Size = new System.Drawing.Size(50, 50);
            this.postion_5_8.TabIndex = 0;
            // 
            // postion_6_0
            // 
            this.postion_6_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_6_0.Location = new System.Drawing.Point(1, 307);
            this.postion_6_0.Margin = new System.Windows.Forms.Padding(0);
            this.postion_6_0.Multiline = true;
            this.postion_6_0.Name = "postion_6_0";
            this.postion_6_0.Size = new System.Drawing.Size(50, 50);
            this.postion_6_0.TabIndex = 0;
            // 
            // postion_6_1
            // 
            this.postion_6_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_6_1.Location = new System.Drawing.Point(52, 307);
            this.postion_6_1.Margin = new System.Windows.Forms.Padding(0);
            this.postion_6_1.Multiline = true;
            this.postion_6_1.Name = "postion_6_1";
            this.postion_6_1.Size = new System.Drawing.Size(50, 50);
            this.postion_6_1.TabIndex = 0;
            // 
            // postion_6_2
            // 
            this.postion_6_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_6_2.Location = new System.Drawing.Point(103, 307);
            this.postion_6_2.Margin = new System.Windows.Forms.Padding(0);
            this.postion_6_2.Multiline = true;
            this.postion_6_2.Name = "postion_6_2";
            this.postion_6_2.Size = new System.Drawing.Size(50, 50);
            this.postion_6_2.TabIndex = 0;
            // 
            // postion_6_3
            // 
            this.postion_6_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_6_3.Location = new System.Drawing.Point(154, 307);
            this.postion_6_3.Margin = new System.Windows.Forms.Padding(0);
            this.postion_6_3.Multiline = true;
            this.postion_6_3.Name = "postion_6_3";
            this.postion_6_3.Size = new System.Drawing.Size(50, 50);
            this.postion_6_3.TabIndex = 0;
            // 
            // postion_6_4
            // 
            this.postion_6_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_6_4.Location = new System.Drawing.Point(205, 307);
            this.postion_6_4.Margin = new System.Windows.Forms.Padding(0);
            this.postion_6_4.Multiline = true;
            this.postion_6_4.Name = "postion_6_4";
            this.postion_6_4.Size = new System.Drawing.Size(50, 50);
            this.postion_6_4.TabIndex = 0;
            // 
            // postion_6_5
            // 
            this.postion_6_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_6_5.Location = new System.Drawing.Point(256, 307);
            this.postion_6_5.Margin = new System.Windows.Forms.Padding(0);
            this.postion_6_5.Multiline = true;
            this.postion_6_5.Name = "postion_6_5";
            this.postion_6_5.Size = new System.Drawing.Size(50, 50);
            this.postion_6_5.TabIndex = 0;
            // 
            // postion_6_6
            // 
            this.postion_6_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_6_6.Location = new System.Drawing.Point(307, 307);
            this.postion_6_6.Margin = new System.Windows.Forms.Padding(0);
            this.postion_6_6.Multiline = true;
            this.postion_6_6.Name = "postion_6_6";
            this.postion_6_6.Size = new System.Drawing.Size(50, 50);
            this.postion_6_6.TabIndex = 0;
            // 
            // postion_6_7
            // 
            this.postion_6_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_6_7.Location = new System.Drawing.Point(358, 307);
            this.postion_6_7.Margin = new System.Windows.Forms.Padding(0);
            this.postion_6_7.Multiline = true;
            this.postion_6_7.Name = "postion_6_7";
            this.postion_6_7.Size = new System.Drawing.Size(50, 50);
            this.postion_6_7.TabIndex = 0;
            // 
            // postion_6_8
            // 
            this.postion_6_8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_6_8.Location = new System.Drawing.Point(409, 307);
            this.postion_6_8.Margin = new System.Windows.Forms.Padding(0);
            this.postion_6_8.Multiline = true;
            this.postion_6_8.Name = "postion_6_8";
            this.postion_6_8.Size = new System.Drawing.Size(50, 50);
            this.postion_6_8.TabIndex = 0;
            // 
            // postion_7_0
            // 
            this.postion_7_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_7_0.Location = new System.Drawing.Point(1, 358);
            this.postion_7_0.Margin = new System.Windows.Forms.Padding(0);
            this.postion_7_0.Multiline = true;
            this.postion_7_0.Name = "postion_7_0";
            this.postion_7_0.Size = new System.Drawing.Size(50, 50);
            this.postion_7_0.TabIndex = 0;
            // 
            // postion_7_1
            // 
            this.postion_7_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_7_1.Location = new System.Drawing.Point(52, 358);
            this.postion_7_1.Margin = new System.Windows.Forms.Padding(0);
            this.postion_7_1.Multiline = true;
            this.postion_7_1.Name = "postion_7_1";
            this.postion_7_1.Size = new System.Drawing.Size(50, 50);
            this.postion_7_1.TabIndex = 0;
            // 
            // postion_7_2
            // 
            this.postion_7_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_7_2.Location = new System.Drawing.Point(103, 358);
            this.postion_7_2.Margin = new System.Windows.Forms.Padding(0);
            this.postion_7_2.Multiline = true;
            this.postion_7_2.Name = "postion_7_2";
            this.postion_7_2.Size = new System.Drawing.Size(50, 50);
            this.postion_7_2.TabIndex = 0;
            // 
            // postion_7_3
            // 
            this.postion_7_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_7_3.Location = new System.Drawing.Point(154, 358);
            this.postion_7_3.Margin = new System.Windows.Forms.Padding(0);
            this.postion_7_3.Multiline = true;
            this.postion_7_3.Name = "postion_7_3";
            this.postion_7_3.Size = new System.Drawing.Size(50, 50);
            this.postion_7_3.TabIndex = 0;
            // 
            // postion_7_4
            // 
            this.postion_7_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_7_4.Location = new System.Drawing.Point(205, 358);
            this.postion_7_4.Margin = new System.Windows.Forms.Padding(0);
            this.postion_7_4.Multiline = true;
            this.postion_7_4.Name = "postion_7_4";
            this.postion_7_4.Size = new System.Drawing.Size(50, 50);
            this.postion_7_4.TabIndex = 0;
            // 
            // postion_7_5
            // 
            this.postion_7_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_7_5.Location = new System.Drawing.Point(256, 358);
            this.postion_7_5.Margin = new System.Windows.Forms.Padding(0);
            this.postion_7_5.Multiline = true;
            this.postion_7_5.Name = "postion_7_5";
            this.postion_7_5.Size = new System.Drawing.Size(50, 50);
            this.postion_7_5.TabIndex = 0;
            // 
            // postion_7_6
            // 
            this.postion_7_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_7_6.Location = new System.Drawing.Point(307, 358);
            this.postion_7_6.Margin = new System.Windows.Forms.Padding(0);
            this.postion_7_6.Multiline = true;
            this.postion_7_6.Name = "postion_7_6";
            this.postion_7_6.Size = new System.Drawing.Size(50, 50);
            this.postion_7_6.TabIndex = 0;
            // 
            // postion_7_7
            // 
            this.postion_7_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_7_7.Location = new System.Drawing.Point(358, 358);
            this.postion_7_7.Margin = new System.Windows.Forms.Padding(0);
            this.postion_7_7.Multiline = true;
            this.postion_7_7.Name = "postion_7_7";
            this.postion_7_7.Size = new System.Drawing.Size(50, 50);
            this.postion_7_7.TabIndex = 0;
            // 
            // postion_7_8
            // 
            this.postion_7_8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_7_8.Location = new System.Drawing.Point(409, 358);
            this.postion_7_8.Margin = new System.Windows.Forms.Padding(0);
            this.postion_7_8.Multiline = true;
            this.postion_7_8.Name = "postion_7_8";
            this.postion_7_8.Size = new System.Drawing.Size(50, 50);
            this.postion_7_8.TabIndex = 0;
            // 
            // postion_8_0
            // 
            this.postion_8_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_8_0.Location = new System.Drawing.Point(1, 409);
            this.postion_8_0.Margin = new System.Windows.Forms.Padding(0);
            this.postion_8_0.Multiline = true;
            this.postion_8_0.Name = "postion_8_0";
            this.postion_8_0.Size = new System.Drawing.Size(50, 50);
            this.postion_8_0.TabIndex = 0;
            // 
            // postion_8_1
            // 
            this.postion_8_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_8_1.Location = new System.Drawing.Point(52, 409);
            this.postion_8_1.Margin = new System.Windows.Forms.Padding(0);
            this.postion_8_1.Multiline = true;
            this.postion_8_1.Name = "postion_8_1";
            this.postion_8_1.Size = new System.Drawing.Size(50, 50);
            this.postion_8_1.TabIndex = 0;
            // 
            // postion_8_2
            // 
            this.postion_8_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_8_2.Location = new System.Drawing.Point(103, 409);
            this.postion_8_2.Margin = new System.Windows.Forms.Padding(0);
            this.postion_8_2.Multiline = true;
            this.postion_8_2.Name = "postion_8_2";
            this.postion_8_2.Size = new System.Drawing.Size(50, 50);
            this.postion_8_2.TabIndex = 0;
            // 
            // postion_8_3
            // 
            this.postion_8_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_8_3.Location = new System.Drawing.Point(154, 409);
            this.postion_8_3.Margin = new System.Windows.Forms.Padding(0);
            this.postion_8_3.Multiline = true;
            this.postion_8_3.Name = "postion_8_3";
            this.postion_8_3.Size = new System.Drawing.Size(50, 50);
            this.postion_8_3.TabIndex = 0;
            // 
            // postion_8_4
            // 
            this.postion_8_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_8_4.Location = new System.Drawing.Point(205, 409);
            this.postion_8_4.Margin = new System.Windows.Forms.Padding(0);
            this.postion_8_4.Multiline = true;
            this.postion_8_4.Name = "postion_8_4";
            this.postion_8_4.Size = new System.Drawing.Size(50, 50);
            this.postion_8_4.TabIndex = 0;
            // 
            // postion_8_5
            // 
            this.postion_8_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_8_5.Location = new System.Drawing.Point(256, 409);
            this.postion_8_5.Margin = new System.Windows.Forms.Padding(0);
            this.postion_8_5.Multiline = true;
            this.postion_8_5.Name = "postion_8_5";
            this.postion_8_5.Size = new System.Drawing.Size(50, 50);
            this.postion_8_5.TabIndex = 0;
            // 
            // postion_8_6
            // 
            this.postion_8_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_8_6.Location = new System.Drawing.Point(307, 409);
            this.postion_8_6.Margin = new System.Windows.Forms.Padding(0);
            this.postion_8_6.Multiline = true;
            this.postion_8_6.Name = "postion_8_6";
            this.postion_8_6.Size = new System.Drawing.Size(50, 50);
            this.postion_8_6.TabIndex = 0;
            // 
            // postion_8_7
            // 
            this.postion_8_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_8_7.Location = new System.Drawing.Point(358, 409);
            this.postion_8_7.Margin = new System.Windows.Forms.Padding(0);
            this.postion_8_7.Multiline = true;
            this.postion_8_7.Name = "postion_8_7";
            this.postion_8_7.Size = new System.Drawing.Size(50, 50);
            this.postion_8_7.TabIndex = 0;
            // 
            // postion_8_8
            // 
            this.postion_8_8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postion_8_8.Location = new System.Drawing.Point(409, 409);
            this.postion_8_8.Margin = new System.Windows.Forms.Padding(0);
            this.postion_8_8.Multiline = true;
            this.postion_8_8.Name = "postion_8_8";
            this.postion_8_8.Size = new System.Drawing.Size(50, 50);
            this.postion_8_8.TabIndex = 0;
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
