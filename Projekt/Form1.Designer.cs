
namespace Projekt
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.addNewPersonBtn = new System.Windows.Forms.Button();
            this.addNewTvCategoryBtn = new System.Windows.Forms.Button();
            this.addNewTvBtn = new System.Windows.Forms.Button();
            this.createPdfBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addNewPersonBtn
            // 
            this.addNewPersonBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.addNewPersonBtn.Location = new System.Drawing.Point(12, 133);
            this.addNewPersonBtn.Name = "addNewPersonBtn";
            this.addNewPersonBtn.Size = new System.Drawing.Size(134, 56);
            this.addNewPersonBtn.TabIndex = 0;
            this.addNewPersonBtn.Text = "Create new person";
            this.addNewPersonBtn.UseVisualStyleBackColor = true;
            this.addNewPersonBtn.Click += new System.EventHandler(this.addNewPersonBtn_Click);
            // 
            // addNewTvCategoryBtn
            // 
            this.addNewTvCategoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.addNewTvCategoryBtn.Location = new System.Drawing.Point(212, 133);
            this.addNewTvCategoryBtn.Name = "addNewTvCategoryBtn";
            this.addNewTvCategoryBtn.Size = new System.Drawing.Size(134, 56);
            this.addNewTvCategoryBtn.TabIndex = 1;
            this.addNewTvCategoryBtn.Text = "Create new tv category";
            this.addNewTvCategoryBtn.UseVisualStyleBackColor = true;
            this.addNewTvCategoryBtn.Click += new System.EventHandler(this.addNewTvCategoryBtn_Click);
            // 
            // addNewTvBtn
            // 
            this.addNewTvBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.addNewTvBtn.Location = new System.Drawing.Point(412, 133);
            this.addNewTvBtn.Name = "addNewTvBtn";
            this.addNewTvBtn.Size = new System.Drawing.Size(134, 56);
            this.addNewTvBtn.TabIndex = 2;
            this.addNewTvBtn.Text = "Create new TV";
            this.addNewTvBtn.UseVisualStyleBackColor = true;
            this.addNewTvBtn.Click += new System.EventHandler(this.addNewTvBtn_Click);
            // 
            // createPdfBtn
            // 
            this.createPdfBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.createPdfBtn.Location = new System.Drawing.Point(612, 133);
            this.createPdfBtn.Name = "createPdfBtn";
            this.createPdfBtn.Size = new System.Drawing.Size(134, 56);
            this.createPdfBtn.TabIndex = 3;
            this.createPdfBtn.Text = "Create new PDF";
            this.createPdfBtn.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.exitBtn.Location = new System.Drawing.Point(310, 250);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(134, 56);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.createPdfBtn);
            this.Controls.Add(this.addNewTvBtn);
            this.Controls.Add(this.addNewTvCategoryBtn);
            this.Controls.Add(this.addNewPersonBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainView";
            this.Text = "Start Window";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addNewPersonBtn;
        private System.Windows.Forms.Button addNewTvCategoryBtn;
        private System.Windows.Forms.Button addNewTvBtn;
        private System.Windows.Forms.Button createPdfBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

