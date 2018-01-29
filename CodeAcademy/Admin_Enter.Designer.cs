namespace CodeAcademy
{
    partial class Admin_Enter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Enter));
            this.userName = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.enter = new System.Windows.Forms.Button();
            this.elselabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.userName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userName.Font = new System.Drawing.Font("Nirmala UI Semilight", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.ForeColor = System.Drawing.Color.SlateGray;
            this.userName.Location = new System.Drawing.Point(159, 37);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(163, 23);
            this.userName.TabIndex = 0;
            this.userName.Text = "username ..";
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(159, 83);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(163, 21);
            this.password.TabIndex = 1;
            this.password.UseSystemPasswordChar = true;
            this.password.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(25, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password :";
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.Color.Transparent;
            this.enter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.enter.Location = new System.Drawing.Point(254, 124);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(78, 26);
            this.enter.TabIndex = 4;
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // elselabel
            // 
            this.elselabel.AutoSize = true;
            this.elselabel.BackColor = System.Drawing.Color.Transparent;
            this.elselabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elselabel.ForeColor = System.Drawing.Color.Brown;
            this.elselabel.Location = new System.Drawing.Point(47, 191);
            this.elselabel.Name = "elselabel";
            this.elselabel.Size = new System.Drawing.Size(0, 29);
            this.elselabel.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Lucida Calligraphy", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Maroon;
            this.label13.Location = new System.Drawing.Point(578, 375);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(183, 27);
            this.label13.TabIndex = 31;
            this.label13.Text = "Code Academy";
            // 
            // Admin_Enter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(769, 410);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.elselabel);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userName);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Admin_Enter";
            this.Text = "Admin_Enter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Label elselabel;
        private System.Windows.Forms.Label label13;
    }
}