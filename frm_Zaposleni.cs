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
    public partial class frm_Zaposleni : Form
    {
        SqlConnection connection;
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string id_grida;
        int selektovani_red_grida, id_zaposlenog, posao_id, odeljenje_id;
        public frm_Zaposleni()
        {
            InitializeComponent();
            connection = new SqlConnection(dbcon.MyConection());
            Ucitaj_Poslove();
            Ucitaj_Odeljenja();
        }
        void Ucitaj_Zaposlene()
        {
            int i = 0;
            dataGrid_Pregled_Zaposlenih.Rows.Clear();
            connection.Open();
            cmd = new SqlCommand("select z.id, z.ime, z.prezime, z.poslovi_id, z.odeljenja_id from zaposleni as z", connection);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGrid_Pregled_Zaposlenih.Rows.Add(i, dr["id"], dr["ime"], dr["prezime"], dr["poslovi_id"], dr["odeljenja_id"]);
            }
            dr.Close();
            connection.Close();
        }
        void Ucitaj_Poslove()
        {
            connection.Open();
            cmd = new SqlCommand("select * from poslovi", connection);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            DataRow Select_Posao = dt.NewRow();
            Select_Posao[1] = "- Select -";
            dt.Rows.InsertAt(Select_Posao, 0);

            cmb_Poslovi.DataSource = dt;

            cmb_Poslovi.DisplayMember = "naziv";
            cmb_Poslovi.ValueMember = "id";

            cmb_Poslovi.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmb_Poslovi.AutoCompleteSource = AutoCompleteSource.ListItems;

            dr.Close();
            connection.Close();
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            Ucitaj_Zaposlene();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            connection.Open();
            cmd = new SqlCommand("update zaposleni set ime=@ime, prezime=@prezime, poslovi_id=@poslovi_id, odeljenja_id=@odeljenja_id" +
                                 " where id=" + id_grida, connection);
            cmd.Parameters.AddWithValue("@ime", txt_Ime_Zaposleni.Text);
            cmd.Parameters.AddWithValue("@prezime", txt_Prezime_Zaposleni.Text);
            cmd.Parameters.AddWithValue("@poslovi_id", cmb_Poslovi.SelectedValue);
            cmd.Parameters.AddWithValue("@odeljenja_id", cmb_Odeljenje.SelectedValue);

            cmd.ExecuteNonQuery();
            connection.Close();
            Ucitaj_Zaposlene();

            dataGrid_Pregled_Zaposlenih.Rows[selektovani_red_grida].Selected = true;
            dataGrid_Pregled_Zaposlenih.FirstDisplayedScrollingRowIndex = selektovani_red_grida;

            MessageBox.Show("Uspešno ste izmenili selektovni red", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txt_Ime_Zaposleni.Clear();
            txt_Prezime_Zaposleni.Clear();
            cmb_Poslovi.SelectedValue = 0;
            cmb_Odeljenje.SelectedValue = 0;
        }

        private void btn_Unos_Click(object sender, EventArgs e)
        {
            if (txt_Ime_Zaposleni.Text != "" && txt_Prezime_Zaposleni.Text != "")
            {
                try
                {
                    connection.Open();
                    cmd = new SqlCommand("insert into zaposleni (ime, prezime, poslovi_id, odeljenja_id)" +
                                         "values (@ime, @prezime, @poslovi_id, @odeljenja_id)", connection);
                    cmd.Parameters.AddWithValue("@ime", txt_Ime_Zaposleni.Text);
                    cmd.Parameters.AddWithValue("@prezime", txt_Prezime_Zaposleni.Text);
                    cmd.Parameters.AddWithValue("@poslovi_id", cmb_Poslovi.SelectedValue);
                    cmd.Parameters.AddWithValue("@odeljenja_id", cmb_Odeljenje.SelectedValue);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Uspešno ste dodadali novog zaposlenog", "Ovbevestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Niste uneli potrebne podatke o zaposlenom", "Ovbevestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Ucitaj_Zaposlene();
        }

        private void dataGrid_Pregled_Zaposlenih_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string col_name = dataGrid_Pregled_Zaposlenih.Columns[e.ColumnIndex].Name;
            id_grida = dataGrid_Pregled_Zaposlenih.Rows[e.RowIndex].Cells[1].Value.ToString();
            selektovani_red_grida = dataGrid_Pregled_Zaposlenih.CurrentRow.Index;

            if (col_name == "edit")
            {
                id_zaposlenog = Int32.Parse(id_grida);
                connection.Open();
                cmd = new SqlCommand("select * from zaposleni where id=" + id_zaposlenog, connection);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txt_Ime_Zaposleni.Text = dr["ime"].ToString();
                    txt_Prezime_Zaposleni.Text = dr["prezime"].ToString();
                    posao_id = Int32.Parse(dr["poslovi_id"].ToString());
                    odeljenje_id = Int32.Parse(dr["odeljenja_id"].ToString());
                }
                dr.Close();
                connection.Close();
                cmb_Poslovi.SelectedValue = posao_id;
                cmb_Odeljenje.SelectedValue = odeljenje_id;
            }
            else if (col_name == "Delete")
            {
                try
                {
                    if (MessageBox.Show("Da li ste sigurni da želite da izbrišete selektovani red?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        connection.Open();
                        cmd = new SqlCommand("delete from zaposleni where id=" + id_grida, connection);
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        Ucitaj_Zaposlene();
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
        void Ucitaj_Odeljenja()
        {
            connection.Open();
            cmd = new SqlCommand("select * from odeljenja", connection);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            DataRow Select_Odeljenje = dt.NewRow();
            Select_Odeljenje[1] = "- Select -";
            dt.Rows.InsertAt(Select_Odeljenje, 0);

            cmb_Odeljenje.DataSource = dt;

            cmb_Odeljenje.DisplayMember = "naziv";
            cmb_Odeljenje.ValueMember = "id";

            cmb_Odeljenje.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmb_Odeljenje.AutoCompleteSource = AutoCompleteSource.ListItems;

            dr.Close();
            connection.Close();
        }
    }
}
