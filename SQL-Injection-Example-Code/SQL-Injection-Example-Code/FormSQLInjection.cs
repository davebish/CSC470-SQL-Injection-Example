using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Injection_Example_Code
{
    public partial class FormSQLInjection : Form
    {
        public FormSQLInjection()
        {
            InitializeComponent();
        }

        private void buttonRunQuery_Click(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            string results = db.GetStudentInfo(textBoxUnsanitized.Text);
            textBoxResults.Text = results;
        }

        private void FormSQLInjection_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
