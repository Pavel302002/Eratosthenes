using System;
using System.Windows.Forms;

namespace EratosthenesProject
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            SignupForm sf = new SignupForm();
            sf.FormClosed += (s, args) => this.Close();
            this.Hide();
            sf.Show();
        }

        private void authButton_Click(object sender, EventArgs e)
        {
            //Стираем введенные пустые символы
            usernameTextBox.Text = usernameTextBox.Text.Trim();
            passwordTextBox.Text = passwordTextBox.Text.Trim();

            try
            {
                User user = new User(usernameTextBox.Text, passwordTextBox.Text);
                if (user.CorrectUser() && user.UserValid())
                {
                    this.Hide();
                    MainForm mf = new MainForm();
                    mf.FormClosed += (s, args) => this.Close();
                    mf.Show();
                }
                else
                {
                    MessageBox.Show("Неверное имя пользователя или пароль", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                passwordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}
