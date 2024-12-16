namespace WindowsFormsApplication1
{
    partial class JoinStudent
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
            this.comboBox학과 = new System.Windows.Forms.ComboBox();
            this.textBox이름 = new System.Windows.Forms.TextBox();
            this.textBox학번 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox교수 = new System.Windows.Forms.ComboBox();
            this.comboBox학년 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 36);
            this.button1.TabIndex = 18;
            this.button1.Text = "가입";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox학과
            // 
            this.comboBox학과.FormattingEnabled = true;
            this.comboBox학과.Location = new System.Drawing.Point(134, 183);
            this.comboBox학과.Name = "comboBox학과";
            this.comboBox학과.Size = new System.Drawing.Size(165, 20);
            this.comboBox학과.TabIndex = 17;
            this.comboBox학과.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox이름
            // 
            this.textBox이름.Location = new System.Drawing.Point(135, 83);
            this.textBox이름.Name = "textBox이름";
            this.textBox이름.Size = new System.Drawing.Size(164, 21);
            this.textBox이름.TabIndex = 16;
            // 
            // textBox학번
            // 
            this.textBox학번.Location = new System.Drawing.Point(135, 30);
            this.textBox학번.Name = "textBox학번";
            this.textBox학번.Size = new System.Drawing.Size(164, 21);
            this.textBox학번.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F);
            this.label3.Location = new System.Drawing.Point(30, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "학과이름";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F);
            this.label2.Location = new System.Drawing.Point(62, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "이름";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F);
            this.label1.Location = new System.Drawing.Point(62, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "학번";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(65, 270);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(62, 36);
            this.buttonBack.TabIndex = 11;
            this.buttonBack.Text = "뒤로가기";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F);
            this.label4.Location = new System.Drawing.Point(62, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "학년";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F);
            this.label5.Location = new System.Drawing.Point(31, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "지도교수";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // comboBox교수
            // 
            this.comboBox교수.FormattingEnabled = true;
            this.comboBox교수.Location = new System.Drawing.Point(134, 227);
            this.comboBox교수.Name = "comboBox교수";
            this.comboBox교수.Size = new System.Drawing.Size(165, 20);
            this.comboBox교수.TabIndex = 22;
            this.comboBox교수.SelectedIndexChanged += new System.EventHandler(this.comboBox교수_SelectedIndexChanged);
            // 
            // comboBox학년
            // 
            this.comboBox학년.FormattingEnabled = true;
            this.comboBox학년.Location = new System.Drawing.Point(134, 134);
            this.comboBox학년.Name = "comboBox학년";
            this.comboBox학년.Size = new System.Drawing.Size(165, 20);
            this.comboBox학년.TabIndex = 23;
            this.comboBox학년.SelectedIndexChanged += new System.EventHandler(this.comboBox학년_SelectedIndexChanged);
            // 
            // JoinStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 330);
            this.Controls.Add(this.comboBox학년);
            this.Controls.Add(this.comboBox교수);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox학과);
            this.Controls.Add(this.textBox이름);
            this.Controls.Add(this.textBox학번);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBack);
            this.Name = "JoinStudent";
            this.Text = "JoinStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox학과;
        private System.Windows.Forms.TextBox textBox이름;
        private System.Windows.Forms.TextBox textBox학번;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox교수;
        private System.Windows.Forms.ComboBox comboBox학년;
    }
}