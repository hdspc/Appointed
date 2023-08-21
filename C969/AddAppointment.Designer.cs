
namespace C969
{
    partial class AddAppointment
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_AppointmentID = new System.Windows.Forms.TextBox();
            this.datetime_AppointmentStart = new System.Windows.Forms.DateTimePicker();
            this.dropdown_AppointmentType = new System.Windows.Forms.ComboBox();
            this.btn_AddAppointment_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_CreatedDate = new System.Windows.Forms.TextBox();
            this.txt_CreatedBy = new System.Windows.Forms.TextBox();
            this.txt_LastUpdate = new System.Windows.Forms.TextBox();
            this.txt_LastUpdateBy = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_URL = new System.Windows.Forms.TextBox();
            this.txt_Contact = new System.Windows.Forms.TextBox();
            this.txt_Location = new System.Windows.Forms.TextBox();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.datetime_AppointmentEnd = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dropdown_customerName = new System.Windows.Forms.ComboBox();
            this.dropdown_UserID = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 9.25F);
            this.label1.Location = new System.Drawing.Point(62, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Appointment ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 9.25F);
            this.label2.Location = new System.Drawing.Point(61, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 9.25F);
            this.label3.Location = new System.Drawing.Point(316, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "User ID*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Meiryo UI", 10.25F);
            this.label4.Location = new System.Drawing.Point(37, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Meiryo UI", 10.25F);
            this.label5.Location = new System.Drawing.Point(38, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Appointment Start:";
            // 
            // txt_AppointmentID
            // 
            this.txt_AppointmentID.Enabled = false;
            this.txt_AppointmentID.Location = new System.Drawing.Point(186, 42);
            this.txt_AppointmentID.Name = "txt_AppointmentID";
            this.txt_AppointmentID.Size = new System.Drawing.Size(49, 23);
            this.txt_AppointmentID.TabIndex = 5;
            // 
            // datetime_AppointmentStart
            // 
            this.datetime_AppointmentStart.CustomFormat = "ddd dd MMM yyyy HH:mm:ss tt";
            this.datetime_AppointmentStart.Location = new System.Drawing.Point(177, 238);
            this.datetime_AppointmentStart.Name = "datetime_AppointmentStart";
            this.datetime_AppointmentStart.Size = new System.Drawing.Size(257, 23);
            this.datetime_AppointmentStart.TabIndex = 8;
            // 
            // dropdown_AppointmentType
            // 
            this.dropdown_AppointmentType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dropdown_AppointmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdown_AppointmentType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.dropdown_AppointmentType.FormattingEnabled = true;
            this.dropdown_AppointmentType.Items.AddRange(new object[] {
            "Scrum",
            "Presentation"});
            this.dropdown_AppointmentType.Location = new System.Drawing.Point(115, 162);
            this.dropdown_AppointmentType.Name = "dropdown_AppointmentType";
            this.dropdown_AppointmentType.Size = new System.Drawing.Size(319, 23);
            this.dropdown_AppointmentType.TabIndex = 11;
            // 
            // btn_AddAppointment_Save
            // 
            this.btn_AddAppointment_Save.Location = new System.Drawing.Point(52, 568);
            this.btn_AddAppointment_Save.Name = "btn_AddAppointment_Save";
            this.btn_AddAppointment_Save.Size = new System.Drawing.Size(157, 51);
            this.btn_AddAppointment_Save.TabIndex = 12;
            this.btn_AddAppointment_Save.Text = "Save";
            this.btn_AddAppointment_Save.UseVisualStyleBackColor = true;
            this.btn_AddAppointment_Save.Click += new System.EventHandler(this.btn_AddAppointment_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(292, 568);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(154, 51);
            this.btn_Cancel.TabIndex = 13;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_CreatedDate);
            this.groupBox1.Controls.Add(this.txt_CreatedBy);
            this.groupBox1.Controls.Add(this.txt_LastUpdate);
            this.groupBox1.Controls.Add(this.txt_LastUpdateBy);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt_URL);
            this.groupBox1.Controls.Add(this.txt_Contact);
            this.groupBox1.Controls.Add(this.txt_Location);
            this.groupBox1.Controls.Add(this.txt_Description);
            this.groupBox1.Controls.Add(this.txt_Title);
            this.groupBox1.Controls.Add(this.datetime_AppointmentEnd);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dropdown_AppointmentType);
            this.groupBox1.Controls.Add(this.datetime_AppointmentStart);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(24, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 416);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appointment Details";
            // 
            // txt_CreatedDate
            // 
            this.txt_CreatedDate.Enabled = false;
            this.txt_CreatedDate.Location = new System.Drawing.Point(177, 297);
            this.txt_CreatedDate.Name = "txt_CreatedDate";
            this.txt_CreatedDate.Size = new System.Drawing.Size(257, 23);
            this.txt_CreatedDate.TabIndex = 31;
            // 
            // txt_CreatedBy
            // 
            this.txt_CreatedBy.Enabled = false;
            this.txt_CreatedBy.Location = new System.Drawing.Point(177, 324);
            this.txt_CreatedBy.Name = "txt_CreatedBy";
            this.txt_CreatedBy.Size = new System.Drawing.Size(257, 23);
            this.txt_CreatedBy.TabIndex = 30;
            // 
            // txt_LastUpdate
            // 
            this.txt_LastUpdate.Enabled = false;
            this.txt_LastUpdate.Location = new System.Drawing.Point(177, 351);
            this.txt_LastUpdate.Name = "txt_LastUpdate";
            this.txt_LastUpdate.Size = new System.Drawing.Size(257, 23);
            this.txt_LastUpdate.TabIndex = 29;
            // 
            // txt_LastUpdateBy
            // 
            this.txt_LastUpdateBy.Enabled = false;
            this.txt_LastUpdateBy.Location = new System.Drawing.Point(177, 378);
            this.txt_LastUpdateBy.Name = "txt_LastUpdateBy";
            this.txt_LastUpdateBy.Size = new System.Drawing.Size(257, 23);
            this.txt_LastUpdateBy.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Meiryo UI", 10.25F);
            this.label15.Location = new System.Drawing.Point(38, 378);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 18);
            this.label15.TabIndex = 27;
            this.label15.Text = "Last Update By:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Meiryo UI", 10.25F);
            this.label14.Location = new System.Drawing.Point(37, 351);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 18);
            this.label14.TabIndex = 26;
            this.label14.Text = "Last Update:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Meiryo UI", 10.25F);
            this.label13.Location = new System.Drawing.Point(38, 324);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 18);
            this.label13.TabIndex = 25;
            this.label13.Text = "CreatedBy:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Meiryo UI", 10.25F);
            this.label12.Location = new System.Drawing.Point(38, 297);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 18);
            this.label12.TabIndex = 24;
            this.label12.Text = "Created Date:";
            // 
            // txt_URL
            // 
            this.txt_URL.Location = new System.Drawing.Point(115, 199);
            this.txt_URL.Name = "txt_URL";
            this.txt_URL.Size = new System.Drawing.Size(319, 23);
            this.txt_URL.TabIndex = 23;
            // 
            // txt_Contact
            // 
            this.txt_Contact.Location = new System.Drawing.Point(117, 132);
            this.txt_Contact.Name = "txt_Contact";
            this.txt_Contact.Size = new System.Drawing.Size(317, 23);
            this.txt_Contact.TabIndex = 22;
            // 
            // txt_Location
            // 
            this.txt_Location.Location = new System.Drawing.Point(117, 93);
            this.txt_Location.Name = "txt_Location";
            this.txt_Location.Size = new System.Drawing.Size(317, 23);
            this.txt_Location.TabIndex = 21;
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(148, 63);
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(286, 23);
            this.txt_Description.TabIndex = 20;
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(115, 28);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(319, 23);
            this.txt_Title.TabIndex = 19;
            // 
            // datetime_AppointmentEnd
            // 
            this.datetime_AppointmentEnd.CustomFormat = "ddd dd MMM yyyy HH:mm:ss tt";
            this.datetime_AppointmentEnd.Location = new System.Drawing.Point(177, 267);
            this.datetime_AppointmentEnd.Name = "datetime_AppointmentEnd";
            this.datetime_AppointmentEnd.Size = new System.Drawing.Size(257, 23);
            this.datetime_AppointmentEnd.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Meiryo UI", 10.25F);
            this.label11.Location = new System.Drawing.Point(38, 270);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 18);
            this.label11.TabIndex = 17;
            this.label11.Text = "Appointment End:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Meiryo UI", 10.25F);
            this.label10.Location = new System.Drawing.Point(39, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 18);
            this.label10.TabIndex = 16;
            this.label10.Text = "URL:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Meiryo UI", 10.25F);
            this.label9.Location = new System.Drawing.Point(37, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "Contact:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Meiryo UI", 10.25F);
            this.label8.Location = new System.Drawing.Point(38, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Location:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Meiryo UI", 10.25F);
            this.label7.Location = new System.Drawing.Point(38, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Description:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Meiryo UI", 10.25F);
            this.label6.Location = new System.Drawing.Point(39, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Title:";
            // 
            // dropdown_customerName
            // 
            this.dropdown_customerName.FormattingEnabled = true;
            this.dropdown_customerName.Location = new System.Drawing.Point(186, 86);
            this.dropdown_customerName.Name = "dropdown_customerName";
            this.dropdown_customerName.Size = new System.Drawing.Size(246, 23);
            this.dropdown_customerName.TabIndex = 15;
            this.dropdown_customerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dropdown_customerName_KeyPress);
            // 
            // dropdown_UserID
            // 
            this.dropdown_UserID.FormattingEnabled = true;
            this.dropdown_UserID.Location = new System.Drawing.Point(383, 13);
            this.dropdown_UserID.Name = "dropdown_UserID";
            this.dropdown_UserID.Size = new System.Drawing.Size(49, 23);
            this.dropdown_UserID.TabIndex = 16;
            this.dropdown_UserID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dropdown_UserID_KeyPress);
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 644);
            this.Controls.Add(this.dropdown_UserID);
            this.Controls.Add(this.dropdown_customerName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_AddAppointment_Save);
            this.Controls.Add(this.txt_AppointmentID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Meiryo UI", 9.25F);
            this.Name = "AddAppointment";
            this.Text = "Add Appointment";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_AppointmentID;
        private System.Windows.Forms.DateTimePicker datetime_AppointmentStart;
        private System.Windows.Forms.ComboBox dropdown_AppointmentType;
        private System.Windows.Forms.Button btn_AddAppointment_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_URL;
        private System.Windows.Forms.TextBox txt_Contact;
        private System.Windows.Forms.TextBox txt_Location;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.DateTimePicker datetime_AppointmentEnd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_CreatedDate;
        private System.Windows.Forms.TextBox txt_CreatedBy;
        private System.Windows.Forms.TextBox txt_LastUpdate;
        private System.Windows.Forms.TextBox txt_LastUpdateBy;
        private System.Windows.Forms.ComboBox dropdown_customerName;
        private System.Windows.Forms.ComboBox dropdown_UserID;
    }
}