namespace FlagsQuiz
{
    partial class Form1
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.Location = new System.Drawing.Point(74, 156);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(204, 30);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "Question";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQuestion.Click += new System.EventHandler(this.lblQuestion_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 2;
            this.button1.Tag = "1";
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(185, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 3;
            this.button2.Tag = "2";
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(77, 236);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 23);
            this.button3.TabIndex = 4;
            this.button3.Tag = "3";
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(185, 236);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 23);
            this.button4.TabIndex = 5;
            this.button4.Tag = "4";
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(120, 278);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 22);
            this.button5.TabIndex = 6;
            this.button5.Text = "Back to Main Menu";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FlagsQuiz.Properties.Resources._1200px_Question_mark__black__svg;
            this.pictureBox1.Location = new System.Drawing.Point(77, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 312);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Classic Flag Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

