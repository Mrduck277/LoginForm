namespace LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UserInput = new System.Windows.Forms.TextBox();
            this.PassInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorBox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 86);
            this.label1.TabIndex = 1;
            this.label1.Text = "Log in ";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(12, 280);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(137, 32);
            this.Username.TabIndex = 2;
            this.Username.Text = "Username: ";
            this.Username.Click += new System.EventHandler(this.Username_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(12, 367);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(129, 32);
            this.password.TabIndex = 3;
            this.password.Text = "Password: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Location = new System.Drawing.Point(18, 309);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 3);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Location = new System.Drawing.Point(18, 396);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 3);
            this.panel2.TabIndex = 5;
            // 
            // UserInput
            // 
            this.UserInput.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInput.Location = new System.Drawing.Point(143, 280);
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(193, 29);
            this.UserInput.TabIndex = 6;
            this.UserInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PassInput
            // 
            this.PassInput.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassInput.Location = new System.Drawing.Point(132, 367);
            this.PassInput.Name = "PassInput";
            this.PassInput.PasswordChar = '*';
            this.PassInput.Size = new System.Drawing.Size(204, 29);
            this.PassInput.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(29, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(328, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "LOG IN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Clear";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 548);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Quit";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(149, 507);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sign up";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // errorBox
            // 
            this.errorBox.AutoSize = true;
            this.errorBox.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorBox.Location = new System.Drawing.Point(5, 245);
            this.errorBox.Name = "errorBox";
            this.errorBox.Size = new System.Drawing.Size(379, 21);
            this.errorBox.TabIndex = 12;
            this.errorBox.Text = "Username or Password are inccorect, please try again";
            this.errorBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(388, 587);
            this.Controls.Add(this.errorBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PassInput);
            this.Controls.Add(this.UserInput);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(4, 235);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox UserInput;
        private System.Windows.Forms.TextBox PassInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label errorBox;
    }
}

