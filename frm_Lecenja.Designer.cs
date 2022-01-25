namespace Projekat_Dom_Zdravlja
{
    partial class frm_Lecenja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Lecenja));
            this.search_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Select = new System.Windows.Forms.Button();
            this.btn_Unos = new System.Windows.Forms.Button();
            this.dataGrid_Pregled_Lecenja = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Opis_Lecenja = new System.Windows.Forms.TextBox();
            this.txt_Cena_Lecenja = new System.Windows.Forms.TextBox();
            this.txt_Naziv_Lecenja = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naziv_Lecenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cena_Lecenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Pregled_Lecenja)).BeginInit();
            this.SuspendLayout();
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(620, 317);
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
            this.label5.Location = new System.Drawing.Point(609, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 60;
            this.label5.Text = "Search:";
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(609, 38);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(163, 23);
            this.txt_Search.TabIndex = 59;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(464, 317);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(150, 36);
            this.btn_Delete.TabIndex = 57;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(326, 317);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(132, 36);
            this.btn_Edit.TabIndex = 56;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(177, 317);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(143, 36);
            this.btn_Select.TabIndex = 55;
            this.btn_Select.Text = "Select";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // btn_Unos
            // 
            this.btn_Unos.Location = new System.Drawing.Point(34, 317);
            this.btn_Unos.Name = "btn_Unos";
            this.btn_Unos.Size = new System.Drawing.Size(137, 36);
            this.btn_Unos.TabIndex = 54;
            this.btn_Unos.Text = "Add";
            this.btn_Unos.UseVisualStyleBackColor = true;
            this.btn_Unos.Click += new System.EventHandler(this.btn_Unos_Click);
            // 
            // dataGrid_Pregled_Lecenja
            // 
            this.dataGrid_Pregled_Lecenja.AllowUserToAddRows = false;
            this.dataGrid_Pregled_Lecenja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Pregled_Lecenja.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid_Pregled_Lecenja.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_Pregled_Lecenja.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Pregled_Lecenja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid_Pregled_Lecenja.ColumnHeadersHeight = 30;
            this.dataGrid_Pregled_Lecenja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid_Pregled_Lecenja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dataGridViewTextBoxColumn1,
            this.naziv_Lecenja,
            this.cena_Lecenja,
            this.opis,
            this.edit,
            this.Delete});
            this.dataGrid_Pregled_Lecenja.EnableHeadersVisualStyles = false;
            this.dataGrid_Pregled_Lecenja.Location = new System.Drawing.Point(34, 68);
            this.dataGrid_Pregled_Lecenja.MultiSelect = false;
            this.dataGrid_Pregled_Lecenja.Name = "dataGrid_Pregled_Lecenja";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Pregled_Lecenja.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGrid_Pregled_Lecenja.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid_Pregled_Lecenja.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGrid_Pregled_Lecenja.RowTemplate.Height = 25;
            this.dataGrid_Pregled_Lecenja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Pregled_Lecenja.Size = new System.Drawing.Size(738, 224);
            this.dataGrid_Pregled_Lecenja.TabIndex = 58;
            this.dataGrid_Pregled_Lecenja.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Pregled_Lecenja_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 52;
            this.label3.Text = "Opis:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 51;
            this.label2.Text = "Cena:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 50;
            this.label1.Text = "Naziv:";
            // 
            // txt_Opis_Lecenja
            // 
            this.txt_Opis_Lecenja.Location = new System.Drawing.Point(326, 39);
            this.txt_Opis_Lecenja.Name = "txt_Opis_Lecenja";
            this.txt_Opis_Lecenja.Size = new System.Drawing.Size(131, 23);
            this.txt_Opis_Lecenja.TabIndex = 48;
            // 
            // txt_Cena_Lecenja
            // 
            this.txt_Cena_Lecenja.Location = new System.Drawing.Point(177, 39);
            this.txt_Cena_Lecenja.Name = "txt_Cena_Lecenja";
            this.txt_Cena_Lecenja.Size = new System.Drawing.Size(124, 23);
            this.txt_Cena_Lecenja.TabIndex = 47;
            // 
            // txt_Naziv_Lecenja
            // 
            this.txt_Naziv_Lecenja.Location = new System.Drawing.Point(34, 39);
            this.txt_Naziv_Lecenja.Name = "txt_Naziv_Lecenja";
            this.txt_Naziv_Lecenja.Size = new System.Drawing.Size(119, 23);
            this.txt_Naziv_Lecenja.TabIndex = 46;
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
            // naziv_Lecenja
            // 
            this.naziv_Lecenja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.naziv_Lecenja.HeaderText = "Naziv_Lecenja";
            this.naziv_Lecenja.Name = "naziv_Lecenja";
            this.naziv_Lecenja.Width = 111;
            // 
            // cena_Lecenja
            // 
            this.cena_Lecenja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cena_Lecenja.HeaderText = "Cena Lecenja";
            this.cena_Lecenja.Name = "cena_Lecenja";
            this.cena_Lecenja.Width = 107;
            // 
            // opis
            // 
            this.opis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.opis.HeaderText = "Opis Lecenja";
            this.opis.Name = "opis";
            this.opis.Width = 105;
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
            // frm_Lecenja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 368);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.btn_Unos);
            this.Controls.Add(this.dataGrid_Pregled_Lecenja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Opis_Lecenja);
            this.Controls.Add(this.txt_Cena_Lecenja);
            this.Controls.Add(this.txt_Naziv_Lecenja);
            this.Name = "frm_Lecenja";
            this.Text = "Lecenja";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Pregled_Lecenja)).EndInit();
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
        public System.Windows.Forms.DataGridView dataGrid_Pregled_Lecenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv_Lecenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn cena_Lecenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn opis;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Opis_Lecenja;
        private System.Windows.Forms.TextBox txt_Cena_Lecenja;
        private System.Windows.Forms.TextBox txt_Naziv_Lecenja;
    }
}