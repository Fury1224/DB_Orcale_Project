namespace WindowsFormsApplication1
{
    partial class JoinMenu
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
            this.button2 = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 76);
            this.button1.TabIndex = 0;
            this.button1.Text = "교수";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(210, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 76);
            this.button2.TabIndex = 1;
            this.button2.Text = "학생";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(303, 130);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(62, 36);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "뒤로가기";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "회원가입 유형을 선택해주세요";
            // 
            // JoinMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 177);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "JoinMenu";
            this.Text = "JoinMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label1;
    }
}