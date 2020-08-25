namespace DTCEngine
{
    partial class RunThread
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
            this.height = new System.Windows.Forms.TextBox();
            this.width = new System.Windows.Forms.TextBox();
            this.framerate = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // height
            // 
            this.height.BackColor = System.Drawing.Color.Black;
            this.height.Location = new System.Drawing.Point(56, 46);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(100, 20);
            this.height.TabIndex = 0;
            this.height.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // width
            // 
            this.width.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.width.Location = new System.Drawing.Point(56, 92);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(100, 20);
            this.width.TabIndex = 1;
            this.width.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // framerate
            // 
            this.framerate.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.framerate.Location = new System.Drawing.Point(56, 136);
            this.framerate.Name = "framerate";
            this.framerate.Size = new System.Drawing.Size(100, 20);
            this.framerate.TabIndex = 2;
            this.framerate.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OK.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OK.Location = new System.Drawing.Point(81, 176);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 3;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DTCEngine.Properties.Resources.Sprite_00043;
            this.pictureBox1.Location = new System.Drawing.Point(160, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 74);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // RunThread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(321, 202);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.framerate);
            this.Controls.Add(this.width);
            this.Controls.Add(this.height);
            this.Name = "RunThread";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.TextBox framerate;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}