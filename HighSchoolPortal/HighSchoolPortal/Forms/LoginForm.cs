using HighSchoolPortal.Library.Classes;
using System;
using System.Linq;
using System.Windows.Forms;

namespace HighSchoolPortal.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            this.InitializeComponent();

            this.btnLogIn.Click += this.BtnLogIn_Click;
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            string username = this.tBoxUsername.Text;
            string password = this.tBoxPassword.Text;

            foreach (User user in UserBody.GetInstance().FacultyList)
            {
                if (user.Username == username && user.Password == password)
                {
                    this.LogIn(user);
                    return;
                }
            }

            foreach (User user in UserBody.GetInstance().StudentList)
            {
                if (user.Username == username && user.Password == password)
                {
                    this.LogIn(user);
                    return;
                }
            }

            MessageBox.Show("Login information incorrect. Please try again.");
        }

        private void LogIn(User user)
        {
            var mainFrom = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            mainFrom.LoggedInUser = user;
            mainFrom.LoggedIn = true;
            this.Close();
        }
    }
}