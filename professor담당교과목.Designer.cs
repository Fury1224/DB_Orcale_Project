namespace WindowsFormsApplication1
{
    partial class professor담당교과목
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
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView개설과목 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label번호 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView개설과목)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 13F);
            this.label5.Location = new System.Drawing.Point(724, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 90;
            this.label5.Text = "<교재>";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(637, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 236);
            this.pictureBox1.TabIndex = 89;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView개설과목
            // 
            this.dataGridView개설과목.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView개설과목.Location = new System.Drawing.Point(33, 51);
            this.dataGridView개설과목.Name = "dataGridView개설과목";
            this.dataGridView개설과목.ReadOnly = true;
            this.dataGridView개설과목.RowTemplate.Height = 23;
            this.dataGridView개설과목.Size = new System.Drawing.Size(564, 236);
            this.dataGridView개설과목.TabIndex = 88;
            this.dataGridView개설과목.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView개설과목_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F);
            this.label1.Location = new System.Drawing.Point(75, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 91;
            this.label1.Text = "선택된 과목번호 :";
            // 
            // label번호
            // 
            this.label번호.AutoSize = true;
            this.label번호.Font = new System.Drawing.Font("굴림", 12F);
            this.label번호.Location = new System.Drawing.Point(215, 311);
            this.label번호.Name = "label번호";
            this.label번호.Size = new System.Drawing.Size(93, 16);
            this.label번호.TabIndex = 92;
            this.label번호.Text = "<과목번호>";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 24);
            this.button1.TabIndex = 93;
            this.button1.Text = "이미지 찾기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(570, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 24);
            this.button2.TabIndex = 94;
            this.button2.Text = "이미지 등록";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(770, 309);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(73, 23);
            this.backButton.TabIndex = 95;
            this.backButton.Text = "뒤로가기";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // professor담당교과목
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 363);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label번호);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView개설과목);
            this.Name = "professor담당교과목";
            this.Text = "professor담당교과목";
            this.Load += new System.EventHandler(this.professor담당교과목_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView개설과목)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView개설과목;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label번호;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button backButton;
    }
}