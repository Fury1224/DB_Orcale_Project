namespace WindowsFormsApplication1
{
    partial class professor수강조회
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
            this.dataGridView수강 = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView수강)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView수강
            // 
            this.dataGridView수강.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView수강.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView수강.Location = new System.Drawing.Point(22, 33);
            this.dataGridView수강.Name = "dataGridView수강";
            this.dataGridView수강.ReadOnly = true;
            this.dataGridView수강.RowTemplate.Height = 23;
            this.dataGridView수강.Size = new System.Drawing.Size(575, 236);
            this.dataGridView수강.TabIndex = 95;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(514, 284);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(83, 30);
            this.backButton.TabIndex = 96;
            this.backButton.Text = "뒤로가기";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click_1);
            // 
            // professor수강조회
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 325);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dataGridView수강);
            this.Name = "professor수강조회";
            this.Text = "professor수강조회";
            this.Load += new System.EventHandler(this.professor수강조회_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView수강)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView수강;
        private System.Windows.Forms.Button backButton;
    }
}