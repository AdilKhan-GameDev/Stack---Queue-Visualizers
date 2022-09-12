namespace Queue
{
    partial class Queue
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.front_btn = new System.Windows.Forms.Button();
            this.enq_btn = new System.Windows.Forms.Button();
            this.value_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_front = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totalcount_lbl = new System.Windows.Forms.Label();
            this.lbl_totalcount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.front_btn);
            this.panel1.Controls.Add(this.enq_btn);
            this.panel1.Controls.Add(this.value_txt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 47);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Dequeue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.deq_btn_Click);
            // 
            // front_btn
            // 
            this.front_btn.Location = new System.Drawing.Point(253, 7);
            this.front_btn.Name = "front_btn";
            this.front_btn.Size = new System.Drawing.Size(59, 34);
            this.front_btn.TabIndex = 4;
            this.front_btn.Text = "Front";
            this.front_btn.UseVisualStyleBackColor = true;
            this.front_btn.Click += new System.EventHandler(this.Front_btn_Click);
            // 
            // enq_btn
            // 
            this.enq_btn.Location = new System.Drawing.Point(98, 7);
            this.enq_btn.Name = "enq_btn";
            this.enq_btn.Size = new System.Drawing.Size(60, 34);
            this.enq_btn.TabIndex = 2;
            this.enq_btn.Text = "Enqueue";
            this.enq_btn.UseVisualStyleBackColor = true;
            this.enq_btn.Click += new System.EventHandler(this.enq_btn_Click);
            // 
            // value_txt
            // 
            this.value_txt.Location = new System.Drawing.Point(12, 15);
            this.value_txt.Name = "value_txt";
            this.value_txt.Size = new System.Drawing.Size(57, 20);
            this.value_txt.TabIndex = 1;
            this.value_txt.TextChanged += new System.EventHandler(this.Value_txt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(461, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stack Visualizer";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.lbl_front);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.totalcount_lbl);
            this.panel2.Controls.Add(this.lbl_totalcount);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(647, 492);
            this.panel2.TabIndex = 1;
            // 
            // lbl_front
            // 
            this.lbl_front.AutoSize = true;
            this.lbl_front.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_front.Location = new System.Drawing.Point(394, 45);
            this.lbl_front.Name = "lbl_front";
            this.lbl_front.Size = new System.Drawing.Size(0, 18);
            this.lbl_front.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(319, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Front:";
            // 
            // totalcount_lbl
            // 
            this.totalcount_lbl.AutoSize = true;
            this.totalcount_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.totalcount_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalcount_lbl.Location = new System.Drawing.Point(119, 45);
            this.totalcount_lbl.Name = "totalcount_lbl";
            this.totalcount_lbl.Size = new System.Drawing.Size(0, 18);
            this.totalcount_lbl.TabIndex = 5;
            // 
            // lbl_totalcount
            // 
            this.lbl_totalcount.AutoSize = true;
            this.lbl_totalcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_totalcount.Location = new System.Drawing.Point(12, 45);
            this.lbl_totalcount.Name = "lbl_totalcount";
            this.lbl_totalcount.Size = new System.Drawing.Size(101, 18);
            this.lbl_totalcount.TabIndex = 4;
            this.lbl_totalcount.Text = "Total Count:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(587, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Front";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rear";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Location = new System.Drawing.Point(3, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(641, 193);
            this.panel3.TabIndex = 1;
            // 
            // Queue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 539);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Queue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Queue";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button enq_btn;
        private System.Windows.Forms.TextBox value_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button deq_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button front_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_totalcount;
        private System.Windows.Forms.Label totalcount_lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_front;
    }
}

