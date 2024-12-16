namespace WindowsFormsApplication1
{
    partial class AdminMenu
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
            this.selectButton = new System.Windows.Forms.Button();
            this.manageButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(30, 34);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(124, 81);
            this.selectButton.TabIndex = 0;
            this.selectButton.Text = "조회";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // manageButton
            // 
            this.manageButton.Location = new System.Drawing.Point(191, 34);
            this.manageButton.Name = "manageButton";
            this.manageButton.Size = new System.Drawing.Size(124, 81);
            this.manageButton.TabIndex = 1;
            this.manageButton.Text = "관리";
            this.manageButton.UseVisualStyleBackColor = true;
            this.manageButton.Click += new System.EventHandler(this.manageButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(30, 148);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 81);
            this.button3.TabIndex = 2;
            this.button3.Text = "개설과목 관리";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(191, 148);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 81);
            this.button4.TabIndex = 3;
            this.button4.Text = "권한 관리";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(331, 193);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(79, 36);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "뒤로가기";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 262);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.manageButton);
            this.Controls.Add(this.selectButton);
            this.Name = "AdminMenu";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button manageButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonBack;
    }
}