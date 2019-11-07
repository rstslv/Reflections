namespace WindowsFormsApplicationReflections
{
    partial class MainForm
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
            this.Libs = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Classes = new System.Windows.Forms.ListBox();
            this.Methods = new System.Windows.Forms.ListBox();
            this.Parameters = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Libs
            // 
            this.Libs.FormattingEnabled = true;
            this.Libs.Location = new System.Drawing.Point(12, 57);
            this.Libs.Name = "Libs";
            this.Libs.Size = new System.Drawing.Size(791, 121);
            this.Libs.TabIndex = 0;
            this.Libs.SelectedIndexChanged += new System.EventHandler(this.Libs_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Retrieve\r\n Libs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(432, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Use Lib";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(432, 242);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "Create Class Instance";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(432, 285);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 37);
            this.button4.TabIndex = 4;
            this.button4.Text = "Use Method";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Classes
            // 
            this.Classes.FormattingEnabled = true;
            this.Classes.Location = new System.Drawing.Point(12, 184);
            this.Classes.Name = "Classes";
            this.Classes.Size = new System.Drawing.Size(406, 95);
            this.Classes.TabIndex = 5;
            this.Classes.SelectedIndexChanged += new System.EventHandler(this.Classes_SelectedIndexChanged);
            // 
            // Methods
            // 
            this.Methods.FormattingEnabled = true;
            this.Methods.Location = new System.Drawing.Point(12, 285);
            this.Methods.Name = "Methods";
            this.Methods.Size = new System.Drawing.Size(226, 95);
            this.Methods.TabIndex = 6;
            this.Methods.SelectedIndexChanged += new System.EventHandler(this.Methods_SelectedIndexChanged);
            // 
            // Parameters
            // 
            this.Parameters.FormattingEnabled = true;
            this.Parameters.Location = new System.Drawing.Point(244, 285);
            this.Parameters.Name = "Parameters";
            this.Parameters.Size = new System.Drawing.Size(174, 95);
            this.Parameters.TabIndex = 7;
            this.Parameters.SelectedIndexChanged += new System.EventHandler(this.Parameters_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(432, 328);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(432, 360);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(648, 360);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(155, 20);
            this.textBox3.TabIndex = 10;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(648, 309);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(155, 39);
            this.button5.TabIndex = 11;
            this.button5.Text = "Get Result";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 393);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Parameters);
            this.Controls.Add(this.Methods);
            this.Controls.Add(this.Classes);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Libs);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Libs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox Classes;
        private System.Windows.Forms.ListBox Methods;
        private System.Windows.Forms.ListBox Parameters;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button5;
    }
}

