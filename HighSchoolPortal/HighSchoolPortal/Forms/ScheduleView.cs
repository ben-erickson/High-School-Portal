using HighSchoolPortal.Library.Classes;
using System;
using System.Windows.Forms;

namespace HighSchoolPortal.Forms
{
    public partial class ScheduleView : Form
    {
        private User _loggedInUser;
        public ScheduleView(User user)
        {
            this.InitializeComponent();

            this._loggedInUser = user;

            this.Load += this.ScheduleView_Load;
            this.btnClose.Click += this.BtnClose_Click;
        }

        private void ScheduleView_Load(object sender, EventArgs e)
        {
            string correctClasses = "";
            foreach (SchoolClass schoolClass in SchoolClassList.GetInstance().ClassList)
            {
                if (this._loggedInUser.PowerLevel == Library.PowerLevel.Student)
                {
                    if (schoolClass.Grade == this._loggedInUser.Grade)
                    {
                        correctClasses += $"{schoolClass.ClassName}{Environment.NewLine}";
                    }
                }
                else
                {
                    if (schoolClass.TeacherId == this._loggedInUser.TeacherId)
                    {
                        correctClasses += $"{schoolClass.ClassName}{Environment.NewLine}";
                    }
                }
            }
            MessageBox.Show(correctClasses);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
