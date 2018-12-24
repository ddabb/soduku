using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SodukuUI
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
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
            this.clue_0_0 = new SodukuUI.CtlNoticePanel();
            this.clue_0_1 = new SodukuUI.CtlNoticePanel();
            this.clue_0_2 = new SodukuUI.CtlNoticePanel();
            this.clue_0_3 = new SodukuUI.CtlNoticePanel();
            this.clue_0_4 = new SodukuUI.CtlNoticePanel();
            this.clue_0_5 = new SodukuUI.CtlNoticePanel();
            this.clue_0_6 = new SodukuUI.CtlNoticePanel();
            this.clue_0_7 = new SodukuUI.CtlNoticePanel();
            this.clue_0_8 = new SodukuUI.CtlNoticePanel();
            this.clue_1_0 = new SodukuUI.CtlNoticePanel();
            this.clue_1_1 = new SodukuUI.CtlNoticePanel();
            this.clue_1_2 = new SodukuUI.CtlNoticePanel();
            this.clue_1_3 = new SodukuUI.CtlNoticePanel();
            this.clue_1_4 = new SodukuUI.CtlNoticePanel();
            this.clue_1_5 = new SodukuUI.CtlNoticePanel();
            this.clue_1_6 = new SodukuUI.CtlNoticePanel();
            this.clue_1_7 = new SodukuUI.CtlNoticePanel();
            this.clue_1_8 = new SodukuUI.CtlNoticePanel();
            this.clue_2_0 = new SodukuUI.CtlNoticePanel();
            this.clue_2_1 = new SodukuUI.CtlNoticePanel();
            this.clue_2_2 = new SodukuUI.CtlNoticePanel();
            this.clue_2_3 = new SodukuUI.CtlNoticePanel();
            this.clue_2_4 = new SodukuUI.CtlNoticePanel();
            this.clue_2_5 = new SodukuUI.CtlNoticePanel();
            this.clue_2_6 = new SodukuUI.CtlNoticePanel();
            this.clue_2_7 = new SodukuUI.CtlNoticePanel();
            this.clue_2_8 = new SodukuUI.CtlNoticePanel();
            this.clue_3_0 = new SodukuUI.CtlNoticePanel();
            this.clue_3_1 = new SodukuUI.CtlNoticePanel();
            this.clue_3_2 = new SodukuUI.CtlNoticePanel();
            this.clue_3_3 = new SodukuUI.CtlNoticePanel();
            this.clue_3_4 = new SodukuUI.CtlNoticePanel();
            this.clue_3_5 = new SodukuUI.CtlNoticePanel();
            this.clue_3_6 = new SodukuUI.CtlNoticePanel();
            this.clue_3_7 = new SodukuUI.CtlNoticePanel();
            this.clue_3_8 = new SodukuUI.CtlNoticePanel();
            this.clue_4_0 = new SodukuUI.CtlNoticePanel();
            this.clue_4_1 = new SodukuUI.CtlNoticePanel();
            this.clue_4_2 = new SodukuUI.CtlNoticePanel();
            this.clue_4_3 = new SodukuUI.CtlNoticePanel();
            this.clue_4_4 = new SodukuUI.CtlNoticePanel();
            this.clue_4_5 = new SodukuUI.CtlNoticePanel();
            this.clue_4_6 = new SodukuUI.CtlNoticePanel();
            this.clue_4_7 = new SodukuUI.CtlNoticePanel();
            this.clue_4_8 = new SodukuUI.CtlNoticePanel();
            this.clue_5_0 = new SodukuUI.CtlNoticePanel();
            this.clue_5_1 = new SodukuUI.CtlNoticePanel();
            this.clue_5_2 = new SodukuUI.CtlNoticePanel();
            this.clue_5_3 = new SodukuUI.CtlNoticePanel();
            this.clue_5_4 = new SodukuUI.CtlNoticePanel();
            this.clue_5_5 = new SodukuUI.CtlNoticePanel();
            this.clue_5_6 = new SodukuUI.CtlNoticePanel();
            this.clue_5_7 = new SodukuUI.CtlNoticePanel();
            this.clue_5_8 = new SodukuUI.CtlNoticePanel();
            this.clue_6_0 = new SodukuUI.CtlNoticePanel();
            this.clue_6_1 = new SodukuUI.CtlNoticePanel();
            this.clue_6_2 = new SodukuUI.CtlNoticePanel();
            this.clue_6_3 = new SodukuUI.CtlNoticePanel();
            this.clue_6_4 = new SodukuUI.CtlNoticePanel();
            this.clue_6_5 = new SodukuUI.CtlNoticePanel();
            this.clue_6_6 = new SodukuUI.CtlNoticePanel();
            this.clue_6_7 = new SodukuUI.CtlNoticePanel();
            this.clue_6_8 = new SodukuUI.CtlNoticePanel();
            this.clue_7_0 = new SodukuUI.CtlNoticePanel();
            this.clue_7_1 = new SodukuUI.CtlNoticePanel();
            this.clue_7_2 = new SodukuUI.CtlNoticePanel();
            this.clue_7_3 = new SodukuUI.CtlNoticePanel();
            this.clue_7_4 = new SodukuUI.CtlNoticePanel();
            this.clue_7_5 = new SodukuUI.CtlNoticePanel();
            this.clue_7_6 = new SodukuUI.CtlNoticePanel();
            this.clue_7_7 = new SodukuUI.CtlNoticePanel();
            this.clue_7_8 = new SodukuUI.CtlNoticePanel();
            this.clue_8_0 = new SodukuUI.CtlNoticePanel();
            this.clue_8_1 = new SodukuUI.CtlNoticePanel();
            this.clue_8_2 = new SodukuUI.CtlNoticePanel();
            this.clue_8_3 = new SodukuUI.CtlNoticePanel();
            this.clue_8_4 = new SodukuUI.CtlNoticePanel();
            this.clue_8_5 = new SodukuUI.CtlNoticePanel();
            this.clue_8_6 = new SodukuUI.CtlNoticePanel();
            this.clue_8_7 = new SodukuUI.CtlNoticePanel();
            this.clue_8_8 = new SodukuUI.CtlNoticePanel();
            this.button1 = new System.Windows.Forms.Button();
            this.SolveSoduku = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.resultMessage = new System.Windows.Forms.TextBox();
            this.helpMessage = new System.Windows.Forms.TextBox();
            this.isShowHelp = new System.Windows.Forms.CheckBox();
            this.makeQuestion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.noticeNumber = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
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
            this.tableLayoutPanel1.Controls.Add(this.clue_0_0, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.clue_0_1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.clue_0_2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.clue_0_3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.clue_0_4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.clue_0_5, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.clue_0_6, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.clue_0_7, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.clue_0_8, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.clue_1_0, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.clue_1_1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.clue_1_2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.clue_1_3, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.clue_1_4, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.clue_1_5, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.clue_1_6, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.clue_1_7, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.clue_1_8, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.clue_2_0, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.clue_2_1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.clue_2_2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.clue_2_3, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.clue_2_4, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.clue_2_5, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.clue_2_6, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.clue_2_7, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.clue_2_8, 8, 2);
            this.tableLayoutPanel1.Controls.Add(this.clue_3_0, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.clue_3_1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.clue_3_2, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.clue_3_3, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.clue_3_4, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.clue_3_5, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.clue_3_6, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.clue_3_7, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.clue_3_8, 8, 3);
            this.tableLayoutPanel1.Controls.Add(this.clue_4_0, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.clue_4_1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.clue_4_2, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.clue_4_3, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.clue_4_4, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.clue_4_5, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.clue_4_6, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.clue_4_7, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.clue_4_8, 8, 4);
            this.tableLayoutPanel1.Controls.Add(this.clue_5_0, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.clue_5_1, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.clue_5_2, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.clue_5_3, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.clue_5_4, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.clue_5_5, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.clue_5_6, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.clue_5_7, 7, 5);
            this.tableLayoutPanel1.Controls.Add(this.clue_5_8, 8, 5);
            this.tableLayoutPanel1.Controls.Add(this.clue_6_0, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.clue_6_1, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.clue_6_2, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.clue_6_3, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.clue_6_4, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.clue_6_5, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.clue_6_6, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.clue_6_7, 7, 6);
            this.tableLayoutPanel1.Controls.Add(this.clue_6_8, 8, 6);
            this.tableLayoutPanel1.Controls.Add(this.clue_7_0, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.clue_7_1, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.clue_7_2, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.clue_7_3, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.clue_7_4, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.clue_7_5, 5, 7);
            this.tableLayoutPanel1.Controls.Add(this.clue_7_6, 6, 7);
            this.tableLayoutPanel1.Controls.Add(this.clue_7_7, 7, 7);
            this.tableLayoutPanel1.Controls.Add(this.clue_7_8, 8, 7);
            this.tableLayoutPanel1.Controls.Add(this.clue_8_0, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.clue_8_1, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.clue_8_2, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.clue_8_3, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.clue_8_4, 4, 8);
            this.tableLayoutPanel1.Controls.Add(this.clue_8_5, 5, 8);
            this.tableLayoutPanel1.Controls.Add(this.clue_8_6, 6, 8);
            this.tableLayoutPanel1.Controls.Add(this.clue_8_7, 7, 8);
            this.tableLayoutPanel1.Controls.Add(this.clue_8_8, 8, 8);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(34, 50);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(460, 460);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tableLayoutPanel1_CellPaint);
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawBorder);
            // 
            // postion_0_0
            // 
            this.postion_0_0.Location = new System.Drawing.Point(55, 4);
            this.postion_0_0.Name = "postion_0_0";
            this.postion_0_0.Size = new System.Drawing.Size(44, 25);
            this.postion_0_0.TabIndex = 0;
            // 
            // postion_0_1
            // 
            this.postion_0_1.Location = new System.Drawing.Point(106, 4);
            this.postion_0_1.Name = "postion_0_1";
            this.postion_0_1.Size = new System.Drawing.Size(44, 25);
            this.postion_0_1.TabIndex = 1;
            // 
            // postion_0_2
            // 
            this.postion_0_2.Location = new System.Drawing.Point(259, 4);
            this.postion_0_2.Name = "postion_0_2";
            this.postion_0_2.Size = new System.Drawing.Size(44, 25);
            this.postion_0_2.TabIndex = 2;
            // 
            // postion_0_3
            // 
            this.postion_0_3.Location = new System.Drawing.Point(310, 4);
            this.postion_0_3.Name = "postion_0_3";
            this.postion_0_3.Size = new System.Drawing.Size(44, 25);
            this.postion_0_3.TabIndex = 3;
            // 
            // postion_0_4
            // 
            this.postion_0_4.Location = new System.Drawing.Point(4, 55);
            this.postion_0_4.Name = "postion_0_4";
            this.postion_0_4.Size = new System.Drawing.Size(44, 25);
            this.postion_0_4.TabIndex = 4;
            // 
            // postion_0_5
            // 
            this.postion_0_5.Location = new System.Drawing.Point(106, 55);
            this.postion_0_5.Name = "postion_0_5";
            this.postion_0_5.Size = new System.Drawing.Size(44, 25);
            this.postion_0_5.TabIndex = 5;
            // 
            // postion_0_6
            // 
            this.postion_0_6.Location = new System.Drawing.Point(208, 55);
            this.postion_0_6.Name = "postion_0_6";
            this.postion_0_6.Size = new System.Drawing.Size(44, 25);
            this.postion_0_6.TabIndex = 6;
            // 
            // postion_0_7
            // 
            this.postion_0_7.Location = new System.Drawing.Point(259, 55);
            this.postion_0_7.Name = "postion_0_7";
            this.postion_0_7.Size = new System.Drawing.Size(44, 25);
            this.postion_0_7.TabIndex = 7;
            // 
            // postion_0_8
            // 
            this.postion_0_8.Location = new System.Drawing.Point(412, 55);
            this.postion_0_8.Name = "postion_0_8";
            this.postion_0_8.Size = new System.Drawing.Size(44, 25);
            this.postion_0_8.TabIndex = 8;
            // 
            // postion_1_0
            // 
            this.postion_1_0.Location = new System.Drawing.Point(4, 106);
            this.postion_1_0.Name = "postion_1_0";
            this.postion_1_0.Size = new System.Drawing.Size(44, 25);
            this.postion_1_0.TabIndex = 9;
            // 
            // postion_1_1
            // 
            this.postion_1_1.Location = new System.Drawing.Point(106, 106);
            this.postion_1_1.Name = "postion_1_1";
            this.postion_1_1.Size = new System.Drawing.Size(44, 25);
            this.postion_1_1.TabIndex = 10;
            // 
            // postion_1_2
            // 
            this.postion_1_2.Location = new System.Drawing.Point(259, 106);
            this.postion_1_2.Name = "postion_1_2";
            this.postion_1_2.Size = new System.Drawing.Size(44, 25);
            this.postion_1_2.TabIndex = 11;
            // 
            // postion_1_3
            // 
            this.postion_1_3.Location = new System.Drawing.Point(310, 106);
            this.postion_1_3.Name = "postion_1_3";
            this.postion_1_3.Size = new System.Drawing.Size(44, 25);
            this.postion_1_3.TabIndex = 12;
            // 
            // postion_1_4
            // 
            this.postion_1_4.Location = new System.Drawing.Point(4, 157);
            this.postion_1_4.Name = "postion_1_4";
            this.postion_1_4.Size = new System.Drawing.Size(44, 25);
            this.postion_1_4.TabIndex = 13;
            // 
            // postion_1_5
            // 
            this.postion_1_5.Location = new System.Drawing.Point(106, 157);
            this.postion_1_5.Name = "postion_1_5";
            this.postion_1_5.Size = new System.Drawing.Size(44, 25);
            this.postion_1_5.TabIndex = 14;
            // 
            // postion_1_6
            // 
            this.postion_1_6.Location = new System.Drawing.Point(208, 157);
            this.postion_1_6.Name = "postion_1_6";
            this.postion_1_6.Size = new System.Drawing.Size(44, 25);
            this.postion_1_6.TabIndex = 15;
            // 
            // postion_1_7
            // 
            this.postion_1_7.Location = new System.Drawing.Point(259, 157);
            this.postion_1_7.Name = "postion_1_7";
            this.postion_1_7.Size = new System.Drawing.Size(44, 25);
            this.postion_1_7.TabIndex = 16;
            // 
            // postion_1_8
            // 
            this.postion_1_8.Location = new System.Drawing.Point(412, 157);
            this.postion_1_8.Name = "postion_1_8";
            this.postion_1_8.Size = new System.Drawing.Size(44, 25);
            this.postion_1_8.TabIndex = 17;
            // 
            // postion_2_0
            // 
            this.postion_2_0.Location = new System.Drawing.Point(55, 208);
            this.postion_2_0.Name = "postion_2_0";
            this.postion_2_0.Size = new System.Drawing.Size(44, 25);
            this.postion_2_0.TabIndex = 18;
            // 
            // postion_2_1
            // 
            this.postion_2_1.Location = new System.Drawing.Point(157, 208);
            this.postion_2_1.Name = "postion_2_1";
            this.postion_2_1.Size = new System.Drawing.Size(44, 25);
            this.postion_2_1.TabIndex = 19;
            // 
            // postion_2_2
            // 
            this.postion_2_2.Location = new System.Drawing.Point(259, 208);
            this.postion_2_2.Name = "postion_2_2";
            this.postion_2_2.Size = new System.Drawing.Size(44, 25);
            this.postion_2_2.TabIndex = 20;
            // 
            // postion_2_3
            // 
            this.postion_2_3.Location = new System.Drawing.Point(361, 208);
            this.postion_2_3.Name = "postion_2_3";
            this.postion_2_3.Size = new System.Drawing.Size(44, 25);
            this.postion_2_3.TabIndex = 21;
            // 
            // postion_2_4
            // 
            this.postion_2_4.Location = new System.Drawing.Point(4, 259);
            this.postion_2_4.Name = "postion_2_4";
            this.postion_2_4.Size = new System.Drawing.Size(44, 25);
            this.postion_2_4.TabIndex = 22;
            // 
            // postion_2_5
            // 
            this.postion_2_5.Location = new System.Drawing.Point(106, 259);
            this.postion_2_5.Name = "postion_2_5";
            this.postion_2_5.Size = new System.Drawing.Size(44, 25);
            this.postion_2_5.TabIndex = 23;
            // 
            // postion_2_6
            // 
            this.postion_2_6.Location = new System.Drawing.Point(157, 259);
            this.postion_2_6.Name = "postion_2_6";
            this.postion_2_6.Size = new System.Drawing.Size(44, 25);
            this.postion_2_6.TabIndex = 24;
            // 
            // postion_2_7
            // 
            this.postion_2_7.Location = new System.Drawing.Point(259, 259);
            this.postion_2_7.Name = "postion_2_7";
            this.postion_2_7.Size = new System.Drawing.Size(44, 25);
            this.postion_2_7.TabIndex = 25;
            // 
            // postion_2_8
            // 
            this.postion_2_8.Location = new System.Drawing.Point(361, 259);
            this.postion_2_8.Name = "postion_2_8";
            this.postion_2_8.Size = new System.Drawing.Size(44, 25);
            this.postion_2_8.TabIndex = 26;
            // 
            // postion_3_0
            // 
            this.postion_3_0.Location = new System.Drawing.Point(55, 310);
            this.postion_3_0.Name = "postion_3_0";
            this.postion_3_0.Size = new System.Drawing.Size(44, 25);
            this.postion_3_0.TabIndex = 27;
            // 
            // postion_3_1
            // 
            this.postion_3_1.Location = new System.Drawing.Point(157, 310);
            this.postion_3_1.Name = "postion_3_1";
            this.postion_3_1.Size = new System.Drawing.Size(44, 25);
            this.postion_3_1.TabIndex = 28;
            // 
            // postion_3_2
            // 
            this.postion_3_2.Location = new System.Drawing.Point(208, 310);
            this.postion_3_2.Name = "postion_3_2";
            this.postion_3_2.Size = new System.Drawing.Size(44, 25);
            this.postion_3_2.TabIndex = 29;
            // 
            // postion_3_3
            // 
            this.postion_3_3.Location = new System.Drawing.Point(310, 310);
            this.postion_3_3.Name = "postion_3_3";
            this.postion_3_3.Size = new System.Drawing.Size(44, 25);
            this.postion_3_3.TabIndex = 30;
            // 
            // postion_3_4
            // 
            this.postion_3_4.Location = new System.Drawing.Point(412, 310);
            this.postion_3_4.Name = "postion_3_4";
            this.postion_3_4.Size = new System.Drawing.Size(44, 25);
            this.postion_3_4.TabIndex = 31;
            // 
            // postion_3_5
            // 
            this.postion_3_5.Location = new System.Drawing.Point(106, 361);
            this.postion_3_5.Name = "postion_3_5";
            this.postion_3_5.Size = new System.Drawing.Size(44, 25);
            this.postion_3_5.TabIndex = 32;
            // 
            // postion_3_6
            // 
            this.postion_3_6.Location = new System.Drawing.Point(157, 361);
            this.postion_3_6.Name = "postion_3_6";
            this.postion_3_6.Size = new System.Drawing.Size(44, 25);
            this.postion_3_6.TabIndex = 33;
            // 
            // postion_3_7
            // 
            this.postion_3_7.Location = new System.Drawing.Point(259, 361);
            this.postion_3_7.Name = "postion_3_7";
            this.postion_3_7.Size = new System.Drawing.Size(44, 25);
            this.postion_3_7.TabIndex = 34;
            // 
            // postion_3_8
            // 
            this.postion_3_8.Location = new System.Drawing.Point(412, 361);
            this.postion_3_8.Name = "postion_3_8";
            this.postion_3_8.Size = new System.Drawing.Size(44, 25);
            this.postion_3_8.TabIndex = 35;
            // 
            // postion_4_0
            // 
            this.postion_4_0.Location = new System.Drawing.Point(55, 412);
            this.postion_4_0.Name = "postion_4_0";
            this.postion_4_0.Size = new System.Drawing.Size(44, 25);
            this.postion_4_0.TabIndex = 36;
            // 
            // postion_4_1
            // 
            this.postion_4_1.Location = new System.Drawing.Point(157, 412);
            this.postion_4_1.Name = "postion_4_1";
            this.postion_4_1.Size = new System.Drawing.Size(44, 25);
            this.postion_4_1.TabIndex = 37;
            // 
            // postion_4_2
            // 
            this.postion_4_2.Location = new System.Drawing.Point(208, 412);
            this.postion_4_2.Name = "postion_4_2";
            this.postion_4_2.Size = new System.Drawing.Size(44, 25);
            this.postion_4_2.TabIndex = 38;
            // 
            // postion_4_3
            // 
            this.postion_4_3.Location = new System.Drawing.Point(310, 412);
            this.postion_4_3.Name = "postion_4_3";
            this.postion_4_3.Size = new System.Drawing.Size(44, 25);
            this.postion_4_3.TabIndex = 39;
            // 
            // postion_4_4
            // 
            this.postion_4_4.Location = new System.Drawing.Point(412, 412);
            this.postion_4_4.Name = "postion_4_4";
            this.postion_4_4.Size = new System.Drawing.Size(44, 25);
            this.postion_4_4.TabIndex = 40;
            // 
            // postion_4_5
            // 
            this.postion_4_5.Location = new System.Drawing.Point(106, 463);
            this.postion_4_5.Name = "postion_4_5";
            this.postion_4_5.Size = new System.Drawing.Size(44, 25);
            this.postion_4_5.TabIndex = 41;
            // 
            // postion_4_6
            // 
            this.postion_4_6.Location = new System.Drawing.Point(157, 463);
            this.postion_4_6.Name = "postion_4_6";
            this.postion_4_6.Size = new System.Drawing.Size(44, 25);
            this.postion_4_6.TabIndex = 42;
            // 
            // postion_4_7
            // 
            this.postion_4_7.Location = new System.Drawing.Point(259, 463);
            this.postion_4_7.Name = "postion_4_7";
            this.postion_4_7.Size = new System.Drawing.Size(44, 25);
            this.postion_4_7.TabIndex = 43;
            // 
            // postion_4_8
            // 
            this.postion_4_8.Location = new System.Drawing.Point(412, 463);
            this.postion_4_8.Name = "postion_4_8";
            this.postion_4_8.Size = new System.Drawing.Size(44, 25);
            this.postion_4_8.TabIndex = 44;
            // 
            // postion_5_0
            // 
            this.postion_5_0.Location = new System.Drawing.Point(4, 484);
            this.postion_5_0.Name = "postion_5_0";
            this.postion_5_0.Size = new System.Drawing.Size(44, 25);
            this.postion_5_0.TabIndex = 45;
            // 
            // postion_5_1
            // 
            this.postion_5_1.Location = new System.Drawing.Point(106, 484);
            this.postion_5_1.Name = "postion_5_1";
            this.postion_5_1.Size = new System.Drawing.Size(44, 25);
            this.postion_5_1.TabIndex = 46;
            // 
            // postion_5_2
            // 
            this.postion_5_2.Location = new System.Drawing.Point(208, 484);
            this.postion_5_2.Name = "postion_5_2";
            this.postion_5_2.Size = new System.Drawing.Size(44, 25);
            this.postion_5_2.TabIndex = 47;
            // 
            // postion_5_3
            // 
            this.postion_5_3.Location = new System.Drawing.Point(310, 484);
            this.postion_5_3.Name = "postion_5_3";
            this.postion_5_3.Size = new System.Drawing.Size(44, 25);
            this.postion_5_3.TabIndex = 48;
            // 
            // postion_5_4
            // 
            this.postion_5_4.Location = new System.Drawing.Point(4, 505);
            this.postion_5_4.Name = "postion_5_4";
            this.postion_5_4.Size = new System.Drawing.Size(44, 25);
            this.postion_5_4.TabIndex = 49;
            // 
            // postion_5_5
            // 
            this.postion_5_5.Location = new System.Drawing.Point(106, 505);
            this.postion_5_5.Name = "postion_5_5";
            this.postion_5_5.Size = new System.Drawing.Size(44, 25);
            this.postion_5_5.TabIndex = 50;
            // 
            // postion_5_6
            // 
            this.postion_5_6.Location = new System.Drawing.Point(208, 505);
            this.postion_5_6.Name = "postion_5_6";
            this.postion_5_6.Size = new System.Drawing.Size(44, 25);
            this.postion_5_6.TabIndex = 51;
            // 
            // postion_5_7
            // 
            this.postion_5_7.Location = new System.Drawing.Point(310, 505);
            this.postion_5_7.Name = "postion_5_7";
            this.postion_5_7.Size = new System.Drawing.Size(44, 25);
            this.postion_5_7.TabIndex = 52;
            // 
            // postion_5_8
            // 
            this.postion_5_8.Location = new System.Drawing.Point(412, 505);
            this.postion_5_8.Name = "postion_5_8";
            this.postion_5_8.Size = new System.Drawing.Size(44, 25);
            this.postion_5_8.TabIndex = 53;
            // 
            // postion_6_0
            // 
            this.postion_6_0.Location = new System.Drawing.Point(4, 526);
            this.postion_6_0.Name = "postion_6_0";
            this.postion_6_0.Size = new System.Drawing.Size(44, 25);
            this.postion_6_0.TabIndex = 54;
            // 
            // postion_6_1
            // 
            this.postion_6_1.Location = new System.Drawing.Point(106, 526);
            this.postion_6_1.Name = "postion_6_1";
            this.postion_6_1.Size = new System.Drawing.Size(44, 25);
            this.postion_6_1.TabIndex = 55;
            // 
            // postion_6_2
            // 
            this.postion_6_2.Location = new System.Drawing.Point(259, 526);
            this.postion_6_2.Name = "postion_6_2";
            this.postion_6_2.Size = new System.Drawing.Size(44, 25);
            this.postion_6_2.TabIndex = 56;
            // 
            // postion_6_3
            // 
            this.postion_6_3.Location = new System.Drawing.Point(310, 526);
            this.postion_6_3.Name = "postion_6_3";
            this.postion_6_3.Size = new System.Drawing.Size(44, 25);
            this.postion_6_3.TabIndex = 57;
            // 
            // postion_6_4
            // 
            this.postion_6_4.Location = new System.Drawing.Point(412, 526);
            this.postion_6_4.Name = "postion_6_4";
            this.postion_6_4.Size = new System.Drawing.Size(44, 25);
            this.postion_6_4.TabIndex = 58;
            // 
            // postion_6_5
            // 
            this.postion_6_5.Location = new System.Drawing.Point(106, 547);
            this.postion_6_5.Name = "postion_6_5";
            this.postion_6_5.Size = new System.Drawing.Size(44, 25);
            this.postion_6_5.TabIndex = 59;
            // 
            // postion_6_6
            // 
            this.postion_6_6.Location = new System.Drawing.Point(208, 547);
            this.postion_6_6.Name = "postion_6_6";
            this.postion_6_6.Size = new System.Drawing.Size(44, 25);
            this.postion_6_6.TabIndex = 60;
            // 
            // postion_6_7
            // 
            this.postion_6_7.Location = new System.Drawing.Point(310, 547);
            this.postion_6_7.Name = "postion_6_7";
            this.postion_6_7.Size = new System.Drawing.Size(44, 25);
            this.postion_6_7.TabIndex = 61;
            // 
            // postion_6_8
            // 
            this.postion_6_8.Location = new System.Drawing.Point(412, 547);
            this.postion_6_8.Name = "postion_6_8";
            this.postion_6_8.Size = new System.Drawing.Size(44, 25);
            this.postion_6_8.TabIndex = 62;
            // 
            // postion_7_0
            // 
            this.postion_7_0.Location = new System.Drawing.Point(4, 568);
            this.postion_7_0.Name = "postion_7_0";
            this.postion_7_0.Size = new System.Drawing.Size(44, 25);
            this.postion_7_0.TabIndex = 63;
            // 
            // postion_7_1
            // 
            this.postion_7_1.Location = new System.Drawing.Point(157, 568);
            this.postion_7_1.Name = "postion_7_1";
            this.postion_7_1.Size = new System.Drawing.Size(44, 25);
            this.postion_7_1.TabIndex = 64;
            // 
            // postion_7_2
            // 
            this.postion_7_2.Location = new System.Drawing.Point(208, 568);
            this.postion_7_2.Name = "postion_7_2";
            this.postion_7_2.Size = new System.Drawing.Size(44, 25);
            this.postion_7_2.TabIndex = 65;
            // 
            // postion_7_3
            // 
            this.postion_7_3.Location = new System.Drawing.Point(310, 568);
            this.postion_7_3.Name = "postion_7_3";
            this.postion_7_3.Size = new System.Drawing.Size(44, 25);
            this.postion_7_3.TabIndex = 66;
            // 
            // postion_7_4
            // 
            this.postion_7_4.Location = new System.Drawing.Point(4, 589);
            this.postion_7_4.Name = "postion_7_4";
            this.postion_7_4.Size = new System.Drawing.Size(44, 25);
            this.postion_7_4.TabIndex = 67;
            // 
            // postion_7_5
            // 
            this.postion_7_5.Location = new System.Drawing.Point(106, 589);
            this.postion_7_5.Name = "postion_7_5";
            this.postion_7_5.Size = new System.Drawing.Size(44, 25);
            this.postion_7_5.TabIndex = 68;
            // 
            // postion_7_6
            // 
            this.postion_7_6.Location = new System.Drawing.Point(157, 589);
            this.postion_7_6.Name = "postion_7_6";
            this.postion_7_6.Size = new System.Drawing.Size(44, 25);
            this.postion_7_6.TabIndex = 69;
            // 
            // postion_7_7
            // 
            this.postion_7_7.Location = new System.Drawing.Point(259, 589);
            this.postion_7_7.Name = "postion_7_7";
            this.postion_7_7.Size = new System.Drawing.Size(44, 25);
            this.postion_7_7.TabIndex = 70;
            // 
            // postion_7_8
            // 
            this.postion_7_8.Location = new System.Drawing.Point(412, 589);
            this.postion_7_8.Name = "postion_7_8";
            this.postion_7_8.Size = new System.Drawing.Size(44, 25);
            this.postion_7_8.TabIndex = 71;
            // 
            // postion_8_0
            // 
            this.postion_8_0.Location = new System.Drawing.Point(4, 610);
            this.postion_8_0.Name = "postion_8_0";
            this.postion_8_0.Size = new System.Drawing.Size(44, 25);
            this.postion_8_0.TabIndex = 72;
            // 
            // postion_8_1
            // 
            this.postion_8_1.Location = new System.Drawing.Point(157, 610);
            this.postion_8_1.Name = "postion_8_1";
            this.postion_8_1.Size = new System.Drawing.Size(44, 25);
            this.postion_8_1.TabIndex = 73;
            // 
            // postion_8_2
            // 
            this.postion_8_2.Location = new System.Drawing.Point(259, 610);
            this.postion_8_2.Name = "postion_8_2";
            this.postion_8_2.Size = new System.Drawing.Size(44, 25);
            this.postion_8_2.TabIndex = 74;
            // 
            // postion_8_3
            // 
            this.postion_8_3.Location = new System.Drawing.Point(310, 610);
            this.postion_8_3.Name = "postion_8_3";
            this.postion_8_3.Size = new System.Drawing.Size(44, 25);
            this.postion_8_3.TabIndex = 75;
            // 
            // postion_8_4
            // 
            this.postion_8_4.Location = new System.Drawing.Point(412, 610);
            this.postion_8_4.Name = "postion_8_4";
            this.postion_8_4.Size = new System.Drawing.Size(44, 25);
            this.postion_8_4.TabIndex = 76;
            // 
            // postion_8_5
            // 
            this.postion_8_5.Location = new System.Drawing.Point(55, 631);
            this.postion_8_5.Name = "postion_8_5";
            this.postion_8_5.Size = new System.Drawing.Size(44, 25);
            this.postion_8_5.TabIndex = 77;
            // 
            // postion_8_6
            // 
            this.postion_8_6.Location = new System.Drawing.Point(157, 631);
            this.postion_8_6.Name = "postion_8_6";
            this.postion_8_6.Size = new System.Drawing.Size(44, 25);
            this.postion_8_6.TabIndex = 78;
            // 
            // postion_8_7
            // 
            this.postion_8_7.Location = new System.Drawing.Point(259, 631);
            this.postion_8_7.Name = "postion_8_7";
            this.postion_8_7.Size = new System.Drawing.Size(44, 25);
            this.postion_8_7.TabIndex = 79;
            // 
            // postion_8_8
            // 
            this.postion_8_8.Location = new System.Drawing.Point(412, 631);
            this.postion_8_8.Name = "postion_8_8";
            this.postion_8_8.Size = new System.Drawing.Size(44, 25);
            this.postion_8_8.TabIndex = 80;
            // 
            // clue_0_0
            // 
            this.clue_0_0.BackColor = System.Drawing.Color.White;
            this.clue_0_0.Location = new System.Drawing.Point(3, 3);
            this.clue_0_0.Margin = new System.Windows.Forms.Padding(2);
            this.clue_0_0.Name = "clue_0_0";
            this.clue_0_0.Size = new System.Drawing.Size(38, 40);
            this.clue_0_0.TabIndex = 81;
            this.clue_0_0.Visible = false;
            // 
            // clue_0_1
            // 
            this.clue_0_1.BackColor = System.Drawing.Color.White;
            this.clue_0_1.Location = new System.Drawing.Point(156, 3);
            this.clue_0_1.Margin = new System.Windows.Forms.Padding(2);
            this.clue_0_1.Name = "clue_0_1";
            this.clue_0_1.Size = new System.Drawing.Size(38, 40);
            this.clue_0_1.TabIndex = 82;
            this.clue_0_1.Visible = false;
            // 
            // clue_0_2
            // 
            this.clue_0_2.BackColor = System.Drawing.Color.White;
            this.clue_0_2.Location = new System.Drawing.Point(207, 3);
            this.clue_0_2.Margin = new System.Windows.Forms.Padding(2);
            this.clue_0_2.Name = "clue_0_2";
            this.clue_0_2.Size = new System.Drawing.Size(38, 40);
            this.clue_0_2.TabIndex = 83;
            this.clue_0_2.Visible = false;
            // 
            // clue_0_3
            // 
            this.clue_0_3.BackColor = System.Drawing.Color.White;
            this.clue_0_3.Location = new System.Drawing.Point(360, 3);
            this.clue_0_3.Margin = new System.Windows.Forms.Padding(2);
            this.clue_0_3.Name = "clue_0_3";
            this.clue_0_3.Size = new System.Drawing.Size(38, 40);
            this.clue_0_3.TabIndex = 84;
            this.clue_0_3.Visible = false;
            // 
            // clue_0_4
            // 
            this.clue_0_4.BackColor = System.Drawing.Color.White;
            this.clue_0_4.Location = new System.Drawing.Point(411, 3);
            this.clue_0_4.Margin = new System.Windows.Forms.Padding(2);
            this.clue_0_4.Name = "clue_0_4";
            this.clue_0_4.Size = new System.Drawing.Size(38, 40);
            this.clue_0_4.TabIndex = 85;
            this.clue_0_4.Visible = false;
            // 
            // clue_0_5
            // 
            this.clue_0_5.BackColor = System.Drawing.Color.White;
            this.clue_0_5.Location = new System.Drawing.Point(54, 54);
            this.clue_0_5.Margin = new System.Windows.Forms.Padding(2);
            this.clue_0_5.Name = "clue_0_5";
            this.clue_0_5.Size = new System.Drawing.Size(38, 40);
            this.clue_0_5.TabIndex = 86;
            this.clue_0_5.Visible = false;
            // 
            // clue_0_6
            // 
            this.clue_0_6.BackColor = System.Drawing.Color.White;
            this.clue_0_6.Location = new System.Drawing.Point(156, 54);
            this.clue_0_6.Margin = new System.Windows.Forms.Padding(2);
            this.clue_0_6.Name = "clue_0_6";
            this.clue_0_6.Size = new System.Drawing.Size(38, 40);
            this.clue_0_6.TabIndex = 87;
            this.clue_0_6.Visible = false;
            // 
            // clue_0_7
            // 
            this.clue_0_7.BackColor = System.Drawing.Color.White;
            this.clue_0_7.Location = new System.Drawing.Point(309, 54);
            this.clue_0_7.Margin = new System.Windows.Forms.Padding(2);
            this.clue_0_7.Name = "clue_0_7";
            this.clue_0_7.Size = new System.Drawing.Size(38, 40);
            this.clue_0_7.TabIndex = 88;
            this.clue_0_7.Visible = false;
            // 
            // clue_0_8
            // 
            this.clue_0_8.BackColor = System.Drawing.Color.White;
            this.clue_0_8.Location = new System.Drawing.Point(360, 54);
            this.clue_0_8.Margin = new System.Windows.Forms.Padding(2);
            this.clue_0_8.Name = "clue_0_8";
            this.clue_0_8.Size = new System.Drawing.Size(38, 40);
            this.clue_0_8.TabIndex = 89;
            this.clue_0_8.Visible = false;
            // 
            // clue_1_0
            // 
            this.clue_1_0.BackColor = System.Drawing.Color.White;
            this.clue_1_0.Location = new System.Drawing.Point(54, 105);
            this.clue_1_0.Margin = new System.Windows.Forms.Padding(2);
            this.clue_1_0.Name = "clue_1_0";
            this.clue_1_0.Size = new System.Drawing.Size(38, 40);
            this.clue_1_0.TabIndex = 90;
            this.clue_1_0.Visible = false;
            // 
            // clue_1_1
            // 
            this.clue_1_1.BackColor = System.Drawing.Color.White;
            this.clue_1_1.Location = new System.Drawing.Point(156, 105);
            this.clue_1_1.Margin = new System.Windows.Forms.Padding(2);
            this.clue_1_1.Name = "clue_1_1";
            this.clue_1_1.Size = new System.Drawing.Size(38, 40);
            this.clue_1_1.TabIndex = 91;
            this.clue_1_1.Visible = false;
            // 
            // clue_1_2
            // 
            this.clue_1_2.BackColor = System.Drawing.Color.White;
            this.clue_1_2.Location = new System.Drawing.Point(207, 105);
            this.clue_1_2.Margin = new System.Windows.Forms.Padding(2);
            this.clue_1_2.Name = "clue_1_2";
            this.clue_1_2.Size = new System.Drawing.Size(38, 40);
            this.clue_1_2.TabIndex = 92;
            this.clue_1_2.Visible = false;
            // 
            // clue_1_3
            // 
            this.clue_1_3.BackColor = System.Drawing.Color.White;
            this.clue_1_3.Location = new System.Drawing.Point(360, 105);
            this.clue_1_3.Margin = new System.Windows.Forms.Padding(2);
            this.clue_1_3.Name = "clue_1_3";
            this.clue_1_3.Size = new System.Drawing.Size(38, 40);
            this.clue_1_3.TabIndex = 93;
            this.clue_1_3.Visible = false;
            // 
            // clue_1_4
            // 
            this.clue_1_4.BackColor = System.Drawing.Color.White;
            this.clue_1_4.Location = new System.Drawing.Point(411, 105);
            this.clue_1_4.Margin = new System.Windows.Forms.Padding(2);
            this.clue_1_4.Name = "clue_1_4";
            this.clue_1_4.Size = new System.Drawing.Size(38, 40);
            this.clue_1_4.TabIndex = 94;
            this.clue_1_4.Visible = false;
            // 
            // clue_1_5
            // 
            this.clue_1_5.BackColor = System.Drawing.Color.White;
            this.clue_1_5.Location = new System.Drawing.Point(54, 156);
            this.clue_1_5.Margin = new System.Windows.Forms.Padding(2);
            this.clue_1_5.Name = "clue_1_5";
            this.clue_1_5.Size = new System.Drawing.Size(38, 40);
            this.clue_1_5.TabIndex = 95;
            this.clue_1_5.Visible = false;
            // 
            // clue_1_6
            // 
            this.clue_1_6.BackColor = System.Drawing.Color.White;
            this.clue_1_6.Location = new System.Drawing.Point(156, 156);
            this.clue_1_6.Margin = new System.Windows.Forms.Padding(2);
            this.clue_1_6.Name = "clue_1_6";
            this.clue_1_6.Size = new System.Drawing.Size(38, 40);
            this.clue_1_6.TabIndex = 96;
            this.clue_1_6.Visible = false;
            // 
            // clue_1_7
            // 
            this.clue_1_7.BackColor = System.Drawing.Color.White;
            this.clue_1_7.Location = new System.Drawing.Point(309, 156);
            this.clue_1_7.Margin = new System.Windows.Forms.Padding(2);
            this.clue_1_7.Name = "clue_1_7";
            this.clue_1_7.Size = new System.Drawing.Size(38, 40);
            this.clue_1_7.TabIndex = 97;
            this.clue_1_7.Visible = false;
            // 
            // clue_1_8
            // 
            this.clue_1_8.BackColor = System.Drawing.Color.White;
            this.clue_1_8.Location = new System.Drawing.Point(360, 156);
            this.clue_1_8.Margin = new System.Windows.Forms.Padding(2);
            this.clue_1_8.Name = "clue_1_8";
            this.clue_1_8.Size = new System.Drawing.Size(38, 40);
            this.clue_1_8.TabIndex = 98;
            this.clue_1_8.Visible = false;
            // 
            // clue_2_0
            // 
            this.clue_2_0.BackColor = System.Drawing.Color.White;
            this.clue_2_0.Location = new System.Drawing.Point(3, 207);
            this.clue_2_0.Margin = new System.Windows.Forms.Padding(2);
            this.clue_2_0.Name = "clue_2_0";
            this.clue_2_0.Size = new System.Drawing.Size(38, 40);
            this.clue_2_0.TabIndex = 99;
            this.clue_2_0.Visible = false;
            // 
            // clue_2_1
            // 
            this.clue_2_1.BackColor = System.Drawing.Color.White;
            this.clue_2_1.Location = new System.Drawing.Point(105, 207);
            this.clue_2_1.Margin = new System.Windows.Forms.Padding(2);
            this.clue_2_1.Name = "clue_2_1";
            this.clue_2_1.Size = new System.Drawing.Size(38, 40);
            this.clue_2_1.TabIndex = 100;
            this.clue_2_1.Visible = false;
            // 
            // clue_2_2
            // 
            this.clue_2_2.BackColor = System.Drawing.Color.White;
            this.clue_2_2.Location = new System.Drawing.Point(207, 207);
            this.clue_2_2.Margin = new System.Windows.Forms.Padding(2);
            this.clue_2_2.Name = "clue_2_2";
            this.clue_2_2.Size = new System.Drawing.Size(38, 40);
            this.clue_2_2.TabIndex = 101;
            this.clue_2_2.Visible = false;
            // 
            // clue_2_3
            // 
            this.clue_2_3.BackColor = System.Drawing.Color.White;
            this.clue_2_3.Location = new System.Drawing.Point(309, 207);
            this.clue_2_3.Margin = new System.Windows.Forms.Padding(2);
            this.clue_2_3.Name = "clue_2_3";
            this.clue_2_3.Size = new System.Drawing.Size(38, 40);
            this.clue_2_3.TabIndex = 102;
            this.clue_2_3.Visible = false;
            // 
            // clue_2_4
            // 
            this.clue_2_4.BackColor = System.Drawing.Color.White;
            this.clue_2_4.Location = new System.Drawing.Point(411, 207);
            this.clue_2_4.Margin = new System.Windows.Forms.Padding(2);
            this.clue_2_4.Name = "clue_2_4";
            this.clue_2_4.Size = new System.Drawing.Size(38, 40);
            this.clue_2_4.TabIndex = 103;
            this.clue_2_4.Visible = false;
            // 
            // clue_2_5
            // 
            this.clue_2_5.BackColor = System.Drawing.Color.White;
            this.clue_2_5.Location = new System.Drawing.Point(54, 258);
            this.clue_2_5.Margin = new System.Windows.Forms.Padding(2);
            this.clue_2_5.Name = "clue_2_5";
            this.clue_2_5.Size = new System.Drawing.Size(38, 40);
            this.clue_2_5.TabIndex = 104;
            this.clue_2_5.Visible = false;
            // 
            // clue_2_6
            // 
            this.clue_2_6.BackColor = System.Drawing.Color.White;
            this.clue_2_6.Location = new System.Drawing.Point(207, 258);
            this.clue_2_6.Margin = new System.Windows.Forms.Padding(2);
            this.clue_2_6.Name = "clue_2_6";
            this.clue_2_6.Size = new System.Drawing.Size(38, 40);
            this.clue_2_6.TabIndex = 105;
            this.clue_2_6.Visible = false;
            // 
            // clue_2_7
            // 
            this.clue_2_7.BackColor = System.Drawing.Color.White;
            this.clue_2_7.Location = new System.Drawing.Point(309, 258);
            this.clue_2_7.Margin = new System.Windows.Forms.Padding(2);
            this.clue_2_7.Name = "clue_2_7";
            this.clue_2_7.Size = new System.Drawing.Size(38, 40);
            this.clue_2_7.TabIndex = 106;
            this.clue_2_7.Visible = false;
            // 
            // clue_2_8
            // 
            this.clue_2_8.BackColor = System.Drawing.Color.White;
            this.clue_2_8.Location = new System.Drawing.Point(411, 258);
            this.clue_2_8.Margin = new System.Windows.Forms.Padding(2);
            this.clue_2_8.Name = "clue_2_8";
            this.clue_2_8.Size = new System.Drawing.Size(38, 40);
            this.clue_2_8.TabIndex = 107;
            this.clue_2_8.Visible = false;
            // 
            // clue_3_0
            // 
            this.clue_3_0.BackColor = System.Drawing.Color.White;
            this.clue_3_0.Location = new System.Drawing.Point(3, 309);
            this.clue_3_0.Margin = new System.Windows.Forms.Padding(2);
            this.clue_3_0.Name = "clue_3_0";
            this.clue_3_0.Size = new System.Drawing.Size(38, 40);
            this.clue_3_0.TabIndex = 108;
            this.clue_3_0.Visible = false;
            // 
            // clue_3_1
            // 
            this.clue_3_1.BackColor = System.Drawing.Color.White;
            this.clue_3_1.Location = new System.Drawing.Point(105, 309);
            this.clue_3_1.Margin = new System.Windows.Forms.Padding(2);
            this.clue_3_1.Name = "clue_3_1";
            this.clue_3_1.Size = new System.Drawing.Size(38, 40);
            this.clue_3_1.TabIndex = 109;
            this.clue_3_1.Visible = false;
            // 
            // clue_3_2
            // 
            this.clue_3_2.BackColor = System.Drawing.Color.White;
            this.clue_3_2.Location = new System.Drawing.Point(258, 309);
            this.clue_3_2.Margin = new System.Windows.Forms.Padding(2);
            this.clue_3_2.Name = "clue_3_2";
            this.clue_3_2.Size = new System.Drawing.Size(38, 40);
            this.clue_3_2.TabIndex = 110;
            this.clue_3_2.Visible = false;
            // 
            // clue_3_3
            // 
            this.clue_3_3.BackColor = System.Drawing.Color.White;
            this.clue_3_3.Location = new System.Drawing.Point(360, 309);
            this.clue_3_3.Margin = new System.Windows.Forms.Padding(2);
            this.clue_3_3.Name = "clue_3_3";
            this.clue_3_3.Size = new System.Drawing.Size(38, 40);
            this.clue_3_3.TabIndex = 111;
            this.clue_3_3.Visible = false;
            // 
            // clue_3_4
            // 
            this.clue_3_4.BackColor = System.Drawing.Color.White;
            this.clue_3_4.Location = new System.Drawing.Point(3, 360);
            this.clue_3_4.Margin = new System.Windows.Forms.Padding(2);
            this.clue_3_4.Name = "clue_3_4";
            this.clue_3_4.Size = new System.Drawing.Size(38, 40);
            this.clue_3_4.TabIndex = 112;
            this.clue_3_4.Visible = false;
            // 
            // clue_3_5
            // 
            this.clue_3_5.BackColor = System.Drawing.Color.White;
            this.clue_3_5.Location = new System.Drawing.Point(54, 360);
            this.clue_3_5.Margin = new System.Windows.Forms.Padding(2);
            this.clue_3_5.Name = "clue_3_5";
            this.clue_3_5.Size = new System.Drawing.Size(38, 40);
            this.clue_3_5.TabIndex = 113;
            this.clue_3_5.Visible = false;
            // 
            // clue_3_6
            // 
            this.clue_3_6.BackColor = System.Drawing.Color.White;
            this.clue_3_6.Location = new System.Drawing.Point(207, 360);
            this.clue_3_6.Margin = new System.Windows.Forms.Padding(2);
            this.clue_3_6.Name = "clue_3_6";
            this.clue_3_6.Size = new System.Drawing.Size(38, 40);
            this.clue_3_6.TabIndex = 114;
            this.clue_3_6.Visible = false;
            // 
            // clue_3_7
            // 
            this.clue_3_7.BackColor = System.Drawing.Color.White;
            this.clue_3_7.Location = new System.Drawing.Point(309, 360);
            this.clue_3_7.Margin = new System.Windows.Forms.Padding(2);
            this.clue_3_7.Name = "clue_3_7";
            this.clue_3_7.Size = new System.Drawing.Size(38, 40);
            this.clue_3_7.TabIndex = 115;
            this.clue_3_7.Visible = false;
            // 
            // clue_3_8
            // 
            this.clue_3_8.BackColor = System.Drawing.Color.White;
            this.clue_3_8.Location = new System.Drawing.Point(360, 360);
            this.clue_3_8.Margin = new System.Windows.Forms.Padding(2);
            this.clue_3_8.Name = "clue_3_8";
            this.clue_3_8.Size = new System.Drawing.Size(38, 40);
            this.clue_3_8.TabIndex = 116;
            this.clue_3_8.Visible = false;
            // 
            // clue_4_0
            // 
            this.clue_4_0.BackColor = System.Drawing.Color.White;
            this.clue_4_0.Location = new System.Drawing.Point(3, 411);
            this.clue_4_0.Margin = new System.Windows.Forms.Padding(2);
            this.clue_4_0.Name = "clue_4_0";
            this.clue_4_0.Size = new System.Drawing.Size(38, 40);
            this.clue_4_0.TabIndex = 117;
            this.clue_4_0.Visible = false;
            // 
            // clue_4_1
            // 
            this.clue_4_1.BackColor = System.Drawing.Color.White;
            this.clue_4_1.Location = new System.Drawing.Point(105, 411);
            this.clue_4_1.Margin = new System.Windows.Forms.Padding(2);
            this.clue_4_1.Name = "clue_4_1";
            this.clue_4_1.Size = new System.Drawing.Size(38, 40);
            this.clue_4_1.TabIndex = 118;
            this.clue_4_1.Visible = false;
            // 
            // clue_4_2
            // 
            this.clue_4_2.BackColor = System.Drawing.Color.White;
            this.clue_4_2.Location = new System.Drawing.Point(258, 411);
            this.clue_4_2.Margin = new System.Windows.Forms.Padding(2);
            this.clue_4_2.Name = "clue_4_2";
            this.clue_4_2.Size = new System.Drawing.Size(38, 40);
            this.clue_4_2.TabIndex = 119;
            this.clue_4_2.Visible = false;
            // 
            // clue_4_3
            // 
            this.clue_4_3.BackColor = System.Drawing.Color.White;
            this.clue_4_3.Location = new System.Drawing.Point(360, 411);
            this.clue_4_3.Margin = new System.Windows.Forms.Padding(2);
            this.clue_4_3.Name = "clue_4_3";
            this.clue_4_3.Size = new System.Drawing.Size(38, 40);
            this.clue_4_3.TabIndex = 120;
            this.clue_4_3.Visible = false;
            // 
            // clue_4_4
            // 
            this.clue_4_4.BackColor = System.Drawing.Color.White;
            this.clue_4_4.Location = new System.Drawing.Point(3, 462);
            this.clue_4_4.Margin = new System.Windows.Forms.Padding(2);
            this.clue_4_4.Name = "clue_4_4";
            this.clue_4_4.Size = new System.Drawing.Size(38, 16);
            this.clue_4_4.TabIndex = 121;
            this.clue_4_4.Visible = false;
            // 
            // clue_4_5
            // 
            this.clue_4_5.BackColor = System.Drawing.Color.White;
            this.clue_4_5.Location = new System.Drawing.Point(54, 462);
            this.clue_4_5.Margin = new System.Windows.Forms.Padding(2);
            this.clue_4_5.Name = "clue_4_5";
            this.clue_4_5.Size = new System.Drawing.Size(38, 16);
            this.clue_4_5.TabIndex = 122;
            this.clue_4_5.Visible = false;
            // 
            // clue_4_6
            // 
            this.clue_4_6.BackColor = System.Drawing.Color.White;
            this.clue_4_6.Location = new System.Drawing.Point(207, 462);
            this.clue_4_6.Margin = new System.Windows.Forms.Padding(2);
            this.clue_4_6.Name = "clue_4_6";
            this.clue_4_6.Size = new System.Drawing.Size(38, 16);
            this.clue_4_6.TabIndex = 123;
            this.clue_4_6.Visible = false;
            // 
            // clue_4_7
            // 
            this.clue_4_7.BackColor = System.Drawing.Color.White;
            this.clue_4_7.Location = new System.Drawing.Point(309, 462);
            this.clue_4_7.Margin = new System.Windows.Forms.Padding(2);
            this.clue_4_7.Name = "clue_4_7";
            this.clue_4_7.Size = new System.Drawing.Size(38, 16);
            this.clue_4_7.TabIndex = 124;
            this.clue_4_7.Visible = false;
            // 
            // clue_4_8
            // 
            this.clue_4_8.BackColor = System.Drawing.Color.White;
            this.clue_4_8.Location = new System.Drawing.Point(360, 462);
            this.clue_4_8.Margin = new System.Windows.Forms.Padding(2);
            this.clue_4_8.Name = "clue_4_8";
            this.clue_4_8.Size = new System.Drawing.Size(38, 16);
            this.clue_4_8.TabIndex = 125;
            this.clue_4_8.Visible = false;
            // 
            // clue_5_0
            // 
            this.clue_5_0.BackColor = System.Drawing.Color.White;
            this.clue_5_0.Location = new System.Drawing.Point(54, 483);
            this.clue_5_0.Margin = new System.Windows.Forms.Padding(2);
            this.clue_5_0.Name = "clue_5_0";
            this.clue_5_0.Size = new System.Drawing.Size(38, 16);
            this.clue_5_0.TabIndex = 126;
            this.clue_5_0.Visible = false;
            // 
            // clue_5_1
            // 
            this.clue_5_1.BackColor = System.Drawing.Color.White;
            this.clue_5_1.Location = new System.Drawing.Point(156, 483);
            this.clue_5_1.Margin = new System.Windows.Forms.Padding(2);
            this.clue_5_1.Name = "clue_5_1";
            this.clue_5_1.Size = new System.Drawing.Size(38, 16);
            this.clue_5_1.TabIndex = 127;
            this.clue_5_1.Visible = false;
            // 
            // clue_5_2
            // 
            this.clue_5_2.BackColor = System.Drawing.Color.White;
            this.clue_5_2.Location = new System.Drawing.Point(258, 483);
            this.clue_5_2.Margin = new System.Windows.Forms.Padding(2);
            this.clue_5_2.Name = "clue_5_2";
            this.clue_5_2.Size = new System.Drawing.Size(38, 16);
            this.clue_5_2.TabIndex = 128;
            this.clue_5_2.Visible = false;
            // 
            // clue_5_3
            // 
            this.clue_5_3.BackColor = System.Drawing.Color.White;
            this.clue_5_3.Location = new System.Drawing.Point(360, 483);
            this.clue_5_3.Margin = new System.Windows.Forms.Padding(2);
            this.clue_5_3.Name = "clue_5_3";
            this.clue_5_3.Size = new System.Drawing.Size(38, 16);
            this.clue_5_3.TabIndex = 129;
            this.clue_5_3.Visible = false;
            // 
            // clue_5_4
            // 
            this.clue_5_4.BackColor = System.Drawing.Color.White;
            this.clue_5_4.Location = new System.Drawing.Point(411, 483);
            this.clue_5_4.Margin = new System.Windows.Forms.Padding(2);
            this.clue_5_4.Name = "clue_5_4";
            this.clue_5_4.Size = new System.Drawing.Size(38, 16);
            this.clue_5_4.TabIndex = 130;
            this.clue_5_4.Visible = false;
            // 
            // clue_5_5
            // 
            this.clue_5_5.BackColor = System.Drawing.Color.White;
            this.clue_5_5.Location = new System.Drawing.Point(54, 504);
            this.clue_5_5.Margin = new System.Windows.Forms.Padding(2);
            this.clue_5_5.Name = "clue_5_5";
            this.clue_5_5.Size = new System.Drawing.Size(38, 16);
            this.clue_5_5.TabIndex = 131;
            this.clue_5_5.Visible = false;
            // 
            // clue_5_6
            // 
            this.clue_5_6.BackColor = System.Drawing.Color.White;
            this.clue_5_6.Location = new System.Drawing.Point(156, 504);
            this.clue_5_6.Margin = new System.Windows.Forms.Padding(2);
            this.clue_5_6.Name = "clue_5_6";
            this.clue_5_6.Size = new System.Drawing.Size(38, 16);
            this.clue_5_6.TabIndex = 132;
            this.clue_5_6.Visible = false;
            // 
            // clue_5_7
            // 
            this.clue_5_7.BackColor = System.Drawing.Color.White;
            this.clue_5_7.Location = new System.Drawing.Point(258, 504);
            this.clue_5_7.Margin = new System.Windows.Forms.Padding(2);
            this.clue_5_7.Name = "clue_5_7";
            this.clue_5_7.Size = new System.Drawing.Size(38, 16);
            this.clue_5_7.TabIndex = 133;
            this.clue_5_7.Visible = false;
            // 
            // clue_5_8
            // 
            this.clue_5_8.BackColor = System.Drawing.Color.White;
            this.clue_5_8.Location = new System.Drawing.Point(360, 504);
            this.clue_5_8.Margin = new System.Windows.Forms.Padding(2);
            this.clue_5_8.Name = "clue_5_8";
            this.clue_5_8.Size = new System.Drawing.Size(38, 16);
            this.clue_5_8.TabIndex = 134;
            this.clue_5_8.Visible = false;
            // 
            // clue_6_0
            // 
            this.clue_6_0.BackColor = System.Drawing.Color.White;
            this.clue_6_0.Location = new System.Drawing.Point(54, 525);
            this.clue_6_0.Margin = new System.Windows.Forms.Padding(2);
            this.clue_6_0.Name = "clue_6_0";
            this.clue_6_0.Size = new System.Drawing.Size(38, 16);
            this.clue_6_0.TabIndex = 135;
            this.clue_6_0.Visible = false;
            // 
            // clue_6_1
            // 
            this.clue_6_1.BackColor = System.Drawing.Color.White;
            this.clue_6_1.Location = new System.Drawing.Point(156, 525);
            this.clue_6_1.Margin = new System.Windows.Forms.Padding(2);
            this.clue_6_1.Name = "clue_6_1";
            this.clue_6_1.Size = new System.Drawing.Size(38, 16);
            this.clue_6_1.TabIndex = 136;
            this.clue_6_1.Visible = false;
            // 
            // clue_6_2
            // 
            this.clue_6_2.BackColor = System.Drawing.Color.White;
            this.clue_6_2.Location = new System.Drawing.Point(207, 525);
            this.clue_6_2.Margin = new System.Windows.Forms.Padding(2);
            this.clue_6_2.Name = "clue_6_2";
            this.clue_6_2.Size = new System.Drawing.Size(38, 16);
            this.clue_6_2.TabIndex = 137;
            this.clue_6_2.Visible = false;
            // 
            // clue_6_3
            // 
            this.clue_6_3.BackColor = System.Drawing.Color.White;
            this.clue_6_3.Location = new System.Drawing.Point(360, 525);
            this.clue_6_3.Margin = new System.Windows.Forms.Padding(2);
            this.clue_6_3.Name = "clue_6_3";
            this.clue_6_3.Size = new System.Drawing.Size(38, 16);
            this.clue_6_3.TabIndex = 138;
            this.clue_6_3.Visible = false;
            // 
            // clue_6_4
            // 
            this.clue_6_4.BackColor = System.Drawing.Color.White;
            this.clue_6_4.Location = new System.Drawing.Point(3, 546);
            this.clue_6_4.Margin = new System.Windows.Forms.Padding(2);
            this.clue_6_4.Name = "clue_6_4";
            this.clue_6_4.Size = new System.Drawing.Size(38, 16);
            this.clue_6_4.TabIndex = 139;
            this.clue_6_4.Visible = false;
            // 
            // clue_6_5
            // 
            this.clue_6_5.BackColor = System.Drawing.Color.White;
            this.clue_6_5.Location = new System.Drawing.Point(54, 546);
            this.clue_6_5.Margin = new System.Windows.Forms.Padding(2);
            this.clue_6_5.Name = "clue_6_5";
            this.clue_6_5.Size = new System.Drawing.Size(38, 16);
            this.clue_6_5.TabIndex = 140;
            this.clue_6_5.Visible = false;
            // 
            // clue_6_6
            // 
            this.clue_6_6.BackColor = System.Drawing.Color.White;
            this.clue_6_6.Location = new System.Drawing.Point(156, 546);
            this.clue_6_6.Margin = new System.Windows.Forms.Padding(2);
            this.clue_6_6.Name = "clue_6_6";
            this.clue_6_6.Size = new System.Drawing.Size(38, 16);
            this.clue_6_6.TabIndex = 141;
            this.clue_6_6.Visible = false;
            // 
            // clue_6_7
            // 
            this.clue_6_7.BackColor = System.Drawing.Color.White;
            this.clue_6_7.Location = new System.Drawing.Point(258, 546);
            this.clue_6_7.Margin = new System.Windows.Forms.Padding(2);
            this.clue_6_7.Name = "clue_6_7";
            this.clue_6_7.Size = new System.Drawing.Size(38, 16);
            this.clue_6_7.TabIndex = 142;
            this.clue_6_7.Visible = false;
            // 
            // clue_6_8
            // 
            this.clue_6_8.BackColor = System.Drawing.Color.White;
            this.clue_6_8.Location = new System.Drawing.Point(360, 546);
            this.clue_6_8.Margin = new System.Windows.Forms.Padding(2);
            this.clue_6_8.Name = "clue_6_8";
            this.clue_6_8.Size = new System.Drawing.Size(38, 16);
            this.clue_6_8.TabIndex = 143;
            this.clue_6_8.Visible = false;
            // 
            // clue_7_0
            // 
            this.clue_7_0.BackColor = System.Drawing.Color.White;
            this.clue_7_0.Location = new System.Drawing.Point(54, 567);
            this.clue_7_0.Margin = new System.Windows.Forms.Padding(2);
            this.clue_7_0.Name = "clue_7_0";
            this.clue_7_0.Size = new System.Drawing.Size(38, 16);
            this.clue_7_0.TabIndex = 144;
            this.clue_7_0.Visible = false;
            // 
            // clue_7_1
            // 
            this.clue_7_1.BackColor = System.Drawing.Color.White;
            this.clue_7_1.Location = new System.Drawing.Point(105, 567);
            this.clue_7_1.Margin = new System.Windows.Forms.Padding(2);
            this.clue_7_1.Name = "clue_7_1";
            this.clue_7_1.Size = new System.Drawing.Size(38, 16);
            this.clue_7_1.TabIndex = 145;
            this.clue_7_1.Visible = false;
            // 
            // clue_7_2
            // 
            this.clue_7_2.BackColor = System.Drawing.Color.White;
            this.clue_7_2.Location = new System.Drawing.Point(258, 567);
            this.clue_7_2.Margin = new System.Windows.Forms.Padding(2);
            this.clue_7_2.Name = "clue_7_2";
            this.clue_7_2.Size = new System.Drawing.Size(38, 16);
            this.clue_7_2.TabIndex = 146;
            this.clue_7_2.Visible = false;
            // 
            // clue_7_3
            // 
            this.clue_7_3.BackColor = System.Drawing.Color.White;
            this.clue_7_3.Location = new System.Drawing.Point(360, 567);
            this.clue_7_3.Margin = new System.Windows.Forms.Padding(2);
            this.clue_7_3.Name = "clue_7_3";
            this.clue_7_3.Size = new System.Drawing.Size(38, 16);
            this.clue_7_3.TabIndex = 147;
            this.clue_7_3.Visible = false;
            // 
            // clue_7_4
            // 
            this.clue_7_4.BackColor = System.Drawing.Color.White;
            this.clue_7_4.Location = new System.Drawing.Point(411, 567);
            this.clue_7_4.Margin = new System.Windows.Forms.Padding(2);
            this.clue_7_4.Name = "clue_7_4";
            this.clue_7_4.Size = new System.Drawing.Size(38, 16);
            this.clue_7_4.TabIndex = 148;
            this.clue_7_4.Visible = false;
            // 
            // clue_7_5
            // 
            this.clue_7_5.BackColor = System.Drawing.Color.White;
            this.clue_7_5.Location = new System.Drawing.Point(54, 588);
            this.clue_7_5.Margin = new System.Windows.Forms.Padding(2);
            this.clue_7_5.Name = "clue_7_5";
            this.clue_7_5.Size = new System.Drawing.Size(38, 16);
            this.clue_7_5.TabIndex = 149;
            this.clue_7_5.Visible = false;
            // 
            // clue_7_6
            // 
            this.clue_7_6.BackColor = System.Drawing.Color.White;
            this.clue_7_6.Location = new System.Drawing.Point(207, 588);
            this.clue_7_6.Margin = new System.Windows.Forms.Padding(2);
            this.clue_7_6.Name = "clue_7_6";
            this.clue_7_6.Size = new System.Drawing.Size(38, 16);
            this.clue_7_6.TabIndex = 150;
            this.clue_7_6.Visible = false;
            // 
            // clue_7_7
            // 
            this.clue_7_7.BackColor = System.Drawing.Color.White;
            this.clue_7_7.Location = new System.Drawing.Point(309, 588);
            this.clue_7_7.Margin = new System.Windows.Forms.Padding(2);
            this.clue_7_7.Name = "clue_7_7";
            this.clue_7_7.Size = new System.Drawing.Size(38, 16);
            this.clue_7_7.TabIndex = 151;
            this.clue_7_7.Visible = false;
            // 
            // clue_7_8
            // 
            this.clue_7_8.BackColor = System.Drawing.Color.White;
            this.clue_7_8.Location = new System.Drawing.Point(360, 588);
            this.clue_7_8.Margin = new System.Windows.Forms.Padding(2);
            this.clue_7_8.Name = "clue_7_8";
            this.clue_7_8.Size = new System.Drawing.Size(38, 16);
            this.clue_7_8.TabIndex = 152;
            this.clue_7_8.Visible = false;
            // 
            // clue_8_0
            // 
            this.clue_8_0.BackColor = System.Drawing.Color.White;
            this.clue_8_0.Location = new System.Drawing.Point(54, 609);
            this.clue_8_0.Margin = new System.Windows.Forms.Padding(2);
            this.clue_8_0.Name = "clue_8_0";
            this.clue_8_0.Size = new System.Drawing.Size(38, 16);
            this.clue_8_0.TabIndex = 153;
            this.clue_8_0.Visible = false;
            // 
            // clue_8_1
            // 
            this.clue_8_1.BackColor = System.Drawing.Color.White;
            this.clue_8_1.Location = new System.Drawing.Point(105, 609);
            this.clue_8_1.Margin = new System.Windows.Forms.Padding(2);
            this.clue_8_1.Name = "clue_8_1";
            this.clue_8_1.Size = new System.Drawing.Size(38, 16);
            this.clue_8_1.TabIndex = 154;
            this.clue_8_1.Visible = false;
            // 
            // clue_8_2
            // 
            this.clue_8_2.BackColor = System.Drawing.Color.White;
            this.clue_8_2.Location = new System.Drawing.Point(207, 609);
            this.clue_8_2.Margin = new System.Windows.Forms.Padding(2);
            this.clue_8_2.Name = "clue_8_2";
            this.clue_8_2.Size = new System.Drawing.Size(38, 16);
            this.clue_8_2.TabIndex = 155;
            this.clue_8_2.Visible = false;
            // 
            // clue_8_3
            // 
            this.clue_8_3.BackColor = System.Drawing.Color.White;
            this.clue_8_3.Location = new System.Drawing.Point(360, 609);
            this.clue_8_3.Margin = new System.Windows.Forms.Padding(2);
            this.clue_8_3.Name = "clue_8_3";
            this.clue_8_3.Size = new System.Drawing.Size(38, 16);
            this.clue_8_3.TabIndex = 156;
            this.clue_8_3.Visible = false;
            // 
            // clue_8_4
            // 
            this.clue_8_4.BackColor = System.Drawing.Color.White;
            this.clue_8_4.Location = new System.Drawing.Point(3, 630);
            this.clue_8_4.Margin = new System.Windows.Forms.Padding(2);
            this.clue_8_4.Name = "clue_8_4";
            this.clue_8_4.Size = new System.Drawing.Size(38, 16);
            this.clue_8_4.TabIndex = 157;
            this.clue_8_4.Visible = false;
            // 
            // clue_8_5
            // 
            this.clue_8_5.BackColor = System.Drawing.Color.White;
            this.clue_8_5.Location = new System.Drawing.Point(105, 630);
            this.clue_8_5.Margin = new System.Windows.Forms.Padding(2);
            this.clue_8_5.Name = "clue_8_5";
            this.clue_8_5.Size = new System.Drawing.Size(38, 16);
            this.clue_8_5.TabIndex = 158;
            this.clue_8_5.Visible = false;
            // 
            // clue_8_6
            // 
            this.clue_8_6.BackColor = System.Drawing.Color.White;
            this.clue_8_6.Location = new System.Drawing.Point(207, 630);
            this.clue_8_6.Margin = new System.Windows.Forms.Padding(2);
            this.clue_8_6.Name = "clue_8_6";
            this.clue_8_6.Size = new System.Drawing.Size(38, 16);
            this.clue_8_6.TabIndex = 159;
            this.clue_8_6.Visible = false;
            // 
            // clue_8_7
            // 
            this.clue_8_7.BackColor = System.Drawing.Color.White;
            this.clue_8_7.Location = new System.Drawing.Point(309, 630);
            this.clue_8_7.Margin = new System.Windows.Forms.Padding(2);
            this.clue_8_7.Name = "clue_8_7";
            this.clue_8_7.Size = new System.Drawing.Size(38, 16);
            this.clue_8_7.TabIndex = 160;
            this.clue_8_7.Visible = false;
            // 
            // clue_8_8
            // 
            this.clue_8_8.BackColor = System.Drawing.Color.White;
            this.clue_8_8.Location = new System.Drawing.Point(360, 630);
            this.clue_8_8.Margin = new System.Windows.Forms.Padding(2);
            this.clue_8_8.Name = "clue_8_8";
            this.clue_8_8.Size = new System.Drawing.Size(38, 16);
            this.clue_8_8.TabIndex = 161;
            this.clue_8_8.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "生成数独";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SolveSoduku
            // 
            this.SolveSoduku.Location = new System.Drawing.Point(379, 12);
            this.SolveSoduku.Name = "SolveSoduku";
            this.SolveSoduku.Size = new System.Drawing.Size(75, 23);
            this.SolveSoduku.TabIndex = 1;
            this.SolveSoduku.Text = "解答数独";
            this.SolveSoduku.UseVisualStyleBackColor = true;
            this.SolveSoduku.Click += new System.EventHandler(this.SolveSoduku_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(689, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "开始游戏";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(298, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "导出数独";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(589, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "导入数独";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // resultMessage
            // 
            this.resultMessage.Location = new System.Drawing.Point(521, 370);
            this.resultMessage.Multiline = true;
            this.resultMessage.Name = "resultMessage";
            this.resultMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultMessage.Size = new System.Drawing.Size(339, 150);
            this.resultMessage.TabIndex = 5;
            this.resultMessage.Text = "结果信息";
            // 
            // helpMessage
            // 
            this.helpMessage.Location = new System.Drawing.Point(521, 155);
            this.helpMessage.Multiline = true;
            this.helpMessage.Name = "helpMessage";
            this.helpMessage.Size = new System.Drawing.Size(339, 147);
            this.helpMessage.TabIndex = 6;
            this.helpMessage.Text = "帮助信息";
            // 
            // isShowHelp
            // 
            this.isShowHelp.AutoSize = true;
            this.isShowHelp.Location = new System.Drawing.Point(523, 110);
            this.isShowHelp.Name = "isShowHelp";
            this.isShowHelp.Size = new System.Drawing.Size(89, 19);
            this.isShowHelp.TabIndex = 7;
            this.isShowHelp.Text = "一键提示";
            this.isShowHelp.UseVisualStyleBackColor = true;
            this.isShowHelp.CheckedChanged += new System.EventHandler(this.isShowHelp_CheckedChanged);
            // 
            // makeQuestion
            // 
            this.makeQuestion.Location = new System.Drawing.Point(191, 12);
            this.makeQuestion.Name = "makeQuestion";
            this.makeQuestion.Size = new System.Drawing.Size(106, 23);
            this.makeQuestion.TabIndex = 8;
            this.makeQuestion.Text = "出数独题目";
            this.makeQuestion.UseVisualStyleBackColor = true;
            this.makeQuestion.Click += new System.EventHandler(this.makeQuestion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(521, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "帮助信息：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "结果信息";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(524, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "提示数个数(最小17个)";
            // 
            // noticeNumber
            // 
            this.noticeNumber.Location = new System.Drawing.Point(689, 47);
            this.noticeNumber.Name = "noticeNumber";
            this.noticeNumber.Size = new System.Drawing.Size(100, 25);
            this.noticeNumber.TabIndex = 12;
            this.noticeNumber.Text = "30";
            this.noticeNumber.TextChanged += new System.EventHandler(this.noticeNumberChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(460, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "导出数独图片";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(526, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(526, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "实际提示数个数";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(110, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 16;
            this.button6.Text = "生成锯齿数独";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // FrmMain
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(919, 540);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.noticeNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.makeQuestion);
            this.Controls.Add(this.isShowHelp);
            this.Controls.Add(this.helpMessage);
            this.Controls.Add(this.resultMessage);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SolveSoduku);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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


        private CtlNoticePanel clue_0_0;
        private CtlNoticePanel clue_0_1;
        private CtlNoticePanel clue_0_2;
        private CtlNoticePanel clue_0_3;
        private CtlNoticePanel clue_0_4;
        private CtlNoticePanel clue_0_5;
        private CtlNoticePanel clue_0_6;
        private CtlNoticePanel clue_0_7;
        private CtlNoticePanel clue_0_8;
        private CtlNoticePanel clue_1_0;
        private CtlNoticePanel clue_1_1;
        private CtlNoticePanel clue_1_2;
        private CtlNoticePanel clue_1_3;
        private CtlNoticePanel clue_1_4;
        private CtlNoticePanel clue_1_5;
        private CtlNoticePanel clue_1_6;
        private CtlNoticePanel clue_1_7;
        private CtlNoticePanel clue_1_8;
        private CtlNoticePanel clue_2_0;
        private CtlNoticePanel clue_2_1;
        private CtlNoticePanel clue_2_2;
        private CtlNoticePanel clue_2_3;
        private CtlNoticePanel clue_2_4;
        private CtlNoticePanel clue_2_5;
        private CtlNoticePanel clue_2_6;
        private CtlNoticePanel clue_2_7;
        private CtlNoticePanel clue_2_8;
        private CtlNoticePanel clue_3_0;
        private CtlNoticePanel clue_3_1;
        private CtlNoticePanel clue_3_2;
        private CtlNoticePanel clue_3_3;
        private CtlNoticePanel clue_3_4;
        private CtlNoticePanel clue_3_5;
        private CtlNoticePanel clue_3_6;
        private CtlNoticePanel clue_3_7;
        private CtlNoticePanel clue_3_8;
        private CtlNoticePanel clue_4_0;
        private CtlNoticePanel clue_4_1;
        private CtlNoticePanel clue_4_2;
        private CtlNoticePanel clue_4_3;
        private CtlNoticePanel clue_4_4;
        private CtlNoticePanel clue_4_5;
        private CtlNoticePanel clue_4_6;
        private CtlNoticePanel clue_4_7;
        private CtlNoticePanel clue_4_8;
        private CtlNoticePanel clue_5_0;
        private CtlNoticePanel clue_5_1;
        private CtlNoticePanel clue_5_2;
        private CtlNoticePanel clue_5_3;
        private CtlNoticePanel clue_5_4;
        private CtlNoticePanel clue_5_5;
        private CtlNoticePanel clue_5_6;
        private CtlNoticePanel clue_5_7;
        private CtlNoticePanel clue_5_8;
        private CtlNoticePanel clue_6_0;
        private CtlNoticePanel clue_6_1;
        private CtlNoticePanel clue_6_2;
        private CtlNoticePanel clue_6_3;
        private CtlNoticePanel clue_6_4;
        private CtlNoticePanel clue_6_5;
        private CtlNoticePanel clue_6_6;
        private CtlNoticePanel clue_6_7;
        private CtlNoticePanel clue_6_8;
        private CtlNoticePanel clue_7_0;
        private CtlNoticePanel clue_7_1;
        private CtlNoticePanel clue_7_2;
        private CtlNoticePanel clue_7_3;
        private CtlNoticePanel clue_7_4;
        private CtlNoticePanel clue_7_5;
        private CtlNoticePanel clue_7_6;
        private CtlNoticePanel clue_7_7;
        private CtlNoticePanel clue_7_8;
        private CtlNoticePanel clue_8_0;
        private CtlNoticePanel clue_8_1;
        private CtlNoticePanel clue_8_2;
        private CtlNoticePanel clue_8_3;
        private CtlNoticePanel clue_8_4;
        private CtlNoticePanel clue_8_5;
        private CtlNoticePanel clue_8_6;
        private CtlNoticePanel clue_8_7;
        private CtlNoticePanel clue_8_8;

        private Button button1;
        private Button SolveSoduku;
        private Button button3;
        private Button button4;
        private Button button2;
        private TextBox resultMessage;
        private TextBox helpMessage;
        private Button makeQuestion;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox noticeNumber;
        private Button button5;
        private Label label4;
        private Label label5;
        private CheckBox isShowHelp;
        private Button button6;
    }
}
