using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Npgsql;

namespace CoffeeShop
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(loginTextBox.Text)
                || string.IsNullOrWhiteSpace(loginTextBox.Text)
                || string.IsNullOrEmpty(passwordTextBox.Text)
                || string.IsNullOrWhiteSpace(passwordTextBox.Text))
                MessageBox.Show("Login i hasło nie mogą być puste!");
            else
            {
                try
                {
                    int.Parse(loginTextBox.Text);

                    NpgsqlDataReader reader = PostgreSQL.executeCommand("SELECT haslo, typuzytkownika FROM uzytkownik WHERE kod_uz=" + loginTextBox.Text);
                    reader.Read();
                    byte[] password = (byte[])reader[0];
                    string userType = reader[1].ToString();
                    HashAlgorithm alg = SHA1.Create();
                    byte[] passwordHash = alg.ComputeHash(Encoding.UTF8.GetBytes(passwordTextBox.Text));
                    reader.Close();

                    if (!passwordIsGood(password, passwordHash))
                        MessageBox.Show("Błąd logowania, zły login lub hasło");
                    else
                    {
                        this.Hide();
                        if (userType == "Admin")
                        {
                            AdminWindow window = new AdminWindow();
                            window.ShowDialog();
                        }
                        else if (userType == "Uzytkownik")
                        {
                            UserWindow window = new UserWindow(int.Parse(loginTextBox.Text));
                            window.ShowDialog();
                        }
                        else
                        {
                            EmployeeWindow window = new EmployeeWindow();
                            window.ShowDialog();
                        }
                        this.Close();
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Zabronione znaki w polu ID (" + ex.Message + ")"); 
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show("Nie ma w bazie użytkownika o podanym numerze ID (" + ex.Message + ")");
                }
            }
        }

        private bool passwordIsGood(byte[] dbPass, byte[] pass)
        {
            if (dbPass.Length != pass.Length)
                return false;
            else
                for (int i = 0; i < dbPass.Length; ++i)
                    if (dbPass[i] != pass[i])
                        return false;
            return true;
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            AddUserWindow window = new AddUserWindow();
            window.ShowDialog();
        }
    }
}
