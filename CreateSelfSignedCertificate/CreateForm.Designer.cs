namespace CreateSelfSignedCertificate
{
    partial class CreateForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioDigitalSignature = new System.Windows.Forms.RadioButton();
            this.radioKeyEncipherment = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(121, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 23);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Expires in year:";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(296, 214);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // numYear
            // 
            this.numYear.Location = new System.Drawing.Point(121, 58);
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(120, 23);
            this.numYear.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(121, 87);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(250, 23);
            this.txtPassword.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioDigitalSignature);
            this.groupBox1.Controls.Add(this.radioKeyEncipherment);
            this.groupBox1.Location = new System.Drawing.Point(121, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 82);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usage:";
            // 
            // radioDigitalSignature
            // 
            this.radioDigitalSignature.AutoSize = true;
            this.radioDigitalSignature.Location = new System.Drawing.Point(54, 47);
            this.radioDigitalSignature.Name = "radioDigitalSignature";
            this.radioDigitalSignature.Size = new System.Drawing.Size(112, 19);
            this.radioDigitalSignature.TabIndex = 1;
            this.radioDigitalSignature.TabStop = true;
            this.radioDigitalSignature.Text = "Digital Signature";
            this.radioDigitalSignature.UseVisualStyleBackColor = true;
            // 
            // radioKeyEncipherment
            // 
            this.radioKeyEncipherment.AutoSize = true;
            this.radioKeyEncipherment.Location = new System.Drawing.Point(54, 22);
            this.radioKeyEncipherment.Name = "radioKeyEncipherment";
            this.radioKeyEncipherment.Size = new System.Drawing.Size(121, 19);
            this.radioKeyEncipherment.TabIndex = 0;
            this.radioKeyEncipherment.TabStop = true;
            this.radioKeyEncipherment.Text = "Key Encipherment";
            this.radioKeyEncipherment.UseVisualStyleBackColor = true;
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 253);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numYear);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(426, 292);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(426, 292);
            this.Name = "CreateForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Self Signed Certificate";
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private Button btnCreate;
        private NumericUpDown numYear;
        private TextBox txtPassword;
        private Label label3;
        private GroupBox groupBox1;
        private RadioButton radioDigitalSignature;
        private RadioButton radioKeyEncipherment;
    }
}