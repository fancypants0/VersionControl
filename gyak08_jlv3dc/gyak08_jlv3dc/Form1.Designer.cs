namespace gyak08_jlv3dc
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
            this.components = new System.ComponentModel.Container();
            this.p_main = new System.Windows.Forms.Panel();
            this.t_create = new System.Windows.Forms.Timer(this.components);
            this.t_conveyor = new System.Windows.Forms.Timer(this.components);
            this.b_product = new System.Windows.Forms.Button();
            this.p_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_main
            // 
            this.p_main.Controls.Add(this.b_product);
            this.p_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_main.Location = new System.Drawing.Point(0, 0);
            this.p_main.Name = "p_main";
            this.p_main.Size = new System.Drawing.Size(726, 344);
            this.p_main.TabIndex = 0;
            // 
            // t_create
            // 
            this.t_create.Enabled = true;
            this.t_create.Interval = 2000;
            this.t_create.Tick += new System.EventHandler(this.t_create_Tick);
            // 
            // t_conveyor
            // 
            this.t_conveyor.Enabled = true;
            this.t_conveyor.Interval = 6;
            this.t_conveyor.Tick += new System.EventHandler(this.t_conveyor_Tick);
            // 
            // b_product
            // 
            this.b_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_product.Location = new System.Drawing.Point(13, 13);
            this.b_product.Name = "b_product";
            this.b_product.Size = new System.Drawing.Size(75, 75);
            this.b_product.TabIndex = 0;
            this.b_product.Text = "Ball";
            this.b_product.UseVisualStyleBackColor = true;
            this.b_product.Click += new System.EventHandler(this.b_product_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 344);
            this.Controls.Add(this.p_main);
            this.Name = "Form1";
            this.Text = "what";
            this.p_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_main;
        private System.Windows.Forms.Timer t_create;
        private System.Windows.Forms.Timer t_conveyor;
        private System.Windows.Forms.Button b_product;
    }
}

