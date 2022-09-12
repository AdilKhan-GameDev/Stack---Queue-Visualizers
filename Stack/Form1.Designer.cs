namespace Stack
{
    partial class Form1
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
            this.peak_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pop_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.value_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.counts_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.peak_btn);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.pop_btn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.value_txt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 47);
            this.panel1.TabIndex = 0;
            // 
            // peak_btn
            // 
            this.peak_btn.Location = new System.Drawing.Point(346, 7);
            this.peak_btn.Name = "peak_btn";
            this.peak_btn.Size = new System.Drawing.Size(58, 34);
            this.peak_btn.TabIndex = 6;
            this.peak_btn.Text = "Peak";
            this.peak_btn.UseVisualStyleBackColor = true;
            this.peak_btn.Click += new System.EventHandler(this.Peak_btn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(224, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 34);
            this.button3.TabIndex = 5;
            this.button3.Text = "IsFull?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.IsFull_btn);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(282, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "IsEmpty?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.IsEmpty_btn);
            // 
            // pop_btn
            // 
            this.pop_btn.Location = new System.Drawing.Point(164, 7);
            this.pop_btn.Name = "pop_btn";
            this.pop_btn.Size = new System.Drawing.Size(52, 34);
            this.pop_btn.TabIndex = 3;
            this.pop_btn.Text = "Pop";
            this.pop_btn.UseVisualStyleBackColor = true;
            this.pop_btn.Click += new System.EventHandler(this.Pop_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Push";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.push_btn);
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
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.counts_lbl);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(647, 492);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(569, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 18);
            this.label4.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(445, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Peak Element:";
            // 
            // counts_lbl
            // 
            this.counts_lbl.AutoSize = true;
            this.counts_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.counts_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.counts_lbl.Location = new System.Drawing.Point(158, 37);
            this.counts_lbl.Name = "counts_lbl";
            this.counts_lbl.Size = new System.Drawing.Size(0, 18);
            this.counts_lbl.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(17, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Current Stored:";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Location = new System.Drawing.Point(224, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(199, 492);
            this.panel3.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 539);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stack";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox value_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button pop_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label counts_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button peak_btn;
    }
}

