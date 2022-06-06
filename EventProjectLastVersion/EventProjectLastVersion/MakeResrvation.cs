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
    public partial class MakeResrvation : Form
    {
        public MakeResrvation()
        {
            InitializeComponent();
        }

        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.patientDataSet);

        }

        private void MakeResrvation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companiesDataSet.companies' table. You can move, or remove it, as needed.
            this.companiesTableAdapter.Fill(this.companiesDataSet.companies);
            // TODO: This line of code loads data into the 'patientDataSet.patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.patientDataSet.patient);

        }

        private void fill_Click(object sender, EventArgs e)
        {
            try
            {
                // Calculate the bill
                float bill = 50 - (float.Parse(reservationTypes.SelectedValue.ToString()) * 50);

                typeTextBox.Text = this.companiesTableAdapter.ScalarQuery(double.Parse(reservationTypes.SelectedValue.ToString()));
                billTextBox.Text = bill.ToString();
                // calcutate the time and date in this pertucilar moment
                DateTime dt = DateTime.Now;
                string timestr = dt.ToString().Substring(9, 8);
                timeTextBox.Text = timestr.ToString();
                dateDateTimePicker.Text = dt.ToString();
                // Create an instance of the class patient
                patient pt = new patient(nameTextBox.Text, int.Parse(phoneTextBox.Text)
                      , int.Parse(ageTextBox.Text), typeTextBox.Text, float.Parse(billTextBox.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void reservationTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(reservationTypes.SelectedIndex == -1)
                {
                    return;
                }
            }
            catch
            {
                MessageBox.Show("You have to choose a value");
            }
        }
    }
    class patient
    {
        private string name;
        private int phone;
        private int age;
        private float bill;
        private string type;
        public patient()
        {
            name = " ";
            phone = 0;
            age = 0;
            bill = 0;
            type = " ";
        }
        public patient(string n, int p, int a, string t, float b)
        {
            name = n;
            phone = p;
            age = a;
            bill = b;
            type = t;
        }
        // return Name
        public string getName()
        {
            return name;
        }
        // return tpye
        public string getType()
        {
            return type;
        }
        // return bill
        public float getBill()
        {
            return bill;
        }
        // return age
        public int getAge()
        {
            return age;
        }
        // return phone
        public int getPhone()
        {
            return phone;
        }
    }
}
