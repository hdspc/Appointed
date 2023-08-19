
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_customerID = new System.Windows.Forms.TextBox();
            this.txt_customerName = new System.Windows.Forms.TextBox();
            this.checkbox_activeCustomer = new System.Windows.Forms.CheckBox();
            this.btn_newAddress = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.lbl_City = new System.Windows.Forms.Label();
            this.lbl_Country = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dropdown_AddressIDs = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_Save.Location = new System.Drawing.Point(39, 362);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(85, 37);
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_Cancel.Location = new System.Drawing.Point(172, 362);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(100, 37);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 11F);
            this.label1.Location = new System.Drawing.Point(34, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 11F);
            this.label2.Location = new System.Drawing.Point(34, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Meiryo UI", 11F);
            this.label6.Location = new System.Drawing.Point(34, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Address ID";
            // 
            // txt_customerID
            // 
            this.txt_customerID.Enabled = false;
            this.txt_customerID.Font = new System.Drawing.Font("Meiryo UI", 11F);
            this.txt_customerID.Location = new System.Drawing.Point(171, 62);
            this.txt_customerID.Name = "txt_customerID";
            this.txt_customerID.Size = new System.Drawing.Size(100, 26);
            this.txt_customerID.TabIndex = 10;
            // 
            // txt_customerName
            // 
            this.txt_customerName.Font = new System.Drawing.Font("Meiryo UI", 11F);
            this.txt_customerName.Location = new System.Drawing.Point(170, 97);
            this.txt_customerName.Name = "txt_customerName";
            this.txt_customerName.Size = new System.Drawing.Size(100, 26);
            this.txt_customerName.TabIndex = 11;
            // 
            // checkbox_activeCustomer
            // 
            this.checkbox_activeCustomer.AutoSize = true;
            this.checkbox_activeCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkbox_activeCustomer.Location = new System.Drawing.Point(87, 318);
            this.checkbox_activeCustomer.Name = "checkbox_activeCustomer";
            this.checkbox_activeCustomer.Size = new System.Drawing.Size(136, 22);
            this.checkbox_activeCustomer.TabIndex = 12;
            this.checkbox_activeCustomer.Text = "Active Customer";
            this.checkbox_activeCustomer.UseVisualStyleBackColor = true;
            // 
            // btn_newAddress
            // 
            this.btn_newAddress.Font = new System.Drawing.Font("Meiryo UI", 11F);
            this.btn_newAddress.Location = new System.Drawing.Point(37, 176);
            this.btn_newAddress.Name = "btn_newAddress";
            this.btn_newAddress.Size = new System.Drawing.Size(233, 29);
            this.btn_newAddress.TabIndex = 14;
            this.btn_newAddress.Text = "New Address";
            this.btn_newAddress.UseVisualStyleBackColor = true;
            this.btn_newAddress.Click += new System.EventHandler(this.btn_newAddress_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 11F);
            this.label3.Location = new System.Drawing.Point(35, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "City ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Meiryo UI", 11F);
            this.label4.Location = new System.Drawing.Point(35, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Country";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Meiryo UI", 11F);
            this.label5.Location = new System.Drawing.Point(35, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Phone Number";
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Font = new System.Drawing.Font("Meiryo UI", 11F);
            this.lbl_Phone.Location = new System.Drawing.Point(168, 221);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(45, 19);
            this.lbl_Phone.TabIndex = 21;
            this.lbl_Phone.Text = "Error";
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.Font = new System.Drawing.Font("Meiryo UI", 11F);
            this.lbl_City.Location = new System.Drawing.Point(168, 251);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(45, 19);
            this.lbl_City.TabIndex = 22;
            this.lbl_City.Text = "Error";
            // 
            // lbl_Country
            // 
            this.lbl_Country.AutoSize = true;
            this.lbl_Country.Font = new System.Drawing.Font("Meiryo UI", 11F);
            this.lbl_Country.Location = new System.Drawing.Point(168, 283);
            this.lbl_Country.Name = "lbl_Country";
            this.lbl_Country.Size = new System.Drawing.Size(45, 19);
            this.lbl_Country.TabIndex = 23;
            this.lbl_Country.Text = "Error";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Meiryo UI", 18F);
            this.label7.Location = new System.Drawing.Point(61, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 30);
            this.label7.TabIndex = 24;
            this.label7.Text = "Add Customer";
            // 
            // dropdown_AddressIDs
            // 
            this.dropdown_AddressIDs.FormattingEnabled = true;
            this.dropdown_AddressIDs.ItemHeight = 13;
            this.dropdown_AddressIDs.Location = new System.Drawing.Point(171, 135);
            this.dropdown_AddressIDs.Name = "dropdown_AddressIDs";
            this.dropdown_AddressIDs.Size = new System.Drawing.Size(99, 21);
            this.dropdown_AddressIDs.TabIndex = 25;
            this.dropdown_AddressIDs.Text = "1";
            this.dropdown_AddressIDs.SelectedIndexChanged += new System.EventHandler(this.dropdown_AddressIDs_SelectedIndexChanged);
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 418);
            this.Controls.Add(this.dropdown_AddressIDs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_Country);
            this.Controls.Add(this.lbl_City);
            this.Controls.Add(this.lbl_Phone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_newAddress);
            this.Controls.Add(this.checkbox_activeCustomer);
            this.Controls.Add(this.txt_customerName);
            this.Controls.Add(this.txt_customerID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_customerID;
        private System.Windows.Forms.TextBox txt_customerName;
        private System.Windows.Forms.CheckBox checkbox_activeCustomer;
        private System.Windows.Forms.Button btn_newAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Label lbl_City;
        private System.Windows.Forms.Label lbl_Country;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox dropdown_AddressIDs;
    }
}