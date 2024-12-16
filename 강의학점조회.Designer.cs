namespace WindowsFormsApplication1
{
    partial class 강의학점조회
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox교수 = new System.Windows.Forms.ComboBox();
            this.comboBox연도 = new System.Windows.Forms.ComboBox();
            this.comboBox학기 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "조회할 교수";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "연도";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "학기";
            // 
            // comboBox교수
            // 
            this.comboBox교수.FormattingEnabled = true;
            this.comboBox교수.Location = new System.Drawing.Point(146, 18);
            this.comboBox교수.Name = "comboBox교수";
            this.comboBox교수.Size = new System.Drawing.Size(114, 20);
            this.comboBox교수.TabIndex = 3;
            this.comboBox교수.SelectedIndexChanged += new System.EventHandler(this.comboBox교수_SelectedIndexChanged);
            // 
            // comboBox연도
            // 
            this.comboBox연도.FormattingEnabled = true;
            this.comboBox연도.Location = new System.Drawing.Point(146, 57);
            this.comboBox연도.Name = "comboBox연도";
            this.comboBox연도.Size = new System.Drawing.Size(114, 20);
            this.comboBox연도.TabIndex = 4;
            this.comboBox연도.SelectedIndexChanged += new System.EventHandler(this.comboBox연도_SelectedIndexChanged);
            // 
            // comboBox학기
            // 
            this.comboBox학기.FormattingEnabled = true;
            this.comboBox학기.Location = new System.Drawing.Point(146, 94);
            this.comboBox학기.Name = "comboBox학기";
            this.comboBox학기.Size = new System.Drawing.Size(114, 20);
            this.comboBox학기.TabIndex = 5;
            this.comboBox학기.SelectedIndexChanged += new System.EventHandler(this.comboBox학기_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "해당 학기의 강의 학점 수 = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 12);
            this.label5.TabIndex = 7;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(109, 161);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(73, 23);
            this.backButton.TabIndex = 48;
            this.backButton.Text = "뒤로가기";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // 강의학점조회
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 202);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox학기);
            this.Controls.Add(this.comboBox연도);
            this.Controls.Add(this.comboBox교수);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "강의학점조회";
            this.Text = "강의학점수_조회";
            this.Load += new System.EventHandler(this.강의학점수_조회_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox교수;
        private System.Windows.Forms.ComboBox comboBox연도;
        private System.Windows.Forms.ComboBox comboBox학기;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button backButton;
    }
}