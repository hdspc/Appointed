
namespace C969
{
    partial class Dashboard
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
            this.appointmentDGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AddAppointment = new System.Windows.Forms.Button();
            this.btn_EditAppointment = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rdo_Monthly = new System.Windows.Forms.RadioButton();
            this.rdo_Weekly = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_ALL = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_currentUser = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_GenerateReports = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // appointmentDGV
            // 
            this.appointmentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentDGV.Location = new System.Drawing.Point(48, 137);
            this.appointmentDGV.MultiSelect = false;
            this.appointmentDGV.Name = "appointmentDGV";
            this.appointmentDGV.ReadOnly = true;
            this.appointmentDGV.RowHeadersVisible = false;
            this.appointmentDGV.Size = new System.Drawing.Size(717, 231);
            this.appointmentDGV.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 18.25F);
            this.label2.Location = new System.Drawing.Point(43, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Appointment dashboard";
            // 
            // btn_AddAppointment
            // 
            this.btn_AddAppointment.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.btn_AddAppointment.Location = new System.Drawing.Point(48, 408);
            this.btn_AddAppointment.Name = "btn_AddAppointment";
            this.btn_AddAppointment.Size = new System.Drawing.Size(256, 40);
            this.btn_AddAppointment.TabIndex = 3;
            this.btn_AddAppointment.Text = "Add Appointment";
            this.btn_AddAppointment.UseVisualStyleBackColor = true;
            this.btn_AddAppointment.Click += new System.EventHandler(this.btn_AddAppointment_Click);
            // 
            // btn_EditAppointment
            // 
            this.btn_EditAppointment.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.btn_EditAppointment.Location = new System.Drawing.Point(48, 454);
            this.btn_EditAppointment.Name = "btn_EditAppointment";
            this.btn_EditAppointment.Size = new System.Drawing.Size(256, 40);
            this.btn_EditAppointment.TabIndex = 4;
            this.btn_EditAppointment.Text = "Edit Appointment";
            this.btn_EditAppointment.UseVisualStyleBackColor = true;
            this.btn_EditAppointment.Click += new System.EventHandler(this.btn_EditAppointment_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(48, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "refresh appts";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdo_Monthly
            // 
            this.rdo_Monthly.AutoSize = true;
            this.rdo_Monthly.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_Monthly.Location = new System.Drawing.Point(4, 30);
            this.rdo_Monthly.Name = "rdo_Monthly";
            this.rdo_Monthly.Size = new System.Drawing.Size(84, 23);
            this.rdo_Monthly.TabIndex = 6;
            this.rdo_Monthly.Text = "Monthly";
            this.rdo_Monthly.UseVisualStyleBackColor = true;
            this.rdo_Monthly.CheckedChanged += new System.EventHandler(this.rdo_Monthly_CheckedChanged);
            // 
            // rdo_Weekly
            // 
            this.rdo_Weekly.AutoSize = true;
            this.rdo_Weekly.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_Weekly.Location = new System.Drawing.Point(5, 66);
            this.rdo_Weekly.Name = "rdo_Weekly";
            this.rdo_Weekly.Size = new System.Drawing.Size(79, 23);
            this.rdo_Weekly.TabIndex = 7;
            this.rdo_Weekly.Text = "Weekly";
            this.rdo_Weekly.UseVisualStyleBackColor = true;
            this.rdo_Weekly.CheckedChanged += new System.EventHandler(this.rdo_Weekly_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_ALL);
            this.groupBox1.Controls.Add(this.rdo_Weekly);
            this.groupBox1.Controls.Add(this.rdo_Monthly);
            this.groupBox1.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.groupBox1.Location = new System.Drawing.Point(585, 408);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 130);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appointment View";
            // 
            // rdo_ALL
            // 
            this.rdo_ALL.AutoSize = true;
            this.rdo_ALL.Checked = true;
            this.rdo_ALL.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_ALL.Location = new System.Drawing.Point(6, 101);
            this.rdo_ALL.Name = "rdo_ALL";
            this.rdo_ALL.Size = new System.Drawing.Size(53, 23);
            this.rdo_ALL.TabIndex = 8;
            this.rdo_ALL.TabStop = true;
            this.rdo_ALL.Text = "ALL";
            this.rdo_ALL.UseVisualStyleBackColor = true;
            this.rdo_ALL.CheckedChanged += new System.EventHandler(this.rdo_ALL_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 14.25F);
            this.label3.Location = new System.Drawing.Point(609, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "User:";
            // 
            // txt_currentUser
            // 
            this.txt_currentUser.AutoSize = true;
            this.txt_currentUser.Font = new System.Drawing.Font("Meiryo UI", 14.25F);
            this.txt_currentUser.Location = new System.Drawing.Point(672, 91);
            this.txt_currentUser.Name = "txt_currentUser";
            this.txt_currentUser.Size = new System.Drawing.Size(46, 24);
            this.txt_currentUser.TabIndex = 10;
            this.txt_currentUser.Text = "N/A";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Meiryo UI", 12.25F);
            this.button2.Location = new System.Drawing.Point(607, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 40);
            this.button2.TabIndex = 11;
            this.button2.Text = "Account Settings";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_GenerateReports
            // 
            this.btn_GenerateReports.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.btn_GenerateReports.Location = new System.Drawing.Point(48, 546);
            this.btn_GenerateReports.Name = "btn_GenerateReports";
            this.btn_GenerateReports.Size = new System.Drawing.Size(256, 40);
            this.btn_GenerateReports.TabIndex = 12;
            this.btn_GenerateReports.Text = "Generate Reports";
            this.btn_GenerateReports.UseVisualStyleBackColor = true;
            this.btn_GenerateReports.Click += new System.EventHandler(this.btn_GenerateReports_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 612);
            this.Controls.Add(this.btn_GenerateReports);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_currentUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_EditAppointment);
            this.Controls.Add(this.btn_AddAppointment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.appointmentDGV);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView appointmentDGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_AddAppointment;
        private System.Windows.Forms.Button btn_EditAppointment;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdo_Monthly;
        private System.Windows.Forms.RadioButton rdo_Weekly;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txt_currentUser;
        private System.Windows.Forms.RadioButton rdo_ALL;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_GenerateReports;
    }
}