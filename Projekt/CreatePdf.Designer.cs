
namespace Projekt
{
    partial class CreatePdf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePdf));
            this.backToStartBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboPersonId = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPriceOfCorrection = new System.Windows.Forms.TextBox();
            this.txtCorrectedError = new System.Windows.Forms.TextBox();
            this.txtDateOfCorrection = new System.Windows.Forms.TextBox();
            this.txtMissingParts = new System.Windows.Forms.TextBox();
            this.txtHasAnyMissingPart = new System.Windows.Forms.TextBox();
            this.txtErrorSeenByCustomer = new System.Windows.Forms.TextBox();
            this.txtDateOfReceipt = new System.Windows.Forms.TextBox();
            this.txtTvCategory = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPhoneMobile = new System.Windows.Forms.TextBox();
            this.txtPhoneFix = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.createPdfBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // backToStartBtn
            // 
            this.backToStartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.backToStartBtn.Location = new System.Drawing.Point(12, 12);
            this.backToStartBtn.Name = "backToStartBtn";
            this.backToStartBtn.Size = new System.Drawing.Size(102, 39);
            this.backToStartBtn.TabIndex = 2;
            this.backToStartBtn.Text = "Vissza a kezdőlapra";
            this.backToStartBtn.UseVisualStyleBackColor = true;
            this.backToStartBtn.Click += new System.EventHandler(this.backToStartBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Személy";
            // 
            // comboPersonId
            // 
            this.comboPersonId.FormattingEnabled = true;
            this.comboPersonId.Location = new System.Drawing.Point(110, 65);
            this.comboPersonId.Name = "comboPersonId";
            this.comboPersonId.Size = new System.Drawing.Size(121, 21);
            this.comboPersonId.TabIndex = 4;
            this.comboPersonId.SelectedValueChanged += new System.EventHandler(this.comboPersonId_SelectedValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPriceOfCorrection);
            this.groupBox1.Controls.Add(this.txtCorrectedError);
            this.groupBox1.Controls.Add(this.txtDateOfCorrection);
            this.groupBox1.Controls.Add(this.txtMissingParts);
            this.groupBox1.Controls.Add(this.txtHasAnyMissingPart);
            this.groupBox1.Controls.Add(this.txtErrorSeenByCustomer);
            this.groupBox1.Controls.Add(this.txtDateOfReceipt);
            this.groupBox1.Controls.Add(this.txtTvCategory);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.Location = new System.Drawing.Point(611, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 426);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TV adatai";
            // 
            // txtPriceOfCorrection
            // 
            this.txtPriceOfCorrection.Location = new System.Drawing.Point(182, 307);
            this.txtPriceOfCorrection.Name = "txtPriceOfCorrection";
            this.txtPriceOfCorrection.Size = new System.Drawing.Size(169, 21);
            this.txtPriceOfCorrection.TabIndex = 28;
            // 
            // txtCorrectedError
            // 
            this.txtCorrectedError.Location = new System.Drawing.Point(182, 267);
            this.txtCorrectedError.Name = "txtCorrectedError";
            this.txtCorrectedError.Size = new System.Drawing.Size(169, 21);
            this.txtCorrectedError.TabIndex = 27;
            // 
            // txtDateOfCorrection
            // 
            this.txtDateOfCorrection.Location = new System.Drawing.Point(182, 227);
            this.txtDateOfCorrection.Name = "txtDateOfCorrection";
            this.txtDateOfCorrection.Size = new System.Drawing.Size(169, 21);
            this.txtDateOfCorrection.TabIndex = 26;
            // 
            // txtMissingParts
            // 
            this.txtMissingParts.Location = new System.Drawing.Point(182, 187);
            this.txtMissingParts.Name = "txtMissingParts";
            this.txtMissingParts.Size = new System.Drawing.Size(169, 21);
            this.txtMissingParts.TabIndex = 25;
            // 
            // txtHasAnyMissingPart
            // 
            this.txtHasAnyMissingPart.Location = new System.Drawing.Point(182, 147);
            this.txtHasAnyMissingPart.Name = "txtHasAnyMissingPart";
            this.txtHasAnyMissingPart.Size = new System.Drawing.Size(169, 21);
            this.txtHasAnyMissingPart.TabIndex = 24;
            // 
            // txtErrorSeenByCustomer
            // 
            this.txtErrorSeenByCustomer.Location = new System.Drawing.Point(182, 110);
            this.txtErrorSeenByCustomer.Name = "txtErrorSeenByCustomer";
            this.txtErrorSeenByCustomer.Size = new System.Drawing.Size(169, 21);
            this.txtErrorSeenByCustomer.TabIndex = 23;
            // 
            // txtDateOfReceipt
            // 
            this.txtDateOfReceipt.Location = new System.Drawing.Point(182, 67);
            this.txtDateOfReceipt.Name = "txtDateOfReceipt";
            this.txtDateOfReceipt.Size = new System.Drawing.Size(169, 21);
            this.txtDateOfReceipt.TabIndex = 22;
            // 
            // txtTvCategory
            // 
            this.txtTvCategory.Location = new System.Drawing.Point(182, 27);
            this.txtTvCategory.Name = "txtTvCategory";
            this.txtTvCategory.Size = new System.Drawing.Size(169, 21);
            this.txtTvCategory.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 310);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 15);
            this.label16.TabIndex = 7;
            this.label16.Text = "Javítás ára";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 270);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 15);
            this.label15.TabIndex = 6;
            this.label15.Text = "Javított hiba";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 230);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 15);
            this.label14.TabIndex = 5;
            this.label14.Text = "Javítás dátuma";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 190);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 15);
            this.label13.TabIndex = 4;
            this.label13.Text = "Mik a hiányzó elemek";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 15);
            this.label12.TabIndex = 3;
            this.label12.Text = "Van hiányzó eleme";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Ügyfél által jelzett hiba";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Átvétel dátuma";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Márka";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPhoneMobile);
            this.groupBox2.Controls.Add(this.txtPhoneFix);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtFirstName);
            this.groupBox2.Controls.Add(this.txtLastName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox2.Location = new System.Drawing.Point(237, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 426);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Személy adatai";
            // 
            // txtPhoneMobile
            // 
            this.txtPhoneMobile.Location = new System.Drawing.Point(125, 224);
            this.txtPhoneMobile.Name = "txtPhoneMobile";
            this.txtPhoneMobile.Size = new System.Drawing.Size(169, 21);
            this.txtPhoneMobile.TabIndex = 20;
            // 
            // txtPhoneFix
            // 
            this.txtPhoneFix.Location = new System.Drawing.Point(125, 184);
            this.txtPhoneFix.Name = "txtPhoneFix";
            this.txtPhoneFix.Size = new System.Drawing.Size(169, 21);
            this.txtPhoneFix.TabIndex = 19;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(125, 144);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(169, 21);
            this.txtAddress.TabIndex = 18;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(125, 107);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(169, 21);
            this.txtEmail.TabIndex = 17;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(125, 67);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(169, 21);
            this.txtFirstName.TabIndex = 16;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(125, 24);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(169, 21);
            this.txtLastName.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Mobil telefon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Vonalas telefon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Lakcím";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Keresztnév";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Vezetéknév";
            // 
            // createPdfBtn
            // 
            this.createPdfBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.createPdfBtn.Location = new System.Drawing.Point(12, 276);
            this.createPdfBtn.Name = "createPdfBtn";
            this.createPdfBtn.Size = new System.Drawing.Size(149, 81);
            this.createPdfBtn.TabIndex = 9;
            this.createPdfBtn.Text = "PDF létrehozása";
            this.createPdfBtn.UseVisualStyleBackColor = true;
            this.createPdfBtn.Click += new System.EventHandler(this.createPdfBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(219, 150);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // CreatePdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 457);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.createPdfBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboPersonId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backToStartBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreatePdf";
            this.Text = "Pdf létrehozása";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreatePdf_FormClosed);
            this.Load += new System.EventHandler(this.CreatePdf_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backToStartBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboPersonId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPriceOfCorrection;
        private System.Windows.Forms.TextBox txtCorrectedError;
        private System.Windows.Forms.TextBox txtDateOfCorrection;
        private System.Windows.Forms.TextBox txtMissingParts;
        private System.Windows.Forms.TextBox txtHasAnyMissingPart;
        private System.Windows.Forms.TextBox txtErrorSeenByCustomer;
        private System.Windows.Forms.TextBox txtDateOfReceipt;
        private System.Windows.Forms.TextBox txtTvCategory;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPhoneMobile;
        private System.Windows.Forms.TextBox txtPhoneFix;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button createPdfBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}