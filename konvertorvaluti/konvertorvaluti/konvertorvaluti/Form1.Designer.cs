
namespace konvertorvaluti
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rub1 = new System.Windows.Forms.RadioButton();
            this.usd1 = new System.Windows.Forms.RadioButton();
            this.eur1 = new System.Windows.Forms.RadioButton();
            this.gbp1 = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.rub2 = new System.Windows.Forms.RadioButton();
            this.usd2 = new System.Windows.Forms.RadioButton();
            this.eur2 = new System.Windows.Forms.RadioButton();
            this.gbp2 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "У меня есть";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(517, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Я хочу пробрести";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.rub1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.eur1, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbp1, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.usd1, 3, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(290, 42);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // rub1
            // 
            this.rub1.AutoSize = true;
            this.rub1.Location = new System.Drawing.Point(3, 3);
            this.rub1.Name = "rub1";
            this.rub1.Size = new System.Drawing.Size(66, 28);
            this.rub1.TabIndex = 1;
            this.rub1.TabStop = true;
            this.rub1.Text = "RUB";
            this.rub1.UseVisualStyleBackColor = true;
            this.rub1.CheckedChanged += new System.EventHandler(this.rub1_CheckedChanged);
            // 
            // usd1
            // 
            this.usd1.AutoSize = true;
            this.usd1.Location = new System.Drawing.Point(75, 3);
            this.usd1.Name = "usd1";
            this.usd1.Size = new System.Drawing.Size(66, 28);
            this.usd1.TabIndex = 0;
            this.usd1.TabStop = true;
            this.usd1.Text = "USD";
            this.usd1.UseVisualStyleBackColor = true;
            this.usd1.CheckedChanged += new System.EventHandler(this.usd1_CheckedChanged);
            // 
            // eur1
            // 
            this.eur1.AutoSize = true;
            this.eur1.Location = new System.Drawing.Point(147, 3);
            this.eur1.Name = "eur1";
            this.eur1.Size = new System.Drawing.Size(67, 28);
            this.eur1.TabIndex = 2;
            this.eur1.TabStop = true;
            this.eur1.Text = "EUR";
            this.eur1.UseVisualStyleBackColor = true;
            this.eur1.CheckedChanged += new System.EventHandler(this.eur1_CheckedChanged);
            // 
            // gbp1
            // 
            this.gbp1.AutoSize = true;
            this.gbp1.Location = new System.Drawing.Point(220, 3);
            this.gbp1.Name = "gbp1";
            this.gbp1.Size = new System.Drawing.Size(66, 28);
            this.gbp1.TabIndex = 3;
            this.gbp1.TabStop = true;
            this.gbp1.Text = "GBP";
            this.gbp1.UseVisualStyleBackColor = true;
            this.gbp1.CheckedChanged += new System.EventHandler(this.gbp1_CheckedChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.rub2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.usd2, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.eur2, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.gbp2, 5, 0);
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(462, 55);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(289, 42);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // rub2
            // 
            this.rub2.AutoSize = true;
            this.rub2.Location = new System.Drawing.Point(3, 3);
            this.rub2.Name = "rub2";
            this.rub2.Size = new System.Drawing.Size(66, 28);
            this.rub2.TabIndex = 1;
            this.rub2.TabStop = true;
            this.rub2.Text = "RUB";
            this.rub2.UseVisualStyleBackColor = true;
            this.rub2.CheckedChanged += new System.EventHandler(this.rub2_CheckedChanged);
            // 
            // usd2
            // 
            this.usd2.AutoSize = true;
            this.usd2.Location = new System.Drawing.Point(75, 3);
            this.usd2.Name = "usd2";
            this.usd2.Size = new System.Drawing.Size(66, 28);
            this.usd2.TabIndex = 0;
            this.usd2.TabStop = true;
            this.usd2.Text = "USD";
            this.usd2.UseVisualStyleBackColor = true;
            this.usd2.CheckedChanged += new System.EventHandler(this.usd2_CheckedChanged);
            // 
            // eur2
            // 
            this.eur2.AutoSize = true;
            this.eur2.Location = new System.Drawing.Point(147, 3);
            this.eur2.Name = "eur2";
            this.eur2.Size = new System.Drawing.Size(67, 28);
            this.eur2.TabIndex = 2;
            this.eur2.TabStop = true;
            this.eur2.Text = "EUR";
            this.eur2.UseVisualStyleBackColor = true;
            this.eur2.CheckedChanged += new System.EventHandler(this.eur2_CheckedChanged);
            // 
            // gbp2
            // 
            this.gbp2.AutoSize = true;
            this.gbp2.Location = new System.Drawing.Point(220, 3);
            this.gbp2.Name = "gbp2";
            this.gbp2.Size = new System.Drawing.Size(66, 28);
            this.gbp2.TabIndex = 3;
            this.gbp2.TabStop = true;
            this.gbp2.Text = "GBP";
            this.gbp2.UseVisualStyleBackColor = true;
            this.gbp2.CheckedChanged += new System.EventHandler(this.gbp2_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(57, 180);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 31);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(521, 180);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(211, 31);
            this.textBox2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(314, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "посчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(57, 256);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(521, 256);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(211, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton usd1;
        private System.Windows.Forms.RadioButton rub1;
        private System.Windows.Forms.RadioButton eur1;
        private System.Windows.Forms.RadioButton gbp1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton rub2;
        private System.Windows.Forms.RadioButton usd2;
        private System.Windows.Forms.RadioButton eur2;
        private System.Windows.Forms.RadioButton gbp2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

