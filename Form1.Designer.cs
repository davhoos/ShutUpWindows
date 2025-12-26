namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStop = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn2h = new System.Windows.Forms.Button();
            this.btn3h = new System.Windows.Forms.Button();
            this.btn4h = new System.Windows.Forms.Button();
            this.btn1h = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Khaki;
            this.btnStop.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStop.Location = new System.Drawing.Point(615, 149);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(112, 49);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(4, 5);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(736, 121);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(266, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "odpočet vypnutí stroje";
            // 
            // btn2h
            // 
            this.btn2h.BackColor = System.Drawing.Color.RosyBrown;
            this.btn2h.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn2h.Location = new System.Drawing.Point(384, 193);
            this.btn2h.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn2h.Name = "btn2h";
            this.btn2h.Size = new System.Drawing.Size(164, 49);
            this.btn2h.TabIndex = 5;
            this.btn2h.Text = "off in 2h";
            this.btn2h.UseVisualStyleBackColor = false;
            this.btn2h.Click += new System.EventHandler(this.btn2h_Click);
            // 
            // btn3h
            // 
            this.btn3h.BackColor = System.Drawing.Color.RosyBrown;
            this.btn3h.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn3h.Location = new System.Drawing.Point(193, 252);
            this.btn3h.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn3h.Name = "btn3h";
            this.btn3h.Size = new System.Drawing.Size(164, 49);
            this.btn3h.TabIndex = 6;
            this.btn3h.Text = "off in 3h";
            this.btn3h.UseVisualStyleBackColor = false;
            this.btn3h.Click += new System.EventHandler(this.btn3h_Click);
            // 
            // btn4h
            // 
            this.btn4h.BackColor = System.Drawing.Color.RosyBrown;
            this.btn4h.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn4h.Location = new System.Drawing.Point(568, 252);
            this.btn4h.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn4h.Name = "btn4h";
            this.btn4h.Size = new System.Drawing.Size(164, 49);
            this.btn4h.TabIndex = 8;
            this.btn4h.Text = "off in 4h";
            this.btn4h.UseVisualStyleBackColor = false;
            this.btn4h.Click += new System.EventHandler(this.btn4h_Click);
            // 
            // btn1h
            // 
            this.btn1h.BackColor = System.Drawing.Color.RosyBrown;
            this.btn1h.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn1h.Location = new System.Drawing.Point(16, 193);
            this.btn1h.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn1h.Name = "btn1h";
            this.btn1h.Size = new System.Drawing.Size(164, 49);
            this.btn1h.TabIndex = 9;
            this.btn1h.Text = "off in 1,0h";
            this.btn1h.UseVisualStyleBackColor = false;
            this.btn1h.Click += new System.EventHandler(this.btn1h_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 315);
            this.Controls.Add(this.btn1h);
            this.Controls.Add(this.btn4h);
            this.Controls.Add(this.btn3h);
            this.Controls.Add(this.btn2h);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnStop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "ShutUp windows";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn2h;
        private System.Windows.Forms.Button btn3h;
        private System.Windows.Forms.Button btn4h;
        private System.Windows.Forms.Button btn1h;
    }
}

