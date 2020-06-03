using System;
using System.Drawing;
using System.Windows.Forms;
using Trentmessenger.Classes;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.IO;

namespace Trentmessenger
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();

            toolTip_info.SetToolTip(pictureBox_passwordError, "User Password must not exceed 30 numbers");

            AppSettings.AppBackgroundImage = null;
            AppSettings.AppBackgroundColor = SystemColors.Control;
            AppSettings.AppAccountBackgroundColor = Color.Purple;
            AppSettings.AppContactBackgroundColor = Color.White;
            AppSettings.AppAccountTextColor = Color.Black;
            AppSettings.AppContactTextColor = Color.Black;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Handling the Login Logic
                maskedTextBox_number.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string phoneNumber_ = maskedTextBox_number.Text;
                maskedTextBox_number.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                Regex phoneNum = new Regex(@"^(07)\d{9}$"); //Specifies and checks for 11 digits, including a mandatory UK Line 07 Prefix
                if (!phoneNum.IsMatch(phoneNumber_)) throw new Exception("Phone number entered is Invalid");
                if (textBox_password.Text.Length > 30) throw new Exception("User Password must not exceed 30 numbers");
                if (!Connection.FetchReader("USE trentMessengerDB3; SELECT AccountID FROM Accounts WHERE TelNumber = '" + phoneNumber_ + "' AND UserPassword = '" + textBox_password.Text + "';").HasRows) throw new Exception("Incorrect phone number or password");

                Connection.CloseConnection();

                //fetching account related user details
                SqlDataReader dataReader = Connection.FetchReader("USE trentMessengerDB3; SELECT * FROM Accounts WHERE TelNumber = '" + phoneNumber_ + "' AND UserPassword = '" + textBox_password.Text + "';");
                while (dataReader.Read())
                {
                    Account.AccountId = int.Parse(dataReader.GetValue(0).ToString());
                    Account.Username_ = dataReader.GetString(1);
                    Account.UserPassword = dataReader.GetString(2);
                    Account.TelNumber = dataReader.GetString(3);
                    Account.AboutUser = dataReader.GetString(4);
                    MemoryStream memoryStream = new MemoryStream((byte[])dataReader.GetValue(5));
                    Account.Image = Image.FromStream(memoryStream);
                    Account.SecurityQuestion = dataReader.GetString(6);
                    Account.SecurityAnswer = dataReader.GetString(7);
                    Account.LastSeenOnline = (DateTime)dataReader.GetValue(8);
                    Account.UserRegistrationDate = (DateTime)dataReader.GetValue(9);
                }

                dataReader.Close();
                Connection.CloseConnection();

                Connection.IssueQuery("USE trentMessengerDB3; UPDATE Accounts SET LastSeenOnline = '" + DateTime.Now.ToString() + "' WHERE AccountID = " + Account.AccountId + ";");
                dataReader = Connection.FetchReader("USE trentMessengerDB3; SELECT * FROM appSettings WHERE AccountID = " + Account.AccountId+";");
                while (dataReader.Read())
                {
                    if (dataReader.GetValue(1).GetType() != typeof(DBNull))
                    {
                        MemoryStream memoryStream = new MemoryStream((byte[])dataReader.GetValue(1));
                        AppSettings.AppBackgroundImage = Image.FromStream(memoryStream);
                    }
                    else

                    AppSettings.AppBackgroundImage = null;
                    AppSettings.AppBackgroundColor = Color.FromArgb(int.Parse(dataReader.GetValue(2).ToString()), int.Parse(dataReader.GetValue(3).ToString()), int.Parse(dataReader.GetValue(4).ToString()));
                    AppSettings.AppAccountBackgroundColor = Color.FromArgb(int.Parse(dataReader.GetValue(5).ToString()), int.Parse(dataReader.GetValue(6).ToString()), int.Parse(dataReader.GetValue(7).ToString()));
                    AppSettings.AppContactBackgroundColor = Color.FromArgb(int.Parse(dataReader.GetValue(8).ToString()), int.Parse(dataReader.GetValue(9).ToString()), int.Parse(dataReader.GetValue(10).ToString()));
                    AppSettings.AppAccountTextColor = Color.FromArgb(int.Parse(dataReader.GetValue(11).ToString()), int.Parse(dataReader.GetValue(12).ToString()), int.Parse(dataReader.GetValue(13).ToString()));
                    AppSettings.AppContactTextColor = Color.FromArgb(int.Parse(dataReader.GetValue(14).ToString()), int.Parse(dataReader.GetValue(15).ToString()), int.Parse(dataReader.GetValue(16).ToString()));


                }
                Connection.CloseConnection();
                ChatHome trentMessenger = new ChatHome();
                trentMessenger.Show();
                MessageBox.Show("Hi, " + Account.Username_ + "\nWelcome to your TrentMessenger Account \nYou last logged in on “ " + Account.LastSeenOnline + " ”", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.CloseConnection();
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            register registerForm = new register();
            registerForm.ShowDialog();
        }

        private void ShowPasswordButton_Click(object sender, EventArgs e)
        {
            if (textBox_password.UseSystemPasswordChar == false && textBox_password.Text != "Password")
                textBox_password.UseSystemPasswordChar = true;
            else
                textBox_password.UseSystemPasswordChar = false;
        }

        private void RecoveryLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            recovery recoveryForm = new recovery();
            recoveryForm.ShowDialog();
        }

        public void ChangeLoginButton()
        {
            button_login.Enabled = (maskedTextBox_number.Text.Length > 0 && textBox_password.Text.Length > 0 && maskedTextBox_number.Text != "Phone Number" && textBox_password.Text != "Password") ? true : false;
        }

        private void TextBoxNumber_Click(object sender, EventArgs e)
        {
            if (maskedTextBox_number.Text == "Phone Number")
            {
                maskedTextBox_number.Clear();
                maskedTextBox_number.ForeColor = Color.White;
            }
        }

        private void TextBoxNumber_Leave(object sender, EventArgs e)
        {
            if (maskedTextBox_number.Text.Length == 0)
            {
                maskedTextBox_number.Text = "Phone Number";
                maskedTextBox_number.ForeColor = Color.LightSeaGreen;
            }
        }

        private void TextBoxPasswordTextChanged(object sender, EventArgs e)
        {
            if (textBox_password.Text.Length > 30 && textBox_password.Text != "Password")
                pictureBox_passwordError.Visible = true;
            else
                pictureBox_passwordError.Visible = false;

            ChangeLoginButton();
            button_showPass.Enabled = textBox_password.Text.Length > 0 && textBox_password.Text != "Password" ? true : false;
        }

        private void TextBoxPasswordClick(object sender, EventArgs e)
        {
            if (textBox_password.Text == "Password")
            {
                textBox_password.UseSystemPasswordChar = true;
                textBox_password.Clear();
                textBox_password.ForeColor = Color.White;
            }
        }

        private void TextBoxPasswordLeave(object sender, EventArgs e)
        {
            if (textBox_password.Text.Length == 0)
            {
                textBox_password.UseSystemPasswordChar = false;
                textBox_password.Text = "Password";
                textBox_password.ForeColor = Color.LightSeaGreen;
            }
        }

        private void LoginFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MaskedTextBoxNumber_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ChangeLoginButton();
        }
    }
}
