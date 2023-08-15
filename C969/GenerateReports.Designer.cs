
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
			this.button3 = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// btn_NumberAppointmentTypesByMonth
			// 
			this.btn_NumberAppointmentTypesByMonth.Location = new System.Drawing.Point(123, 106);
			this.btn_NumberAppointmentTypesByMonth.Name = "btn_NumberAppointmentTypesByMonth";
			this.btn_NumberAppointmentTypesByMonth.Size = new System.Drawing.Size(204, 23);
			this.btn_NumberAppointmentTypesByMonth.TabIndex = 0;
			this.btn_NumberAppointmentTypesByMonth.Text = "Number of appt types by month";
			this.btn_NumberAppointmentTypesByMonth.UseVisualStyleBackColor = true;
			this.btn_NumberAppointmentTypesByMonth.Click += new System.EventHandler(this.btn_NumberAppointmentTypesByMonth_Click);
			// 
			// btn_ConsultantSchedule
			// 
			this.btn_ConsultantSchedule.Location = new System.Drawing.Point(123, 151);
			this.btn_ConsultantSchedule.Name = "btn_ConsultantSchedule";
			this.btn_ConsultantSchedule.Size = new System.Drawing.Size(204, 23);
			this.btn_ConsultantSchedule.TabIndex = 1;
			this.btn_ConsultantSchedule.Text = "Consultant Schedule";
			this.btn_ConsultantSchedule.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(123, 195);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(204, 23);
			this.button3.TabIndex = 2;
			this.button3.Text = "Report of my choice";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(425, 64);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(293, 248);
			this.richTextBox1.TabIndex = 3;
			this.richTextBox1.Text = "";
			// 
			// GenerateReports
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.btn_ConsultantSchedule);
			this.Controls.Add(this.btn_NumberAppointmentTypesByMonth);
			this.Name = "GenerateReports";
			this.Text = "GenerateReports";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn_NumberAppointmentTypesByMonth;
		private System.Windows.Forms.Button btn_ConsultantSchedule;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.RichTextBox richTextBox1;
	}
}