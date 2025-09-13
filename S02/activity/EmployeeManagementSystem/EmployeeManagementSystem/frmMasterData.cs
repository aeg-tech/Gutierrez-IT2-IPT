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
    }
}
