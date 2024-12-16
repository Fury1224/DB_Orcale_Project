namespace WindowsFormsApplication1
{
    partial class AdminSelect
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
            this.tableList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox학과별 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox학년별 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.button학점 = new System.Windows.Forms.Button();
            this.button수강학점 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableList
            // 
            this.tableList.FormattingEnabled = true;
            this.tableList.Location = new System.Drawing.Point(92, 68);
            this.tableList.Name = "tableList";
            this.tableList.Size = new System.Drawing.Size(130, 20);
            this.tableList.TabIndex = 0;
            this.tableList.SelectedIndexChanged += new System.EventHandler(this.tableList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "테이블";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "학과별";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox학과별
            // 
            this.comboBox학과별.FormattingEnabled = true;
            this.comboBox학과별.Location = new System.Drawing.Point(92, 196);
            this.comboBox학과별.Name = "comboBox학과별";
            this.comboBox학과별.Size = new System.Drawing.Size(130, 20);
            this.comboBox학과별.TabIndex = 2;
            this.comboBox학과별.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "학년별";
            // 
            // comboBox학년별
            // 
            this.comboBox학년별.FormattingEnabled = true;
            this.comboBox학년별.Location = new System.Drawing.Point(92, 243);
            this.comboBox학년별.Name = "comboBox학년별";
            this.comboBox학년별.Size = new System.Drawing.Size(130, 20);
            this.comboBox학년별.TabIndex = 4;
            this.comboBox학년별.SelectedIndexChanged += new System.EventHandler(this.comboBox학년별_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(254, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(743, 404);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(73, 23);
            this.backButton.TabIndex = 47;
            this.backButton.Text = "뒤로가기";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // button학점
            // 
            this.button학점.Location = new System.Drawing.Point(74, 316);
            this.button학점.Name = "button학점";
            this.button학점.Size = new System.Drawing.Size(114, 34);
            this.button학점.TabIndex = 48;
            this.button학점.Text = "강의 학점 수 조회";
            this.button학점.UseVisualStyleBackColor = true;
            this.button학점.Visible = false;
            this.button학점.Click += new System.EventHandler(this.button학점_Click);
            // 
            // button수강학점
            // 
            this.button수강학점.Location = new System.Drawing.Point(74, 316);
            this.button수강학점.Name = "button수강학점";
            this.button수강학점.Size = new System.Drawing.Size(114, 34);
            this.button수강학점.TabIndex = 49;
            this.button수강학점.Text = "수강 학점 수 조회";
            this.button수강학점.UseVisualStyleBackColor = true;
            this.button수강학점.Visible = false;
            this.button수강학점.Click += new System.EventHandler(this.button수강학점_Click);
            // 
            // AdminSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 450);
            this.Controls.Add(this.button수강학점);
            this.Controls.Add(this.button학점);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox학년별);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox학과별);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableList);
            this.Name = "AdminSelect";
            this.Text = "AdminSelect";
            this.Load += new System.EventHandler(this.AdminSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tableList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox학과별;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox학년별;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button button학점;
        private System.Windows.Forms.Button button수강학점;
    }
}