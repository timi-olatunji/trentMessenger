using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace Trentmessenger
{
    public partial class recovery : Form
    {
        string securityA;

        public recovery()
        {
            InitializeComponent();

            toolTipInfoTP.SetToolTip(pictureBoxNumError, "Username must not exceed 30 characters!");
            toolTipInfoTP.SetToolTip(pictureBoxNumErrorLB, "Phone number must not exceed 10 numbers!");
            toolTipInfoTP.SetToolTip(pictureBox_reponseError, "Security Answer must not exceed 40 characters!");
        }

        private void AccountBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                Regex phoneNumber = new Regex(@"^(07)\d{9}$");
                if (!phoneNumber.IsMatch(textBoxNumber.Text)) throw new Exception("You entered an invalid phone number!");
                if (textBox_reponseS.Text.Length > 40) throw new Exception("Security Answer must not exceed 40 characters!");
                if (!Connection.FetchReader("USE trentMessengerDB3; SELECT AccountID FROM Accounts WHERE TelNumber = '" + textBoxNumber.Text + "' AND Username_ = '" + textBox_TextName.Text + "';").HasRows) throw new Exception("There is no phone number or username matching the one you entered");

                Connection.CloseConnection();
                groupBoxSecurity.Visible = true;
                labelStep2LB.Visible = true;

                SqlDataReader dataReader = Connection.FetchReader("USE trentMessengerDB3; SELECT SecurityQuestion, SecurityR FROM Accounts WHERE TelNumber = '" + textBoxNumber.Text + "' AND Username_ = '" + textBox_TextName.Text + "';");
                while (dataReader.Read())
                {
                    textBoxQuestionS_.Text = dataReader.GetString(0);
                    securityA = dataReader.GetString(1);
                }
                dataReader.Close();
                Connection.CloseConnection();
            }
            catch (Exception expt)
            {
                MessageBox.Show(expt.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.CloseConnection();
            }
        }

        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            if (textBox_TextName.Text.Length > 30)
                pictureBoxNumError.Visible = true;
            else
                pictureBoxNumError.Visible = false;

            ChangeConBtn();
        }

        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNumber.Text.Length > 11)
                pictureBoxNumErrorLB.Visible = true;
            else
                pictureBoxNumErrorLB.Visible = false;

            ChangeConBtn();
        }

        private void TextBoxReponseS_TextChanged(object sender, EventArgs e)
        {
            if (textBox_reponseS.Text.Length > 40)
                pictureBox_reponseError.Visible = true;
            else
                pictureBox_reponseError.Visible = false;

            buttonRecover_Btn.Enabled = textBox_reponseS.Text.Length > 0 ? true : false;
        }

        public void ChangeConBtn()
        {
            buttonAccount.Enabled = textBox_TextName.Text.Length > 0 && textBoxNumber.Text.Length > 0 ? true : false;
        }

        private void RecoveryButton_Click(object sender, EventArgs e)
        {
            if (textBox_reponseS.Text.ToLower() != securityA.ToLower()) MessageBox.Show("You entered the wrong answer for the given question", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                string password = Connection.ReturnScalar("USE trentMessengerDB3; SELECT UserPassword FROM Accounts WHERE TelNumber = '" + textBoxNumber.Text + "' AND Username_ = '" + textBox_TextName.Text + "';").ToString();

                MessageBox.Show("The security question has been successfully confirmed! \n Your password is: “" + password + "”\n\nBe sure to change it as soon as possible", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void RecoveryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            login SignInForm = new login();
            SignInForm.Show();
        }
    }
}
