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
    public partial class frm_Dijagnoze : Form
    {
        SqlConnection connection;
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string id_grida;
        int selektovani_red_grida, id_dijagnoze;
        public frm_Dijagnoze()
        {
            connection = new SqlConnection(dbcon.MyConection());
            InitializeComponent();
        }

        void Ucitaj_Dijagnoze()
        {
            int i = 0;
            dataGrid_Pregled_Dijagnoze.Rows.Clear();
            connection.Open();
            cmd = new SqlCommand("select p.id, p.naziv, p.opis from dijagnoze as p", connection);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGrid_Pregled_Dijagnoze.Rows.Add(i, dr["id"], dr["naziv"], dr["opis"]);
            }
            dr.Close();
            connection.Close();
        }

        private void btn_Unos_Click(object sender, EventArgs e)
        {
            if (txt_Naziv_Dijagnoze.Text != "" && txt_Opis_Dijagnoze.Text != "")
            {
                try
                {
                    connection.Open();
                    cmd = new SqlCommand("insert into dijagnoze (naziv, opis)" +
                                         "values (@naziv, @opis)", connection);
                    cmd.Parameters.AddWithValue("@naziv", txt_Naziv_Dijagnoze.Text);
                    cmd.Parameters.AddWithValue("@opis", txt_Opis_Dijagnoze.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Uspešno ste dodadali novu dijagnozu", "Ovbevestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Nisteu neli potrebne podatke o dijagnozi", "Ovbevestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Ucitaj_Dijagnoze();
            txt_Naziv_Dijagnoze.Clear();
            txt_Opis_Dijagnoze.Clear();
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            Ucitaj_Dijagnoze();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            connection.Open();
            cmd = new SqlCommand("update dijagnoze set naziv=@naziv, opis=@opis" +
                                 " where id=" + id_grida, connection);
            cmd.Parameters.AddWithValue("@naziv", txt_Naziv_Dijagnoze.Text);
            cmd.Parameters.AddWithValue("@opis", txt_Opis_Dijagnoze.Text);

            cmd.ExecuteNonQuery();
            connection.Close();
            Ucitaj_Dijagnoze();

            dataGrid_Pregled_Dijagnoze.Rows[selektovani_red_grida].Selected = true;
            dataGrid_Pregled_Dijagnoze.FirstDisplayedScrollingRowIndex = selektovani_red_grida;

            MessageBox.Show("Uspešno ste izmenili selektovni red", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txt_Naziv_Dijagnoze.Clear();
            txt_Opis_Dijagnoze.Clear();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Da li ste sigurni da želite da izbrišete selektovani red?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connection.Open();
                    cmd = new SqlCommand("delete from dijagnoze where id=" + id_grida, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    Ucitaj_Dijagnoze();
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
            dataGrid_Pregled_Dijagnoze.Rows.Clear();
            connection.Open();
            cmd = new SqlCommand("select p.id, p.naziv, p.opis from dijagnoze as p where p.naziv like '" + txt_Search.Text + "%'", connection);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGrid_Pregled_Dijagnoze.Rows.Add(i, dr["id"], dr["naziv"], dr["opis"]);
            }
            dr.Close();
            connection.Close();
        }

        private void dataGrid_Pregled_Dijagnoze_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string col_name = dataGrid_Pregled_Dijagnoze.Columns[e.ColumnIndex].Name;
            id_grida = dataGrid_Pregled_Dijagnoze.Rows[e.RowIndex].Cells[1].Value.ToString();
            selektovani_red_grida = dataGrid_Pregled_Dijagnoze.CurrentRow.Index;

            if (col_name == "edit")
            {
                id_dijagnoze = Int32.Parse(id_grida);
                connection.Open();
                cmd = new SqlCommand("select * from dijagnoze where id=" + id_dijagnoze, connection);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txt_Naziv_Dijagnoze.Text = dr["naziv"].ToString();
                    txt_Opis_Dijagnoze.Text = dr["opis"].ToString();
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
                        cmd = new SqlCommand("delete from dijagnoze where id=" + id_grida, connection);
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        Ucitaj_Dijagnoze();
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
