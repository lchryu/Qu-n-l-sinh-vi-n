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
namespace LuongChungHoi
{
    public partial class FormCon : Form
    {
        string strCon = @"Data Source=LCH;Initial Catalog=Test;Integrated Security=True";
        SqlConnection sqlCon = null;
        public FormCon()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon == null) sqlCon = new SqlConnection(strCon);
                if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();

                string strSql = $"select * from QuanLySinhVien where MaSV like '%{msvTimKiem.Text.Trim()}%'";
                SqlDataAdapter adapter = new SqlDataAdapter(strSql, sqlCon);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvCon.DataSource = table;
                
            }
            catch (Exception)
            {
                MessageBox.Show("lỗi");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon == null) sqlCon = new SqlConnection(strCon);
                if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();

                string strSql = $"select * from QuanLySinhVien where NoiSinh = N'{NoiSinhTimKiem.Text.Trim()}'";
                SqlDataAdapter adapter = new SqlDataAdapter(strSql, sqlCon);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvCon.DataSource = table;

            }
            catch (Exception)
            {
                MessageBox.Show("lỗi");
                //throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon == null) sqlCon = new SqlConnection(strCon);
                if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();

                string strSql = $"select * from QuanLySinhVien where NgaySinh = '{NgaySinhTimKiem.Text.Trim()}'";
                SqlDataAdapter adapter = new SqlDataAdapter(strSql, sqlCon);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvCon.DataSource = table;

            }
            catch (Exception)
            {
                MessageBox.Show("lỗi");
                //throw;
            }
        }

        private void NgaySinhTimKiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
