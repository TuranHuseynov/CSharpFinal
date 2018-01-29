namespace CodeAcademy
{
    partial class AddTaskType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTaskType));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.typeName = new System.Windows.Forms.TextBox();
            this.typeRate = new System.Windows.Forms.TextBox();
            this.addType = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.dataGridType = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridType)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type Rate :";
            // 
            // typeName
            // 
            this.typeName.BackColor = System.Drawing.SystemColors.Control;
            this.typeName.Location = new System.Drawing.Point(288, 16);
            this.typeName.Name = "typeName";
            this.typeName.Size = new System.Drawing.Size(130, 20);
            this.typeName.TabIndex = 2;
            // 
            // typeRate
            // 
            this.typeRate.BackColor = System.Drawing.SystemColors.Control;
            this.typeRate.Location = new System.Drawing.Point(288, 65);
            this.typeRate.Name = "typeRate";
            this.typeRate.Size = new System.Drawing.Size(130, 20);
            this.typeRate.TabIndex = 3;
            // 
            // addType
            // 
            this.addType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addType.Location = new System.Drawing.Point(487, 103);
            this.addType.Name = "addType";
            this.addType.Size = new System.Drawing.Size(79, 33);
            this.addType.TabIndex = 4;
            this.addType.Text = "Add";
            this.addType.UseVisualStyleBackColor = true;
            this.addType.Click += new System.EventHandler(this.addType_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Transparent;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.update.Location = new System.Drawing.Point(64, 261);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(67, 28);
            this.update.TabIndex = 5;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Transparent;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete.Location = new System.Drawing.Point(64, 294);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(67, 28);
            this.delete.TabIndex = 6;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // dataGridType
            // 
            this.dataGridType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2});
            this.dataGridType.Location = new System.Drawing.Point(248, 258);
            this.dataGridType.Name = "dataGridType";
            this.dataGridType.Size = new System.Drawing.Size(419, 150);
            this.dataGridType.TabIndex = 7;
            this.dataGridType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridType_CellContentClick);
            // 
            // Column3
            // 
            this.Column3.FillWeight = 30.45685F;
            this.Column3.HeaderText = "id";
            this.Column3.Name = "Column3";
            // 
            // Column1
            // 
            this.Column1.FillWeight = 134.7716F;
            this.Column1.HeaderText = "Type Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 134.7716F;
            this.Column2.HeaderText = "Type Rate";
            this.Column2.Name = "Column2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Lucida Calligraphy", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Maroon;
            this.label13.Location = new System.Drawing.Point(42, 376);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(183, 27);
            this.label13.TabIndex = 30;
            this.label13.Text = "Code Academy";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Baskerville Old Face", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label12.Location = new System.Drawing.Point(564, 234);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 21);
            this.label12.TabIndex = 31;
            this.label12.Text = "Task Types";
            // 
            // AddTaskType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(672, 412);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dataGridType);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.addType);
            this.Controls.Add(this.typeRate);
            this.Controls.Add(this.typeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AddTaskType";
            this.Text = "AddTaskType";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox typeName;
        private System.Windows.Forms.TextBox typeRate;
        private System.Windows.Forms.Button addType;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridView dataGridType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}