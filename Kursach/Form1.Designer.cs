
namespace Kursach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rbBinarySys1 = new System.Windows.Forms.RadioButton();
            this.rbOctalSys1 = new System.Windows.Forms.RadioButton();
            this.rbHexaSys1 = new System.Windows.Forms.RadioButton();
            this.rbDecimalSys1 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gbOrigNumSys = new System.Windows.Forms.GroupBox();
            this.gbReqNumSys = new System.Windows.Forms.GroupBox();
            this.rbBinarySys2 = new System.Windows.Forms.RadioButton();
            this.rbOctalSys2 = new System.Windows.Forms.RadioButton();
            this.rbDecimalSys2 = new System.Windows.Forms.RadioButton();
            this.rbHexaSys2 = new System.Windows.Forms.RadioButton();
            this.gbOrigNumSys.SuspendLayout();
            this.gbReqNumSys.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(261, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Расчитать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(100, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Операция перевода";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(354, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Проведение математических операций";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(119, 171);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 21);
            this.textBox1.TabIndex = 8;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(81, 209);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(104, 21);
            this.textBox2.TabIndex = 9;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(357, 171);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(122, 21);
            this.textBox3.TabIndex = 10;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(428, 209);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(104, 21);
            this.textBox5.TabIndex = 12;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Исходное число";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Резултат";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(386, 84);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(84, 19);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Сложение";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(495, 84);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(90, 19);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Вычитание";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3.Location = new System.Drawing.Point(386, 109);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(93, 19);
            this.radioButton3.TabIndex = 18;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Умножение";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton4.Location = new System.Drawing.Point(495, 109);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(76, 19);
            this.radioButton4.TabIndex = 19;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Деление";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(383, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Значение 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(354, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Результат";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(495, 171);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(122, 21);
            this.textBox4.TabIndex = 22;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(522, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Значение 2";
            // 
            // rbBinarySys1
            // 
            this.rbBinarySys1.AutoSize = true;
            this.rbBinarySys1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbBinarySys1.Location = new System.Drawing.Point(6, 31);
            this.rbBinarySys1.Name = "rbBinarySys1";
            this.rbBinarySys1.Size = new System.Drawing.Size(82, 19);
            this.rbBinarySys1.TabIndex = 26;
            this.rbBinarySys1.TabStop = true;
            this.rbBinarySys1.Text = "Двоичная";
            this.rbBinarySys1.UseVisualStyleBackColor = true;
            // 
            // rbOctalSys1
            // 
            this.rbOctalSys1.AutoSize = true;
            this.rbOctalSys1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbOctalSys1.Location = new System.Drawing.Point(6, 56);
            this.rbOctalSys1.Name = "rbOctalSys1";
            this.rbOctalSys1.Size = new System.Drawing.Size(110, 19);
            this.rbOctalSys1.TabIndex = 27;
            this.rbOctalSys1.TabStop = true;
            this.rbOctalSys1.Text = "Восьмеричная";
            this.rbOctalSys1.UseVisualStyleBackColor = true;
            // 
            // rbHexaSys1
            // 
            this.rbHexaSys1.AutoSize = true;
            this.rbHexaSys1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbHexaSys1.Location = new System.Drawing.Point(6, 100);
            this.rbHexaSys1.Name = "rbHexaSys1";
            this.rbHexaSys1.Size = new System.Drawing.Size(146, 19);
            this.rbHexaSys1.TabIndex = 28;
            this.rbHexaSys1.TabStop = true;
            this.rbHexaSys1.Text = "Шестнадцатиричная";
            this.rbHexaSys1.UseVisualStyleBackColor = true;
            // 
            // rbDecimalSys1
            // 
            this.rbDecimalSys1.AutoSize = true;
            this.rbDecimalSys1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbDecimalSys1.Location = new System.Drawing.Point(6, 80);
            this.rbDecimalSys1.Name = "rbDecimalSys1";
            this.rbDecimalSys1.Size = new System.Drawing.Size(95, 19);
            this.rbDecimalSys1.TabIndex = 29;
            this.rbDecimalSys1.TabStop = true;
            this.rbDecimalSys1.Text = "Десятичная";
            this.rbDecimalSys1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2 (двоичная)",
            "8 (восьмиричная)",
            "10 (десятичная)",
            "16 (шестнадцатиричная)"});
            this.comboBox1.Location = new System.Drawing.Point(386, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 23);
            this.comboBox1.TabIndex = 33;
            this.comboBox1.Text = "Выберите систему счисления";
            // 
            // gbOrigNumSys
            // 
            this.gbOrigNumSys.Controls.Add(this.rbBinarySys1);
            this.gbOrigNumSys.Controls.Add(this.rbOctalSys1);
            this.gbOrigNumSys.Controls.Add(this.rbDecimalSys1);
            this.gbOrigNumSys.Controls.Add(this.rbHexaSys1);
            this.gbOrigNumSys.Location = new System.Drawing.Point(11, 43);
            this.gbOrigNumSys.Name = "gbOrigNumSys";
            this.gbOrigNumSys.Size = new System.Drawing.Size(159, 125);
            this.gbOrigNumSys.TabIndex = 34;
            this.gbOrigNumSys.TabStop = false;
            this.gbOrigNumSys.Text = "Исходная система счисления";
            // 
            // gbReqNumSys
            // 
            this.gbReqNumSys.Controls.Add(this.rbBinarySys2);
            this.gbReqNumSys.Controls.Add(this.rbOctalSys2);
            this.gbReqNumSys.Controls.Add(this.rbDecimalSys2);
            this.gbReqNumSys.Controls.Add(this.rbHexaSys2);
            this.gbReqNumSys.Location = new System.Drawing.Point(176, 44);
            this.gbReqNumSys.Name = "gbReqNumSys";
            this.gbReqNumSys.Size = new System.Drawing.Size(159, 125);
            this.gbReqNumSys.TabIndex = 35;
            this.gbReqNumSys.TabStop = false;
            this.gbReqNumSys.Text = "Требуемая система счисления";
            // 
            // rbBinarySys2
            // 
            this.rbBinarySys2.AutoSize = true;
            this.rbBinarySys2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbBinarySys2.Location = new System.Drawing.Point(6, 31);
            this.rbBinarySys2.Name = "rbBinarySys2";
            this.rbBinarySys2.Size = new System.Drawing.Size(82, 19);
            this.rbBinarySys2.TabIndex = 26;
            this.rbBinarySys2.TabStop = true;
            this.rbBinarySys2.Text = "Двоичная";
            this.rbBinarySys2.UseVisualStyleBackColor = true;
            // 
            // rbOctalSys2
            // 
            this.rbOctalSys2.AutoSize = true;
            this.rbOctalSys2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbOctalSys2.Location = new System.Drawing.Point(6, 56);
            this.rbOctalSys2.Name = "rbOctalSys2";
            this.rbOctalSys2.Size = new System.Drawing.Size(110, 19);
            this.rbOctalSys2.TabIndex = 27;
            this.rbOctalSys2.TabStop = true;
            this.rbOctalSys2.Text = "Восьмеричная";
            this.rbOctalSys2.UseVisualStyleBackColor = true;
            // 
            // rbDecimalSys2
            // 
            this.rbDecimalSys2.AutoSize = true;
            this.rbDecimalSys2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbDecimalSys2.Location = new System.Drawing.Point(6, 80);
            this.rbDecimalSys2.Name = "rbDecimalSys2";
            this.rbDecimalSys2.Size = new System.Drawing.Size(95, 19);
            this.rbDecimalSys2.TabIndex = 29;
            this.rbDecimalSys2.TabStop = true;
            this.rbDecimalSys2.Text = "Десятичная";
            this.rbDecimalSys2.UseVisualStyleBackColor = true;
            // 
            // rbHexaSys2
            // 
            this.rbHexaSys2.AutoSize = true;
            this.rbHexaSys2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbHexaSys2.Location = new System.Drawing.Point(6, 100);
            this.rbHexaSys2.Name = "rbHexaSys2";
            this.rbHexaSys2.Size = new System.Drawing.Size(146, 19);
            this.rbHexaSys2.TabIndex = 28;
            this.rbHexaSys2.TabStop = true;
            this.rbHexaSys2.Text = "Шестнадцатиричная";
            this.rbHexaSys2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(643, 288);
            this.Controls.Add(this.gbReqNumSys);
            this.Controls.Add(this.gbOrigNumSys);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Системы счисления";
            this.gbOrigNumSys.ResumeLayout(false);
            this.gbOrigNumSys.PerformLayout();
            this.gbReqNumSys.ResumeLayout(false);
            this.gbReqNumSys.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbBinarySys1;
        private System.Windows.Forms.RadioButton rbOctalSys1;
        private System.Windows.Forms.RadioButton rbHexaSys1;
        private System.Windows.Forms.RadioButton rbDecimalSys1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox gbOrigNumSys;
        private System.Windows.Forms.GroupBox gbReqNumSys;
        private System.Windows.Forms.RadioButton rbBinarySys2;
        private System.Windows.Forms.RadioButton rbOctalSys2;
        private System.Windows.Forms.RadioButton rbDecimalSys2;
        private System.Windows.Forms.RadioButton rbHexaSys2;
    }
}

