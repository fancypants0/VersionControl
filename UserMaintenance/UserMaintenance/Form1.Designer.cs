namespace UserMaintenance
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.l_fist = new System.Windows.Forms.Label();
            this.l_last = new System.Windows.Forms.Label();
            this.tb_first = new System.Windows.Forms.TextBox();
            this.tb_last = new System.Windows.Forms.TextBox();
            this.b_save = new System.Windows.Forms.Button();
            this.b_write = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(330, 404);
            this.listBox1.TabIndex = 0;
            // 
            // l_fist
            // 
            this.l_fist.AutoSize = true;
            this.l_fist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_fist.Location = new System.Drawing.Point(348, 17);
            this.l_fist.Name = "l_fist";
            this.l_fist.Size = new System.Drawing.Size(76, 25);
            this.l_fist.TabIndex = 1;
            this.l_fist.Text = "label1";
            // 
            // l_last
            // 
            this.l_last.AutoSize = true;
            this.l_last.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_last.Location = new System.Drawing.Point(348, 54);
            this.l_last.Name = "l_last";
            this.l_last.Size = new System.Drawing.Size(76, 25);
            this.l_last.TabIndex = 2;
            this.l_last.Text = "label2";
            // 
            // tb_first
            // 
            this.tb_first.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_first.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_first.Location = new System.Drawing.Point(473, 14);
            this.tb_first.Name = "tb_first";
            this.tb_first.Size = new System.Drawing.Size(195, 31);
            this.tb_first.TabIndex = 3;
            // 
            // tb_last
            // 
            this.tb_last.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_last.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_last.Location = new System.Drawing.Point(473, 51);
            this.tb_last.Name = "tb_last";
            this.tb_last.Size = new System.Drawing.Size(195, 31);
            this.tb_last.TabIndex = 4;
            // 
            // b_save
            // 
            this.b_save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_save.Location = new System.Drawing.Point(353, 88);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(315, 43);
            this.b_save.TabIndex = 5;
            this.b_save.Text = "button1";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // b_write
            // 
            this.b_write.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b_write.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_write.Location = new System.Drawing.Point(348, 373);
            this.b_write.Name = "b_write";
            this.b_write.Size = new System.Drawing.Size(315, 43);
            this.b_write.TabIndex = 6;
            this.b_write.Text = "button1";
            this.b_write.UseVisualStyleBackColor = true;
            this.b_write.Click += new System.EventHandler(this.b_write_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 430);
            this.Controls.Add(this.b_write);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.tb_last);
            this.Controls.Add(this.tb_first);
            this.Controls.Add(this.l_last);
            this.Controls.Add(this.l_fist);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "user";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label l_fist;
        private System.Windows.Forms.Label l_last;
        private System.Windows.Forms.TextBox tb_first;
        private System.Windows.Forms.TextBox tb_last;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.Button b_write;
    }
}

