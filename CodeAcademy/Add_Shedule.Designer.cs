namespace CodeAcademy
{
    partial class Add_Shedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Shedule));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.scheduleName = new System.Windows.Forms.TextBox();
            this.beginTime = new System.Windows.Forms.DateTimePicker();
            this.endTime = new System.Windows.Forms.DateTimePicker();
            this.addSchedule = new System.Windows.Forms.Button();
            this.dataGridSchedule = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shedule Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(563, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Begin Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(571, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "End Time";
            // 
            // scheduleName
            // 
            this.scheduleName.BackColor = System.Drawing.SystemColors.Control;
            this.scheduleName.Location = new System.Drawing.Point(370, 32);
            this.scheduleName.Name = "scheduleName";
            this.scheduleName.Size = new System.Drawing.Size(144, 20);
            this.scheduleName.TabIndex = 3;
            // 
            // beginTime
            // 
            this.beginTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginTime.CalendarForeColor = System.Drawing.Color.Transparent;
            this.beginTime.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.beginTime.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.beginTime.CalendarTitleForeColor = System.Drawing.Color.Transparent;
            this.beginTime.Location = new System.Drawing.Point(663, 8);
            this.beginTime.Name = "beginTime";
            this.beginTime.Size = new System.Drawing.Size(200, 20);
            this.beginTime.TabIndex = 4;
            // 
            // endTime
            // 
            this.endTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTime.CalendarForeColor = System.Drawing.Color.Transparent;
            this.endTime.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.endTime.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.endTime.CalendarTitleForeColor = System.Drawing.Color.Transparent;
            this.endTime.Location = new System.Drawing.Point(664, 50);
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(200, 20);
            this.endTime.TabIndex = 5;
            // 
            // addSchedule
            // 
            this.addSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSchedule.Location = new System.Drawing.Point(782, 104);
            this.addSchedule.Name = "addSchedule";
            this.addSchedule.Size = new System.Drawing.Size(108, 35);
            this.addSchedule.TabIndex = 6;
            this.addSchedule.Text = "Add Schedule";
            this.addSchedule.UseVisualStyleBackColor = true;
            this.addSchedule.Click += new System.EventHandler(this.addSchedule_Click);
            // 
            // dataGridSchedule
            // 
            this.dataGridSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column3});
            this.dataGridSchedule.Location = new System.Drawing.Point(300, 338);
            this.dataGridSchedule.Name = "dataGridSchedule";
            this.dataGridSchedule.Size = new System.Drawing.Size(635, 154);
            this.dataGridSchedule.TabIndex = 7;
            this.dataGridSchedule.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridSchedule_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 40.60913F;
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            // 
            // Column4
            // 
            this.Column4.FillWeight = 119.797F;
            this.Column4.HeaderText = "Schedule Name";
            this.Column4.Name = "Column4";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 119.797F;
            this.Column2.HeaderText = "Begin Time";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.FillWeight = 119.797F;
            this.Column3.HeaderText = "End Time";
            this.Column3.Name = "Column3";
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Transparent;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.update.Location = new System.Drawing.Point(88, 302);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(100, 39);
            this.update.TabIndex = 8;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Transparent;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.delete.Location = new System.Drawing.Point(88, 352);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(100, 38);
            this.delete.TabIndex = 9;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Baskerville Old Face", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(845, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Shedules";
            // 
            // Add_Shedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(947, 495);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.dataGridSchedule);
            this.Controls.Add(this.addSchedule);
            this.Controls.Add(this.endTime);
            this.Controls.Add(this.beginTime);
            this.Controls.Add(this.scheduleName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Add_Shedule";
            this.Text = "Add_Shedule";
            this.Load += new System.EventHandler(this.Add_Shedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox scheduleName;
        private System.Windows.Forms.DateTimePicker beginTime;
        private System.Windows.Forms.DateTimePicker endTime;
        private System.Windows.Forms.Button addSchedule;
        private System.Windows.Forms.DataGridView dataGridSchedule;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label4;
    }
}