using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Trentmessenger
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();

            toolTipInfo.SetToolTip(pictureBoxNomError, "Username must not exceed 30 characters!");
            toolTipInfo.SetToolTip(pictureBoxNumberError, "Phone number must not exceed 10 numbers!");
            toolTipInfo.SetToolTip(pictureBox_aboutError, "AboutUser must not exceed 100 characters!");
            toolTipInfo.SetToolTip(pictureBox_passwordError, "UserPassword must not exceed 30 characters");
            toolTipInfo.SetToolTip(pictureBox_reponseError, "Security Answer must not exceed 40 characters");
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            try
            {
                Regex phoneNum = new Regex(@"^(07)\d{9}$");
                if (!phoneNum.IsMatch(textBoxNumber.Text)) throw new Exception("You entered an invalid phone number!");
                if (textBoxAbout.Text.Length > 100) throw new Exception("About User must not exceed 100 characters!");
                if (textBox_password_pass.Text.Length > 30) throw new Exception("UserPassword must not exceed 30 characters!");
                if (textBoxResponseS.Text.Length > 40) throw new Exception("Security Answer must not exceed 40 characters!");
                if (Connection.FetchReader("USE trentMessengerDB3; SELECT AccountID FROM Accounts WHERE TelNumber = '" + textBoxNumber.Text + "';").HasRows) throw new Exception("An account with the same phone number already exists!");

                Connection.CloseConnection();
                MemoryStream memoryStream = new MemoryStream();
                pictureBoxPhoto.Image.Save(memoryStream, pictureBoxPhoto.Image.RawFormat);
                byte[] picture = memoryStream.GetBuffer();
                memoryStream.Close();
                Connection.sqlCommand.Parameters.Clear();
                Connection.sqlCommand.Parameters.AddWithValue("@photo", picture);
                Connection.sqlCommand.Parameters.AddWithValue("@about", textBoxAbout.Text);
                Connection.IssueQuery(" USE trentMessengerDB3; INSERT INTO Accounts(Username_, UserPassword, TelNumber, AboutUser, Image, SecurityQuestion, SecurityR) VALUES('" + textBoxName.Text + "', '" + textBox_password_pass.Text + "', '" + textBoxNumber.Text + "', @about, @photo, '" + comboBoxQuestionS.Text + "', '" + textBoxResponseS.Text + "');");
                MessageBox.Show("Account successfully registered", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.CloseConnection();
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            foreach (TextBox textBox in this.Controls.OfType<TextBox>())
                textBox.Clear();

            comboBoxQuestionS.SelectedIndex = -1;
            pictureBoxPhoto.Image = Properties.Resources.Pic_Placeholder_Male;
            ChangeClearBtn();
        }

        private void PhotoPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog() { Multiselect = false, Title = "Choose an Image", InitialDirectory = "C:\\Pictures", Filter = "Files PNG (*.png)|*.png|Files JPG (*.jpg)|*.jpg|Files GIF (*.gif)|*.gif", FilterIndex = 2 };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPhoto.Image = Image.FromFile(openFileDialog.FileName);
                ChangeClearBtn();
            }
        }

        private void NumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNumber.Text.Length > 11)
                pictureBoxNumberError.Visible = true;
            else
                pictureBoxNumberError.Visible = false;

            ChangeRegBtn();
            ChangeClearBtn();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length > 30)
                pictureBoxNomError.Visible = true;
            else
                pictureBoxNomError.Visible = false;

            ChangeRegBtn();
            ChangeClearBtn();
        }

        private void AboutTextBox_TextChanged(object sender, EventArgs e)
        {
            if (textBoxAbout.Text.Length > 100)
                pictureBox_aboutError.Visible = true;
            else
                pictureBox_aboutError.Visible = false;

            ChangeRegBtn();
            ChangeClearBtn();
        }

        private void QuestionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeRegBtn();
            ChangeClearBtn();
        }

        private void ReponseTextBox_TextChanged(object sender, EventArgs e)
        {
            if (textBoxResponseS.Text.Length > 40)
                pictureBox_reponseError.Visible = true;
            else
                pictureBox_reponseError.Visible = false;

            ChangeRegBtn();
            ChangeClearBtn();
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (textBox_password_pass.Text.Length > 40)
                pictureBox_passwordError.Visible = true;
            else
                pictureBox_passwordError.Visible = false;

            button_showPass_pass.Enabled = textBox_password_pass.Text.Length > 0 ? true : false;
            ChangeRegBtn();
            ChangeClearBtn();
        }

        public void ChangeRegBtn()
        {
            buttonRegister.Enabled = textBox_password_pass.Text.Length > 0 && textBoxName.Text.Length > 0 && textBoxNumber.Text.Length > 0 && textBoxAbout.Text.Length > 0 && comboBoxQuestionS.SelectedIndex != -1 && textBoxResponseS.Text.Length > 0 ? true : false;
        }

        public void ChangeClearBtn()
        {
            buttonReset.Enabled = pictureBoxPhoto.Image != Properties.Resources.Pic_Placeholder_Male || textBoxName.Text.Length > 0 || textBoxNumber.Text.Length > 0 || textBox_password_pass.Text.Length > 0 || textBoxAbout.Text.Length > 0 || comboBoxQuestionS.SelectedIndex != -1 || textBoxResponseS.Text.Length > 0 ? true : false;
        }

        private void ShowPassButton_Click(object sender, EventArgs e)
        {
            if (textBox_password_pass.UseSystemPasswordChar == false && textBox_password_pass.Text != "Password")
                textBox_password_pass.UseSystemPasswordChar = true;
            else
                textBox_password_pass.UseSystemPasswordChar = false; ;
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            login SignInForm = new login();
            SignInForm.Show();
        }
    }
}
