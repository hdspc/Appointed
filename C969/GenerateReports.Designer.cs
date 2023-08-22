
namespace C969
{
	partial class GenerateReports
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
            this.btn_NumberAppointmentTypesByMonth = new System.Windows.Forms.Button();
            this.btn_ConsultantSchedule = new System.Windows.Forms.Button();
            this.btn_customReport = new System.Windows.Forms.Button();
            this.txt_ReportTextBox = new System.Windows.Forms.RichTextBox();
            this.dropdown_Months = new System.Windows.Forms.ComboBox();
            this.dgv_consultantSchedule = new System.Windows.Forms.DataGridView();
            this.btn_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_UserID = new System.Windows.Forms.TextBox();
            this.btn_UserIDRefresh = new System.Windows.Forms.Button();
            this.lbl_UserIDEntry = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consultantSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_NumberAppointmentTypesByMonth
            // 
            this.btn_NumberAppointmentTypesByMonth.Font = new System.Drawing.Font("Meiryo UI", 10F);
            this.btn_NumberAppointmentTypesByMonth.Location = new System.Drawing.Point(82, 168);
            this.btn_NumberAppointmentTypesByMonth.Margin = new System.Windows.Forms.Padding(4);
            this.btn_NumberAppointmentTypesByMonth.Name = "btn_NumberAppointmentTypesByMonth";
            this.btn_NumberAppointmentTypesByMonth.Size = new System.Drawing.Size(262, 30);
            this.btn_NumberAppointmentTypesByMonth.TabIndex = 0;
            this.btn_NumberAppointmentTypesByMonth.Text = "Number of appt types by month";
            this.btn_NumberAppointmentTypesByMonth.UseVisualStyleBackColor = true;
            this.btn_NumberAppointmentTypesByMonth.Click += new System.EventHandler(this.btn_NumberAppointmentTypesByMonth_Click);
            // 
            // btn_ConsultantSchedule
            // 
            this.btn_ConsultantSchedule.Font = new System.Drawing.Font("Meiryo UI", 10F);
            this.btn_ConsultantSchedule.Location = new System.Drawing.Point(82, 226);
            this.btn_ConsultantSchedule.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ConsultantSchedule.Name = "btn_ConsultantSchedule";
            this.btn_ConsultantSchedule.Size = new System.Drawing.Size(262, 30);
            this.btn_ConsultantSchedule.TabIndex = 1;
            this.btn_ConsultantSchedule.Text = "Consultant Schedule";
            this.btn_ConsultantSchedule.UseVisualStyleBackColor = true;
            this.btn_ConsultantSchedule.Click += new System.EventHandler(this.btn_ConsultantSchedule_Click);
            // 
            // btn_customReport
            // 
            this.btn_customReport.Font = new System.Drawing.Font("Meiryo UI", 10F);
            this.btn_customReport.Location = new System.Drawing.Point(82, 284);
            this.btn_customReport.Margin = new System.Windows.Forms.Padding(4);
            this.btn_customReport.Name = "btn_customReport";
            this.btn_customReport.Size = new System.Drawing.Size(262, 62);
            this.btn_customReport.TabIndex = 2;
            this.btn_customReport.Text = "Number of appointments with Alfred Newman";
            this.btn_customReport.UseVisualStyleBackColor = true;
            this.btn_customReport.Click += new System.EventHandler(this.btn_customReport_Click);
            // 
            // txt_ReportTextBox
            // 
            this.txt_ReportTextBox.Font = new System.Drawing.Font("Meiryo UI", 10F);
            this.txt_ReportTextBox.Location = new System.Drawing.Point(465, 168);
            this.txt_ReportTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ReportTextBox.Name = "txt_ReportTextBox";
            this.txt_ReportTextBox.Size = new System.Drawing.Size(558, 323);
            this.txt_ReportTextBox.TabIndex = 3;
            this.txt_ReportTextBox.Text = "";
            // 
            // dropdown_Months
            // 
            this.dropdown_Months.Font = new System.Drawing.Font("Meiryo UI", 10F);
            this.dropdown_Months.FormattingEnabled = true;
            this.dropdown_Months.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.dropdown_Months.Location = new System.Drawing.Point(465, 124);
            this.dropdown_Months.Margin = new System.Windows.Forms.Padding(4);
            this.dropdown_Months.Name = "dropdown_Months";
            this.dropdown_Months.Size = new System.Drawing.Size(160, 25);
            this.dropdown_Months.TabIndex = 4;
            this.dropdown_Months.Tag = "MMMonth";
            this.dropdown_Months.Text = "January";
            // 
            // dgv_consultantSchedule
            // 
            this.dgv_consultantSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_consultantSchedule.Location = new System.Drawing.Point(465, 168);
            this.dgv_consultantSchedule.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_consultantSchedule.Name = "dgv_consultantSchedule";
            this.dgv_consultantSchedule.RowHeadersVisible = false;
            this.dgv_consultantSchedule.Size = new System.Drawing.Size(558, 324);
            this.dgv_consultantSchedule.TabIndex = 5;
            this.dgv_consultantSchedule.Visible = false;
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("Meiryo UI", 10F);
            this.btn_Close.Location = new System.Drawing.Point(82, 438);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(100, 30);
            this.btn_Close.TabIndex = 6;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 24F);
            this.label1.Location = new System.Drawing.Point(75, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 41);
            this.label1.TabIndex = 7;
            this.label1.Text = "Generate Reports";
            // 
            // txt_UserID
            // 
            this.txt_UserID.Location = new System.Drawing.Point(465, 125);
            this.txt_UserID.Name = "txt_UserID";
            this.txt_UserID.Size = new System.Drawing.Size(160, 24);
            this.txt_UserID.TabIndex = 8;
            this.txt_UserID.Text = "1";
            // 
            // btn_UserIDRefresh
            // 
            this.btn_UserIDRefresh.Location = new System.Drawing.Point(648, 125);
            this.btn_UserIDRefresh.Name = "btn_UserIDRefresh";
            this.btn_UserIDRefresh.Size = new System.Drawing.Size(75, 23);
            this.btn_UserIDRefresh.TabIndex = 9;
            this.btn_UserIDRefresh.Text = "Refresh";
            this.btn_UserIDRefresh.UseVisualStyleBackColor = true;
            this.btn_UserIDRefresh.Click += new System.EventHandler(this.btn_UserIDRefresh_Click);
            // 
            // lbl_UserIDEntry
            // 
            this.lbl_UserIDEntry.AutoSize = true;
            this.lbl_UserIDEntry.Location = new System.Drawing.Point(462, 93);
            this.lbl_UserIDEntry.Name = "lbl_UserIDEntry";
            this.lbl_UserIDEntry.Size = new System.Drawing.Size(66, 18);
            this.lbl_UserIDEntry.TabIndex = 10;
            this.lbl_UserIDEntry.Text = "User ID:";
            // 
            // GenerateReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 567);
            this.Controls.Add(this.lbl_UserIDEntry);
            this.Controls.Add(this.btn_UserIDRefresh);
            this.Controls.Add(this.txt_UserID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.dgv_consultantSchedule);
            this.Controls.Add(this.dropdown_Months);
            this.Controls.Add(this.txt_ReportTextBox);
            this.Controls.Add(this.btn_customReport);
            this.Controls.Add(this.btn_ConsultantSchedule);
            this.Controls.Add(this.btn_NumberAppointmentTypesByMonth);
            this.Font = new System.Drawing.Font("Meiryo UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GenerateReports";
            this.Text = "GenerateReports";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consultantSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_NumberAppointmentTypesByMonth;
		private System.Windows.Forms.Button btn_ConsultantSchedule;
		private System.Windows.Forms.Button btn_customReport;
		private System.Windows.Forms.RichTextBox txt_ReportTextBox;
		private System.Windows.Forms.ComboBox dropdown_Months;
		private System.Windows.Forms.DataGridView dgv_consultantSchedule;
		private System.Windows.Forms.Button btn_Close;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_UserID;
        private System.Windows.Forms.Button btn_UserIDRefresh;
        private System.Windows.Forms.Label lbl_UserIDEntry;
    }
}