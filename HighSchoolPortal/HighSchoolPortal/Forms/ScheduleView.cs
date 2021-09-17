using HighSchoolPortal.Library;
using HighSchoolPortal.Library.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HighSchoolPortal.Forms
{
    public partial class ScheduleView : Form
    {
        private User _loggedInUser;
        private int _height;
        public ScheduleView(User user)
        {
            this.InitializeComponent();

            this._loggedInUser = user;

            this._height = Enum.GetValues(typeof(PeriodTimes)).Length;

            this.Load += this.ScheduleView_Load;
            this.btnClose.Click += this.BtnClose_Click;
        }

        private void ScheduleView_Load(object sender, EventArgs e)
        {
            List<SchoolClass> correctClasses = new List<SchoolClass>();
            foreach (SchoolClass schoolClass in SchoolClassList.GetInstance().ClassList)
            {
                if (this._loggedInUser.PowerLevel == Library.PowerLevel.Student)
                {
                    if (schoolClass.Grade == this._loggedInUser.Grade)
                    {
                        correctClasses.Add(schoolClass);
                    }
                }
                else
                {
                    if (schoolClass.TeacherId == this._loggedInUser.TeacherId)
                    {
                        correctClasses.Add(schoolClass);
                    }
                }
            }

            this.dGridSchedule.Columns.Add(new DataGridViewColumn() { HeaderText = "Class Period", CellTemplate = new DataGridViewTextBoxCell() });
            foreach (Weekdays day in Enum.GetValues(typeof(Weekdays)))
            {
                this.dGridSchedule.Columns.Add(new DataGridViewColumn() { HeaderText = day.ToString(), CellTemplate = new DataGridViewTextBoxCell() });
            }

            foreach (PeriodTimes period in Enum.GetValues(typeof(PeriodTimes)))
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Height = (int)Math.Ceiling((double)(this.dGridSchedule.Height / this._height) - (this.dGridSchedule.ColumnHeadersHeight / this._height));

                // Period value for "row header"
                DataGridViewTextBoxCell header = new DataGridViewTextBoxCell();
                header.Value = period.ToString();
                row.Cells.Add(header);

                foreach (Weekdays day in Enum.GetValues(typeof(PeriodTimes)))
                {
                    DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                    if (correctClasses.Where(x => x.ClassDay == day && x.ClassTime == period).FirstOrDefault() != null)
                    {
                        cell.Value = correctClasses.Where(x => x.ClassDay == day && x.ClassTime == period).FirstOrDefault().ClassName;
                    }
                    else
                    {
                        cell.Value = "Free Period";
                    }
                    row.Cells.Add(cell);
                }
                this.dGridSchedule.Rows.Add(row);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
