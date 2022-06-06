using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventProjectLastVersion
{
    public partial class addNew : Form
    {
        public addNew()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.empolyeeDataSet);

        }

        private void addNew_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'empolyeeDataSet.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.empolyeeDataSet.employee);

        }

        private void upBtn_Click(object sender, EventArgs e)
        {
            // update the password of this perticular employee
            try
            {
                this.employeeTableAdapter.UpdateQuery(nameTextBox.Text, passwordTextBox.Text, nameTextBox.Text);
                nameTextBox.Text = " ";
                passwordTextBox.Text = " ";
            }
            catch
            {
                MessageBox.Show("Enter a valid input");
            }
        }
    }
}
