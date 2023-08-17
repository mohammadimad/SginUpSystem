using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        struct stEmailRequirements
        {
            public bool Capital;
            public bool @Gmail;
            public bool Digit;
            public bool IsGmailAtLast(TextBox textBox)
            {
                int indexOf = 0;
                string GmailText = "gmail.com";
                indexOf = textBox.Text.IndexOf(GmailText);
                bool IsGmailAtLast = (textBox.Text.Length == (indexOf + GmailText.Length)) ? true : false;
                if (!IsGmailAtLast || indexOf == -1)
                {
                    @Gmail = false;
                    return @Gmail;
                }
                else
                {
                    @Gmail = true;
                    return @Gmail;
                }
            }
            public bool CheckEmailRequirements()
            {
                return Capital == true&& @Gmail == true && true && Digit == true;
            }
            public bool IsEmailHasDigit(TextBox TxtBox)
            {
                for (byte i = 0; i < TxtBox.Text.Length; i++)
                {
                    if (char.IsDigit(TxtBox.Text[i]))
                    {
                        Digit = true;
                        return Digit;
                    }
                }
                Digit = false;
                return Digit;
            }

            public bool IsEmailHasCapital(TextBox TxtBox)
            {
                for (byte i = 0; i < TxtBox.Text.Length; i++)
                {
                    if (char.IsUpper(TxtBox.Text[i]))
                    {
                        Capital = true;
                        return Capital;
                    }
                }
                Capital = false;
                return Capital;
            }
        }

        struct stPasswordReuirements
        {
            public byte Capitals;
            public byte Digits;
            public byte MaxLength;
            public bool IsMaxLength;
            public void CountCapitals()
            {
                Capitals++;
            }
            public void CountDigits()
            {
                Digits++;
            }
            public bool IsCapitalAtLeast(byte num)
            {
                return Capitals >= num;
            }
            public bool IsDigitAtLeast(byte num)
            {
                return Digits >= num;
            }
            
           public bool CheckMaxLength(TextBox textBox)
            {
                MaxLength = 10;
                if (textBox.Text.Length > MaxLength)
                {
                    IsMaxLength = true;
                    return IsMaxLength;
                }
                else
                {
                    IsMaxLength = false;
                    return IsMaxLength;
                }
            }
            public bool CheckPasswordRequirements(TextBox textBox, byte num)
            {
                return IsCapitalAtLeast(num) && IsDigitAtLeast(num) && !CheckMaxLength(textBox);
            }
            public void Clear()
            {
                Capitals = 0;
                Digits = 0;
            }
        }
        struct stSignInResults
        {
            public bool Email;
            public bool Password;
        }
        stSignInResults SignInResults;
        // real exambels

        stEmailRequirements EmailRequirements;

        stPasswordReuirements PasswordRequirements;
        bool CheckEmail()
        {
            if (EmailRequirements.IsGmailAtLast(txtEmail))
            {
                lblGmail.ForeColor = Color.Green;
            }
            else
            {
                lblGmail.ForeColor = Color.Red;
            }
            if (EmailRequirements.IsEmailHasCapital(txtEmail))
            {
                lblEmailCapital.ForeColor = Color.Green;
            }
            else
            {
                lblEmailDigit.ForeColor = Color.Red;
            }
            if (EmailRequirements.IsEmailHasDigit(txtEmail))
            {
                lblEmailDigit.ForeColor = Color.Green;
            }
            else
            {
                lblEmailDigit.ForeColor = Color.Red;
            }
            return EmailRequirements.CheckEmailRequirements();
        }
        void ChangePasswordLabelsColor()
        {
            if (PasswordRequirements.IsCapitalAtLeast(2))
            {
                lblPassword2Capitals.ForeColor = Color.Green;
            }
            else
            {
                lblPassword2Capitals.ForeColor = Color.Red;
            }
            if (PasswordRequirements.IsDigitAtLeast(2))
            {
                lblPassword2Digits.ForeColor = Color.Green;
            }
            else
            {
                lblPassword2Digits.ForeColor = Color.Red;
            }
            if (!PasswordRequirements.CheckMaxLength(txtPassword))
            {
                lblPasswordMaxLength.ForeColor = Color.Green;
            }
            else
            {
                lblPasswordMaxLength.ForeColor = Color.Red;
            }
        }
        bool CheckPassword()
        {
            PasswordRequirements.Clear();
            for (byte i = 0; i < txtPassword.Text.Length; i++)
            {
                if (char.IsDigit(txtPassword.Text[i]))
                {
                    PasswordRequirements.CountDigits();
                }
                if (char.IsUpper(txtPassword.Text[i]))
                {
                    PasswordRequirements.CountCapitals();
                }
            }
            ChangePasswordLabelsColor();
            return PasswordRequirements.CheckPasswordRequirements(txtPassword,2);
        }
        void ClearErrorProvider(ErrorProvider ERP)
        {
            ERP.Clear();
        }
        void ShowErrorProvider(ErrorProvider ERP, string Text, TextBox TxtBox)
        {
            ERP.SetError(TxtBox, Text);
        }
        void CheckStartButton()
        {
            if (SignInResults.Email && SignInResults.Password)
            {
                BtnSignIn.Enabled = true;
            }
            else
            {
                BtnSignIn.Enabled = false;
            }
        }
        void ShowNotifyIcon(NotifyIcon notifyIcon, string Text, string Title)
        {
            notifyIcon1.BalloonTipTitle = Title;
            notifyIcon1.BalloonTipText = Text;
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.ShowBalloonTip(1000);
        }
        void SignIn()
        {
            MessageBox.Show("Sign In Success !", "Sign In ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowNotifyIcon(notifyIcon1, "Success", "Sign In");
            this.Close();
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (CheckEmail())
            {
                ClearErrorProvider(errorProvider1);
                SignInResults.Email = true;
            }
            else
            {
                ShowErrorProvider(errorProvider1, "Please Enter Right Email", txtEmail);
                SignInResults.Email = false;
            }

            CheckStartButton();
            // Check Button
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (CheckPassword())
            {
                ClearErrorProvider(errorProvider2);
                SignInResults.Password = true;
            }
            else
            {
                ShowErrorProvider(errorProvider2, "Please Enter Right Password", txtPassword);
                SignInResults.Password = false;
            }

            CheckStartButton();
            // Check Button
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            SignIn();
        }
    }
}
