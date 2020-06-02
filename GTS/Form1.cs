using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GTS
{
    public partial class Form1 : Form
    {
        public string CmdText = "SELECT * FROM [Abonent]";
        public string ConnString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\\Users\\Пользователь\\Desktop\\бд\\ГТС.mdb";
        public Form1()
        {
            InitializeComponent();
            OleDbDataAdapter dA = new OleDbDataAdapter(CmdText, ConnString);
            DataSet ds = new DataSet();
            dA.Fill(ds, "[Abonent]");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
