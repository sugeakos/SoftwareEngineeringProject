
namespace Projekt
{
    partial class CreateOrUpdateTvCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateOrUpdateTvCategory));
            this.backToStartBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.selectCategoryBtn = new System.Windows.Forms.Button();
            this.createNewCategoryBtn = new System.Windows.Forms.Button();
            this.updateCategoryBtn = new System.Windows.Forms.Button();
            this.searchRadioBtn = new System.Windows.Forms.RadioButton();
            this.updateRadioBtn = new System.Windows.Forms.RadioButton();
            this.createNewRadioBtn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // backToStartBtn
            // 
            this.backToStartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.backToStartBtn.Location = new System.Drawing.Point(12, 12);
            this.backToStartBtn.Name = "backToStartBtn";
            this.backToStartBtn.Size = new System.Drawing.Size(102, 39);
            this.backToStartBtn.TabIndex = 1;
            this.backToStartBtn.Text = "Back to start";
            this.backToStartBtn.UseVisualStyleBackColor = true;
            this.backToStartBtn.Click += new System.EventHandler(this.backToStartBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(27, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Category ID";
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Location = new System.Drawing.Point(132, 82);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(122, 20);
            this.txtCategoryId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(27, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Category name";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(132, 116);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(122, 20);
            this.txtCategoryName.TabIndex = 5;
            // 
            // selectCategoryBtn
            // 
            this.selectCategoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.selectCategoryBtn.Location = new System.Drawing.Point(12, 172);
            this.selectCategoryBtn.Name = "selectCategoryBtn";
            this.selectCategoryBtn.Size = new System.Drawing.Size(131, 57);
            this.selectCategoryBtn.TabIndex = 6;
            this.selectCategoryBtn.Text = "Search for a category by name";
            this.selectCategoryBtn.UseVisualStyleBackColor = true;
            this.selectCategoryBtn.Click += new System.EventHandler(this.selectCategoryBtn_Click);
            // 
            // createNewCategoryBtn
            // 
            this.createNewCategoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.createNewCategoryBtn.Location = new System.Drawing.Point(199, 172);
            this.createNewCategoryBtn.Name = "createNewCategoryBtn";
            this.createNewCategoryBtn.Size = new System.Drawing.Size(131, 57);
            this.createNewCategoryBtn.TabIndex = 7;
            this.createNewCategoryBtn.Text = "Create new category";
            this.createNewCategoryBtn.UseVisualStyleBackColor = true;
            this.createNewCategoryBtn.Click += new System.EventHandler(this.createNewCategoryBtn_Click);
            // 
            // updateCategoryBtn
            // 
            this.updateCategoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.updateCategoryBtn.Location = new System.Drawing.Point(383, 172);
            this.updateCategoryBtn.Name = "updateCategoryBtn";
            this.updateCategoryBtn.Size = new System.Drawing.Size(131, 57);
            this.updateCategoryBtn.TabIndex = 8;
            this.updateCategoryBtn.Text = "Update category";
            this.updateCategoryBtn.UseVisualStyleBackColor = true;
            this.updateCategoryBtn.Click += new System.EventHandler(this.updateCategoryBtn_Click);
            // 
            // searchRadioBtn
            // 
            this.searchRadioBtn.AutoSize = true;
            this.searchRadioBtn.Location = new System.Drawing.Point(373, 51);
            this.searchRadioBtn.Name = "searchRadioBtn";
            this.searchRadioBtn.Size = new System.Drawing.Size(55, 17);
            this.searchRadioBtn.TabIndex = 9;
            this.searchRadioBtn.Text = "Select";
            this.searchRadioBtn.UseVisualStyleBackColor = true;
            this.searchRadioBtn.CheckedChanged += new System.EventHandler(this.searchRadioBtn_CheckedChanged);
            // 
            // updateRadioBtn
            // 
            this.updateRadioBtn.AutoSize = true;
            this.updateRadioBtn.Location = new System.Drawing.Point(373, 74);
            this.updateRadioBtn.Name = "updateRadioBtn";
            this.updateRadioBtn.Size = new System.Drawing.Size(60, 17);
            this.updateRadioBtn.TabIndex = 10;
            this.updateRadioBtn.Text = "Update";
            this.updateRadioBtn.UseVisualStyleBackColor = true;
            this.updateRadioBtn.CheckedChanged += new System.EventHandler(this.updateRadioBtn_CheckedChanged);
            // 
            // createNewRadioBtn
            // 
            this.createNewRadioBtn.AutoSize = true;
            this.createNewRadioBtn.Location = new System.Drawing.Point(373, 97);
            this.createNewRadioBtn.Name = "createNewRadioBtn";
            this.createNewRadioBtn.Size = new System.Drawing.Size(47, 17);
            this.createNewRadioBtn.TabIndex = 11;
            this.createNewRadioBtn.Text = "New";
            this.createNewRadioBtn.UseVisualStyleBackColor = true;
            this.createNewRadioBtn.CheckedChanged += new System.EventHandler(this.createNewRadioBtn_CheckedChanged);
            // 
            // CreateOrUpdateTvCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 255);
            this.Controls.Add(this.createNewRadioBtn);
            this.Controls.Add(this.updateRadioBtn);
            this.Controls.Add(this.searchRadioBtn);
            this.Controls.Add(this.updateCategoryBtn);
            this.Controls.Add(this.createNewCategoryBtn);
            this.Controls.Add(this.selectCategoryBtn);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCategoryId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backToStartBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateOrUpdateTvCategory";
            this.Text = "Create Or Update Tv Category";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateOrUpdateTvCategory_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backToStartBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Button selectCategoryBtn;
        private System.Windows.Forms.Button createNewCategoryBtn;
        private System.Windows.Forms.Button updateCategoryBtn;
        private System.Windows.Forms.RadioButton searchRadioBtn;
        private System.Windows.Forms.RadioButton updateRadioBtn;
        private System.Windows.Forms.RadioButton createNewRadioBtn;
    }
}