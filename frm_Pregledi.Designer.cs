namespace Projekat_Dom_Zdravlja
{
    partial class frm_Pregledi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Pregledi));
            this.search_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Select = new System.Windows.Forms.Button();
            this.btn_Unos = new System.Windows.Forms.Button();
            this.dataGrid_Pregled_Pregleda = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Opis_Dijagnoze = new System.Windows.Forms.TextBox();
            this.txt_Naziv_Dijagnoze = new System.Windows.Forms.TextBox();
            this.cmb_Pacijenti = new System.Windows.Forms.ComboBox();
            this.cmb_Doktori = new System.Windows.Forms.ComboBox();
            this.cmb_Lecenja = new System.Windows.Forms.ComboBox();
            this.cmb_Dijagnoze = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vreme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime_Pacijenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dijagnoza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecenje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Pregled_Pregleda)).BeginInit();
            this.SuspendLayout();
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(614, 318);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(152, 36);
            this.search_btn.TabIndex = 87;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(657, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 86;
            this.label5.Text = "Search:";
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(657, 40);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(109, 23);
            this.txt_Search.TabIndex = 85;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(458, 318);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(150, 36);
            this.btn_Delete.TabIndex = 83;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(320, 318);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(132, 36);
            this.btn_Edit.TabIndex = 82;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(171, 318);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(143, 36);
            this.btn_Select.TabIndex = 81;
            this.btn_Select.Text = "Select";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // btn_Unos
            // 
            this.btn_Unos.Location = new System.Drawing.Point(28, 318);
            this.btn_Unos.Name = "btn_Unos";
            this.btn_Unos.Size = new System.Drawing.Size(137, 36);
            this.btn_Unos.TabIndex = 80;
            this.btn_Unos.Text = "Add";
            this.btn_Unos.UseVisualStyleBackColor = true;
            this.btn_Unos.Click += new System.EventHandler(this.btn_Unos_Click);
            // 
            // dataGrid_Pregled_Pregleda
            // 
            this.dataGrid_Pregled_Pregleda.AllowUserToAddRows = false;
            this.dataGrid_Pregled_Pregleda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Pregled_Pregleda.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid_Pregled_Pregleda.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_Pregled_Pregleda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Pregled_Pregleda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_Pregled_Pregleda.ColumnHeadersHeight = 50;
            this.dataGrid_Pregled_Pregleda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid_Pregled_Pregleda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dataGridViewTextBoxColumn1,
            this.vreme,
            this.datum,
            this.Ime_Pacijenta,
            this.doktor,
            this.dijagnoza,
            this.lecenje,
            this.edit,
            this.Delete});
            this.dataGrid_Pregled_Pregleda.EnableHeadersVisualStyles = false;
            this.dataGrid_Pregled_Pregleda.Location = new System.Drawing.Point(28, 69);
            this.dataGrid_Pregled_Pregleda.MultiSelect = false;
            this.dataGrid_Pregled_Pregleda.Name = "dataGrid_Pregled_Pregleda";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Pregled_Pregleda.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_Pregled_Pregleda.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid_Pregled_Pregleda.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_Pregled_Pregleda.RowTemplate.Height = 25;
            this.dataGrid_Pregled_Pregleda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Pregled_Pregleda.Size = new System.Drawing.Size(738, 224);
            this.dataGrid_Pregled_Pregleda.TabIndex = 84;
            this.dataGrid_Pregled_Pregleda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Pregled_Pregleda_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 79;
            this.label3.Text = "Datum:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 78;
            this.label1.Text = "Vreme:";
            // 
            // txt_Opis_Dijagnoze
            // 
            this.txt_Opis_Dijagnoze.Location = new System.Drawing.Point(109, 40);
            this.txt_Opis_Dijagnoze.Name = "txt_Opis_Dijagnoze";
            this.txt_Opis_Dijagnoze.Size = new System.Drawing.Size(106, 23);
            this.txt_Opis_Dijagnoze.TabIndex = 77;
            // 
            // txt_Naziv_Dijagnoze
            // 
            this.txt_Naziv_Dijagnoze.Location = new System.Drawing.Point(28, 40);
            this.txt_Naziv_Dijagnoze.Name = "txt_Naziv_Dijagnoze";
            this.txt_Naziv_Dijagnoze.Size = new System.Drawing.Size(75, 23);
            this.txt_Naziv_Dijagnoze.TabIndex = 76;
            // 
            // cmb_Pacijenti
            // 
            this.cmb_Pacijenti.FormattingEnabled = true;
            this.cmb_Pacijenti.Location = new System.Drawing.Point(221, 40);
            this.cmb_Pacijenti.Name = "cmb_Pacijenti";
            this.cmb_Pacijenti.Size = new System.Drawing.Size(103, 23);
            this.cmb_Pacijenti.TabIndex = 88;
            // 
            // cmb_Doktori
            // 
            this.cmb_Doktori.FormattingEnabled = true;
            this.cmb_Doktori.Location = new System.Drawing.Point(330, 40);
            this.cmb_Doktori.Name = "cmb_Doktori";
            this.cmb_Doktori.Size = new System.Drawing.Size(103, 23);
            this.cmb_Doktori.TabIndex = 89;
            // 
            // cmb_Lecenja
            // 
            this.cmb_Lecenja.FormattingEnabled = true;
            this.cmb_Lecenja.Location = new System.Drawing.Point(548, 40);
            this.cmb_Lecenja.Name = "cmb_Lecenja";
            this.cmb_Lecenja.Size = new System.Drawing.Size(103, 23);
            this.cmb_Lecenja.TabIndex = 90;
            // 
            // cmb_Dijagnoze
            // 
            this.cmb_Dijagnoze.FormattingEnabled = true;
            this.cmb_Dijagnoze.Location = new System.Drawing.Point(439, 40);
            this.cmb_Dijagnoze.Name = "cmb_Dijagnoze";
            this.cmb_Dijagnoze.Size = new System.Drawing.Size(103, 23);
            this.cmb_Dijagnoze.TabIndex = 91;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 92;
            this.label2.Text = "Pacijent:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(439, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 93;
            this.label4.Text = "Dijagnoza:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(548, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 94;
            this.label6.Text = "Lecenje:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(330, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 95;
            this.label7.Text = "Doktor:";
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.HeaderText = "#";
            this.id.Name = "id";
            this.id.Width = 39;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // vreme
            // 
            this.vreme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.vreme.HeaderText = "Zakazano vreme";
            this.vreme.Name = "vreme";
            this.vreme.Width = 115;
            // 
            // datum
            // 
            this.datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.datum.HeaderText = "Datum Pregleda";
            this.datum.Name = "datum";
            this.datum.Width = 114;
            // 
            // Ime_Pacijenta
            // 
            this.Ime_Pacijenta.HeaderText = "Ime Pacijenta";
            this.Ime_Pacijenta.Name = "Ime_Pacijenta";
            // 
            // doktor
            // 
            this.doktor.HeaderText = "Ime Doktora";
            this.doktor.Name = "doktor";
            // 
            // dijagnoza
            // 
            this.dijagnoza.HeaderText = "Dijagnoza";
            this.dijagnoza.Name = "dijagnoza";
            // 
            // lecenje
            // 
            this.lecenje.HeaderText = "Lecenje";
            this.lecenje.Name = "lecenje";
            // 
            // edit
            // 
            this.edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.edit.HeaderText = "";
            this.edit.Image = ((System.Drawing.Image)(resources.GetObject("edit.Image")));
            this.edit.Name = "edit";
            this.edit.Width = 5;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            this.Delete.Width = 5;
            // 
            // frm_Pregledi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 367);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_Dijagnoze);
            this.Controls.Add(this.cmb_Lecenja);
            this.Controls.Add(this.cmb_Doktori);
            this.Controls.Add(this.cmb_Pacijenti);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.btn_Unos);
            this.Controls.Add(this.dataGrid_Pregled_Pregleda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Opis_Dijagnoze);
            this.Controls.Add(this.txt_Naziv_Dijagnoze);
            this.Name = "frm_Pregledi";
            this.Text = "Pregledi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Pregled_Pregleda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Button btn_Unos;
        public System.Windows.Forms.DataGridView dataGrid_Pregled_Pregleda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Opis_Dijagnoze;
        private System.Windows.Forms.TextBox txt_Naziv_Dijagnoze;
        private System.Windows.Forms.ComboBox cmb_Pacijenti;
        private System.Windows.Forms.ComboBox cmb_Doktori;
        private System.Windows.Forms.ComboBox cmb_Lecenja;
        private System.Windows.Forms.ComboBox cmb_Dijagnoze;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vreme;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime_Pacijenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dijagnoza;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecenje;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}