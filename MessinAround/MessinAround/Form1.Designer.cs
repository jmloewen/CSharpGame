namespace MessinAround
{
    partial class frmLoad
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
            this.components = new System.ComponentModel.Container();
            this.ticktimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ticktimer
            // 
            this.ticktimer.Enabled = true;
            this.ticktimer.Interval = 1000;
            this.ticktimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 661);
            this.MaximizeBox = false;
            this.Name = "frmLoad";
            this.Text = "The Form!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmLoad_Paint);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmLoad_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer ticktimer;
    }
}

