
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Pacijent));
            this.txt_Ime_Pacijenta = new System.Windows.Forms.TextBox();
            this.txt_Prezime_Pacijenta = new System.Windows.Forms.TextBox();
            this.txt_Godine_Pacijenta = new System.Windows.Forms.TextBox();
            this.txt_Adresa_Pacijenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGrid_Pregled_Pacijenata = new System.Windows.Forms.DataGridView();
            this.btn_Unos = new System.Windows.Forms.Button();
            this.btn_Select = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ime_Pacijenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezime_Pacijenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Pregled_Pacijenata)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Ime_Pacijenta
            // 
            this.txt_Ime_Pacijenta.Location = new System.Drawing.Point(31, 48);
            this.txt_Ime_Pacijenta.Name = "txt_Ime_Pacijenta";
            this.txt_Ime_Pacijenta.Size = new System.Drawing.Size(93, 23);
            this.txt_Ime_Pacijenta.TabIndex = 0;
            // 
            // txt_Prezime_Pacijenta
            // 
            this.txt_Prezime_Pacijenta.Location = new System.Drawing.Point(139, 48);
            this.txt_Prezime_Pacijenta.Name = "txt_Prezime_Pacijenta";
            this.txt_Prezime_Pacijenta.Size = new System.Drawing.Size(124, 23);
            this.txt_Prezime_Pacijenta.TabIndex = 1;
            // 
            // txt_Godine_Pacijenta
            // 
            this.txt_Godine_Pacijenta.Location = new System.Drawing.Point(280, 48);
            this.txt_Godine_Pacijenta.Name = "txt_Godine_Pacijenta";
            this.txt_Godine_Pacijenta.Size = new System.Drawing.Size(131, 23);
            this.txt_Godine_Pacijenta.TabIndex = 2;
            // 
            // txt_Adresa_Pacijenta
            // 
            this.txt_Adresa_Pacijenta.Location = new System.Drawing.Point(428, 48);
            this.txt_Adresa_Pacijenta.Name = "txt_Adresa_Pacijenta";
            this.txt_Adresa_Pacijenta.Size = new System.Drawing.Size(158, 23);
            this.txt_Adresa_Pacijenta.TabIndex = 3;
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
            this.label2.Location = new System.Drawing.Point(139, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Godine:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adresa";
            // 
            // dataGrid_Pregled_Pacijenata
            // 
            this.dataGrid_Pregled_Pacijenata.AllowUserToAddRows = false;
            this.dataGrid_Pregled_Pacijenata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Pregled_Pacijenata.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid_Pregled_Pacijenata.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_Pregled_Pacijenata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Pregled_Pacijenata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid_Pregled_Pacijenata.ColumnHeadersHeight = 30;
            this.dataGrid_Pregled_Pacijenata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid_Pregled_Pacijenata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dataGridViewTextBoxColumn1,
            this.ime_Pacijenta,
            this.prezime_Pacijenta,
            this.godine,
            this.adresa,
            this.edit,
            this.Delete});
            this.dataGrid_Pregled_Pacijenata.EnableHeadersVisualStyles = false;
            this.dataGrid_Pregled_Pacijenata.Location = new System.Drawing.Point(31, 77);
            this.dataGrid_Pregled_Pacijenata.MultiSelect = false;
            this.dataGrid_Pregled_Pacijenata.Name = "dataGrid_Pregled_Pacijenata";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Pregled_Pacijenata.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGrid_Pregled_Pacijenata.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid_Pregled_Pacijenata.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGrid_Pregled_Pacijenata.RowTemplate.Height = 25;
            this.dataGrid_Pregled_Pacijenata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Pregled_Pacijenata.Size = new System.Drawing.Size(738, 224);
            this.dataGrid_Pregled_Pacijenata.TabIndex = 42;
            this.dataGrid_Pregled_Pacijenata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Pregled_Pacijenata_CellContentClick);
            // 
            // btn_Unos
            // 
            this.btn_Unos.Location = new System.Drawing.Point(31, 326);
            this.btn_Unos.Name = "btn_Unos";
            this.btn_Unos.Size = new System.Drawing.Size(137, 36);
            this.btn_Unos.TabIndex = 9;
            this.btn_Unos.Text = "Add";
            this.btn_Unos.UseVisualStyleBackColor = true;
            this.btn_Unos.Click += new System.EventHandler(this.btn_Unos_Click);
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(174, 326);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(143, 36);
            this.btn_Select.TabIndex = 10;
            this.btn_Select.Text = "Select";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(323, 326);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(132, 36);
            this.btn_Edit.TabIndex = 11;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(461, 326);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(150, 36);
            this.btn_Delete.TabIndex = 12;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(606, 47);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(163, 23);
            this.txt_Search.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(606, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 44;
            this.label5.Text = "Search:";
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(617, 326);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(152, 36);
            this.search_btn.TabIndex = 45;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
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
            // godine
            // 
            this.godine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.godine.HeaderText = "Godine Pacijenta";
            this.godine.Name = "godine";
            this.godine.Width = 128;
            // 
            // adresa
            // 
            this.adresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.adresa.HeaderText = "Adresa Pacijenta";
            this.adresa.Name = "adresa";
            this.adresa.Width = 127;
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
            // frm_Pacijent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.btn_Unos);
            this.Controls.Add(this.dataGrid_Pregled_Pacijenata);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Adresa_Pacijenta);
            this.Controls.Add(this.txt_Godine_Pacijenta);
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
        private System.Windows.Forms.TextBox txt_Godine_Pacijenta;
        private System.Windows.Forms.TextBox txt_Adresa_Pacijenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Unos;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        public System.Windows.Forms.DataGridView dataGrid_Pregled_Pacijenata;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ime_Pacijenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezime_Pacijenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn godine;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresa;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}