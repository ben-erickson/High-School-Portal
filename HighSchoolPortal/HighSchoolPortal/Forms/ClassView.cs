using HighSchoolPortal.Library.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HighSchoolPortal.Forms
{
    public partial class ClassView : Form
    {
        private List<SchoolClass> _comboClasses;
        private User _loggedInUser;
        public ClassView(User user)
        {
            this.InitializeComponent();

            this._loggedInUser = user;
            this._comboClasses = new List<SchoolClass>();

            foreach (SchoolClass schoolClass in SchoolClassList.GetInstance().ClassList)
            {
                if (this._loggedInUser.PowerLevel == Library.PowerLevel.Student)
                {
                    if (schoolClass.Grade == this._loggedInUser.Grade)
                    {
                        this._comboClasses.Add(schoolClass);
                    }
                }
                else if (this._loggedInUser.PowerLevel == Library.PowerLevel.Teacher)
                {
                    if (schoolClass.TeacherId == this._loggedInUser.TeacherId)
                    {
                        this._comboClasses.Add(schoolClass);
                    }
                }
            }

            this.comboClasses.DataSource = this._comboClasses;

            this.btnClose.Click += this.BtnClose_Click;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
