﻿namespace WindowsFormsApplication1
{
    partial class professorMenu
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "담당 교과목";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(74, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 73);
            this.button2.TabIndex = 1;
            this.button2.Text = "수강명부";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(74, 319);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 73);
            this.button3.TabIndex = 2;
            this.button3.Text = "성적입력";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(309, 63);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 73);
            this.button4.TabIndex = 3;
            this.button4.Text = "지도학생 정보";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(309, 265);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 73);
            this.button5.TabIndex = 4;
            this.button5.Text = "상담 작성";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(323, 344);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(93, 48);
            this.backButton.TabIndex = 65;
            this.backButton.Text = "뒤로가기";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(309, 167);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(117, 73);
            this.button6.TabIndex = 66;
            this.button6.Text = "상담 조회";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // professorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "professorMenu";
            this.Text = "professorMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button button6;
    }
}