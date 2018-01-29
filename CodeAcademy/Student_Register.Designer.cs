namespace CodeAcademy
{
    partial class Student_Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Register));
            this.txt_s_pass = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.txt_s_email = new System.Windows.Forms.TextBox();
            this.elselabel = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_s_pass
            // 
            this.txt_s_pass.BackColor = System.Drawing.SystemColors.Control;
            this.txt_s_pass.Location = new System.Drawing.Point(155, 88);
            this.txt_s_pass.Name = "txt_s_pass";
            this.txt_s_pass.Size = new System.Drawing.Size(144, 20);
            this.txt_s_pass.TabIndex = 2;
            this.txt_s_pass.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(250, 128);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(70, 29);
            this.Login.TabIndex = 3;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // txt_s_email
            // 
            this.txt_s_email.BackColor = System.Drawing.SystemColors.Control;
            this.txt_s_email.Location = new System.Drawing.Point(155, 47);
            this.txt_s_email.Name = "txt_s_email";
            this.txt_s_email.Size = new System.Drawing.Size(144, 20);
            this.txt_s_email.TabIndex = 2;
            // 
            // elselabel
            // 
            this.elselabel.AutoSize = true;
            this.elselabel.BackColor = System.Drawing.Color.Transparent;
            this.elselabel.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elselabel.ForeColor = System.Drawing.Color.Brown;
            this.elselabel.Location = new System.Drawing.Point(79, 199);
            this.elselabel.Name = "elselabel";
            this.elselabel.Size = new System.Drawing.Size(0, 25);
            this.elselabel.TabIndex = 9;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(55, 262);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(0, 13);
            this.labelID.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(55, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(85, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email :";
            // 
            // Student_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(436, 329);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.elselabel);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.txt_s_email);
            this.Controls.Add(this.txt_s_pass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Student_Register";
            this.Text = "Student_Register";
            this.Load += new System.EventHandler(this.Student_Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_s_pass;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.TextBox txt_s_email;
        private System.Windows.Forms.Label elselabel;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}