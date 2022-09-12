using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue
{
    public partial class Queue : Form
    {
        private Random rnd = new Random();
        string value;
        int x = 3;
        int y = 3;
        int shift =0;
        int arrcount = 0;
        private Label[] array = new Label[23];
        public Queue()
        {
            InitializeComponent();
        }
        private void Value_txt_TextChanged(object sender, EventArgs e)
        {
            this.value = value_txt.Text;
        }
        private void enq_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                BackColor = randomColor;
                Label label2 = new Label();
                this.array[this.arrcount] = label2;
                this.panel3.Controls.Add(label2);
                if (arrcount != 0)
                {
                    shift = 27 * arrcount;
                    for(int i = 0; i < arrcount; i++)
                    {
                        array[i].Location = new System.Drawing.Point(this.x + shift, this.y);
                        shift -= 27;
                    }
                }
                label2.BackColor = BackColor;
                label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                label2.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label2.Location = new System.Drawing.Point(3, 3);
                label2.Name = "label2";
                label2.Size = new System.Drawing.Size(27, 190);
                label2.TabIndex = 23;
                label2.Text = this.value;
                label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                arrcount++;
                totalcount_lbl.Text = "" + arrcount;
                //value_txt.Clear();(
                fillrandom_intextfield();
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception err)
            {
                MessageBox.Show("Cannot add more Items");

            }
        }
        public void fillrandom_intextfield()
        {
            Random ran = new Random();
            
            value_txt.Text = ""+ ran.NextDouble() * 100;
        }
        private void deq_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.array[0].Dispose();
                for (int i = 1; i < arrcount; i++)
                {
                    array[i-1] = array[i];
                }
                arrcount --;
                if (arrcount < 0) { throw new IndexOutOfRangeException(); }
                    totalcount_lbl.Text = "" + arrcount;
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception err)
            {
                MessageBox.Show("Queue is Empty");
                arrcount++;
            }
        }

        private void Front_btn_Click(object sender, EventArgs e)
        {
            lbl_front.Text = "" + array[0].Text;
        }
    }
}
