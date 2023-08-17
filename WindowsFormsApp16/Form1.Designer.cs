
namespace WindowsFormsApp16
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEmailCapital = new System.Windows.Forms.Label();
            this.lblEmailDigit = new System.Windows.Forms.Label();
            this.lblGmail = new System.Windows.Forms.Label();
            this.lblPasswordMaxLength = new System.Windows.Forms.Label();
            this.lblPassword2Digits = new System.Windows.Forms.Label();
            this.lblPassword2Capitals = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnSignIn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(58, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email: ";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(186, 120);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(194, 30);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(186, 202);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(194, 29);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(48, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(508, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email Must Be:";
            // 
            // lblEmailCapital
            // 
            this.lblEmailCapital.AutoSize = true;
            this.lblEmailCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailCapital.ForeColor = System.Drawing.Color.Red;
            this.lblEmailCapital.Location = new System.Drawing.Point(508, 74);
            this.lblEmailCapital.Name = "lblEmailCapital";
            this.lblEmailCapital.Size = new System.Drawing.Size(135, 20);
            this.lblEmailCapital.TabIndex = 5;
            this.lblEmailCapital.Text = "At Least 1 Capital";
            // 
            // lblEmailDigit
            // 
            this.lblEmailDigit.AutoSize = true;
            this.lblEmailDigit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailDigit.ForeColor = System.Drawing.Color.Red;
            this.lblEmailDigit.Location = new System.Drawing.Point(508, 120);
            this.lblEmailDigit.Name = "lblEmailDigit";
            this.lblEmailDigit.Size = new System.Drawing.Size(118, 20);
            this.lblEmailDigit.TabIndex = 6;
            this.lblEmailDigit.Text = "At Least 1 Digit";
            // 
            // lblGmail
            // 
            this.lblGmail.AutoSize = true;
            this.lblGmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGmail.ForeColor = System.Drawing.Color.Red;
            this.lblGmail.Location = new System.Drawing.Point(508, 168);
            this.lblGmail.Name = "lblGmail";
            this.lblGmail.Size = new System.Drawing.Size(149, 20);
            this.lblGmail.TabIndex = 7;
            this.lblGmail.Text = "@gmail.com(at last)";
            // 
            // lblPasswordMaxLength
            // 
            this.lblPasswordMaxLength.AutoSize = true;
            this.lblPasswordMaxLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordMaxLength.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordMaxLength.Location = new System.Drawing.Point(508, 379);
            this.lblPasswordMaxLength.Name = "lblPasswordMaxLength";
            this.lblPasswordMaxLength.Size = new System.Drawing.Size(114, 20);
            this.lblPasswordMaxLength.TabIndex = 11;
            this.lblPasswordMaxLength.Text = "Max Length 10";
            // 
            // lblPassword2Digits
            // 
            this.lblPassword2Digits.AutoSize = true;
            this.lblPassword2Digits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword2Digits.ForeColor = System.Drawing.Color.Red;
            this.lblPassword2Digits.Location = new System.Drawing.Point(508, 331);
            this.lblPassword2Digits.Name = "lblPassword2Digits";
            this.lblPassword2Digits.Size = new System.Drawing.Size(118, 20);
            this.lblPassword2Digits.TabIndex = 10;
            this.lblPassword2Digits.Text = "At Least 2 Digit";
            // 
            // lblPassword2Capitals
            // 
            this.lblPassword2Capitals.AutoSize = true;
            this.lblPassword2Capitals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword2Capitals.ForeColor = System.Drawing.Color.Red;
            this.lblPassword2Capitals.Location = new System.Drawing.Point(508, 285);
            this.lblPassword2Capitals.Name = "lblPassword2Capitals";
            this.lblPassword2Capitals.Size = new System.Drawing.Size(135, 20);
            this.lblPassword2Capitals.TabIndex = 9;
            this.lblPassword2Capitals.Text = "At Least 2 Capital";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Brown;
            this.label10.Location = new System.Drawing.Point(508, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Password Must Be:";
            // 
            // BtnSignIn
            // 
            this.BtnSignIn.BackColor = System.Drawing.Color.White;
            this.BtnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(165)))));
            this.BtnSignIn.Location = new System.Drawing.Point(186, 379);
            this.BtnSignIn.Name = "BtnSignIn";
            this.BtnSignIn.Size = new System.Drawing.Size(132, 39);
            this.BtnSignIn.TabIndex = 12;
            this.BtnSignIn.Text = "Sign in";
            this.BtnSignIn.UseVisualStyleBackColor = false;
            this.BtnSignIn.Click += new System.EventHandler(this.BtnSignIn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSignIn);
            this.Controls.Add(this.lblPasswordMaxLength);
            this.Controls.Add(this.lblPassword2Digits);
            this.Controls.Add(this.lblPassword2Capitals);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblGmail);
            this.Controls.Add(this.lblEmailDigit);
            this.Controls.Add(this.lblEmailCapital);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEmailCapital;
        private System.Windows.Forms.Label lblEmailDigit;
        private System.Windows.Forms.Label lblGmail;
        private System.Windows.Forms.Label lblPasswordMaxLength;
        private System.Windows.Forms.Label lblPassword2Digits;
        private System.Windows.Forms.Label lblPassword2Capitals;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnSignIn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

