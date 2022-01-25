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
    public partial class frm_Lecenja : Form
    {
        SqlConnection connection;
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string id_grida;
        int selektovani_red_grida, id_lecenja;
        public frm_Lecenja()
        {
            connection = new SqlConnection(dbcon.MyConection());
            InitializeComponent();
        }

        void Ucitaj_Lecenja()
        {
            int i = 0;
            dataGrid_Pregled_Lecenja.Rows.Clear();
            connection.Open();
            cmd = new SqlCommand("select p.id, p.naziv, p.cena, p.opis from lecenja as p", connection);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGrid_Pregled_Lecenja.Rows.Add(i, dr["id"], dr["naziv"], dr["cena"], dr["opis"]);
            }
            dr.Close();
            connection.Close();
        }

        private void btn_Unos_Click(object sender, EventArgs e)
        {
            if (txt_Naziv_Lecenja.Text != "" && txt_Cena_Lecenja.Text != "" && txt_Opis_Lecenja.Text != "")
            {
                try
                {
                    connection.Open();
                    cmd = new SqlCommand("insert into lecenja (naziv, cena, opis)" +
                                         "values (@naziv, @cena, @opis)", connection);
                    cmd.Parameters.AddWithValue("@naziv", txt_Naziv_Lecenja.Text);
                    cmd.Parameters.AddWithValue("@cena", txt_Cena_Lecenja.Text);
                    cmd.Parameters.AddWithValue("@opis", txt_Opis_Lecenja.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Uspešno ste dodadali novo lecenje", "Ovbevestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Nisteu neli potrebne podatke o lecenju", "Ovbevestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Ucitaj_Lecenja();
            txt_Naziv_Lecenja.Clear();
            txt_Cena_Lecenja.Clear();
            txt_Opis_Lecenja.Clear();
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            Ucitaj_Lecenja();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            connection.Open();
            cmd = new SqlCommand("update lecenja set naziv=@naziv, cena=@cena, opis=@opis" +
                                 " where id=" + id_grida, connection);
            cmd.Parameters.AddWithValue("@naziv", txt_Naziv_Lecenja.Text);
            cmd.Parameters.AddWithValue("@cena", txt_Cena_Lecenja.Text);
            cmd.Parameters.AddWithValue("@opis", txt_Opis_Lecenja.Text);

            cmd.ExecuteNonQuery();
            connection.Close();
            Ucitaj_Lecenja(); 

            dataGrid_Pregled_Lecenja.Rows[selektovani_red_grida].Selected = true;
            dataGrid_Pregled_Lecenja.FirstDisplayedScrollingRowIndex = selektovani_red_grida;

            MessageBox.Show("Uspešno ste izmenili selektovni red", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txt_Naziv_Lecenja.Clear();
            txt_Cena_Lecenja.Clear();
            txt_Opis_Lecenja.Clear();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Da li ste sigurni da želite da izbrišete selektovani red?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connection.Open();
                    cmd = new SqlCommand("delete from lecenja where id=" + id_grida, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    Ucitaj_Lecenja();
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
            dataGrid_Pregled_Lecenja.Rows.Clear();
            connection.Open();
            cmd = new SqlCommand("select p.id, p.naziv, p.cena, p.opis from lecenja as p where p.naziv like '" + txt_Search.Text + "%'", connection);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGrid_Pregled_Lecenja.Rows.Add(i, dr["id"], dr["naziv"], dr["cena"], dr["opis"]);
            }
            dr.Close();
            connection.Close();
        }

        private void dataGrid_Pregled_Lecenja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string col_name = dataGrid_Pregled_Lecenja.Columns[e.ColumnIndex].Name;
            id_grida = dataGrid_Pregled_Lecenja.Rows[e.RowIndex].Cells[1].Value.ToString();
            selektovani_red_grida = dataGrid_Pregled_Lecenja.CurrentRow.Index;

            if (col_name == "edit")
            {
                id_lecenja = Int32.Parse(id_grida);
                connection.Open();
                cmd = new SqlCommand("select * from lecenja where id=" + id_lecenja, connection);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txt_Naziv_Lecenja.Text = dr["naziv"].ToString();
                    txt_Cena_Lecenja.Text = dr["cena"].ToString();
                    txt_Opis_Lecenja.Text = dr["opis"].ToString();
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
                        cmd = new SqlCommand("delete from lecenja where id=" + id_grida, connection);
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        Ucitaj_Lecenja();
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
