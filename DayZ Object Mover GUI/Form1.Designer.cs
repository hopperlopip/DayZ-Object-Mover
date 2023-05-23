namespace DayZ_Object_Mover_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.OpenButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.FileOpenLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox_X = new System.Windows.Forms.TextBox();
            this.OffsetX = new System.Windows.Forms.Label();
            this.OffsetY = new System.Windows.Forms.Label();
            this.textBox_Y = new System.Windows.Forms.TextBox();
            this.StartAndSaveButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(216, 48);
            this.OpenButton.Margin = new System.Windows.Forms.Padding(2);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(66, 27);
            this.OpenButton.TabIndex = 0;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 20);
            this.textBox1.TabIndex = 1;
            // 
            // FileOpenLabel
            // 
            this.FileOpenLabel.AutoSize = true;
            this.FileOpenLabel.Location = new System.Drawing.Point(9, 23);
            this.FileOpenLabel.Name = "FileOpenLabel";
            this.FileOpenLabel.Size = new System.Drawing.Size(236, 13);
            this.FileOpenLabel.TabIndex = 2;
            this.FileOpenLabel.Text = "Type path to your file or press the \"Open\" button";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 199);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(269, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // textBox_X
            // 
            this.textBox_X.Location = new System.Drawing.Point(63, 86);
            this.textBox_X.Name = "textBox_X";
            this.textBox_X.Size = new System.Drawing.Size(218, 20);
            this.textBox_X.TabIndex = 4;
            this.textBox_X.TextChanged += new System.EventHandler(this.textBox_X_TextChanged);
            // 
            // OffsetX
            // 
            this.OffsetX.AutoSize = true;
            this.OffsetX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OffsetX.Location = new System.Drawing.Point(12, 89);
            this.OffsetX.Name = "OffsetX";
            this.OffsetX.Size = new System.Drawing.Size(45, 13);
            this.OffsetX.TabIndex = 5;
            this.OffsetX.Text = "Offset X";
            // 
            // OffsetY
            // 
            this.OffsetY.AutoSize = true;
            this.OffsetY.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OffsetY.Location = new System.Drawing.Point(12, 126);
            this.OffsetY.Name = "OffsetY";
            this.OffsetY.Size = new System.Drawing.Size(45, 13);
            this.OffsetY.TabIndex = 5;
            this.OffsetY.Text = "Offset Y";
            // 
            // textBox_Y
            // 
            this.textBox_Y.Location = new System.Drawing.Point(63, 123);
            this.textBox_Y.Name = "textBox_Y";
            this.textBox_Y.Size = new System.Drawing.Size(218, 20);
            this.textBox_Y.TabIndex = 4;
            this.textBox_Y.TextChanged += new System.EventHandler(this.textBox_Y_TextChanged);
            // 
            // StartAndSaveButton
            // 
            this.StartAndSaveButton.Location = new System.Drawing.Point(113, 158);
            this.StartAndSaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.StartAndSaveButton.Name = "StartAndSaveButton";
            this.StartAndSaveButton.Size = new System.Drawing.Size(66, 27);
            this.StartAndSaveButton.TabIndex = 0;
            this.StartAndSaveButton.Text = "Start";
            this.StartAndSaveButton.UseVisualStyleBackColor = true;
            this.StartAndSaveButton.Click += new System.EventHandler(this.StartAndSaveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 234);
            this.Controls.Add(this.OffsetY);
            this.Controls.Add(this.OffsetX);
            this.Controls.Add(this.textBox_Y);
            this.Controls.Add(this.textBox_X);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.FileOpenLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.StartAndSaveButton);
            this.Controls.Add(this.OpenButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DayZ Object Mover";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label FileOpenLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox_X;
        private System.Windows.Forms.Label OffsetX;
        private System.Windows.Forms.Label OffsetY;
        private System.Windows.Forms.TextBox textBox_Y;
        private System.Windows.Forms.Button StartAndSaveButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

