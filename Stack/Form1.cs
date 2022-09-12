using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stack
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random();
        string value;
        int x = 3;
        int y = 462;
        int arrcount = 0;
        private Label[] array = new Label[18];
        public Form1()
        {
            InitializeComponent();
        }
        private void Value_txt_TextChanged(object sender, EventArgs e)
        {
            this.value = value_txt.Text;
        }
        private void push_btn(object sender, EventArgs e)
        {
            try
            {
                Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                BackColor = randomColor;
                Label label2 = new Label();
                this.array[this.arrcount] = label2;
                this.panel3.Controls.Add(label2);
                label2.BackColor = BackColor;
                label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                label2.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label2.Location = new System.Drawing.Point(this.x, this.y);
                label2.Name = "label2";
                label2.Size = new System.Drawing.Size(193, 27);
                label2.TabIndex = 23;
                label2.Text = this.value;
                label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
                this.y -= 27;
                arrcount++;
                counts_lbl.Text = "" + arrcount;
                this.value_txt.Clear();
            }
        #pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception err)
            {
                arrcount = 18;
                MessageBox.Show("OverFlow! Cannot add more Items");
                this.value_txt.Clear();
            }
        }
        private void Pop_btn_Click(object sender, EventArgs e)
        {
            try { 
                this.array[arrcount - 1].Dispose();
                arrcount--;
                this.y += 27;
                counts_lbl.Text = "" + arrcount;
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception err)
            {
                MessageBox.Show("UnderFlow! Stack is Empty");
            }
        }
        private void IsFull_btn(object sender, EventArgs e)
        {
            if (arrcount == 18)
            {
                MessageBox.Show("Stack is Full!");
            }
            else
            {
                MessageBox.Show("Stack is Not Full!");
            }
        }

        private void IsEmpty_btn(object sender, EventArgs e)
        {
            if (arrcount == 0)
            {
                MessageBox.Show("Stack is Empty!");
            }
            else
            {
                MessageBox.Show("Stack is Not Empty!");
            }
        }
        private void Peak_btn_Click(object sender, EventArgs e)
        {
            label4.Text = "" + array[arrcount - 1].Text;
        }
    }
}
