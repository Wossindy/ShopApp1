using ShopApp1.Forms;
using ShopApp1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string username =txtLogin.Text;
            string password = txtPassword.Text;
            try
            {
                List<User> users = Shop_SSAEntities.GetContext().User.ToList();
                User u = users.FirstOrDefault(p => p.UserName == username && p.Password ==password);
                if (u != null)
                {
                    MainWindow mainwindow = new MainWindow(u.Role, u.UserName);
                    mainwindow.Owner = this;
                    this.Hide();
                    txtPassword.Clear();
                    mainwindow.Show();
                }
                else
                {
                    MessageBox.Show("Не верный логин или пароль");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult x = MessageBox.Show("Вы действительно хотите закрыть приложение ?", "Выйти", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (x == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pB2.Visible= false;
            txtPassword.PasswordChar = '*';
            
                pB1.Visible = true;
            }

        private void pB1_Click(object sender, EventArgs e)
        {
            pB1.Visible = false;
            txtPassword.PasswordChar = '\0';
            pB2.Visible = true;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
