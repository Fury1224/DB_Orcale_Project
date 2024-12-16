namespace WindowsFormsApplication1
{
    partial class AdminManageAll
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
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox학년별 = new System.Windows.Forms.ComboBox();
            this.comboBox학과별 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(932, 456);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(70, 42);
            this.updateButton.TabIndex = 44;
            this.updateButton.Text = "수정";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(856, 456);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(70, 42);
            this.deleteButton.TabIndex = 43;
            this.deleteButton.Text = "삭제";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(780, 456);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(70, 42);
            this.insertButton.TabIndex = 42;
            this.insertButton.Text = "삽입";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(831, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 21);
            this.textBox1.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(772, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 28;
            this.label1.Text = "라벨1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(743, 409);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(74, 477);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(549, 21);
            this.textBox9.TabIndex = 45;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(929, 28);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(73, 23);
            this.backButton.TabIndex = 46;
            this.backButton.Text = "뒤로가기";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 12F);
            this.label9.Location = new System.Drawing.Point(94, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 49;
            this.label9.Text = "학과별";
            this.label9.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(829, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 21);
            this.textBox2.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(770, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 50;
            this.label2.Text = "라벨2";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(829, 169);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(173, 21);
            this.textBox3.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(770, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 52;
            this.label3.Text = "라벨3";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(829, 224);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(173, 21);
            this.textBox4.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(770, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 54;
            this.label4.Text = "라벨4";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(829, 278);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(173, 21);
            this.textBox5.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(770, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 56;
            this.label5.Text = "라벨5";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(829, 339);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(173, 21);
            this.textBox6.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(770, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 58;
            this.label6.Text = "라벨6";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(829, 399);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(173, 21);
            this.textBox7.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(770, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 60;
            this.label7.Text = "라벨7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 12F);
            this.label8.Location = new System.Drawing.Point(315, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 62;
            this.label8.Text = "학년별";
            this.label8.Visible = false;
            // 
            // comboBox학년별
            // 
            this.comboBox학년별.FormattingEnabled = true;
            this.comboBox학년별.Location = new System.Drawing.Point(376, 18);
            this.comboBox학년별.Name = "comboBox학년별";
            this.comboBox학년별.Size = new System.Drawing.Size(136, 20);
            this.comboBox학년별.TabIndex = 63;
            this.comboBox학년별.Visible = false;
            this.comboBox학년별.SelectedIndexChanged += new System.EventHandler(this.comboBox학년별_SelectedIndexChanged);
            // 
            // comboBox학과별
            // 
            this.comboBox학과별.FormattingEnabled = true;
            this.comboBox학과별.Location = new System.Drawing.Point(155, 18);
            this.comboBox학과별.Name = "comboBox학과별";
            this.comboBox학과별.Size = new System.Drawing.Size(136, 20);
            this.comboBox학과별.TabIndex = 64;
            this.comboBox학과별.Visible = false;
            this.comboBox학과별.SelectedIndexChanged += new System.EventHandler(this.comboBox학과별_SelectedIndexChanged);
            // 
            // AdminManageAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 523);
            this.Controls.Add(this.comboBox학과별);
            this.Controls.Add(this.comboBox학년별);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminManageAll";
            this.Text = "AdminManage학과";
            this.Load += new System.EventHandler(this.AdminManage학과_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox학년별;
        private System.Windows.Forms.ComboBox comboBox학과별;
    }
}