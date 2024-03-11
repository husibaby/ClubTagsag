namespace ClubTagsagGrafikus
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
            this.listBox_Members = new System.Windows.Forms.ListBox();
            this.groupBox_chosemembers = new System.Windows.Forms.GroupBox();
            this.numericUpDown_ID = new System.Windows.Forms.NumericUpDown();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_read = new System.Windows.Forms.Button();
            this.button_insert = new System.Windows.Forms.Button();
            this.dateTimePicker_Entry = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown_Rating = new System.Windows.Forms.NumericUpDown();
            this.label_Rating = new System.Windows.Forms.Label();
            this.textBox_Interest = new System.Windows.Forms.TextBox();
            this.label_Interest = new System.Windows.Forms.Label();
            this.textBox_Fullname = new System.Windows.Forms.TextBox();
            this.label_Fullname = new System.Windows.Forms.Label();
            this.label_Entry = new System.Windows.Forms.Label();
            this.label_Id = new System.Windows.Forms.Label();
            this.groupBox_chosemembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Rating)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Members
            // 
            this.listBox_Members.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_Members.FormattingEnabled = true;
            this.listBox_Members.Location = new System.Drawing.Point(0, 0);
            this.listBox_Members.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_Members.Name = "listBox_Members";
            this.listBox_Members.Size = new System.Drawing.Size(189, 292);
            this.listBox_Members.TabIndex = 0;
            this.listBox_Members.SelectedIndexChanged += new System.EventHandler(this.listbox_Members_SelectedIndexChanged);
            // 
            // groupBox_chosemembers
            // 
            this.groupBox_chosemembers.Controls.Add(this.numericUpDown_ID);
            this.groupBox_chosemembers.Controls.Add(this.button_delete);
            this.groupBox_chosemembers.Controls.Add(this.button_update);
            this.groupBox_chosemembers.Controls.Add(this.button_read);
            this.groupBox_chosemembers.Controls.Add(this.button_insert);
            this.groupBox_chosemembers.Controls.Add(this.dateTimePicker_Entry);
            this.groupBox_chosemembers.Controls.Add(this.numericUpDown_Rating);
            this.groupBox_chosemembers.Controls.Add(this.label_Rating);
            this.groupBox_chosemembers.Controls.Add(this.textBox_Interest);
            this.groupBox_chosemembers.Controls.Add(this.label_Interest);
            this.groupBox_chosemembers.Controls.Add(this.textBox_Fullname);
            this.groupBox_chosemembers.Controls.Add(this.label_Fullname);
            this.groupBox_chosemembers.Controls.Add(this.label_Entry);
            this.groupBox_chosemembers.Controls.Add(this.label_Id);
            this.groupBox_chosemembers.Location = new System.Drawing.Point(185, 2);
            this.groupBox_chosemembers.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_chosemembers.Name = "groupBox_chosemembers";
            this.groupBox_chosemembers.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_chosemembers.Size = new System.Drawing.Size(346, 290);
            this.groupBox_chosemembers.TabIndex = 1;
            this.groupBox_chosemembers.TabStop = false;
            this.groupBox_chosemembers.Text = "Kiválasztott tag";
            // 
            // numericUpDown_ID
            // 
            this.numericUpDown_ID.Location = new System.Drawing.Point(25, 35);
            this.numericUpDown_ID.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_ID.Name = "numericUpDown_ID";
            this.numericUpDown_ID.ReadOnly = true;
            this.numericUpDown_ID.Size = new System.Drawing.Size(83, 20);
            this.numericUpDown_ID.TabIndex = 15;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(245, 168);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(73, 21);
            this.button_delete.TabIndex = 14;
            this.button_delete.Text = "törlés";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(245, 124);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(73, 21);
            this.button_update.TabIndex = 13;
            this.button_update.Text = "módósítás";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_read
            // 
            this.button_read.Location = new System.Drawing.Point(245, 79);
            this.button_read.Name = "button_read";
            this.button_read.Size = new System.Drawing.Size(73, 21);
            this.button_read.TabIndex = 12;
            this.button_read.Text = "olvasás";
            this.button_read.UseVisualStyleBackColor = true;
            this.button_read.Click += new System.EventHandler(this.button_read_Click);
            // 
            // button_insert
            // 
            this.button_insert.Location = new System.Drawing.Point(245, 35);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(73, 21);
            this.button_insert.TabIndex = 11;
            this.button_insert.Text = "új";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // dateTimePicker_Entry
            // 
            this.dateTimePicker_Entry.Location = new System.Drawing.Point(30, 198);
            this.dateTimePicker_Entry.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_Entry.Name = "dateTimePicker_Entry";
            this.dateTimePicker_Entry.Size = new System.Drawing.Size(91, 20);
            this.dateTimePicker_Entry.TabIndex = 10;
            // 
            // numericUpDown_Rating
            // 
            this.numericUpDown_Rating.Location = new System.Drawing.Point(28, 140);
            this.numericUpDown_Rating.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_Rating.Name = "numericUpDown_Rating";
            this.numericUpDown_Rating.Size = new System.Drawing.Size(83, 20);
            this.numericUpDown_Rating.TabIndex = 9;
            // 
            // label_Rating
            // 
            this.label_Rating.AutoSize = true;
            this.label_Rating.Location = new System.Drawing.Point(27, 115);
            this.label_Rating.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Rating.Name = "label_Rating";
            this.label_Rating.Size = new System.Drawing.Size(51, 13);
            this.label_Rating.TabIndex = 8;
            this.label_Rating.Text = "Értékelés";
            // 
            // textBox_Interest
            // 
            this.textBox_Interest.Location = new System.Drawing.Point(30, 252);
            this.textBox_Interest.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Interest.Name = "textBox_Interest";
            this.textBox_Interest.ReadOnly = true;
            this.textBox_Interest.Size = new System.Drawing.Size(87, 20);
            this.textBox_Interest.TabIndex = 7;
            // 
            // label_Interest
            // 
            this.label_Interest.AutoSize = true;
            this.label_Interest.Location = new System.Drawing.Point(27, 235);
            this.label_Interest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Interest.Name = "label_Interest";
            this.label_Interest.Size = new System.Drawing.Size(80, 13);
            this.label_Interest.TabIndex = 6;
            this.label_Interest.Text = "Érdeklődési kör";
            // 
            // textBox_Fullname
            // 
            this.textBox_Fullname.Location = new System.Drawing.Point(25, 80);
            this.textBox_Fullname.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Fullname.Name = "textBox_Fullname";
            this.textBox_Fullname.ReadOnly = true;
            this.textBox_Fullname.Size = new System.Drawing.Size(87, 20);
            this.textBox_Fullname.TabIndex = 5;
            // 
            // label_Fullname
            // 
            this.label_Fullname.AutoSize = true;
            this.label_Fullname.Location = new System.Drawing.Point(25, 65);
            this.label_Fullname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Fullname.Name = "label_Fullname";
            this.label_Fullname.Size = new System.Drawing.Size(56, 13);
            this.label_Fullname.TabIndex = 4;
            this.label_Fullname.Text = "Teljes név";
            // 
            // label_Entry
            // 
            this.label_Entry.AutoSize = true;
            this.label_Entry.Location = new System.Drawing.Point(27, 174);
            this.label_Entry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Entry.Name = "label_Entry";
            this.label_Entry.Size = new System.Drawing.Size(45, 13);
            this.label_Entry.TabIndex = 2;
            this.label_Entry.Text = "Belépés";
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Location = new System.Drawing.Point(25, 14);
            this.label_Id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(15, 13);
            this.label_Id.TabIndex = 0;
            this.label_Id.Text = "id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.groupBox_chosemembers);
            this.Controls.Add(this.listBox_Members);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_chosemembers.ResumeLayout(false);
            this.groupBox_chosemembers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Rating)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox listBox_Members;
        private System.Windows.Forms.GroupBox groupBox_chosemembers;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Label label_Entry;
        private System.Windows.Forms.NumericUpDown numericUpDown_Rating;
        private System.Windows.Forms.Label label_Rating;
        private System.Windows.Forms.TextBox textBox_Interest;
        private System.Windows.Forms.Label label_Interest;
        private System.Windows.Forms.TextBox textBox_Fullname;
        private System.Windows.Forms.Label label_Fullname;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Entry;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_read;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.NumericUpDown numericUpDown_ID;
    }
}

