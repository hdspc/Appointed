
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
			this.userIDLabel = new System.Windows.Forms.Label();
			this.userIDTextBox = new System.Windows.Forms.TextBox();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.loginTitleLabel = new System.Windows.Forms.Label();
			this.submitButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// userIDLabel
			// 
			this.userIDLabel.AutoSize = true;
			this.userIDLabel.Location = new System.Drawing.Point(87, 110);
			this.userIDLabel.Name = "userIDLabel";
			this.userIDLabel.Size = new System.Drawing.Size(46, 13);
			this.userIDLabel.TabIndex = 0;
			this.userIDLabel.Text = "User ID:";
			this.userIDLabel.Click += new System.EventHandler(this.label1_Click);
			// 
			// userIDTextBox
			// 
			this.userIDTextBox.Location = new System.Drawing.Point(157, 102);
			this.userIDTextBox.Name = "userIDTextBox";
			this.userIDTextBox.Size = new System.Drawing.Size(100, 20);
			this.userIDTextBox.TabIndex = 1;
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Location = new System.Drawing.Point(87, 161);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(56, 13);
			this.passwordLabel.TabIndex = 2;
			this.passwordLabel.Text = "Password:";
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Location = new System.Drawing.Point(157, 153);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
			this.passwordTextBox.TabIndex = 3;
			// 
			// loginTitleLabel
			// 
			this.loginTitleLabel.AutoSize = true;
			this.loginTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loginTitleLabel.Location = new System.Drawing.Point(85, 23);
			this.loginTitleLabel.Name = "loginTitleLabel";
			this.loginTitleLabel.Size = new System.Drawing.Size(81, 25);
			this.loginTitleLabel.TabIndex = 4;
			this.loginTitleLabel.Text = "LOGIN";
			// 
			// submitButton
			// 
			this.submitButton.Location = new System.Drawing.Point(140, 241);
			this.submitButton.Name = "submitButton";
			this.submitButton.Size = new System.Drawing.Size(75, 23);
			this.submitButton.TabIndex = 5;
			this.submitButton.Text = "Submit";
			this.submitButton.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 325);
			this.Controls.Add(this.submitButton);
			this.Controls.Add(this.loginTitleLabel);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.userIDTextBox);
			this.Controls.Add(this.userIDLabel);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label userIDLabel;
		private System.Windows.Forms.TextBox userIDTextBox;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.Label loginTitleLabel;
		private System.Windows.Forms.Button submitButton;
	}
}

