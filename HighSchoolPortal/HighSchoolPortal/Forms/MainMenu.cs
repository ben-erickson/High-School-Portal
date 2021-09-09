using HighSchoolPortal.Library.Classes;
using System;
using System.Windows.Forms;

namespace HighSchoolPortal.Forms
{
    public partial class MainForm : Form
    {
        internal User LoggedInUser { get; set; }
        internal bool LoggedIn = false;
        public MainForm()
        {
            this.InitializeComponent();

            this.Load += this.MainForm_Load;

            this.btnLogOut.Click += this.BtnLogOut_Click;
            this.btnOpenClass.Click += this.BtnOpenClass_Click;
            this.btnOpenSchedule.Click += this.BtnOpenSchedule_Click;
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            this.LoggedIn = false;
            this.LogIn();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.LogIn();
        }

        private void BtnOpenSchedule_Click(object sender, EventArgs e)
        {
            var scheduleForm = new ScheduleView(this.LoggedInUser);
            scheduleForm.ShowDialog();
        }

        private void BtnOpenClass_Click(object sender, EventArgs e)
        {
            var classForm = new ClassView(this.LoggedInUser);
            classForm.ShowDialog();
        }

        /// <summary>
        /// Open the LoginForm, and don't let the user access the MainForm until they have logged in
        /// </summary>
        private void LogIn()
        {
            // This works, but I could also just close the program when they close the login form w/o logging in
            do
            {
                var loginForm = new LoginForm();
                loginForm.ShowDialog();
            }
            while (!this.LoggedIn);
        }
    }
}
