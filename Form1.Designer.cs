namespace WindowsFormsApp1
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
            this.Create = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.Textbook = new System.Windows.Forms.Label();
            this.Derectory = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.FileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(12, 46);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(181, 49);
            this.Create.TabIndex = 0;
            this.Create.Text = "Создать/сохранить";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(12, 119);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(111, 49);
            this.Open.TabIndex = 1;
            this.Open.Text = "Открыть";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Textbook
            // 
            this.Textbook.AutoSize = true;
            this.Textbook.Location = new System.Drawing.Point(1, 9);
            this.Textbook.Name = "Textbook";
            this.Textbook.Size = new System.Drawing.Size(74, 20);
            this.Textbook.TabIndex = 3;
            this.Textbook.Text = "Блокнот";
            // 
            // Derectory
            // 
            this.Derectory.Location = new System.Drawing.Point(231, 57);
            this.Derectory.Name = "Derectory";
            this.Derectory.Size = new System.Drawing.Size(402, 26);
            this.Derectory.TabIndex = 4;
            this.Derectory.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 195);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(950, 1087);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(654, 57);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(268, 26);
            this.FileName.TabIndex = 7;
            this.FileName.TextChanged += new System.EventHandler(this.FileName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Дерриктроия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(650, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Название файла (безрасширения)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 1319);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Derectory);
            this.Controls.Add(this.Textbook);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Create);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Label Textbook;
        private System.Windows.Forms.TextBox Derectory;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

