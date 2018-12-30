namespace SodukuUI
{
    partial class FrmColorConfig
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
            this.ctlColorConfig1 = new SodukuUserControls.ctlColorConfig();
            this.SuspendLayout();
            // 
            // ctlColorConfig1
            // 
            this.ctlColorConfig1.ForeColor = System.Drawing.Color.Coral;
            this.ctlColorConfig1.Location = new System.Drawing.Point(12, 50);
            this.ctlColorConfig1.Name = "ctlColorConfig1";
            this.ctlColorConfig1.Size = new System.Drawing.Size(307, 237);
            this.ctlColorConfig1.TabIndex = 0;
            // 
            // FrmColorConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 450);
            this.Controls.Add(this.ctlColorConfig1);
            this.Name = "FrmColorConfig";
            this.Text = "数独颜色配置";
            this.ResumeLayout(false);

        }

        #endregion

        private SodukuUserControls.ctlColorConfig ctlColorConfig1;
    }
}