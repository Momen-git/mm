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
    public partial class compenies : Form
    {
        public compenies()
        {
            InitializeComponent();
        }

        private void companiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.companiesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.companiesDataSet);

        }

        private void compenies_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companiesDataSet.companies' table. You can move, or remove it, as needed.
            this.companiesTableAdapter.Fill(this.companiesDataSet.companies);

        }
    }
}
