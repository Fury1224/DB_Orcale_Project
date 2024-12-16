namespace WindowsFormsApplication1
{
    partial class professor지도학생
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.comboBox학년별 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(452, 260);
            this.dataGridView1.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(521, 179);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(104, 55);
            this.backButton.TabIndex = 49;
            this.backButton.Text = "뒤로가기";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // comboBox학년별
            // 
            this.comboBox학년별.FormattingEnabled = true;
            this.comboBox학년별.Location = new System.Drawing.Point(548, 66);
            this.comboBox학년별.Name = "comboBox학년별";
            this.comboBox학년별.Size = new System.Drawing.Size(93, 20);
            this.comboBox학년별.TabIndex = 65;
            this.comboBox학년별.SelectedIndexChanged += new System.EventHandler(this.comboBox학년별_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 12F);
            this.label8.Location = new System.Drawing.Point(487, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 64;
            this.label8.Text = "학년별";
            // 
            // professor지도학생
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 284);
            this.Controls.Add(this.comboBox학년별);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "professor지도학생";
            this.Text = "professor지도학생";
            this.Load += new System.EventHandler(this.professor지도학생_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ComboBox comboBox학년별;
        private System.Windows.Forms.Label label8;
    }
}