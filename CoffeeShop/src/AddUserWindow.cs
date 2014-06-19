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
    public partial class AddUserWindow : Form
    {
        public AddUserWindow()
        {
            InitializeComponent();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text)
                || string.IsNullOrWhiteSpace(nameTextBox.Text)
                || string.IsNullOrEmpty(surnameTextBox.Text)
                || string.IsNullOrWhiteSpace(surnameTextBox.Text)
                || string.IsNullOrEmpty(addressTextBox.Text)
                || string.IsNullOrWhiteSpace(addressTextBox.Text)
                || string.IsNullOrEmpty(passwordTextBox.Text)
                || string.IsNullOrWhiteSpace(passwordTextBox.Text)
                || string.IsNullOrEmpty(passwordTextBox2.Text)
                || string.IsNullOrWhiteSpace(passwordTextBox2.Text)
                )
                MessageBox.Show("Żadne z pól nie może być puste!");
            else if (passwordTextBox.Text != passwordTextBox2.Text)
                MessageBox.Show("Inne hasło w polu 'Powtórz hasło'");
            else
            {
                HashAlgorithm alg = SHA1.Create();
                byte[] passwordHash = alg.ComputeHash(Encoding.UTF8.GetBytes(passwordTextBox.Text));
                int userId = (int)PostgreSQL.executeScalarWithByteArray("INSERT INTO uzytkownik(imie, nazwisko, adres, haslo, typuzytkownika) VALUES('"
                    + nameTextBox.Text + "', '"
                    + surnameTextBox.Text + "', '"
                    + addressTextBox.Text + "', "
                    + ":passwordHash,"
                    + "'Uzytkownik')"
                    + " RETURNING kod_uz",
                    "passwordHash",
                    passwordHash
                    );
                MessageBox.Show("Założono nowe konto. Twój numer użytkowika to: " + userId);
                this.Close();
            }
        }
    }
}
