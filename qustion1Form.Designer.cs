namespace Laba_3_1_
{
    partial class qustion1Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Ninsert = new System.Windows.Forms.NumericUpDown();
            this.x = new System.Windows.Forms.TextBox();
            this.y = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.TextBox();
            this.width = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resultShow = new System.Windows.Forms.Label();
            this.apply = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Ninsert)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите количество точек на плоскости";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(46, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите координаты прямоугольника";
            // 
            // Ninsert
            // 
            this.Ninsert.Location = new System.Drawing.Point(401, 35);
            this.Ninsert.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.Ninsert.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Ninsert.Name = "Ninsert";
            this.Ninsert.Size = new System.Drawing.Size(150, 22);
            this.Ninsert.TabIndex = 4;
            this.Ninsert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ninsert.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // x
            // 
            this.x.Location = new System.Drawing.Point(144, 134);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(110, 22);
            this.x.TabIndex = 5;
            this.x.Text = "x";
            this.x.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // y
            // 
            this.y.Location = new System.Drawing.Point(349, 134);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(109, 22);
            this.y.TabIndex = 6;
            this.y.Text = "y";
            this.y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(349, 239);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(109, 22);
            this.height.TabIndex = 9;
            this.height.Text = "height";
            this.height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(144, 239);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(110, 22);
            this.width.TabIndex = 8;
            this.width.Text = "width";
            this.width.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(46, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Введите ширину и высоту прямоугольника";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(46, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(304, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Количество точек в многоугольнике:";
            // 
            // resultShow
            // 
            this.resultShow.Location = new System.Drawing.Point(0, 0);
            this.resultShow.Name = "resultShow";
            this.resultShow.Size = new System.Drawing.Size(100, 23);
            this.resultShow.TabIndex = 0;
            // 
            // apply
            // 
            this.apply.Location = new System.Drawing.Point(212, 308);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(189, 23);
            this.apply.TabIndex = 12;
            this.apply.Text = "Подтвердить";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(457, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = " ";
            // 
            // qustion1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1004, 513);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.height);
            this.Controls.Add(this.width);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.y);
            this.Controls.Add(this.x);
            this.Controls.Add(this.Ninsert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "qustion1Form";
            this.Text = "Задание 1";
            ((System.ComponentModel.ISupportInitialize)(this.Ninsert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Ninsert;
        private System.Windows.Forms.TextBox x;
        private System.Windows.Forms.TextBox y;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label resultShow;
    }
}