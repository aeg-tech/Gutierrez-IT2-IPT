using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class frmAddEmployee : Form
    {
        public frmAddEmployee()
        {
            InitializeComponent();
        }

        private void btnInsertUpdate_Click(object sender, EventArgs e)
        {
            // check if may existing id number
            bool dtg_addrequestor = false;
            string EMS_data = string.Empty;
            EMS_data = "Select * from [tblEmployeeData] where [EmployeeNumber] = '" + txtEmpID.Text + "'";
            dtg_addrequestor = CRUD.CRUD.RETRIEVESINGLE(EMS_data);
            if (dtg_addrequestor == true )
            {
                MessageBox.Show("This account '" + txtRequestorName.Text + "' is already exist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtRequestorName.Text = "";
                txtEmailAddress.Text = "";
                txtLocalNumber.Text = "";

            }
            else
            {


                string add_requestor = "Insert into [tblEmployeeData] ([EmployeeNumber], [RequestorName]," +
                    " [RequestorEmail], [Section], [LocalNumber]) " +
                       "values ('" + txtEmpID.Text + "', '" + txtRequestorName.Text + "', '" 
                       + txtEmailAddress.Text + "', '" + cmbSection.Text + "', '" + txtLocalNumber.Text + "')";     

                CRUD.CRUD.CUD(add_requestor);
                MessageBox.Show("Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}
