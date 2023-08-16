
namespace C969
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
			this.components = new System.ComponentModel.Container();
			this.userIDLabel = new System.Windows.Forms.Label();
			this.txt_UserIDTextBox = new System.Windows.Forms.TextBox();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.txt_PasswordTextBox = new System.Windows.Forms.TextBox();
			this.loginTitleLabel = new System.Windows.Forms.Label();
			this.submitButton = new System.Windows.Forms.Button();
			this.SqlConnectionLabel = new System.Windows.Forms.Label();
			this.sqlStatusLabel = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.timer_1sTick = new System.Windows.Forms.Timer(this.components);
			this.lbl_regionCheck = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// userIDLabel
			// 
			this.userIDLabel.AutoSize = true;
			this.userIDLabel.Location = new System.Drawing.Point(26, 103);
			this.userIDLabel.Name = "userIDLabel";
			this.userIDLabel.Size = new System.Drawing.Size(58, 13);
			this.userIDLabel.TabIndex = 0;
			this.userIDLabel.Text = "Username:";
			// 
			// txt_UserIDTextBox
			// 
			this.txt_UserIDTextBox.Location = new System.Drawing.Point(96, 100);
			this.txt_UserIDTextBox.Name = "txt_UserIDTextBox";
			this.txt_UserIDTextBox.Size = new System.Drawing.Size(100, 20);
			this.txt_UserIDTextBox.TabIndex = 1;
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Location = new System.Drawing.Point(26, 154);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(56, 13);
			this.passwordLabel.TabIndex = 2;
			this.passwordLabel.Text = "Password:";
			// 
			// txt_PasswordTextBox
			// 
			this.txt_PasswordTextBox.Location = new System.Drawing.Point(96, 151);
			this.txt_PasswordTextBox.Name = "txt_PasswordTextBox";
			this.txt_PasswordTextBox.Size = new System.Drawing.Size(100, 20);
			this.txt_PasswordTextBox.TabIndex = 3;
			// 
			// loginTitleLabel
			// 
			this.loginTitleLabel.AutoSize = true;
			this.loginTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loginTitleLabel.Location = new System.Drawing.Point(24, 21);
			this.loginTitleLabel.Name = "loginTitleLabel";
			this.loginTitleLabel.Size = new System.Drawing.Size(81, 25);
			this.loginTitleLabel.TabIndex = 4;
			this.loginTitleLabel.Text = "LOGIN";
			// 
			// submitButton
			// 
			this.submitButton.Location = new System.Drawing.Point(29, 206);
			this.submitButton.Name = "submitButton";
			this.submitButton.Size = new System.Drawing.Size(167, 23);
			this.submitButton.TabIndex = 5;
			this.submitButton.Text = "Submit";
			this.submitButton.UseVisualStyleBackColor = true;
			this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
			// 
			// SqlConnectionLabel
			// 
			this.SqlConnectionLabel.AutoSize = true;
			this.SqlConnectionLabel.Location = new System.Drawing.Point(239, 100);
			this.SqlConnectionLabel.Name = "SqlConnectionLabel";
			this.SqlConnectionLabel.Size = new System.Drawing.Size(121, 13);
			this.SqlConnectionLabel.TabIndex = 6;
			this.SqlConnectionLabel.Text = "SQL Connection Status:";
			// 
			// sqlStatusLabel
			// 
			this.sqlStatusLabel.AutoSize = true;
			this.sqlStatusLabel.Location = new System.Drawing.Point(239, 133);
			this.sqlStatusLabel.Name = "sqlStatusLabel";
			this.sqlStatusLabel.Size = new System.Drawing.Size(27, 13);
			this.sqlStatusLabel.TabIndex = 7;
			this.sqlStatusLabel.Text = "N/A";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(259, 206);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 9;
			this.button1.Text = "dashboard";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// timer_1sTick
			// 
			this.timer_1sTick.Enabled = true;
			this.timer_1sTick.Interval = 3000;
			this.timer_1sTick.Tick += new System.EventHandler(this.timer_1sTick_Tick);
			// 
			// lbl_regionCheck
			// 
			this.lbl_regionCheck.AutoSize = true;
			this.lbl_regionCheck.Location = new System.Drawing.Point(268, 23);
			this.lbl_regionCheck.Name = "lbl_regionCheck";
			this.lbl_regionCheck.Size = new System.Drawing.Size(35, 13);
			this.lbl_regionCheck.TabIndex = 10;
			this.lbl_regionCheck.Text = "label1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(398, 261);
			this.Controls.Add(this.lbl_regionCheck);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.sqlStatusLabel);
			this.Controls.Add(this.SqlConnectionLabel);
			this.Controls.Add(this.submitButton);
			this.Controls.Add(this.loginTitleLabel);
			this.Controls.Add(this.txt_PasswordTextBox);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.txt_UserIDTextBox);
			this.Controls.Add(this.userIDLabel);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label userIDLabel;
		private System.Windows.Forms.TextBox txt_UserIDTextBox;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.TextBox txt_PasswordTextBox;
		private System.Windows.Forms.Label loginTitleLabel;
		private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label SqlConnectionLabel;
        private System.Windows.Forms.Label sqlStatusLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer_1sTick;
		private System.Windows.Forms.Label lbl_regionCheck;
	}
}

