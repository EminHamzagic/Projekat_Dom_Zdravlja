using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projekat_Dom_Zdravlja
{
    public partial class frm_Pacijent : Form
    {
        SqlConnection connection;
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string id_grida;
        int selektovani_red_grida, id_pacijenta;
        public frm_Pacijent()
        {
            connection = new SqlConnection(dbcon.MyConection());
            InitializeComponent();
        }

        private void btn_Unos_Click(object sender, EventArgs e)
        {
            if (txt_Ime_Pacijenta.Text != "" && txt_Prezime_Pacijenta.Text != "" && txt_Godine_Pacijenta.Text != "" && txt_Adresa_Pacijenta.Text != "")
            {
                try
                {
                    connection.Open();
                    cmd = new SqlCommand("insert into pacijent (ime, prezime, godine, adresa)" +
                                         "values (@ime, @prezime, @godine, @adresa)", connection);
                    cmd.Parameters.AddWithValue("@ime", txt_Ime_Pacijenta.Text);
                    cmd.Parameters.AddWithValue("@prezime", txt_Prezime_Pacijenta.Text);
                    cmd.Parameters.AddWithValue("@godine", txt_Godine_Pacijenta.Text);
                    cmd.Parameters.AddWithValue("@adresa", txt_Adresa_Pacijenta.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Uspešno ste dodadali novog pacijenta", "Ovbevestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                }
                catch (Exception ex)
                {
                    connection.Close();
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Niste uneli potrebne podatke o pacijentu", "Ovbevestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Ucitaj_Pacijente();
            txt_Ime_Pacijenta.Clear();
            txt_Prezime_Pacijenta.Clear();
            txt_Godine_Pacijenta.Clear();
            txt_Adresa_Pacijenta.Clear();
        }
        void Ucitaj_Pacijente()
        {
            int i = 0;
            dataGrid_Pregled_Pacijenata.Rows.Clear();
            connection.Open();
            cmd = new SqlCommand("select p.id, p.ime, p.prezime, p.godine, p.adresa from pacijent as p", connection);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGrid_Pregled_Pacijenata.Rows.Add(i, dr["id"], dr["ime"], dr["prezime"], dr["godine"], dr["adresa"]);
            }
            dr.Close();
            connection.Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Da li ste sigurni da želite da izbrišete selektovani red?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connection.Open();
                    cmd = new SqlCommand("delete from pacijent where id=" + id_grida, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    Ucitaj_Pacijente();
                    MessageBox.Show("Red je uspesno izbrisan", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                dr.Close();
                connection.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            connection.Open();
            cmd = new SqlCommand("update pacijent set ime=@ime, prezime=@prezime, godine=@godine, adresa=@adresa" +
                                 " where id=" + id_grida, connection);
            cmd.Parameters.AddWithValue("@ime", txt_Ime_Pacijenta.Text);
            cmd.Parameters.AddWithValue("@prezime", txt_Prezime_Pacijenta.Text);
            cmd.Parameters.AddWithValue("@godine", txt_Godine_Pacijenta.Text);
            cmd.Parameters.AddWithValue("@adresa", txt_Adresa_Pacijenta.Text);

            cmd.ExecuteNonQuery();
            connection.Close();
            Ucitaj_Pacijente();

            dataGrid_Pregled_Pacijenata.Rows[selektovani_red_grida].Selected = true;
            dataGrid_Pregled_Pacijenata.FirstDisplayedScrollingRowIndex = selektovani_red_grida;

            MessageBox.Show("Uspešno ste izmenili selektovni red", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txt_Ime_Pacijenta.Clear();
            txt_Prezime_Pacijenta.Clear();
            txt_Godine_Pacijenta.Clear();
            txt_Adresa_Pacijenta.Clear();
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            Ucitaj_Pacijente();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            int i = 0;
            dataGrid_Pregled_Pacijenata.Rows.Clear();
            connection.Open();
            cmd = new SqlCommand("select p.id, p.ime, p.prezime, p.godine, p.adresa from pacijent as p where p.ime like '" + txt_Search.Text + "%'", connection);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGrid_Pregled_Pacijenata.Rows.Add(i, dr["id"], dr["ime"], dr["prezime"], dr["godine"], dr["adresa"]);
            }
            dr.Close();
            connection.Close();
        }

        private void dataGrid_Pregled_Pacijenata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string col_name = dataGrid_Pregled_Pacijenata.Columns[e.ColumnIndex].Name;
            id_grida = dataGrid_Pregled_Pacijenata.Rows[e.RowIndex].Cells[1].Value.ToString();
            selektovani_red_grida = dataGrid_Pregled_Pacijenata.CurrentRow.Index;

            if (col_name == "edit")
            {
                id_pacijenta = Int32.Parse(id_grida);
                connection.Open();
                cmd = new SqlCommand("select * from pacijent where id=" + id_pacijenta, connection);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txt_Ime_Pacijenta.Text = dr["ime"].ToString();
                    txt_Prezime_Pacijenta.Text = dr["prezime"].ToString();
                    txt_Godine_Pacijenta.Text = dr["godine"].ToString();
                    txt_Adresa_Pacijenta.Text = dr["adresa"].ToString();
                }
                dr.Close();
                connection.Close();
            }
            else if (col_name == "Delete")
            {
                try
                {
                    if (MessageBox.Show("Da li ste sigurni da želite da izbrišete selektovani red?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        connection.Open();
                        cmd = new SqlCommand("delete from pacijent where id=" + id_grida, connection);
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        Ucitaj_Pacijente();
                        MessageBox.Show("Red je uspesno izbrisan", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    dr.Close();
                    connection.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
