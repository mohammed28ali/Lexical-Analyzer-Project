namespace LexicalAnalyzer
{
    partial class Form1
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
            this.find = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.analyzed = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.path = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(324, 379);
            this.find.Margin = new System.Windows.Forms.Padding(4);
            this.find.Name = "find";
            this.find.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.find.Size = new System.Drawing.Size(104, 28);
            this.find.TabIndex = 1;
            this.find.Text = "Chose File";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(13, 13);
            this.textBox.Margin = new System.Windows.Forms.Padding(4);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(415, 356);
            this.textBox.TabIndex = 2;
            this.textBox.Text = "";
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // analyzed
            // 
            this.analyzed.Location = new System.Drawing.Point(436, 379);
            this.analyzed.Margin = new System.Windows.Forms.Padding(4);
            this.analyzed.Name = "analyzed";
            this.analyzed.Size = new System.Drawing.Size(213, 28);
            this.analyzed.TabIndex = 4;
            this.analyzed.Text = "Print Token";
            this.analyzed.UseVisualStyleBackColor = true;
            this.analyzed.Click += new System.EventHandler(this.analyzed_Click);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(436, 13);
            this.outputBox.Margin = new System.Windows.Forms.Padding(4);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(451, 356);
            this.outputBox.TabIndex = 5;
            this.outputBox.Text = "";
            this.outputBox.TextChanged += new System.EventHandler(this.outputBox_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(13, 379);
            this.path.Margin = new System.Windows.Forms.Padding(4);
            this.path.Multiline = true;
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(295, 25);
            this.path.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(669, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Number of Tokens";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(894, 420);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.analyzed);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.find);
            this.Controls.Add(this.path);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.Button analyzed;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.Button button1;
    }
}

