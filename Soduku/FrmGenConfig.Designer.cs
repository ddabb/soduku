﻿namespace SodukuUI
{
    partial class FrmGenConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctlGenConfig1 = new SodukuUserControls.ctlGenConfig();
            this.SuspendLayout();
            // 
            // ctlGenConfig1
            // 
            this.ctlGenConfig1.Location = new System.Drawing.Point(6, 1);
            this.ctlGenConfig1.Name = "ctlGenConfig1";
            this.ctlGenConfig1.Size = new System.Drawing.Size(451, 441);
            this.ctlGenConfig1.TabIndex = 0;
            // 
            // FrmGenConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 500);
            this.Controls.Add(this.ctlGenConfig1);
            this.Name = "FrmGenConfig";
            this.Text = "数独生成配置";
            this.ResumeLayout(false);

        }

        #endregion

        private SodukuUserControls.ctlGenConfig ctlGenConfig1;
    }
}