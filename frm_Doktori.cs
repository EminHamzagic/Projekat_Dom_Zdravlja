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
    public partial class frm_Doktori : Form
    {
        SqlConnection connection;
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string id_grida;
        int selektovani_red_grida, id_doktora;
        public frm_Doktori()
        {
            connection = new SqlConnection(dbcon.MyConection());
            InitializeComponent();
        }
        void Ucitaj_Doktore()
        {
            int i = 0;
            dataGrid_Pregled_Doktora.Rows.Clear();
            connection.Open();
            cmd = new SqlCommand("select p.id, p.ime, p.prezime, p.struka, p.opis from doktori as p", connection);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGrid_Pregled_Doktora.Rows.Add(i, dr["id"], dr["ime"], dr["prezime"], dr["struka"], dr["opis"]);
            }
            dr.Close();
            connection.Close();
        }
        private void btn_Unos_Click(object sender, EventArgs e)
        {
            if (txt_Ime_Doktora.Text != "" && txt_Prezime_Doktora.Text != "" && txt_Struka_Doktora.Text != "" && txt_Opis_Doktora.Text != "")
            {
                try
                {
                    connection.Open();
                    cmd = new SqlCommand("insert into doktori (ime, prezime, struka, opis)" +
                                         "values (@ime, @prezime, @struka, @opis)", connection);
                    cmd.Parameters.AddWithValue("@ime", txt_Ime_Doktora.Text);
                    cmd.Parameters.AddWithValue("@prezime", txt_Prezime_Doktora.Text);
                    cmd.Parameters.AddWithValue("@struka", txt_Struka_Doktora.Text);
                    cmd.Parameters.AddWithValue("@opis", txt_Opis_Doktora.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Uspešno ste dodadali novog doktora", "Ovbevestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Nisteu neli potrebne podatke o doktoru", "Ovbevestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Ucitaj_Doktore();
            txt_Ime_Doktora.Clear();
            txt_Prezime_Doktora.Clear();
            txt_Struka_Doktora.Clear();
            txt_Opis_Doktora.Clear();
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            Ucitaj_Doktore();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            connection.Open();
            cmd = new SqlCommand("update doktori set ime=@ime, prezime=@prezime, struka=@struka, opis=@opis" +
                                 " where id=" + id_grida, connection);
            cmd.Parameters.AddWithValue("@ime", txt_Ime_Doktora.Text);
            cmd.Parameters.AddWithValue("@prezime", txt_Prezime_Doktora.Text);
            cmd.Parameters.AddWithValue("@struka", txt_Struka_Doktora.Text);
            cmd.Parameters.AddWithValue("@opis", txt_Opis_Doktora.Text);

            cmd.ExecuteNonQuery();
            connection.Close();
            Ucitaj_Doktore();

            dataGrid_Pregled_Doktora.Rows[selektovani_red_grida].Selected = true;
            dataGrid_Pregled_Doktora.FirstDisplayedScrollingRowIndex = selektovani_red_grida;

            MessageBox.Show("Uspešno ste izmenili selektovni red", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txt_Ime_Doktora.Clear();
            txt_Prezime_Doktora.Clear();
            txt_Struka_Doktora.Clear();
            txt_Opis_Doktora.Clear();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Da li ste sigurni da želite da izbrišete selektovani red?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connection.Open();
                    cmd = new SqlCommand("delete from doktori where id=" + id_grida, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    Ucitaj_Doktore();
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

        private void search_btn_Click(object sender, EventArgs e)
        {
            int i = 0;
            dataGrid_Pregled_Doktora.Rows.Clear();
            connection.Open();
            cmd = new SqlCommand("select p.id, p.ime, p.prezime, p.struka, p.opis from doktori as p where p.ime like '" + txt_Search.Text + "%'", connection);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGrid_Pregled_Doktora.Rows.Add(i, dr["id"], dr["ime"], dr["prezime"], dr["struka"], dr["opis"]);
            }
            dr.Close();
            connection.Close();
        }

        private void dataGrid_Pregled_Doktora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string col_name = dataGrid_Pregled_Doktora.Columns[e.ColumnIndex].Name;
            id_grida = dataGrid_Pregled_Doktora.Rows[e.RowIndex].Cells[1].Value.ToString();
            selektovani_red_grida = dataGrid_Pregled_Doktora.CurrentRow.Index;

            if (col_name == "edit")
            {
                id_doktora = Int32.Parse(id_grida);
                connection.Open();
                cmd = new SqlCommand("select * from doktori where id=" + id_doktora, connection);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txt_Ime_Doktora.Text = dr["ime"].ToString();
                    txt_Prezime_Doktora.Text = dr["prezime"].ToString();
                    txt_Struka_Doktora.Text = dr["struka"].ToString();
                    txt_Opis_Doktora.Text = dr["opis"].ToString();
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
                        cmd = new SqlCommand("delete from doktori where id=" + id_grida, connection);
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        Ucitaj_Doktore();
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
