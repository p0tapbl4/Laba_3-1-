namespace Laba_3_1_
{
    partial class mainForm
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
            this.question1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // question1
            // 
            this.question1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.question1.Location = new System.Drawing.Point(57, 55);
            this.question1.Name = "question1";
            this.question1.Size = new System.Drawing.Size(158, 64);
            this.question1.TabIndex = 0;
            this.question1.Text = "Задание 1";
            this.question1.UseVisualStyleBackColor = true;
            this.question1.Click += new System.EventHandler(this.question1_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(322, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "Задание 2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(548, 189);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.question1);
            this.Name = "mainForm";
            this.Text = "Лабораторная 3-4";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button question1;
        private System.Windows.Forms.Button button1;
    }
}

