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
    public partial class frm_Pregledi : Form
    {
        SqlConnection connection;
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string id_grida;
        int selektovani_red_grida, id_dijagnoze;
        int pacijent_id, doktori_id, dijagnoze_id, lecenje_id;
        public frm_Pregledi()
        {
            connection = new SqlConnection(dbcon.MyConection());
            InitializeComponent();
            Ucitaj_Pacijente();
            Ucitaj_Doktore();
            Ucitaj_Dijagnoze();
            Ucitaj_Lecenja();
        }

        void Ucitaj_Preglede()
        {
            int i = 0;
            dataGrid_Pregled_Pregleda.Rows.Clear();
            connection.Open();
            cmd = new SqlCommand("select p.id, p.vreme_pregleda, p.datum_pregleda, p.pacijent_id, p.doktori_id, p.dijagnoze_id, p.lecenja_id from pregledi as p", connection);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGrid_Pregled_Pregleda.Rows.Add(i, dr["id"], dr["vreme_pregleda"], dr["datum_pregleda"], dr["pacijent_id"], dr["doktori_id"], dr["dijagnoze_id"], dr["lecenja_id"]);
            }
            dr.Close();
            connection.Close();
        }

        void Ucitaj_Pacijente()
        {
            connection.Open();
            cmd = new SqlCommand("select * from pacijent", connection);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            cmb_Pacijenti.DataSource = dt;

            cmb_Pacijenti.DisplayMember = "ime";
            cmb_Pacijenti.ValueMember = "id";

            cmb_Pacijenti.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmb_Pacijenti.AutoCompleteSource = AutoCompleteSource.ListItems;

            dr.Close();
            connection.Close();
        }

        void Ucitaj_Doktore()
        {
            connection.Open();
            cmd = new SqlCommand("select * from doktori", connection);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            cmb_Doktori.DataSource = dt;

            cmb_Doktori.DisplayMember = "ime";
            cmb_Doktori.ValueMember = "id";

            cmb_Doktori.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmb_Doktori.AutoCompleteSource = AutoCompleteSource.ListItems;

            dr.Close();
            connection.Close();
        }

        void Ucitaj_Dijagnoze()
        {
            connection.Open();
            cmd = new SqlCommand("select * from dijagnoze", connection);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            cmb_Dijagnoze.DataSource = dt;

            cmb_Dijagnoze.DisplayMember = "naziv";
            cmb_Dijagnoze.ValueMember = "id";

            cmb_Dijagnoze.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmb_Dijagnoze.AutoCompleteSource = AutoCompleteSource.ListItems;

            dr.Close();
            connection.Close();
        }

        void Ucitaj_Lecenja()
        {
            connection.Open();
            cmd = new SqlCommand("select * from lecenja", connection);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            cmb_Lecenja.DataSource = dt;

            cmb_Lecenja.DisplayMember = "naziv";
            cmb_Lecenja.ValueMember = "id";

            cmb_Lecenja.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmb_Lecenja.AutoCompleteSource = AutoCompleteSource.ListItems;

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
                    cmd = new SqlCommand("insert into pregledi (vreme_pregleda, datum_pregleda, pacijent_id, doktori_id, dijagnoze_id, lecenja_id)" +
                                         "values (@vreme_pregleda, @datum_pregleda, @pacijent_id, @doktori_id, @dijagnoze_id, @lecenja_id)", connection);
                    cmd.Parameters.AddWithValue("@vreme_pregleda", txt_Naziv_Dijagnoze.Text);
                    cmd.Parameters.AddWithValue("@datum_pregleda", txt_Opis_Dijagnoze.Text);
                    cmd.Parameters.AddWithValue("@pacijent_id", cmb_Pacijenti.SelectedValue);
                    cmd.Parameters.AddWithValue("@doktori_id", cmb_Doktori.SelectedValue);
                    cmd.Parameters.AddWithValue("@dijagnoze_id", cmb_Dijagnoze.SelectedValue);
                    cmd.Parameters.AddWithValue("@lecenja_id", cmb_Lecenja.SelectedValue);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Uspešno ste dodadali novi pregled", "Ovbevestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Niste uneli potrebne podatke o pregledu", "Ovbevestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Ucitaj_Preglede();
            txt_Opis_Dijagnoze.Clear();
            txt_Naziv_Dijagnoze.Clear();
            cmb_Lecenja.SelectedValue = 0;
            cmb_Doktori.SelectedValue = 0;
            cmb_Pacijenti.SelectedValue = 0;
            cmb_Dijagnoze.SelectedValue = 0;
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            Ucitaj_Preglede();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            connection.Open();
            cmd = new SqlCommand("update pregledi set vreme_pregleda=@vreme_pregleda, datum_pregleda=@datum_pregleda, pacijent_id=@pacijent_id, doktori_id=@doktori_id, dijagnoze_id=@dijagnoze_id, lecenja_id=@lecenja_id" +
                                 " where id=" + id_grida, connection);
            cmd.Parameters.AddWithValue("@vreme_pregleda", txt_Naziv_Dijagnoze.Text);
            cmd.Parameters.AddWithValue("@datum_pregleda", txt_Opis_Dijagnoze.Text);
            cmd.Parameters.AddWithValue("@pacijent_id", cmb_Pacijenti.SelectedValue);
            cmd.Parameters.AddWithValue("@doktori_id", cmb_Doktori.SelectedValue);
            cmd.Parameters.AddWithValue("@dijagnoze_id", cmb_Dijagnoze.SelectedValue);
            cmd.Parameters.AddWithValue("@lecenja_id", cmb_Lecenja.SelectedValue);

            cmd.ExecuteNonQuery();
            connection.Close();
            Ucitaj_Preglede();

            dataGrid_Pregled_Pregleda.Rows[selektovani_red_grida].Selected = true;
            dataGrid_Pregled_Pregleda.FirstDisplayedScrollingRowIndex = selektovani_red_grida;

            MessageBox.Show("Uspešno ste izmenili selektovni red", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txt_Opis_Dijagnoze.Clear();
            txt_Naziv_Dijagnoze.Clear();
            cmb_Lecenja.SelectedValue = 0;
            cmb_Doktori.SelectedValue = 0;
            cmb_Pacijenti.SelectedValue = 0;
            cmb_Dijagnoze.SelectedValue = 0;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Da li ste sigurni da želite da izbrišete selektovani red?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connection.Open();
                    cmd = new SqlCommand("delete from preglede where id=" + id_grida, connection);
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
            dataGrid_Pregled_Pregleda.Rows.Clear();
            connection.Open();
            cmd = new SqlCommand("select p.id, p.vreme_pregleda, p.datum_pregleda, p.pacijent_id, p.doktori_id, p.dijagnoze_id, p.lecenja_id from pregledi as p where p.id like '" + txt_Search.Text + "%'", connection);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGrid_Pregled_Pregleda.Rows.Add(i, dr["id"], dr["vreme_pregleda"], dr["datum_pregleda"], dr["pacijent_id"], dr["doktori_id"], dr["dijagnoze_id"], dr["lecenja_id"]);
            }
            dr.Close();
            connection.Close();
        }

        private void dataGrid_Pregled_Pregleda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string col_name = dataGrid_Pregled_Pregleda.Columns[e.ColumnIndex].Name;
            id_grida = dataGrid_Pregled_Pregleda.Rows[e.RowIndex].Cells[1].Value.ToString();
            selektovani_red_grida = dataGrid_Pregled_Pregleda.CurrentRow.Index;

            if (col_name == "edit")
            {
                id_dijagnoze = Int32.Parse(id_grida);
                connection.Open();
                cmd = new SqlCommand("select * from pregledi where id=" + id_dijagnoze, connection);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txt_Naziv_Dijagnoze.Text = dr["vreme_pregleda"].ToString();
                    txt_Opis_Dijagnoze.Text = dr["datum_pregleda"].ToString();
                    pacijent_id = Int32.Parse(dr["pacijent_id"].ToString());
                    doktori_id = Int32.Parse(dr["doktori_id"].ToString());
                    dijagnoze_id = Int32.Parse(dr["dijagnoze_id"].ToString());
                    lecenje_id = Int32.Parse(dr["lecenja_id"].ToString());
                }
                dr.Close();
                connection.Close();
                cmb_Doktori.SelectedValue = doktori_id;
                cmb_Pacijenti.SelectedValue = pacijent_id;
                cmb_Dijagnoze.SelectedValue = dijagnoze_id;
                cmb_Lecenja.SelectedValue = lecenje_id;
            }
            else if (col_name == "Delete")
            {
                try
                {
                    if (MessageBox.Show("Da li ste sigurni da želite da izbrišete selektovani red?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        connection.Open();
                        cmd = new SqlCommand("delete from pregledi where id=" + id_grida, connection);
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        Ucitaj_Preglede();
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
