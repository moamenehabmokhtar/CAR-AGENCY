namespace DBProject
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.SignupBT = new System.Windows.Forms.Button();
            this.SignInBT = new System.Windows.Forms.Button();
            this.CarsBrandsBT = new System.Windows.Forms.Button();
            this.carBrand1 = new DBProject.CarBrand();
            this.signIn1 = new DBProject.SignIn();
            this.signUp1 = new DBProject.SignUp();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.SignupBT);
            this.panel1.Controls.Add(this.SignInBT);
            this.panel1.Controls.Add(this.CarsBrandsBT);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 528);
            this.panel1.TabIndex = 0;
            // 
            // SignupBT
            // 
            this.SignupBT.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SignupBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SignupBT.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SignupBT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SignupBT.Location = new System.Drawing.Point(6, 286);
            this.SignupBT.Name = "SignupBT";
            this.SignupBT.Size = new System.Drawing.Size(200, 49);
            this.SignupBT.TabIndex = 3;
            this.SignupBT.Text = "Sign up";
            this.SignupBT.UseVisualStyleBackColor = false;
            this.SignupBT.Click += new System.EventHandler(this.SignupBT_Click);
            // 
            // SignInBT
            // 
            this.SignInBT.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SignInBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SignInBT.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SignInBT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SignInBT.Location = new System.Drawing.Point(3, 219);
            this.SignInBT.Name = "SignInBT";
            this.SignInBT.Size = new System.Drawing.Size(200, 49);
            this.SignInBT.TabIndex = 2;
            this.SignInBT.Text = "Sign In";
            this.SignInBT.UseVisualStyleBackColor = false;
            this.SignInBT.Click += new System.EventHandler(this.SignInBT_Click);
            // 
            // CarsBrandsBT
            // 
            this.CarsBrandsBT.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CarsBrandsBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CarsBrandsBT.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CarsBrandsBT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CarsBrandsBT.Location = new System.Drawing.Point(3, 147);
            this.CarsBrandsBT.Name = "CarsBrandsBT";
            this.CarsBrandsBT.Size = new System.Drawing.Size(203, 49);
            this.CarsBrandsBT.TabIndex = 0;
            this.CarsBrandsBT.Text = "Cars Brands";
            this.CarsBrandsBT.UseVisualStyleBackColor = false;
            this.CarsBrandsBT.Click += new System.EventHandler(this.CarsBrandsBT_Click);
            // 
            // carBrand1
            // 
            this.carBrand1.Location = new System.Drawing.Point(209, 2);
            this.carBrand1.Name = "carBrand1";
            this.carBrand1.Size = new System.Drawing.Size(773, 525);
            this.carBrand1.TabIndex = 1;
            // 
            // signIn1
            // 
            this.signIn1.Location = new System.Drawing.Point(209, 2);
            this.signIn1.Name = "signIn1";
            this.signIn1.Size = new System.Drawing.Size(773, 525);
            this.signIn1.TabIndex = 2;
            // 
            // signUp1
            // 
            this.signUp1.Location = new System.Drawing.Point(209, 2);
            this.signUp1.Name = "signUp1";
            this.signUp1.Size = new System.Drawing.Size(773, 525);
            this.signUp1.TabIndex = 3;
            this.signUp1.Load += new System.EventHandler(this.signUp1_Load);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 528);
            this.Controls.Add(this.signUp1);
            this.Controls.Add(this.signIn1);
            this.Controls.Add(this.carBrand1);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button SignupBT;
        private Button SignInBT;
        private Button CarsBrandsBT;
        private CarBrand carBrand1;
        private SignIn signIn1;
        private SignUp signUp1;
    }
}