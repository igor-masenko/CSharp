namespace The_Life_Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();


            // pictureBox
            this.pictureBox.BackColor = System.Drawing.Color.FromArgb(255, 246, 212);
            this.pictureBox.Name = "FieldForPainting";
            this.pictureBox.Location = new System.Drawing.Point(200, 200);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.Size = new System.Drawing.Size(500, 500);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;

            //timer
            this.timer.Interval = 100;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);

            // Form1
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 1000);
            this.Text = "Form1";
            this.Controls.Add(this.pictureBox);
        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox;
        public System.Windows.Forms.Timer timer;
    }
}

