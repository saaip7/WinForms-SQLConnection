using Npgsql;
using NpgsqlTypes;
using System.Data;
using System.Windows.Forms;


namespace modul8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=ListofName";

        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        public void btnInsert_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    conn.Open();
                    sql = @"select * from st_insert(:_name, :_alamat, :_no_handphone)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_name", txtName.Text);
                    cmd.Parameters.AddWithValue("_alamat", txtAlamat.Text);
                    cmd.Parameters.AddWithValue("_no_handphone", txtNo_handphone.Text);
                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Data Users Berhasil Diinputkan", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        btnLoadData.PerformClick();
                        txtName.Text = txtNo_handphone.Text = txtAlamat.Text = null;
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "Insert FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void btnLoadData_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                dgvData.DataSource = null;
                sql = "select * from st_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvData.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvData.Rows[e.RowIndex];
                txtName.Text = r.Cells["_name"].Value.ToString();
                txtAlamat.Text = r.Cells["_alamat"].Value.ToString();
                txtNo_handphone.Text = r.Cells["_no_handphone"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan diupdate", "Good!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                conn.Open();
                sql = @"select * from st_update(:_id, :_name, :_alamat, :_no_handphone)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id", r.Cells["_id"].Value.ToString());
                cmd.Parameters.AddWithValue("_name", txtName.Text);
                cmd.Parameters.AddWithValue("_alamat", txtAlamat.Text);
                cmd.Parameters.AddWithValue("_no_handphone", txtNo_handphone.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Users Berhasil Diupdate", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btnLoadData.PerformClick();
                    txtName.Text = txtNo_handphone.Text = txtAlamat.Text = null;
                    r = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Update FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan diupdate", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Apakah benar anda ingin menghapus data " + r.Cells["_name"].Value.ToString() + " ?", "Hapus data terkonfirmasi",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)

                try
                {
                    conn.Open();
                    sql = @"select * from st_delete(:_id)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id", r.Cells["_id"].Value.ToString());
                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Data Users Berhasil Dihapus", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        btnLoadData.PerformClick();
                        txtName.Text = txtNo_handphone.Text = txtAlamat.Text = null;
                        r = null;
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "Delete FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void btn_qr_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2(this);
            f2.Show();
        }
    }
}