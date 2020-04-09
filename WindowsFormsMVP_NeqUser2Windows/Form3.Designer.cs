namespace WindowsFormsMVP_NeqUser2Windows
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveChange = new System.Windows.Forms.Button();
            this.txtLoginChange = new System.Windows.Forms.TextBox();
            this.txtPasswordChange = new System.Windows.Forms.TextBox();
            this.txtNameChange = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // btnSaveChange
            // 
            this.btnSaveChange.Location = new System.Drawing.Point(12, 109);
            this.btnSaveChange.Name = "btnSaveChange";
            this.btnSaveChange.Size = new System.Drawing.Size(158, 23);
            this.btnSaveChange.TabIndex = 2;
            this.btnSaveChange.Text = "Save change";
            this.btnSaveChange.UseVisualStyleBackColor = true;
            this.btnSaveChange.Click += new System.EventHandler(this.btnSaveChange_Click);
            // 
            // txtLoginChange
            // 
            this.txtLoginChange.Location = new System.Drawing.Point(12, 37);
            this.txtLoginChange.Name = "txtLoginChange";
            this.txtLoginChange.Size = new System.Drawing.Size(158, 20);
            this.txtLoginChange.TabIndex = 3;
            // 
            // txtPasswordChange
            // 
            this.txtPasswordChange.Location = new System.Drawing.Point(12, 63);
            this.txtPasswordChange.Name = "txtPasswordChange";
            this.txtPasswordChange.Size = new System.Drawing.Size(158, 20);
            this.txtPasswordChange.TabIndex = 4;
            // 
            // txtNameChange
            // 
            this.txtNameChange.Location = new System.Drawing.Point(12, 11);
            this.txtNameChange.Name = "txtNameChange";
            this.txtNameChange.Size = new System.Drawing.Size(158, 20);
            this.txtNameChange.TabIndex = 5;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 204);
            this.Controls.Add(this.txtNameChange);
            this.Controls.Add(this.txtPasswordChange);
            this.Controls.Add(this.txtLoginChange);
            this.Controls.Add(this.btnSaveChange);
            this.Controls.Add(this.label2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveChange;
        private System.Windows.Forms.TextBox txtLoginChange;
        private System.Windows.Forms.TextBox txtPasswordChange;
        private System.Windows.Forms.TextBox txtNameChange;
    }
}