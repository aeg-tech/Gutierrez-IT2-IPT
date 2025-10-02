using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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

        private void frmAddEmployee_Load(object sender, EventArgs e)
        {
            txtEmpID.Text = frmMasterData.TransactionNumber;
            txtRequestorName.Text = frmMasterData.RequestorName;
            txtEmailAddress.Text = frmMasterData.RequestorEmail;
            txtLocalNumber.Text = frmMasterData.LocalNumber;
            cmbSection.Text = frmMasterData.Section;
           

        }

        private void btnInsertUpdate_Click(object sender, EventArgs e)
        {


            if (txtRequestorName.Text == "" || txtEmailAddress.Text == "" || txtLocalNumber.Text == ""
                || cmbSection.Text == "")
            {
                MessageBox.Show("Incomplete / Missing Data", "Error: ");
                return;
            }

            // check if may existing id number
            bool dtg_addrequestor = false;
            string EMS_data = string.Empty;
            EMS_data = "Select * from [tblEmployeeData] where [EmployeeNumber] = '" + txtEmpID.Text + "'";
            dtg_addrequestor = CRUD.CRUD.RETRIEVESINGLE(EMS_data);

            if (dtg_addrequestor == true)
            {
                MessageBox.Show("This account '" + txtRequestorName.Text + "' is already exist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtRequestorName.Text = "";
                txtEmailAddress.Text = "";
                txtLocalNumber.Text = "";

                 string update_requestor = $"UPDATE [tblEmployeeData] SET " +
                $"[RequestorName] = '{txtRequestorName.Text}', " +
                    $"[RequestorEmail] = '{txtEmailAddress.Text}', " +
                    $"[Section] = '{cmbSection.Text}', " +
                    $"[LocalNumber] = '{txtLocalNumber.Text}' " +
                    $"WHERE [EmployeeNumber] = '{txtEmpID.Text}'";

                CRUD.CRUD.CUD(update_requestor);
                MessageBox.Show("Updated Successfully", "Message: ", MessageBoxButtons.OK, MessageBoxIcon.Information);



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















/*
 * private void btnInsertUpdate_Click(object sender, EventArgs e)
        {
        

            if (txtRequestorName.Text == "" || txtEmailAddress.Text == "" || txtLocalNumber.Text == ""
                || cmbSection.Text == "")
            {
                MessageBox.Show("Incomplete / Missing Data", "Error: ");
                return;
            }

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
*/

/* 
  private void btnInsertUpdate_Click(object sender, EventArgs e)
        {
            if (txtRequestorName.Text == "" || txtEmailAddress.Text == "" || txtLocalNumber.Text == "" || cmbSection.Text == "")
            {
                MessageBox.Show("Incomplete / Missing Data", "Error: ");
                return;
            }

            string EMS_data = $"SELECT * FROM [tblEmployeeData] WHERE [EmployeeNumber] = '{txtEmpID.Text}'";
            bool recordExists = CRUD.CRUD.RETRIEVESINGLE(EMS_data);

            if (recordExists)
            {
                
                string update_requestor = $"UPDATE [tblEmployeeData] SET " +
                $"[RequestorName] = '{txtRequestorName.Text}', " +
                    $"[RequestorEmail] = '{txtEmailAddress.Text}', " +
                    $"[Section] = '{cmbSection.Text}', " +
                    $"[LocalNumber] = '{txtLocalNumber.Text}' " +
                    $"WHERE [EmployeeNumber] = '{txtEmpID.Text}'";

                CRUD.CRUD.CUD(update_requestor);
                MessageBox.Show("Updated Successfully", "Message: ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
              
                string add_requestor = $"INSERT INTO [tblEmployeeData] ([EmployeeNumber], [RequestorName], [RequestorEmail], [Section], [LocalNumber]) " +
                    $"VALUES ('{txtEmpID.Text}', '{txtRequestorName.Text}', '{txtEmailAddress.Text}', '{cmbSection.Text}', '{txtLocalNumber.Text}')";

                CRUD.CRUD.CUD(add_requestor);
                MessageBox.Show("Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }*/