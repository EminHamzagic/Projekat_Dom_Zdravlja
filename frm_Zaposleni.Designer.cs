
namespace Projekat_Dom_Zdravlja
{
    partial class frm_Zaposleni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Zaposleni));
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Select = new System.Windows.Forms.Button();
            this.btn_Unos = new System.Windows.Forms.Button();
            this.dataGrid_Pregled_Zaposlenih = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Prezime_Zaposleni = new System.Windows.Forms.TextBox();
            this.txt_Ime_Zaposleni = new System.Windows.Forms.TextBox();
            this.cmb_Poslovi = new System.Windows.Forms.ComboBox();
            this.cmb_Odeljenje = new System.Windows.Forms.ComboBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ime_Pacijenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezime_Pacijenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_posla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_odeljenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Pregled_Zaposlenih)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(505, 326);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(152, 36);
            this.btn_Delete.TabIndex = 25;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(347, 326);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(152, 36);
            this.btn_Edit.TabIndex = 24;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(189, 326);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(152, 36);
            this.btn_Select.TabIndex = 23;
            this.btn_Select.Text = "Select";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // btn_Unos
            // 
            this.btn_Unos.Location = new System.Drawing.Point(31, 326);
            this.btn_Unos.Name = "btn_Unos";
            this.btn_Unos.Size = new System.Drawing.Size(152, 36);
            this.btn_Unos.TabIndex = 22;
            this.btn_Unos.Text = "Add";
            this.btn_Unos.UseVisualStyleBackColor = true;
            this.btn_Unos.Click += new System.EventHandler(this.btn_Unos_Click);
            // 
            // dataGrid_Pregled_Zaposlenih
            // 
            this.dataGrid_Pregled_Zaposlenih.AllowUserToAddRows = false;
            this.dataGrid_Pregled_Zaposlenih.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Pregled_Zaposlenih.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid_Pregled_Zaposlenih.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_Pregled_Zaposlenih.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid_Pregled_Zaposlenih.ColumnHeadersHeight = 30;
            this.dataGrid_Pregled_Zaposlenih.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid_Pregled_Zaposlenih.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dataGridViewTextBoxColumn1,
            this.ime_Pacijenta,
            this.prezime_Pacijenta,
            this.id_posla,
            this.id_odeljenja,
            this.edit,
            this.Delete});
            this.dataGrid_Pregled_Zaposlenih.EnableHeadersVisualStyles = false;
            this.dataGrid_Pregled_Zaposlenih.Location = new System.Drawing.Point(31, 77);
            this.dataGrid_Pregled_Zaposlenih.MultiSelect = false;
            this.dataGrid_Pregled_Zaposlenih.Name = "dataGrid_Pregled_Zaposlenih";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Pregled_Zaposlenih.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_Pregled_Zaposlenih.RowHeadersVisible = false;
            this.dataGrid_Pregled_Zaposlenih.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid_Pregled_Zaposlenih.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_Pregled_Zaposlenih.RowTemplate.Height = 25;
            this.dataGrid_Pregled_Zaposlenih.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Pregled_Zaposlenih.Size = new System.Drawing.Size(708, 223);
            this.dataGrid_Pregled_Zaposlenih.TabIndex = 42;
            this.dataGrid_Pregled_Zaposlenih.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Pregled_Zaposlenih_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(575, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Id Odeljenja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Id Posla:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Prezime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ime:";
            // 
            // txt_Prezime_Zaposleni
            // 
            this.txt_Prezime_Zaposleni.Location = new System.Drawing.Point(211, 48);
            this.txt_Prezime_Zaposleni.Name = "txt_Prezime_Zaposleni";
            this.txt_Prezime_Zaposleni.Size = new System.Drawing.Size(163, 23);
            this.txt_Prezime_Zaposleni.TabIndex = 14;
            // 
            // txt_Ime_Zaposleni
            // 
            this.txt_Ime_Zaposleni.Location = new System.Drawing.Point(31, 48);
            this.txt_Ime_Zaposleni.Name = "txt_Ime_Zaposleni";
            this.txt_Ime_Zaposleni.Size = new System.Drawing.Size(152, 23);
            this.txt_Ime_Zaposleni.TabIndex = 13;
            // 
            // cmb_Poslovi
            // 
            this.cmb_Poslovi.FormattingEnabled = true;
            this.cmb_Poslovi.Location = new System.Drawing.Point(396, 48);
            this.cmb_Poslovi.Name = "cmb_Poslovi";
            this.cmb_Poslovi.Size = new System.Drawing.Size(149, 23);
            this.cmb_Poslovi.TabIndex = 26;
            // 
            // cmb_Odeljenje
            // 
            this.cmb_Odeljenje.FormattingEnabled = true;
            this.cmb_Odeljenje.Location = new System.Drawing.Point(575, 48);
            this.cmb_Odeljenje.Name = "cmb_Odeljenje";
            this.cmb_Odeljenje.Size = new System.Drawing.Size(164, 23);
            this.cmb_Odeljenje.TabIndex = 27;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.HeaderText = "#";
            this.id.Name = "id";
            this.id.Width = 37;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // ime_Pacijenta
            // 
            this.ime_Pacijenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ime_Pacijenta.HeaderText = "Ime Zaposlenog";
            this.ime_Pacijenta.Name = "ime_Pacijenta";
            this.ime_Pacijenta.Width = 115;
            // 
            // prezime_Pacijenta
            // 
            this.prezime_Pacijenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.prezime_Pacijenta.HeaderText = "Prezime Zaposlenog";
            this.prezime_Pacijenta.Name = "prezime_Pacijenta";
            this.prezime_Pacijenta.Width = 137;
            // 
            // id_posla
            // 
            this.id_posla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id_posla.HeaderText = "Id Posla";
            this.id_posla.Name = "id_posla";
            this.id_posla.Width = 71;
            // 
            // id_odeljenja
            // 
            this.id_odeljenja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id_odeljenja.HeaderText = "Id Odeljenja";
            this.id_odeljenja.Name = "id_odeljenja";
            this.id_odeljenja.Width = 93;
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
            // frm_Zaposleni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 385);
            this.Controls.Add(this.cmb_Odeljenje);
            this.Controls.Add(this.cmb_Poslovi);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.btn_Unos);
            this.Controls.Add(this.dataGrid_Pregled_Zaposlenih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Prezime_Zaposleni);
            this.Controls.Add(this.txt_Ime_Zaposleni);
            this.Name = "frm_Zaposleni";
            this.Text = "frm_Zaposleni";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Pregled_Zaposlenih)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Button btn_Unos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Prezime_Zaposleni;
        private System.Windows.Forms.TextBox txt_Ime_Zaposleni;
        private System.Windows.Forms.ComboBox cmb_Poslovi;
        private System.Windows.Forms.ComboBox cmb_Odeljenje;
        public System.Windows.Forms.DataGridView dataGrid_Pregled_Zaposlenih;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ime_Pacijenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezime_Pacijenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_posla;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_odeljenja;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}