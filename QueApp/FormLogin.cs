using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueApp
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void TextBoxUsername_Click(object sender, EventArgs e)
        {
            textBoxPassword.Clear();
            pictureBoxUsername.BackgroundImage = Properties.Resources.no_user;
            textBoxEmail.ForeColor = Color.FromArgb(97, 166, 186);
            panelUsername.BackColor = Color.FromArgb(97, 166, 186);
        }
        private void TextBoxPassword_Click(object sender, EventArgs e)
        {
            textBoxPassword.Clear();
            textBoxPassword.PasswordChar = '*';
            pictureBoxPassword.BackgroundImage = Properties.Resources.no_user;
            panelPassword.ForeColor = Color.FromArgb(97, 166, 186);
            panelPassword.BackColor = Color.FromArgb(97, 166, 186);
        }
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text != string.Empty && textBoxPassword.Text != string.Empty)
            {
            
                //var encryptedPassword = Helpers.PasswordHashing.GenerateSHA256String(textBoxPassword.Text.ToString());

                var loginok = Helpers.UserHelper.UserLogin(textBoxEmail.Text.ToString(), textBoxPassword.Text.ToString());

                if (loginok.StartsWith("Login Succeeded!"))
                {
                    MessageBox.Show("Login Succeeded!");
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }

            }
            else if (textBoxPassword.Text == string.Empty || textBoxPassword.Text == string.Empty)
            {
                MessageBox.Show("Email or Password are empty. Please fill in!");
            }
        }
    }
}
