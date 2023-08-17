
namespace C969
{
    partial class AddCustomer
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
            this.btn_Save = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_customerID = new System.Windows.Forms.TextBox();
            this.txt_customerName = new System.Windows.Forms.TextBox();
            this.checkbox_activeCustomer = new System.Windows.Forms.CheckBox();
            this.txt_addressID = new System.Windows.Forms.TextBox();
            this.btn_newAddress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_Save.Location = new System.Drawing.Point(37, 205);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(85, 37);
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button2.Location = new System.Drawing.Point(170, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(34, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(34, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Address ID";
            // 
            // txt_customerID
            // 
            this.txt_customerID.Enabled = false;
            this.txt_customerID.Location = new System.Drawing.Point(170, 32);
            this.txt_customerID.Name = "txt_customerID";
            this.txt_customerID.Size = new System.Drawing.Size(100, 20);
            this.txt_customerID.TabIndex = 10;
            // 
            // txt_customerName
            // 
            this.txt_customerName.Location = new System.Drawing.Point(170, 63);
            this.txt_customerName.Name = "txt_customerName";
            this.txt_customerName.Size = new System.Drawing.Size(100, 20);
            this.txt_customerName.TabIndex = 11;
            // 
            // checkbox_activeCustomer
            // 
            this.checkbox_activeCustomer.AutoSize = true;
            this.checkbox_activeCustomer.Location = new System.Drawing.Point(37, 172);
            this.checkbox_activeCustomer.Name = "checkbox_activeCustomer";
            this.checkbox_activeCustomer.Size = new System.Drawing.Size(103, 17);
            this.checkbox_activeCustomer.TabIndex = 12;
            this.checkbox_activeCustomer.Text = "Active Customer";
            this.checkbox_activeCustomer.UseVisualStyleBackColor = true;
            // 
            // txt_addressID
            // 
            this.txt_addressID.Location = new System.Drawing.Point(170, 91);
            this.txt_addressID.Name = "txt_addressID";
            this.txt_addressID.Size = new System.Drawing.Size(100, 20);
            this.txt_addressID.TabIndex = 13;
            // 
            // btn_newAddress
            // 
            this.btn_newAddress.Location = new System.Drawing.Point(170, 117);
            this.btn_newAddress.Name = "btn_newAddress";
            this.btn_newAddress.Size = new System.Drawing.Size(100, 23);
            this.btn_newAddress.TabIndex = 14;
            this.btn_newAddress.Text = "New Address";
            this.btn_newAddress.UseVisualStyleBackColor = true;
            this.btn_newAddress.Click += new System.EventHandler(this.btn_newAddress_Click);
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 297);
            this.Controls.Add(this.btn_newAddress);
            this.Controls.Add(this.txt_addressID);
            this.Controls.Add(this.checkbox_activeCustomer);
            this.Controls.Add(this.txt_customerName);
            this.Controls.Add(this.txt_customerID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Save);
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_customerID;
        private System.Windows.Forms.TextBox txt_customerName;
        private System.Windows.Forms.CheckBox checkbox_activeCustomer;
        private System.Windows.Forms.TextBox txt_addressID;
        private System.Windows.Forms.Button btn_newAddress;
    }
}