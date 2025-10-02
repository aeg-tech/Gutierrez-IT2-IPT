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
    public partial class frmMasterData : Form
    {
        public frmMasterData()
        {
            InitializeComponent();
        }

        private void frmMasterData_Load(object sender, EventArgs e)
        {
            string select_tblrequestorlist = "select * from tblEmployeeData order by EmployeeNumber desc";
            CRUD.CRUD.RETRIEVEDTG(dtgMasterData, select_tblrequestorlist);

            // first CRUD -- Folder, second CRUD -- class (.cs), RETRIEVE DTG -- method na nasa loob ng CRUD.cs
            // nirerequire magkaroon ng data grid view
        }

        public static string TransactionNumber, EmployeeNumber, RequestorName, RequestorEmail, LocalNumber,
            Section;
        private void dtgMasterData_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           lblTransactionNo.Text = dtgMasterData.Rows[e.RowIndex].Cells["ID"].Value.ToString();
           TransactionNumber = lblTransactionNo.Text;
           EmployeeNumber = dtgMasterData.Rows[e.RowIndex].Cells["EmployeeNumber"].Value.ToString();
           RequestorName = dtgMasterData.Rows[e.RowIndex].Cells["RequestorName"].Value.ToString();
           RequestorEmail = dtgMasterData.Rows[e.RowIndex].Cells["RequestorEmail"].Value.ToString();
           LocalNumber = dtgMasterData.Rows[e.RowIndex].Cells["LocalNumber"].Value.ToString();
           Section = dtgMasterData.Rows[e.RowIndex].Cells["Section"].Value.ToString();

        }

        public static string TextBoxData;
        private void btnEditData_Click(object sender, EventArgs e)
        {
            frmAddEmployee openNewFrm = new frmAddEmployee();
            openNewFrm.ShowDialog();
          
        }

    }
}
