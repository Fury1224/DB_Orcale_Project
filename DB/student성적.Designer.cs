namespace WindowsFormsApplication1
{
    partial class student성적
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
            this.comboBox학기 = new System.Windows.Forms.ComboBox();
            this.comboBox연도 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView성적 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView성적)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(77, 197);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(101, 38);
            this.backButton.TabIndex = 66;
            this.backButton.Text = "뒤로가기";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 12);
            this.label5.TabIndex = 65;
            // 
            // comboBox학기
            // 
            this.comboBox학기.FormattingEnabled = true;
            this.comboBox학기.Location = new System.Drawing.Point(90, 116);
            this.comboBox학기.Name = "comboBox학기";
            this.comboBox학기.Size = new System.Drawing.Size(114, 20);
            this.comboBox학기.TabIndex = 63;
            this.comboBox학기.SelectedIndexChanged += new System.EventHandler(this.comboBox학기_SelectedIndexChanged);
            // 
            // comboBox연도
            // 
            this.comboBox연도.FormattingEnabled = true;
            this.comboBox연도.Location = new System.Drawing.Point(90, 79);
            this.comboBox연도.Name = "comboBox연도";
            this.comboBox연도.Size = new System.Drawing.Size(114, 20);
            this.comboBox연도.TabIndex = 62;
            this.comboBox연도.SelectedIndexChanged += new System.EventHandler(this.comboBox연도_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 60;
            this.label3.Text = "학기";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 59;
            this.label2.Text = "연도";
            // 
            // dataGridView성적
            // 
            this.dataGridView성적.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView성적.Location = new System.Drawing.Point(261, 27);
            this.dataGridView성적.Name = "dataGridView성적";
            this.dataGridView성적.RowTemplate.Height = 23;
            this.dataGridView성적.Size = new System.Drawing.Size(254, 262);
            this.dataGridView성적.TabIndex = 67;
            // 
            // student성적
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 347);
            this.Controls.Add(this.dataGridView성적);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox학기);
            this.Controls.Add(this.comboBox연도);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "student성적";
            this.Text = "student성적";
            this.Load += new System.EventHandler(this.student성적_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView성적)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox학기;
        private System.Windows.Forms.ComboBox comboBox연도;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView성적;
    }
}