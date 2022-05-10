
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
            this.SuspendLayout();
            // 
            // backToStartBtn
            // 
            this.backToStartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.backToStartBtn.Location = new System.Drawing.Point(12, 12);
            this.backToStartBtn.Name = "backToStartBtn";
            this.backToStartBtn.Size = new System.Drawing.Size(102, 39);
            this.backToStartBtn.TabIndex = 2;
            this.backToStartBtn.Text = "Back to start";
            this.backToStartBtn.UseVisualStyleBackColor = true;
            this.backToStartBtn.Click += new System.EventHandler(this.backToStartBtn_Click);
            // 
            // CreatePdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backToStartBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreatePdf";
            this.Text = "Pdf létrehozása";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreatePdf_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backToStartBtn;
    }
}