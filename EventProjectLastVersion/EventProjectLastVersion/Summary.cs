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
    public partial class Summary : Form
    {
        public Summary()
        {
            InitializeComponent();
        }

        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.patientDataSet);

        }

        private void Summary_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'patientDataSet.patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.patientDataSet.patient);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                this.patientTableAdapter.fillByStatus(this.patientDataSet.patient
                    , findStatus.Text);
                findStatus.Text = " ";
                // search by the status
            }
            catch
            {
                MessageBox.Show("Enter a valid input");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                // search in between range of id
                this.patientTableAdapter.fillRange(this.patientDataSet.patient, int.Parse(minText.Text),
                                  int.Parse(maxText.Text));
                maxText.Text = " ";
                minText.Text = " ";
            }
            catch
            {
                MessageBox.Show("Enter a valid input");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                // search in perticuler data in database
                this.patientTableAdapter.FillByDate(this.patientDataSet.patient,
                     Date.Text);
                Date.Text = " ";
            }
            catch
            {
                MessageBox.Show("Enter a valid input");
            }
        }
    }
}
