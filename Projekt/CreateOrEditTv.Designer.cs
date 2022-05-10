
namespace Projekt
{
    partial class CreateOrEditTv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateOrEditTv));
            this.backToStartBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboPersonId = new System.Windows.Forms.ComboBox();
            this.comboCategoryId = new System.Windows.Forms.ComboBox();
            this.txtErrorByCustomer = new System.Windows.Forms.TextBox();
            this.txtDateOfReceip = new System.Windows.Forms.TextBox();
            this.txtDateOfCorrection = new System.Windows.Forms.TextBox();
            this.txtCorrectedError = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.notInProgressRadio = new System.Windows.Forms.RadioButton();
            this.stillInProgressRadio = new System.Windows.Forms.RadioButton();
            this.txtMissingParts = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.createRadio = new System.Windows.Forms.RadioButton();
            this.updateRadio = new System.Windows.Forms.RadioButton();
            this.selectRadio = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.hasNoMissingParts = new System.Windows.Forms.RadioButton();
            this.hasAnyMissingPart = new System.Windows.Forms.RadioButton();
            this.updateBtn = new System.Windows.Forms.Button();
            this.createNewBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.comboTvId = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // backToStartBtn
            // 
            this.backToStartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.backToStartBtn.Location = new System.Drawing.Point(12, 12);
            this.backToStartBtn.Name = "backToStartBtn";
            this.backToStartBtn.Size = new System.Drawing.Size(102, 39);
            this.backToStartBtn.TabIndex = 1;
            this.backToStartBtn.Text = "Vissza a kezdőlapra";
            this.backToStartBtn.UseVisualStyleBackColor = true;
            this.backToStartBtn.Click += new System.EventHandler(this.backToStartBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TV ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Személy ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Márka  ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tulaj által észlelt hiba";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Átvétel dátuma";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Javítás dátuma";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Javított hiba";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Tart a javítás";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Hiányző elemek";
            // 
            // comboPersonId
            // 
            this.comboPersonId.FormattingEnabled = true;
            this.comboPersonId.Location = new System.Drawing.Point(141, 100);
            this.comboPersonId.Name = "comboPersonId";
            this.comboPersonId.Size = new System.Drawing.Size(121, 21);
            this.comboPersonId.TabIndex = 12;
            // 
            // comboCategoryId
            // 
            this.comboCategoryId.FormattingEnabled = true;
            this.comboCategoryId.Location = new System.Drawing.Point(141, 130);
            this.comboCategoryId.Name = "comboCategoryId";
            this.comboCategoryId.Size = new System.Drawing.Size(121, 21);
            this.comboCategoryId.TabIndex = 13;
            // 
            // txtErrorByCustomer
            // 
            this.txtErrorByCustomer.Location = new System.Drawing.Point(141, 160);
            this.txtErrorByCustomer.Name = "txtErrorByCustomer";
            this.txtErrorByCustomer.Size = new System.Drawing.Size(193, 20);
            this.txtErrorByCustomer.TabIndex = 14;
            // 
            // txtDateOfReceip
            // 
            this.txtDateOfReceip.Location = new System.Drawing.Point(141, 190);
            this.txtDateOfReceip.Name = "txtDateOfReceip";
            this.txtDateOfReceip.Size = new System.Drawing.Size(193, 20);
            this.txtDateOfReceip.TabIndex = 15;
            // 
            // txtDateOfCorrection
            // 
            this.txtDateOfCorrection.Location = new System.Drawing.Point(141, 220);
            this.txtDateOfCorrection.Name = "txtDateOfCorrection";
            this.txtDateOfCorrection.Size = new System.Drawing.Size(193, 20);
            this.txtDateOfCorrection.TabIndex = 16;
            // 
            // txtCorrectedError
            // 
            this.txtCorrectedError.Location = new System.Drawing.Point(141, 250);
            this.txtCorrectedError.Name = "txtCorrectedError";
            this.txtCorrectedError.Size = new System.Drawing.Size(193, 20);
            this.txtCorrectedError.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.notInProgressRadio);
            this.groupBox1.Controls.Add(this.stillInProgressRadio);
            this.groupBox1.Location = new System.Drawing.Point(141, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 43);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // notInProgressRadio
            // 
            this.notInProgressRadio.AutoSize = true;
            this.notInProgressRadio.Location = new System.Drawing.Point(109, 19);
            this.notInProgressRadio.Name = "notInProgressRadio";
            this.notInProgressRadio.Size = new System.Drawing.Size(47, 17);
            this.notInProgressRadio.TabIndex = 1;
            this.notInProgressRadio.TabStop = true;
            this.notInProgressRadio.Text = "Nem";
            this.notInProgressRadio.UseVisualStyleBackColor = true;
            // 
            // stillInProgressRadio
            // 
            this.stillInProgressRadio.AutoSize = true;
            this.stillInProgressRadio.Location = new System.Drawing.Point(6, 19);
            this.stillInProgressRadio.Name = "stillInProgressRadio";
            this.stillInProgressRadio.Size = new System.Drawing.Size(46, 17);
            this.stillInProgressRadio.TabIndex = 0;
            this.stillInProgressRadio.TabStop = true;
            this.stillInProgressRadio.Text = "Igen";
            this.stillInProgressRadio.UseVisualStyleBackColor = true;
            // 
            // txtMissingParts
            // 
            this.txtMissingParts.Location = new System.Drawing.Point(141, 350);
            this.txtMissingParts.Name = "txtMissingParts";
            this.txtMissingParts.Size = new System.Drawing.Size(193, 20);
            this.txtMissingParts.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.createRadio);
            this.groupBox2.Controls.Add(this.updateRadio);
            this.groupBox2.Controls.Add(this.selectRadio);
            this.groupBox2.Location = new System.Drawing.Point(588, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Műveletek";
            // 
            // createRadio
            // 
            this.createRadio.AutoSize = true;
            this.createRadio.Location = new System.Drawing.Point(7, 68);
            this.createRadio.Name = "createRadio";
            this.createRadio.Size = new System.Drawing.Size(87, 17);
            this.createRadio.TabIndex = 2;
            this.createRadio.TabStop = true;
            this.createRadio.Text = "Új megadása";
            this.createRadio.UseVisualStyleBackColor = true;
            this.createRadio.CheckedChanged += new System.EventHandler(this.createRadio_CheckedChanged);
            // 
            // updateRadio
            // 
            this.updateRadio.AutoSize = true;
            this.updateRadio.Location = new System.Drawing.Point(7, 44);
            this.updateRadio.Name = "updateRadio";
            this.updateRadio.Size = new System.Drawing.Size(82, 17);
            this.updateRadio.TabIndex = 1;
            this.updateRadio.TabStop = true;
            this.updateRadio.Text = "Szerkesztés";
            this.updateRadio.UseVisualStyleBackColor = true;
            this.updateRadio.CheckedChanged += new System.EventHandler(this.updateRadio_CheckedChanged);
            // 
            // selectRadio
            // 
            this.selectRadio.AutoSize = true;
            this.selectRadio.Location = new System.Drawing.Point(7, 20);
            this.selectRadio.Name = "selectRadio";
            this.selectRadio.Size = new System.Drawing.Size(63, 17);
            this.selectRadio.TabIndex = 0;
            this.selectRadio.TabStop = true;
            this.selectRadio.Text = "Keresés";
            this.selectRadio.UseVisualStyleBackColor = true;
            this.selectRadio.CheckedChanged += new System.EventHandler(this.selectRadio_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.hasNoMissingParts);
            this.groupBox3.Controls.Add(this.hasAnyMissingPart);
            this.groupBox3.Location = new System.Drawing.Point(588, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Van hiányzó elem az átvétel pillanatában";
            // 
            // hasNoMissingParts
            // 
            this.hasNoMissingParts.AutoSize = true;
            this.hasNoMissingParts.Location = new System.Drawing.Point(109, 42);
            this.hasNoMissingParts.Name = "hasNoMissingParts";
            this.hasNoMissingParts.Size = new System.Drawing.Size(47, 17);
            this.hasNoMissingParts.TabIndex = 1;
            this.hasNoMissingParts.TabStop = true;
            this.hasNoMissingParts.Text = "Nem";
            this.hasNoMissingParts.UseVisualStyleBackColor = true;
            this.hasNoMissingParts.CheckedChanged += new System.EventHandler(this.hasNoMissingParts_CheckedChanged);
            // 
            // hasAnyMissingPart
            // 
            this.hasAnyMissingPart.AutoSize = true;
            this.hasAnyMissingPart.Location = new System.Drawing.Point(7, 42);
            this.hasAnyMissingPart.Name = "hasAnyMissingPart";
            this.hasAnyMissingPart.Size = new System.Drawing.Size(46, 17);
            this.hasAnyMissingPart.TabIndex = 0;
            this.hasAnyMissingPart.TabStop = true;
            this.hasAnyMissingPart.Text = "Igen";
            this.hasAnyMissingPart.UseVisualStyleBackColor = true;
            this.hasAnyMissingPart.CheckedChanged += new System.EventHandler(this.hasAnyMissingPart_CheckedChanged);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(588, 311);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(130, 43);
            this.updateBtn.TabIndex = 23;
            this.updateBtn.Text = "Szerkesztés";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // createNewBtn
            // 
            this.createNewBtn.Location = new System.Drawing.Point(588, 374);
            this.createNewBtn.Name = "createNewBtn";
            this.createNewBtn.Size = new System.Drawing.Size(130, 43);
            this.createNewBtn.TabIndex = 24;
            this.createNewBtn.Text = "Új megadása";
            this.createNewBtn.UseVisualStyleBackColor = true;
            this.createNewBtn.Click += new System.EventHandler(this.createNewBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(298, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Javítás ára";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(388, 70);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 26;
            // 
            // comboTvId
            // 
            this.comboTvId.FormattingEnabled = true;
            this.comboTvId.Location = new System.Drawing.Point(141, 62);
            this.comboTvId.Name = "comboTvId";
            this.comboTvId.Size = new System.Drawing.Size(121, 21);
            this.comboTvId.TabIndex = 27;
            this.comboTvId.SelectedValueChanged += new System.EventHandler(this.comboTvId_SelectedValueChanged);
            // 
            // CreateOrEditTv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboTvId);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.createNewBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtMissingParts);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCorrectedError);
            this.Controls.Add(this.txtDateOfCorrection);
            this.Controls.Add(this.txtDateOfReceip);
            this.Controls.Add(this.txtErrorByCustomer);
            this.Controls.Add(this.comboCategoryId);
            this.Controls.Add(this.comboPersonId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backToStartBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateOrEditTv";
            this.Text = "Új TV hozzáadása, vagy meglévő szerkesztése";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateOrEditTv_FormClosed);
            this.Load += new System.EventHandler(this.CreateOrEditTv_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backToStartBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboPersonId;
        private System.Windows.Forms.ComboBox comboCategoryId;
        private System.Windows.Forms.TextBox txtErrorByCustomer;
        private System.Windows.Forms.TextBox txtDateOfReceip;
        private System.Windows.Forms.TextBox txtDateOfCorrection;
        private System.Windows.Forms.TextBox txtCorrectedError;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton notInProgressRadio;
        private System.Windows.Forms.RadioButton stillInProgressRadio;
        private System.Windows.Forms.TextBox txtMissingParts;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton createRadio;
        private System.Windows.Forms.RadioButton updateRadio;
        private System.Windows.Forms.RadioButton selectRadio;
        private System.Windows.Forms.RadioButton hasNoMissingParts;
        private System.Windows.Forms.RadioButton hasAnyMissingPart;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button createNewBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox comboTvId;
    }
}