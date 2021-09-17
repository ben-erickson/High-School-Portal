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

            // Initialize instance fields
            this._loggedInUser = user;
            this._comboClasses = new List<SchoolClass>();

            // Populate the combo box with the relevant classes for logged in user
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

            // Populate the class information for default selection (make this a regular method in the future?)
            SchoolClass selectedClass = (SchoolClass)this.comboClasses.Items[this.comboClasses.SelectedIndex];

            this.lblClassName.Text = selectedClass.ClassName;
            this.lblTeacherName.Text = selectedClass.TeacherId.ToString();

            // Event subscriptions
            this.btnClose.Click += this.BtnClose_Click;
            this.btnConfirmCombo.Click += this.BtnConfirmCombo_Click;
        }

        private void BtnConfirmCombo_Click(object sender, EventArgs e)
        {
            SchoolClass selectedClass = (SchoolClass)this.comboClasses.Items[this.comboClasses.SelectedIndex];

            this.lblClassName.Text = selectedClass.ClassName;
            this.lblTeacherName.Text = selectedClass.TeacherId.ToString();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
