namespace Projekat_Dom_Zdravlja
{
    partial class frm_Doktori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Doktori));
            this.search_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Select = new System.Windows.Forms.Button();
            this.btn_Unos = new System.Windows.Forms.Button();
            this.dataGrid_Pregled_Doktora = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Opis_Doktora = new System.Windows.Forms.TextBox();
            this.txt_Struka_Doktora = new System.Windows.Forms.TextBox();
            this.txt_Prezime_Doktora = new System.Windows.Forms.TextBox();
            this.txt_Ime_Doktora = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ime_Doktora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezime_Doktora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.struka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Pregled_Doktora)).BeginInit();
            this.SuspendLayout();
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(617, 313);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(152, 36);
            this.search_btn.TabIndex = 61;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(606, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 60;
            this.label5.Text = "Search:";
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(606, 34);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(163, 23);
            this.txt_Search.TabIndex = 59;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(461, 313);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(150, 36);
            this.btn_Delete.TabIndex = 57;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(323, 313);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(132, 36);
            this.btn_Edit.TabIndex = 56;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(174, 313);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(143, 36);
            this.btn_Select.TabIndex = 55;
            this.btn_Select.Text = "Select";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // btn_Unos
            // 
            this.btn_Unos.Location = new System.Drawing.Point(31, 313);
            this.btn_Unos.Name = "btn_Unos";
            this.btn_Unos.Size = new System.Drawing.Size(137, 36);
            this.btn_Unos.TabIndex = 54;
            this.btn_Unos.Text = "Add";
            this.btn_Unos.UseVisualStyleBackColor = true;
            this.btn_Unos.Click += new System.EventHandler(this.btn_Unos_Click);
            // 
            // dataGrid_Pregled_Doktora
            // 
            this.dataGrid_Pregled_Doktora.AllowUserToAddRows = false;
            this.dataGrid_Pregled_Doktora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Pregled_Doktora.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid_Pregled_Doktora.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_Pregled_Doktora.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Pregled_Doktora.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid_Pregled_Doktora.ColumnHeadersHeight = 30;
            this.dataGrid_Pregled_Doktora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid_Pregled_Doktora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dataGridViewTextBoxColumn1,
            this.ime_Doktora,
            this.prezime_Doktora,
            this.struka,
            this.opis,
            this.edit,
            this.Delete});
            this.dataGrid_Pregled_Doktora.EnableHeadersVisualStyles = false;
            this.dataGrid_Pregled_Doktora.Location = new System.Drawing.Point(31, 64);
            this.dataGrid_Pregled_Doktora.MultiSelect = false;
            this.dataGrid_Pregled_Doktora.Name = "dataGrid_Pregled_Doktora";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Pregled_Doktora.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGrid_Pregled_Doktora.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid_Pregled_Doktora.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGrid_Pregled_Doktora.RowTemplate.Height = 25;
            this.dataGrid_Pregled_Doktora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Pregled_Doktora.Size = new System.Drawing.Size(738, 224);
            this.dataGrid_Pregled_Doktora.TabIndex = 58;
            this.dataGrid_Pregled_Doktora.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Pregled_Doktora_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 53;
            this.label4.Text = "Opis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 52;
            this.label3.Text = "Struka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 51;
            this.label2.Text = "Prezime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 50;
            this.label1.Text = "Ime:";
            // 
            // txt_Opis_Doktora
            // 
            this.txt_Opis_Doktora.Location = new System.Drawing.Point(428, 35);
            this.txt_Opis_Doktora.Name = "txt_Opis_Doktora";
            this.txt_Opis_Doktora.Size = new System.Drawing.Size(158, 23);
            this.txt_Opis_Doktora.TabIndex = 49;
            // 
            // txt_Struka_Doktora
            // 
            this.txt_Struka_Doktora.Location = new System.Drawing.Point(280, 35);
            this.txt_Struka_Doktora.Name = "txt_Struka_Doktora";
            this.txt_Struka_Doktora.Size = new System.Drawing.Size(131, 23);
            this.txt_Struka_Doktora.TabIndex = 48;
            // 
            // txt_Prezime_Doktora
            // 
            this.txt_Prezime_Doktora.Location = new System.Drawing.Point(139, 35);
            this.txt_Prezime_Doktora.Name = "txt_Prezime_Doktora";
            this.txt_Prezime_Doktora.Size = new System.Drawing.Size(124, 23);
            this.txt_Prezime_Doktora.TabIndex = 47;
            // 
            // txt_Ime_Doktora
            // 
            this.txt_Ime_Doktora.Location = new System.Drawing.Point(31, 35);
            this.txt_Ime_Doktora.Name = "txt_Ime_Doktora";
            this.txt_Ime_Doktora.Size = new System.Drawing.Size(93, 23);
            this.txt_Ime_Doktora.TabIndex = 46;
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
            // ime_Doktora
            // 
            this.ime_Doktora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ime_Doktora.HeaderText = "Ime Doktora";
            this.ime_Doktora.Name = "ime_Doktora";
            this.ime_Doktora.Width = 103;
            // 
            // prezime_Doktora
            // 
            this.prezime_Doktora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.prezime_Doktora.HeaderText = "Prezime Doktora";
            this.prezime_Doktora.Name = "prezime_Doktora";
            this.prezime_Doktora.Width = 128;
            // 
            // struka
            // 
            this.struka.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.struka.HeaderText = "Struka Doktora";
            this.struka.Name = "struka";
            this.struka.Width = 118;
            // 
            // opis
            // 
            this.opis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.opis.HeaderText = "Opis Doktora";
            this.opis.Name = "opis";
            this.opis.Width = 109;
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
            // frm_Doktori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 366);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.btn_Unos);
            this.Controls.Add(this.dataGrid_Pregled_Doktora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Opis_Doktora);
            this.Controls.Add(this.txt_Struka_Doktora);
            this.Controls.Add(this.txt_Prezime_Doktora);
            this.Controls.Add(this.txt_Ime_Doktora);
            this.Name = "frm_Doktori";
            this.Text = "frm_Doktori";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Pregled_Doktora)).EndInit();
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
        public System.Windows.Forms.DataGridView dataGrid_Pregled_Doktora;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ime_Doktora;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezime_Doktora;
        private System.Windows.Forms.DataGridViewTextBoxColumn struka;
        private System.Windows.Forms.DataGridViewTextBoxColumn opis;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Opis_Doktora;
        private System.Windows.Forms.TextBox txt_Struka_Doktora;
        private System.Windows.Forms.TextBox txt_Prezime_Doktora;
        private System.Windows.Forms.TextBox txt_Ime_Doktora;
    }
}