
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AddAppointment = new System.Windows.Forms.Button();
            this.btn_EditAppointment = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentDGV
            // 
            this.appointmentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentDGV.Location = new System.Drawing.Point(47, 104);
            this.appointmentDGV.Name = "appointmentDGV";
            this.appointmentDGV.Size = new System.Drawing.Size(717, 150);
            this.appointmentDGV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Appointments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(405, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome to your appointment dashboard";
            // 
            // btn_AddAppointment
            // 
            this.btn_AddAppointment.Location = new System.Drawing.Point(47, 302);
            this.btn_AddAppointment.Name = "btn_AddAppointment";
            this.btn_AddAppointment.Size = new System.Drawing.Size(99, 23);
            this.btn_AddAppointment.TabIndex = 3;
            this.btn_AddAppointment.Text = "Add Appointment";
            this.btn_AddAppointment.UseVisualStyleBackColor = true;
            this.btn_AddAppointment.Click += new System.EventHandler(this.btn_AddAppointment_Click);
            // 
            // btn_EditAppointment
            // 
            this.btn_EditAppointment.Location = new System.Drawing.Point(164, 302);
            this.btn_EditAppointment.Name = "btn_EditAppointment";
            this.btn_EditAppointment.Size = new System.Drawing.Size(117, 23);
            this.btn_EditAppointment.TabIndex = 4;
            this.btn_EditAppointment.Text = "Edit Appointment";
            this.btn_EditAppointment.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(485, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "refresh appts";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_EditAppointment);
            this.Controls.Add(this.btn_AddAppointment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.appointmentDGV);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView appointmentDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_AddAppointment;
        private System.Windows.Forms.Button btn_EditAppointment;
        private System.Windows.Forms.Button button1;
    }
}