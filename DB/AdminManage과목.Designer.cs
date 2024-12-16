namespace WindowsFormsApplication1
{
    partial class AdminManage과목
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
            this.dataGridView과목 = new System.Windows.Forms.DataGridView();
            this.textBox과목명 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox연도 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.textBox과목번호 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.dataGridView개설과목 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox교수명 = new System.Windows.Forms.ComboBox();
            this.button과목개설 = new System.Windows.Forms.Button();
            this.textBox학기 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView과목)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView개설과목)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView과목
            // 
            this.dataGridView과목.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView과목.Location = new System.Drawing.Point(26, 41);
            this.dataGridView과목.Name = "dataGridView과목";
            this.dataGridView과목.ReadOnly = true;
            this.dataGridView과목.RowTemplate.Height = 23;
            this.dataGridView과목.Size = new System.Drawing.Size(743, 236);
            this.dataGridView과목.TabIndex = 28;
            this.dataGridView과목.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView과목_CellContentClick);
            // 
            // textBox과목명
            // 
            this.textBox과목명.Location = new System.Drawing.Point(871, 89);
            this.textBox과목명.Name = "textBox과목명";
            this.textBox과목명.Size = new System.Drawing.Size(173, 21);
            this.textBox과목명.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(810, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 73;
            this.label6.Text = "과목명";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(798, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 69;
            this.label4.Text = "담당 교수";
            // 
            // textBox연도
            // 
            this.textBox연도.Location = new System.Drawing.Point(869, 139);
            this.textBox연도.Name = "textBox연도";
            this.textBox연도.Size = new System.Drawing.Size(173, 21);
            this.textBox연도.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(816, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 65;
            this.label2.Text = "연도";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(968, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(73, 23);
            this.backButton.TabIndex = 64;
            this.backButton.Text = "뒤로가기";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // textBox과목번호
            // 
            this.textBox과목번호.Location = new System.Drawing.Point(871, 42);
            this.textBox과목번호.Name = "textBox과목번호";
            this.textBox과목번호.Size = new System.Drawing.Size(173, 21);
            this.textBox과목번호.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(799, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 62;
            this.label1.Text = "과목 번호";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(26, 301);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(549, 21);
            this.textBox9.TabIndex = 77;
            // 
            // dataGridView개설과목
            // 
            this.dataGridView개설과목.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView개설과목.Location = new System.Drawing.Point(26, 373);
            this.dataGridView개설과목.Name = "dataGridView개설과목";
            this.dataGridView개설과목.ReadOnly = true;
            this.dataGridView개설과목.RowTemplate.Height = 23;
            this.dataGridView개설과목.Size = new System.Drawing.Size(743, 236);
            this.dataGridView개설과목.TabIndex = 78;
            this.dataGridView개설과목.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView개설과목_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 12F);
            this.label8.Location = new System.Drawing.Point(54, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 16);
            this.label8.TabIndex = 79;
            this.label8.Text = "과목 리스트";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 12F);
            this.label9.Location = new System.Drawing.Point(54, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 16);
            this.label9.TabIndex = 80;
            this.label9.Text = "개설 과목 리스트";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(815, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 67;
            this.label3.Text = "학기";
            // 
            // comboBox교수명
            // 
            this.comboBox교수명.FormattingEnabled = true;
            this.comboBox교수명.Location = new System.Drawing.Point(868, 237);
            this.comboBox교수명.Name = "comboBox교수명";
            this.comboBox교수명.Size = new System.Drawing.Size(173, 20);
            this.comboBox교수명.TabIndex = 83;
            // 
            // button과목개설
            // 
            this.button과목개설.Location = new System.Drawing.Point(814, 279);
            this.button과목개설.Name = "button과목개설";
            this.button과목개설.Size = new System.Drawing.Size(229, 43);
            this.button과목개설.TabIndex = 84;
            this.button과목개설.Text = "과목 개설하기";
            this.button과목개설.UseVisualStyleBackColor = true;
            this.button과목개설.Click += new System.EventHandler(this.button과목개설_Click);
            // 
            // textBox학기
            // 
            this.textBox학기.Location = new System.Drawing.Point(870, 189);
            this.textBox학기.Name = "textBox학기";
            this.textBox학기.Size = new System.Drawing.Size(173, 21);
            this.textBox학기.TabIndex = 85;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(801, 373);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 236);
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 13F);
            this.label5.Location = new System.Drawing.Point(888, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 87;
            this.label5.Text = "<교재>";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // AdminManage과목
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 742);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox학기);
            this.Controls.Add(this.button과목개설);
            this.Controls.Add(this.comboBox교수명);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView개설과목);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox과목명);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox연도);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.textBox과목번호);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView과목);
            this.Name = "AdminManage과목";
            this.Text = "AdminManage과목";
            this.Load += new System.EventHandler(this.AdminManage과목_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView과목)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView개설과목)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView과목;
        private System.Windows.Forms.TextBox textBox과목명;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox연도;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox textBox과목번호;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.DataGridView dataGridView개설과목;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox교수명;
        private System.Windows.Forms.Button button과목개설;
        private System.Windows.Forms.TextBox textBox학기;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}