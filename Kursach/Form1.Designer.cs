
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
            this.rbSum = new System.Windows.Forms.RadioButton();
            this.rbMinus = new System.Windows.Forms.RadioButton();
            this.rbMultiply = new System.Windows.Forms.RadioButton();
            this.rbDevide = new System.Windows.Forms.RadioButton();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.gbOrigNumSys.SuspendLayout();
            this.gbReqNumSys.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(305, 310);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Расчитать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(133, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Операция перевода";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(496, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Проведение математических операций";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(159, 210);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 24);
            this.textBox1.TabIndex = 8;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(108, 257);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(137, 24);
            this.textBox2.TabIndex = 9;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(481, 210);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(161, 24);
            this.textBox3.TabIndex = 10;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(576, 257);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(137, 24);
            this.textBox5.TabIndex = 12;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(19, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Исходное число";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(19, 265);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Резултат";
            // 
            // rbSum
            // 
            this.rbSum.AutoSize = true;
            this.rbSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbSum.Location = new System.Drawing.Point(25, 23);
            this.rbSum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbSum.Name = "rbSum";
            this.rbSum.Size = new System.Drawing.Size(101, 22);
            this.rbSum.TabIndex = 16;
            this.rbSum.TabStop = true;
            this.rbSum.Text = "Сложение";
            this.rbSum.UseVisualStyleBackColor = true;
            // 
            // rbMinus
            // 
            this.rbMinus.AutoSize = true;
            this.rbMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbMinus.Location = new System.Drawing.Point(171, 23);
            this.rbMinus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbMinus.Name = "rbMinus";
            this.rbMinus.Size = new System.Drawing.Size(105, 22);
            this.rbMinus.TabIndex = 17;
            this.rbMinus.TabStop = true;
            this.rbMinus.Text = "Вычитание";
            this.rbMinus.UseVisualStyleBackColor = true;
            // 
            // rbMultiply
            // 
            this.rbMultiply.AutoSize = true;
            this.rbMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbMultiply.Location = new System.Drawing.Point(25, 54);
            this.rbMultiply.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbMultiply.Name = "rbMultiply";
            this.rbMultiply.Size = new System.Drawing.Size(110, 22);
            this.rbMultiply.TabIndex = 18;
            this.rbMultiply.TabStop = true;
            this.rbMultiply.Text = "Умножение";
            this.rbMultiply.UseVisualStyleBackColor = true;
            // 
            // rbDevide
            // 
            this.rbDevide.AutoSize = true;
            this.rbDevide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbDevide.Location = new System.Drawing.Point(171, 54);
            this.rbDevide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbDevide.Name = "rbDevide";
            this.rbDevide.Size = new System.Drawing.Size(90, 22);
            this.rbDevide.TabIndex = 19;
            this.rbDevide.TabStop = true;
            this.rbDevide.Text = "Деление";
            this.rbDevide.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(516, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Значение 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(477, 265);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Результат";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(665, 210);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(161, 24);
            this.textBox4.TabIndex = 22;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(701, 182);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Значение 2";
            // 
            // rbBinarySys1
            // 
            this.rbBinarySys1.AutoSize = true;
            this.rbBinarySys1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbBinarySys1.Location = new System.Drawing.Point(8, 38);
            this.rbBinarySys1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbBinarySys1.Name = "rbBinarySys1";
            this.rbBinarySys1.Size = new System.Drawing.Size(98, 22);
            this.rbBinarySys1.TabIndex = 26;
            this.rbBinarySys1.TabStop = true;
            this.rbBinarySys1.Text = "Двоичная";
            this.rbBinarySys1.UseVisualStyleBackColor = true;
            // 
            // rbOctalSys1
            // 
            this.rbOctalSys1.AutoSize = true;
            this.rbOctalSys1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbOctalSys1.Location = new System.Drawing.Point(8, 66);
            this.rbOctalSys1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbOctalSys1.Name = "rbOctalSys1";
            this.rbOctalSys1.Size = new System.Drawing.Size(131, 22);
            this.rbOctalSys1.TabIndex = 27;
            this.rbOctalSys1.TabStop = true;
            this.rbOctalSys1.Text = "Восьмеричная";
            this.rbOctalSys1.UseVisualStyleBackColor = true;
            // 
            // rbHexaSys1
            // 
            this.rbHexaSys1.AutoSize = true;
            this.rbHexaSys1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbHexaSys1.Location = new System.Drawing.Point(8, 123);
            this.rbHexaSys1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbHexaSys1.Name = "rbHexaSys1";
            this.rbHexaSys1.Size = new System.Drawing.Size(169, 22);
            this.rbHexaSys1.TabIndex = 28;
            this.rbHexaSys1.TabStop = true;
            this.rbHexaSys1.Text = "Шестнадцатиричная";
            this.rbHexaSys1.UseVisualStyleBackColor = true;
            // 
            // rbDecimalSys1
            // 
            this.rbDecimalSys1.AutoSize = true;
            this.rbDecimalSys1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbDecimalSys1.Location = new System.Drawing.Point(8, 96);
            this.rbDecimalSys1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbDecimalSys1.Name = "rbDecimalSys1";
            this.rbDecimalSys1.Size = new System.Drawing.Size(112, 22);
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
            this.comboBox1.Location = new System.Drawing.Point(525, 54);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(264, 26);
            this.comboBox1.TabIndex = 33;
            this.comboBox1.Text = "Выберите систему счисления";
            // 
            // gbOrigNumSys
            // 
            this.gbOrigNumSys.Controls.Add(this.rbBinarySys1);
            this.gbOrigNumSys.Controls.Add(this.rbOctalSys1);
            this.gbOrigNumSys.Controls.Add(this.rbDecimalSys1);
            this.gbOrigNumSys.Controls.Add(this.rbHexaSys1);
            this.gbOrigNumSys.Location = new System.Drawing.Point(15, 53);
            this.gbOrigNumSys.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbOrigNumSys.Name = "gbOrigNumSys";
            this.gbOrigNumSys.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbOrigNumSys.Size = new System.Drawing.Size(220, 154);
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
            this.gbReqNumSys.Location = new System.Drawing.Point(237, 53);
            this.gbReqNumSys.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbReqNumSys.Name = "gbReqNumSys";
            this.gbReqNumSys.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbReqNumSys.Size = new System.Drawing.Size(238, 154);
            this.gbReqNumSys.TabIndex = 35;
            this.gbReqNumSys.TabStop = false;
            this.gbReqNumSys.Text = "Требуемая система счисления";
            // 
            // rbBinarySys2
            // 
            this.rbBinarySys2.AutoSize = true;
            this.rbBinarySys2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbBinarySys2.Location = new System.Drawing.Point(8, 37);
            this.rbBinarySys2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbBinarySys2.Name = "rbBinarySys2";
            this.rbBinarySys2.Size = new System.Drawing.Size(98, 22);
            this.rbBinarySys2.TabIndex = 26;
            this.rbBinarySys2.TabStop = true;
            this.rbBinarySys2.Text = "Двоичная";
            this.rbBinarySys2.UseVisualStyleBackColor = true;
            // 
            // rbOctalSys2
            // 
            this.rbOctalSys2.AutoSize = true;
            this.rbOctalSys2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbOctalSys2.Location = new System.Drawing.Point(8, 65);
            this.rbOctalSys2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbOctalSys2.Name = "rbOctalSys2";
            this.rbOctalSys2.Size = new System.Drawing.Size(131, 22);
            this.rbOctalSys2.TabIndex = 27;
            this.rbOctalSys2.TabStop = true;
            this.rbOctalSys2.Text = "Восьмеричная";
            this.rbOctalSys2.UseVisualStyleBackColor = true;
            // 
            // rbDecimalSys2
            // 
            this.rbDecimalSys2.AutoSize = true;
            this.rbDecimalSys2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbDecimalSys2.Location = new System.Drawing.Point(8, 95);
            this.rbDecimalSys2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbDecimalSys2.Name = "rbDecimalSys2";
            this.rbDecimalSys2.Size = new System.Drawing.Size(112, 22);
            this.rbDecimalSys2.TabIndex = 29;
            this.rbDecimalSys2.TabStop = true;
            this.rbDecimalSys2.Text = "Десятичная";
            this.rbDecimalSys2.UseVisualStyleBackColor = true;
            // 
            // rbHexaSys2
            // 
            this.rbHexaSys2.AutoSize = true;
            this.rbHexaSys2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbHexaSys2.Location = new System.Drawing.Point(8, 122);
            this.rbHexaSys2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbHexaSys2.Name = "rbHexaSys2";
            this.rbHexaSys2.Size = new System.Drawing.Size(169, 22);
            this.rbHexaSys2.TabIndex = 28;
            this.rbHexaSys2.TabStop = true;
            this.rbHexaSys2.Text = "Шестнадцатиричная";
            this.rbHexaSys2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDevide);
            this.groupBox1.Controls.Add(this.rbMultiply);
            this.groupBox1.Controls.Add(this.rbMinus);
            this.groupBox1.Controls.Add(this.rbSum);
            this.groupBox1.Location = new System.Drawing.Point(498, 91);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(316, 85);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Требуемая математическая операция";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(440, 310);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 30);
            this.button2.TabIndex = 37;
            this.button2.Text = "Сбросить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(857, 354);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbReqNumSys);
            this.Controls.Add(this.gbOrigNumSys);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Системы счисления";
            this.gbOrigNumSys.ResumeLayout(false);
            this.gbOrigNumSys.PerformLayout();
            this.gbReqNumSys.ResumeLayout(false);
            this.gbReqNumSys.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.RadioButton rbSum;
        private System.Windows.Forms.RadioButton rbMinus;
        private System.Windows.Forms.RadioButton rbMultiply;
        private System.Windows.Forms.RadioButton rbDevide;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
    }
}

