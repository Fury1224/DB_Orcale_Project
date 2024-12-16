namespace WindowsFormsApplication1
{
    partial class 수강학점조회
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
            this.backButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox학기 = new System.Windows.Forms.ComboBox();
            this.comboBox연도 = new System.Windows.Forms.ComboBox();
            this.comboBox학생 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(90, 169);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(73, 23);
            this.backButton.TabIndex = 57;
            this.backButton.Text = "뒤로가기";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 12);
            this.label5.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 12);
            this.label4.TabIndex = 55;
            this.label4.Text = "해당 학기의 수강 학점 수 = ";
            // 
            // comboBox학기
            // 
            this.comboBox학기.FormattingEnabled = true;
            this.comboBox학기.Location = new System.Drawing.Point(121, 96);
            this.comboBox학기.Name = "comboBox학기";
            this.comboBox학기.Size = new System.Drawing.Size(114, 20);
            this.comboBox학기.TabIndex = 54;
            this.comboBox학기.SelectedIndexChanged += new System.EventHandler(this.comboBox학기_SelectedIndexChanged);
            // 
            // comboBox연도
            // 
            this.comboBox연도.FormattingEnabled = true;
            this.comboBox연도.Location = new System.Drawing.Point(121, 59);
            this.comboBox연도.Name = "comboBox연도";
            this.comboBox연도.Size = new System.Drawing.Size(114, 20);
            this.comboBox연도.TabIndex = 53;
            this.comboBox연도.SelectedIndexChanged += new System.EventHandler(this.comboBox연도_SelectedIndexChanged);
            // 
            // comboBox학생
            // 
            this.comboBox학생.FormattingEnabled = true;
            this.comboBox학생.Location = new System.Drawing.Point(121, 20);
            this.comboBox학생.Name = "comboBox학생";
            this.comboBox학생.Size = new System.Drawing.Size(114, 20);
            this.comboBox학생.TabIndex = 52;
            this.comboBox학생.SelectedIndexChanged += new System.EventHandler(this.comboBox학생_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 51;
            this.label3.Text = "학기";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 50;
            this.label2.Text = "연도";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 49;
            this.label1.Text = "조회할 학생";
            // 
            // 수강학점조회
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 204);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox학기);
            this.Controls.Add(this.comboBox연도);
            this.Controls.Add(this.comboBox학생);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "수강학점조회";
            this.Text = "수강학점조회";
            this.Load += new System.EventHandler(this.수강학점조회_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox학기;
        private System.Windows.Forms.ComboBox comboBox연도;
        private System.Windows.Forms.ComboBox comboBox학생;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}