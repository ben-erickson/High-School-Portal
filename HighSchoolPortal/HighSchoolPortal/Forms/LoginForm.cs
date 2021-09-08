using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HighSchoolPortal.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.btnLogIn.Click += this.BtnLogIn_Click;
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            // Eventually, this will check whether they input a valid username/password
            var mainFrom = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            mainFrom.LoggedIn = true;
            this.Close();
        }
    }
}
