using System;
using System.Windows.Forms;

namespace EratosthenesProject
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            //стираем пустые введенные символы
            usernameTextBox.Text = usernameTextBox.Text.Trim();
            passwordTextBox.Text = passwordTextBox.Text.Trim();
            confirmTextBox.Text = confirmTextBox.Text.Trim();

            try
            {
                var user = new User(usernameTextBox.Text, passwordTextBox.Text, confirmTextBox.Text);
                if (user.CorrectUser() && !user.UsernameExist())
                {
                    user.CreateUser();

                    this.Hide();
                    MainForm mf = new MainForm();
                    mf.FormClosed += (s, args) => this.Close();
                    mf.Show();
                }
                else
                {
                    MessageBox.Show("Имя пользователя уже занято", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                confirmTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                confirmTextBox.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
