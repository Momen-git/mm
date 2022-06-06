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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.empolyeeDataSet);

        }

        private void login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'empolyeeDataSet.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.empolyeeDataSet.employee);
            nameTextBox.Text = " ";
            passwordTextBox.Text = " ";
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            try
            {
                employee em = new employee(nameTextBox.Text, passwordTextBox.Text);
                string name = this.employeeTableAdapter.checks(em.getName(), em.getPassword());
                nameTextBox.Text = " ";
                passwordTextBox.Text = " ";
                if (name != null)
                {
                    // open a new window

                    Home home = new Home();
                    home.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Enter a valid input");
                }
            }
            catch
            {
                MessageBox.Show("Enter a valid input");
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    class employee
    {
        private string employeeName;
        private string password;
        //Make properteies
        public string Name
        {
            get { return employeeName; }
            set
            {
                employeeName = value;
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
            }
        }

        public employee()
        {
            employeeName = " ";
            password = " ";
        }
        public employee(string n, string p)
        {
            employeeName = n;
            password = p;
        }
        // return the name of the employee
        public string getName()
        {
            return employeeName;
        }
        // return the password of an employee
        public string getPassword()
        {

            return password;
        }
    }
}
