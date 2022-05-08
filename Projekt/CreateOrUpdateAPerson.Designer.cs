
namespace Projekt
{
    partial class CreateOrUpdateAPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateOrUpdateAPerson));
            this.backToStartBtn = new System.Windows.Forms.Button();
            this.createNewRadioBtn = new System.Windows.Forms.RadioButton();
            this.updateRadioBtn = new System.Windows.Forms.RadioButton();
            this.searchRadioBtn = new System.Windows.Forms.RadioButton();
            this.ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPersonId = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtJoinDate = new System.Windows.Forms.TextBox();
            this.txtPhonFix = new System.Windows.Forms.TextBox();
            this.txtPhoneMobile = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchByFixRadio = new System.Windows.Forms.RadioButton();
            this.searchByMobileRadio = new System.Windows.Forms.RadioButton();
            this.searchByEmailRadio = new System.Windows.Forms.RadioButton();
            this.searchByLastNameRadio = new System.Windows.Forms.RadioButton();
            this.searchByFirstNameRadio = new System.Windows.Forms.RadioButton();
            this.searchBtn = new System.Windows.Forms.Button();
            this.createNewPersonBtn = new System.Windows.Forms.Button();
            this.updatePersonBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // backToStartBtn
            // 
            this.backToStartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.backToStartBtn.Location = new System.Drawing.Point(12, 12);
            this.backToStartBtn.Name = "backToStartBtn";
            this.backToStartBtn.Size = new System.Drawing.Size(102, 39);
            this.backToStartBtn.TabIndex = 0;
            this.backToStartBtn.Text = "Back to start";
            this.backToStartBtn.UseVisualStyleBackColor = true;
            this.backToStartBtn.Click += new System.EventHandler(this.backToStartBtn_Click);
            // 
            // createNewRadioBtn
            // 
            this.createNewRadioBtn.AutoSize = true;
            this.createNewRadioBtn.Location = new System.Drawing.Point(44, 67);
            this.createNewRadioBtn.Name = "createNewRadioBtn";
            this.createNewRadioBtn.Size = new System.Drawing.Size(50, 19);
            this.createNewRadioBtn.TabIndex = 14;
            this.createNewRadioBtn.Text = "New";
            this.createNewRadioBtn.UseVisualStyleBackColor = true;
            this.createNewRadioBtn.CheckedChanged += new System.EventHandler(this.createNewRadioBtn_CheckedChanged);
            // 
            // updateRadioBtn
            // 
            this.updateRadioBtn.AutoSize = true;
            this.updateRadioBtn.Location = new System.Drawing.Point(44, 44);
            this.updateRadioBtn.Name = "updateRadioBtn";
            this.updateRadioBtn.Size = new System.Drawing.Size(65, 19);
            this.updateRadioBtn.TabIndex = 13;
            this.updateRadioBtn.Text = "Update";
            this.updateRadioBtn.UseVisualStyleBackColor = true;
            this.updateRadioBtn.CheckedChanged += new System.EventHandler(this.updateRadioBtn_CheckedChanged);
            // 
            // searchRadioBtn
            // 
            this.searchRadioBtn.AutoSize = true;
            this.searchRadioBtn.Location = new System.Drawing.Point(44, 21);
            this.searchRadioBtn.Name = "searchRadioBtn";
            this.searchRadioBtn.Size = new System.Drawing.Size(59, 19);
            this.searchRadioBtn.TabIndex = 12;
            this.searchRadioBtn.Text = "Select";
            this.searchRadioBtn.UseVisualStyleBackColor = true;
            this.searchRadioBtn.CheckedChanged += new System.EventHandler(this.searchRadioBtn_CheckedChanged);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ID.Location = new System.Drawing.Point(79, 70);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(19, 15);
            this.ID.TabIndex = 15;
            this.ID.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(79, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Vezetéknév";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(79, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Keresztnév";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(79, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Lakcím";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(79, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(79, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Csatlakozás dátuma";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(79, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Vonalas telefon";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label8.Location = new System.Drawing.Point(79, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Mobil telefon";
            // 
            // txtPersonId
            // 
            this.txtPersonId.Location = new System.Drawing.Point(175, 70);
            this.txtPersonId.Name = "txtPersonId";
            this.txtPersonId.Size = new System.Drawing.Size(68, 20);
            this.txtPersonId.TabIndex = 23;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(175, 110);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(165, 20);
            this.txtLastName.TabIndex = 24;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(175, 150);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(165, 20);
            this.txtFirstName.TabIndex = 25;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(175, 190);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(165, 20);
            this.txtAddress.TabIndex = 26;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(175, 230);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(165, 20);
            this.txtEmail.TabIndex = 27;
            // 
            // txtJoinDate
            // 
            this.txtJoinDate.Location = new System.Drawing.Point(268, 270);
            this.txtJoinDate.Name = "txtJoinDate";
            this.txtJoinDate.Size = new System.Drawing.Size(168, 20);
            this.txtJoinDate.TabIndex = 28;
            // 
            // txtPhonFix
            // 
            this.txtPhonFix.Location = new System.Drawing.Point(217, 310);
            this.txtPhonFix.Name = "txtPhonFix";
            this.txtPhonFix.Size = new System.Drawing.Size(155, 20);
            this.txtPhonFix.TabIndex = 29;
            // 
            // txtPhoneMobile
            // 
            this.txtPhoneMobile.Location = new System.Drawing.Point(175, 350);
            this.txtPhoneMobile.Name = "txtPhoneMobile";
            this.txtPhoneMobile.Size = new System.Drawing.Size(165, 20);
            this.txtPhoneMobile.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.createNewRadioBtn);
            this.groupBox1.Controls.Add(this.updateRadioBtn);
            this.groupBox1.Controls.Add(this.searchRadioBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.Location = new System.Drawing.Point(576, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operations";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchByFixRadio);
            this.groupBox2.Controls.Add(this.searchByMobileRadio);
            this.groupBox2.Controls.Add(this.searchByEmailRadio);
            this.groupBox2.Controls.Add(this.searchByLastNameRadio);
            this.groupBox2.Controls.Add(this.searchByFirstNameRadio);
            this.groupBox2.Location = new System.Drawing.Point(576, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 145);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search by";
            // 
            // searchByFixRadio
            // 
            this.searchByFixRadio.AutoSize = true;
            this.searchByFixRadio.Location = new System.Drawing.Point(17, 111);
            this.searchByFixRadio.Name = "searchByFixRadio";
            this.searchByFixRadio.Size = new System.Drawing.Size(167, 17);
            this.searchByFixRadio.TabIndex = 4;
            this.searchByFixRadio.TabStop = true;
            this.searchByFixRadio.Text = "Keresés vonalas szám alapján";
            this.searchByFixRadio.UseVisualStyleBackColor = true;
            this.searchByFixRadio.CheckedChanged += new System.EventHandler(this.searchByFixRadio_CheckedChanged);
            // 
            // searchByMobileRadio
            // 
            this.searchByMobileRadio.AutoSize = true;
            this.searchByMobileRadio.Location = new System.Drawing.Point(17, 88);
            this.searchByMobileRadio.Name = "searchByMobileRadio";
            this.searchByMobileRadio.Size = new System.Drawing.Size(151, 17);
            this.searchByMobileRadio.TabIndex = 3;
            this.searchByMobileRadio.TabStop = true;
            this.searchByMobileRadio.Text = "Keresés mobilszám alapján";
            this.searchByMobileRadio.UseVisualStyleBackColor = true;
            this.searchByMobileRadio.CheckedChanged += new System.EventHandler(this.searchByMobileRadio_CheckedChanged);
            // 
            // searchByEmailRadio
            // 
            this.searchByEmailRadio.AutoSize = true;
            this.searchByEmailRadio.Location = new System.Drawing.Point(17, 65);
            this.searchByEmailRadio.Name = "searchByEmailRadio";
            this.searchByEmailRadio.Size = new System.Drawing.Size(127, 17);
            this.searchByEmailRadio.TabIndex = 2;
            this.searchByEmailRadio.TabStop = true;
            this.searchByEmailRadio.Text = "Keresés email alapján";
            this.searchByEmailRadio.UseVisualStyleBackColor = true;
            this.searchByEmailRadio.CheckedChanged += new System.EventHandler(this.searchByEmailRadio_CheckedChanged);
            // 
            // searchByLastNameRadio
            // 
            this.searchByLastNameRadio.AutoSize = true;
            this.searchByLastNameRadio.Location = new System.Drawing.Point(17, 42);
            this.searchByLastNameRadio.Name = "searchByLastNameRadio";
            this.searchByLastNameRadio.Size = new System.Drawing.Size(160, 17);
            this.searchByLastNameRadio.TabIndex = 1;
            this.searchByLastNameRadio.TabStop = true;
            this.searchByLastNameRadio.Text = "Keresés Vezetéknév alapján";
            this.searchByLastNameRadio.UseVisualStyleBackColor = true;
            this.searchByLastNameRadio.CheckedChanged += new System.EventHandler(this.searchByLastNameRadio_CheckedChanged);
            // 
            // searchByFirstNameRadio
            // 
            this.searchByFirstNameRadio.AutoSize = true;
            this.searchByFirstNameRadio.Location = new System.Drawing.Point(17, 19);
            this.searchByFirstNameRadio.Name = "searchByFirstNameRadio";
            this.searchByFirstNameRadio.Size = new System.Drawing.Size(155, 17);
            this.searchByFirstNameRadio.TabIndex = 0;
            this.searchByFirstNameRadio.TabStop = true;
            this.searchByFirstNameRadio.Text = "Keresés keresztnév alapján";
            this.searchByFirstNameRadio.UseVisualStyleBackColor = true;
            this.searchByFirstNameRadio.CheckedChanged += new System.EventHandler(this.searchByFirstNameRadio_CheckedChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(576, 270);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(144, 42);
            this.searchBtn.TabIndex = 33;
            this.searchBtn.Text = "Keresés";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // createNewPersonBtn
            // 
            this.createNewPersonBtn.Location = new System.Drawing.Point(576, 330);
            this.createNewPersonBtn.Name = "createNewPersonBtn";
            this.createNewPersonBtn.Size = new System.Drawing.Size(144, 42);
            this.createNewPersonBtn.TabIndex = 34;
            this.createNewPersonBtn.Text = "Új személy beírása";
            this.createNewPersonBtn.UseVisualStyleBackColor = true;
            this.createNewPersonBtn.Click += new System.EventHandler(this.createNewPersonBtn_Click);
            // 
            // updatePersonBtn
            // 
            this.updatePersonBtn.Location = new System.Drawing.Point(576, 390);
            this.updatePersonBtn.Name = "updatePersonBtn";
            this.updatePersonBtn.Size = new System.Drawing.Size(144, 42);
            this.updatePersonBtn.TabIndex = 35;
            this.updatePersonBtn.Text = "Személy módosítása";
            this.updatePersonBtn.UseVisualStyleBackColor = true;
            this.updatePersonBtn.Click += new System.EventHandler(this.updatePersonBtn_Click);
            // 
            // CreateOrUpdateAPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updatePersonBtn);
            this.Controls.Add(this.createNewPersonBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPhoneMobile);
            this.Controls.Add(this.txtPhonFix);
            this.Controls.Add(this.txtJoinDate);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtPersonId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.backToStartBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateOrUpdateAPerson";
            this.Text = "Create Or Update A Person";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateOrUpdateAPerson_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backToStartBtn;
        private System.Windows.Forms.RadioButton createNewRadioBtn;
        private System.Windows.Forms.RadioButton updateRadioBtn;
        private System.Windows.Forms.RadioButton searchRadioBtn;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPersonId;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtJoinDate;
        private System.Windows.Forms.TextBox txtPhonFix;
        private System.Windows.Forms.TextBox txtPhoneMobile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton searchByFixRadio;
        private System.Windows.Forms.RadioButton searchByMobileRadio;
        private System.Windows.Forms.RadioButton searchByEmailRadio;
        private System.Windows.Forms.RadioButton searchByLastNameRadio;
        private System.Windows.Forms.RadioButton searchByFirstNameRadio;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button createNewPersonBtn;
        private System.Windows.Forms.Button updatePersonBtn;
    }
}