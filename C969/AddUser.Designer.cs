
namespace C969
{
    partial class AddUser
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_userID = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_password2 = new System.Windows.Forms.TextBox();
            this.checkbox_active = new System.Windows.Forms.CheckBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lbl_passwordWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Meiryo UI", 10.25F);
            this.label9.Location = new System.Drawing.Point(36, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 18);
            this.label9.TabIndex = 19;
            this.label9.Text = "Verify Password:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Meiryo UI", 10.25F);
            this.label8.Location = new System.Drawing.Point(37, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Password:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Meiryo UI", 10.25F);
            this.label7.Location = new System.Drawing.Point(36, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Username:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Meiryo UI", 10.25F);
            this.label6.Location = new System.Drawing.Point(84, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "User ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 18F);
            this.label1.Location = new System.Drawing.Point(100, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 30);
            this.label1.TabIndex = 25;
            this.label1.Text = "Add User";
            // 
            // txt_userID
            // 
            this.txt_userID.Enabled = false;
            this.txt_userID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txt_userID.Location = new System.Drawing.Point(176, 217);
            this.txt_userID.Name = "txt_userID";
            this.txt_userID.Size = new System.Drawing.Size(59, 23);
            this.txt_userID.TabIndex = 27;
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txt_username.Location = new System.Drawing.Point(125, 84);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(172, 23);
            this.txt_username.TabIndex = 28;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txt_password.Location = new System.Drawing.Point(125, 123);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(172, 23);
            this.txt_password.TabIndex = 29;
            // 
            // txt_password2
            // 
            this.txt_password2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txt_password2.Location = new System.Drawing.Point(166, 162);
            this.txt_password2.Name = "txt_password2";
            this.txt_password2.Size = new System.Drawing.Size(131, 23);
            this.txt_password2.TabIndex = 30;
            this.txt_password2.TextChanged += new System.EventHandler(this.txt_password2_TextChanged);
            // 
            // checkbox_active
            // 
            this.checkbox_active.AutoSize = true;
            this.checkbox_active.Font = new System.Drawing.Font("Meiryo UI", 10.25F);
            this.checkbox_active.Location = new System.Drawing.Point(129, 256);
            this.checkbox_active.Name = "checkbox_active";
            this.checkbox_active.Size = new System.Drawing.Size(68, 22);
            this.checkbox_active.TabIndex = 31;
            this.checkbox_active.Text = "Active";
            this.checkbox_active.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Meiryo UI", 10.25F);
            this.btn_Save.Location = new System.Drawing.Point(126, 303);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 29);
            this.btn_Save.TabIndex = 32;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_passwordWarning
            // 
            this.lbl_passwordWarning.AutoSize = true;
            this.lbl_passwordWarning.Font = new System.Drawing.Font("Meiryo UI", 8.25F);
            this.lbl_passwordWarning.ForeColor = System.Drawing.Color.Red;
            this.lbl_passwordWarning.Location = new System.Drawing.Point(163, 195);
            this.lbl_passwordWarning.Name = "lbl_passwordWarning";
            this.lbl_passwordWarning.Size = new System.Drawing.Size(136, 14);
            this.lbl_passwordWarning.TabIndex = 33;
            this.lbl_passwordWarning.Text = "Passwords must match.";
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 369);
            this.Controls.Add(this.lbl_passwordWarning);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.checkbox_active);
            this.Controls.Add(this.txt_password2);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_userID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_userID;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_password2;
        private System.Windows.Forms.CheckBox checkbox_active;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbl_passwordWarning;
    }
}