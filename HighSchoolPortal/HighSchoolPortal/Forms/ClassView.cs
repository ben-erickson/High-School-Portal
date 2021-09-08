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
    public partial class ClassView : Form
    {
        public ClassView()
        {
            InitializeComponent();

            this.btnClose.Click += this.BtnClose_Click;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
