
namespace Projekat_Dom_Zdravlja
{
    partial class frm_Pacijent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Pacijent));
            this.txt_Ime_Pacijenta = new System.Windows.Forms.TextBox();
            this.txt_Prezime_Pacijenta = new System.Windows.Forms.TextBox();
            this.txt_Datum_Rodjenja_Pacijenta = new System.Windows.Forms.TextBox();
            this.txt_JMBG_Pacijenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGrid_Pregled_Pacijenata = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ime_Pacijenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezime_Pacijenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum_rodjenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jmbg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_Unos = new System.Windows.Forms.Button();
            this.btn_Select = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Pregled_Pacijenata)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Ime_Pacijenta
            // 
            this.txt_Ime_Pacijenta.Location = new System.Drawing.Point(31, 48);
            this.txt_Ime_Pacijenta.Name = "txt_Ime_Pacijenta";
            this.txt_Ime_Pacijenta.Size = new System.Drawing.Size(152, 23);
            this.txt_Ime_Pacijenta.TabIndex = 0;
            // 
            // txt_Prezime_Pacijenta
            // 
            this.txt_Prezime_Pacijenta.Location = new System.Drawing.Point(211, 48);
            this.txt_Prezime_Pacijenta.Name = "txt_Prezime_Pacijenta";
            this.txt_Prezime_Pacijenta.Size = new System.Drawing.Size(163, 23);
            this.txt_Prezime_Pacijenta.TabIndex = 1;
            // 
            // txt_Datum_Rodjenja_Pacijenta
            // 
            this.txt_Datum_Rodjenja_Pacijenta.Location = new System.Drawing.Point(396, 48);
            this.txt_Datum_Rodjenja_Pacijenta.Name = "txt_Datum_Rodjenja_Pacijenta";
            this.txt_Datum_Rodjenja_Pacijenta.Size = new System.Drawing.Size(160, 23);
            this.txt_Datum_Rodjenja_Pacijenta.TabIndex = 2;
            // 
            // txt_JMBG_Pacijenta
            // 
            this.txt_JMBG_Pacijenta.Location = new System.Drawing.Point(602, 48);
            this.txt_JMBG_Pacijenta.Name = "txt_JMBG_Pacijenta";
            this.txt_JMBG_Pacijenta.Size = new System.Drawing.Size(167, 23);
            this.txt_JMBG_Pacijenta.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datum Rodjenja:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(602, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "JMBG:";
            // 
            // dataGrid_Pregled_Pacijenata
            // 
            this.dataGrid_Pregled_Pacijenata.AllowUserToAddRows = false;
            this.dataGrid_Pregled_Pacijenata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Pregled_Pacijenata.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid_Pregled_Pacijenata.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_Pregled_Pacijenata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Pregled_Pacijenata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_Pregled_Pacijenata.ColumnHeadersHeight = 30;
            this.dataGrid_Pregled_Pacijenata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid_Pregled_Pacijenata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dataGridViewTextBoxColumn1,
            this.ime_Pacijenta,
            this.prezime_Pacijenta,
            this.datum_rodjenja,
            this.jmbg,
            this.edit,
            this.Delete});
            this.dataGrid_Pregled_Pacijenata.EnableHeadersVisualStyles = false;
            this.dataGrid_Pregled_Pacijenata.Location = new System.Drawing.Point(31, 77);
            this.dataGrid_Pregled_Pacijenata.MultiSelect = false;
            this.dataGrid_Pregled_Pacijenata.Name = "dataGrid_Pregled_Pacijenata";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Pregled_Pacijenata.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_Pregled_Pacijenata.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid_Pregled_Pacijenata.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_Pregled_Pacijenata.RowTemplate.Height = 25;
            this.dataGrid_Pregled_Pacijenata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Pregled_Pacijenata.Size = new System.Drawing.Size(738, 224);
            this.dataGrid_Pregled_Pacijenata.TabIndex = 42;
            this.dataGrid_Pregled_Pacijenata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Pregled_Pacijenata_CellContentClick);
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
            // ime_Pacijenta
            // 
            this.ime_Pacijenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ime_Pacijenta.HeaderText = "Ime Pacijenta";
            this.ime_Pacijenta.Name = "ime_Pacijenta";
            this.ime_Pacijenta.Width = 107;
            // 
            // prezime_Pacijenta
            // 
            this.prezime_Pacijenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.prezime_Pacijenta.HeaderText = "Prezime Pacijenta";
            this.prezime_Pacijenta.Name = "prezime_Pacijenta";
            this.prezime_Pacijenta.Width = 132;
            // 
            // datum_rodjenja
            // 
            this.datum_rodjenja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.datum_rodjenja.HeaderText = "Datum Rodjenja";
            this.datum_rodjenja.Name = "datum_rodjenja";
            this.datum_rodjenja.Width = 124;
            // 
            // jmbg
            // 
            this.jmbg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.jmbg.HeaderText = "JMBG";
            this.jmbg.Name = "jmbg";
            this.jmbg.Width = 64;
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
            // btn_Unos
            // 
            this.btn_Unos.Location = new System.Drawing.Point(31, 326);
            this.btn_Unos.Name = "btn_Unos";
            this.btn_Unos.Size = new System.Drawing.Size(152, 36);
            this.btn_Unos.TabIndex = 9;
            this.btn_Unos.Text = "Add";
            this.btn_Unos.UseVisualStyleBackColor = true;
            this.btn_Unos.Click += new System.EventHandler(this.btn_Unos_Click);
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(189, 326);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(152, 36);
            this.btn_Select.TabIndex = 10;
            this.btn_Select.Text = "Select";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(347, 326);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(152, 36);
            this.btn_Edit.TabIndex = 11;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(505, 326);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(152, 36);
            this.btn_Delete.TabIndex = 12;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // frm_Pacijent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.btn_Unos);
            this.Controls.Add(this.dataGrid_Pregled_Pacijenata);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_JMBG_Pacijenta);
            this.Controls.Add(this.txt_Datum_Rodjenja_Pacijenta);
            this.Controls.Add(this.txt_Prezime_Pacijenta);
            this.Controls.Add(this.txt_Ime_Pacijenta);
            this.Name = "frm_Pacijent";
            this.Text = "frm_Pacijent";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Pregled_Pacijenata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Ime_Pacijenta;
        private System.Windows.Forms.TextBox txt_Prezime_Pacijenta;
        private System.Windows.Forms.TextBox txt_Datum_Rodjenja_Pacijenta;
        private System.Windows.Forms.TextBox txt_JMBG_Pacijenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Unos;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ime_Pacijenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezime_Pacijenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum_rodjenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn jmbg;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        public System.Windows.Forms.DataGridView dataGrid_Pregled_Pacijenata;
    }
}