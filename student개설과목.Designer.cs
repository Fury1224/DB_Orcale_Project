namespace WindowsFormsApplication1
{
    partial class student개설과목
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
            this.button신청 = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.dataGridView수강 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView개설과목)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView수강)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 13F);
            this.label5.Location = new System.Drawing.Point(866, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 90;
            this.label5.Text = "<교재>";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(779, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 236);
            this.pictureBox1.TabIndex = 89;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView개설과목
            // 
            this.dataGridView개설과목.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView개설과목.Location = new System.Drawing.Point(23, 57);
            this.dataGridView개설과목.Name = "dataGridView개설과목";
            this.dataGridView개설과목.ReadOnly = true;
            this.dataGridView개설과목.RowTemplate.Height = 23;
            this.dataGridView개설과목.Size = new System.Drawing.Size(736, 236);
            this.dataGridView개설과목.TabIndex = 88;
            this.dataGridView개설과목.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView개설과목_CellContentClick);
            // 
            // button신청
            // 
            this.button신청.Location = new System.Drawing.Point(779, 312);
            this.button신청.Name = "button신청";
            this.button신청.Size = new System.Drawing.Size(240, 41);
            this.button신청.TabIndex = 92;
            this.button신청.Text = "수강 신청";
            this.button신청.UseVisualStyleBackColor = true;
            this.button신청.Click += new System.EventHandler(this.button신청_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(934, 377);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(85, 32);
            this.backButton.TabIndex = 93;
            this.backButton.Text = "뒤로가기";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // dataGridView수강
            // 
            this.dataGridView수강.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView수강.Location = new System.Drawing.Point(23, 344);
            this.dataGridView수강.Name = "dataGridView수강";
            this.dataGridView수강.ReadOnly = true;
            this.dataGridView수강.RowTemplate.Height = 23;
            this.dataGridView수강.Size = new System.Drawing.Size(736, 236);
            this.dataGridView수강.TabIndex = 94;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F);
            this.label2.Location = new System.Drawing.Point(109, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 16);
            this.label2.TabIndex = 95;
            this.label2.Text = "수강 신청된 과목 리스트";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F);
            this.label1.Location = new System.Drawing.Point(109, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 96;
            this.label1.Text = "과목 리스트";
            // 
            // student개설과목
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 621);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView수강);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.button신청);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView개설과목);
            this.Name = "student개설과목";
            this.Text = "student개설과목";
            this.Load += new System.EventHandler(this.student개설과목_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView개설과목)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView수강)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView개설과목;
        private System.Windows.Forms.Button button신청;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView dataGridView수강;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}