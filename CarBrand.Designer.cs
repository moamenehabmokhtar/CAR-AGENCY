namespace DBProject
{
    partial class CarBrand
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarBrand));
            this.MiniBT = new System.Windows.Forms.Button();
            this.BMW = new System.Windows.Forms.Button();
            this.PeugotBT = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MiniBT
            // 
            this.MiniBT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MiniBT.BackgroundImage")));
            this.MiniBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MiniBT.Location = new System.Drawing.Point(98, 58);
            this.MiniBT.Name = "MiniBT";
            this.MiniBT.Size = new System.Drawing.Size(191, 156);
            this.MiniBT.TabIndex = 0;
            this.MiniBT.UseVisualStyleBackColor = true;
            this.MiniBT.Click += new System.EventHandler(this.MiniBT_Click);
            // 
            // BMW
            // 
            this.BMW.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BMW.BackgroundImage")));
            this.BMW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BMW.Location = new System.Drawing.Point(479, 58);
            this.BMW.Name = "BMW";
            this.BMW.Size = new System.Drawing.Size(191, 156);
            this.BMW.TabIndex = 1;
            this.BMW.UseVisualStyleBackColor = true;
            this.BMW.Click += new System.EventHandler(this.BMWBT_Click);
            // 
            // PeugotBT
            // 
            this.PeugotBT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PeugotBT.BackgroundImage")));
            this.PeugotBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PeugotBT.Location = new System.Drawing.Point(292, 274);
            this.PeugotBT.Name = "PeugotBT";
            this.PeugotBT.Size = new System.Drawing.Size(191, 156);
            this.PeugotBT.TabIndex = 2;
            this.PeugotBT.UseVisualStyleBackColor = true;
            this.PeugotBT.Click += new System.EventHandler(this.PeugotBT_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(131, 231);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 36);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Mini";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(503, 231);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(117, 36);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "BMW";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(323, 436);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(117, 36);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Peugot";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CarBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PeugotBT);
            this.Controls.Add(this.BMW);
            this.Controls.Add(this.MiniBT);
            this.Name = "CarBrand";
            this.Size = new System.Drawing.Size(794, 525);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button MiniBT;
        private Button BMW;
        private Button PeugotBT;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}
