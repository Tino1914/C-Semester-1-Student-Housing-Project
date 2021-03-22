using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_UI
{
    public partial class Rules : Form
    {
        ConnectSQL cs;

        public Rules(ConnectSQL conssql)
        {
            InitializeComponent();
            cs = conssql;

            listView.Items.Clear();

            SqlConnection cnn = new SqlConnection(cs.ConStr);
            cnn.Open();

            SqlDataReader dataReader;
            SqlCommand cmd = cnn.CreateCommand();

            string sql = "SElECT RuleID, RuleDescription FROM RuleTable";

            cmd = new SqlCommand(sql, cnn);
            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                ListViewItem line = new ListViewItem(dataReader.GetValue(0).ToString());

                line.SubItems.Add(dataReader.GetValue(1).ToString());
                listView.Items.Add(line);
            }
            cnn.Close();
            dataReader.Close();
            cmd.Dispose();
        }
    }
}
