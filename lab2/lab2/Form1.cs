using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {

        public int selectedBox = 1;
        public int enteredNumber = 0;

        public int firstNumber = 0;
        public int secondNumber = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "0";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(80, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(139, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(203, 107);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(44, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(203, 136);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(44, 53);
            this.button5.TabIndex = 4;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(139, 166);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(58, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(80, 166);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(53, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "5";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 166);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(62, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "4";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(12, 195);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(62, 23);
            this.button9.TabIndex = 8;
            this.button9.Text = "1";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(80, 195);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(53, 23);
            this.button10.TabIndex = 9;
            this.button10.Text = "2";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(139, 195);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(58, 23);
            this.button11.TabIndex = 10;
            this.button11.Text = "3";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(203, 195);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(44, 52);
            this.button12.TabIndex = 11;
            this.button12.Text = "Enter";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(139, 224);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(58, 23);
            this.button13.TabIndex = 12;
            this.button13.Text = ".";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(12, 136);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(62, 23);
            this.button14.TabIndex = 13;
            this.button14.Text = "7";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(139, 107);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(58, 23);
            this.button15.TabIndex = 14;
            this.button15.Text = "*";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(80, 107);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(53, 23);
            this.button16.TabIndex = 15;
            this.button16.Text = "/";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(12, 107);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(62, 23);
            this.button17.TabIndex = 16;
            this.button17.Text = "Clear";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(48, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseEnter);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(66, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(22, 20);
            this.textBox2.TabIndex = 18;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseDown);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(94, 81);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(58, 20);
            this.textBox3.TabIndex = 19;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox3_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "=";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(182, 81);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(65, 20);
            this.textBox4.TabIndex = 21;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(323, 294);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            operationSet("+");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.selectedBox = 1;
            this.numberSet();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.selectedBox = 2;
            numberSet();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.selectedBox = 3;
            numberSet();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //reset
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.enteredNumber = enteredNumber * 10 + 1;
            numberSet();
        }

        private void numberSet()
        {
            if(this.selectedBox ==1)
            {
                this.firstNumber = enteredNumber;
                this.textBox1.Text = enteredNumber.ToString();
            }
            if(this.selectedBox == 3)
            {
                this.secondNumber = enteredNumber;
                this.textBox3.Text = enteredNumber.ToString();
            }
      
        }

        private void operationSet(string op)
        {
            this.textBox2.Text = op;
        }
        private void textBox1_MouseEnter(object sender, MouseEventArgs e)
        {
            this.enteredNumber = 0;
            this.selectedBox = 1;
            this.numberSet();
        }

        private void textBox3_MouseEnter(object sender, MouseEventArgs e)
        {
            this.enteredNumber = 0;
            this.selectedBox = 3;
            numberSet();
        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {
            this.enteredNumber = 0;
            this.selectedBox = 2;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.enteredNumber = enteredNumber * 10 + 2;
            numberSet();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.enteredNumber = enteredNumber * 10 + 3;
            numberSet();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.enteredNumber = enteredNumber * 10 + 4;
            numberSet();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.enteredNumber = enteredNumber * 10 + 5;
            numberSet();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.enteredNumber = enteredNumber * 10 +6;
            numberSet();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.enteredNumber = enteredNumber * 10 + 7;
            numberSet();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.enteredNumber = enteredNumber * 10 + 8;
            numberSet();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.enteredNumber = enteredNumber * 10 + 9;
            numberSet();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.operationSet("-");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.operationSet("X");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.operationSet("-");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(this.textBox2.Text.Contains("+") )
            {
                this.textBox4.Text = (firstNumber + secondNumber).ToString();
            }

            if (this.textBox2.Text.Contains("-"))
            {
                this.textBox4.Text = (firstNumber - secondNumber).ToString();
            }
            if (this.textBox2.Text.Contains("X"))
            {
                this.textBox4.Text = (firstNumber * secondNumber).ToString();
            }
            if (this.textBox2.Text.Contains("/"))
            {
                this.textBox4.Text = (firstNumber / secondNumber).ToString();
            }
        }
    }
}
