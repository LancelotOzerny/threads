namespace MatrixThread
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startMatrixes = new System.Windows.Forms.ListBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.ResultValues = new System.Windows.Forms.ListBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startMatrixes
            // 
            this.startMatrixes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.startMatrixes.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startMatrixes.FormattingEnabled = true;
            this.startMatrixes.ItemHeight = 26;
            this.startMatrixes.Location = new System.Drawing.Point(12, 12);
            this.startMatrixes.Name = "startMatrixes";
            this.startMatrixes.Size = new System.Drawing.Size(332, 498);
            this.startMatrixes.TabIndex = 0;
            // 
            // add_btn
            // 
            this.add_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.add_btn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_btn.Location = new System.Drawing.Point(12, 516);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(332, 55);
            this.add_btn.TabIndex = 1;
            this.add_btn.Text = "Добавить";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // ResultValues
            // 
            this.ResultValues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultValues.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResultValues.FormattingEnabled = true;
            this.ResultValues.ItemHeight = 26;
            this.ResultValues.Location = new System.Drawing.Point(350, 12);
            this.ResultValues.Name = "ResultValues";
            this.ResultValues.Size = new System.Drawing.Size(391, 498);
            this.ResultValues.TabIndex = 0;
            // 
            // calcButton
            // 
            this.calcButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calcButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calcButton.Location = new System.Drawing.Point(350, 516);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(391, 55);
            this.calcButton.TabIndex = 2;
            this.calcButton.Text = "Рассчитать";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clear_btn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clear_btn.Location = new System.Drawing.Point(12, 577);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(332, 55);
            this.clear_btn.TabIndex = 3;
            this.clear_btn.Text = "Очистить";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 577);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(294, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "Установить количество потоков";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(350, 577);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(91, 55);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 642);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.ResultValues);
            this.Controls.Add(this.startMatrixes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox startMatrixes;
        private Button add_btn;
        private ListBox ResultValues;
        private Button calcButton;
        private Button clear_btn;
        private Button button1;
        private TextBox textBox1;
    }
}