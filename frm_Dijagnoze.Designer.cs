namespace Projekat_Dom_Zdravlja
{
    partial class frm_Dijagnoze
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Dijagnoze));
            this.search_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Select = new System.Windows.Forms.Button();
            this.btn_Unos = new System.Windows.Forms.Button();
            this.dataGrid_Pregled_Dijagnoze = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Opis_Dijagnoze = new System.Windows.Forms.TextBox();
            this.txt_Naziv_Dijagnoze = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naziv_Dijagnoze = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Pregled_Dijagnoze)).BeginInit();
            this.SuspendLayout();
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(608, 319);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(152, 36);
            this.search_btn.TabIndex = 75;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(597, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 74;
            this.label5.Text = "Search:";
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(597, 40);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(163, 23);
            this.txt_Search.TabIndex = 73;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(452, 319);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(150, 36);
            this.btn_Delete.TabIndex = 71;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(314, 319);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(132, 36);
            this.btn_Edit.TabIndex = 70;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(165, 319);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(143, 36);
            this.btn_Select.TabIndex = 69;
            this.btn_Select.Text = "Select";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // btn_Unos
            // 
            this.btn_Unos.Location = new System.Drawing.Point(22, 319);
            this.btn_Unos.Name = "btn_Unos";
            this.btn_Unos.Size = new System.Drawing.Size(137, 36);
            this.btn_Unos.TabIndex = 68;
            this.btn_Unos.Text = "Add";
            this.btn_Unos.UseVisualStyleBackColor = true;
            this.btn_Unos.Click += new System.EventHandler(this.btn_Unos_Click);
            // 
            // dataGrid_Pregled_Dijagnoze
            // 
            this.dataGrid_Pregled_Dijagnoze.AllowUserToAddRows = false;
            this.dataGrid_Pregled_Dijagnoze.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Pregled_Dijagnoze.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid_Pregled_Dijagnoze.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_Pregled_Dijagnoze.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Pregled_Dijagnoze.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_Pregled_Dijagnoze.ColumnHeadersHeight = 30;
            this.dataGrid_Pregled_Dijagnoze.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid_Pregled_Dijagnoze.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dataGridViewTextBoxColumn1,
            this.naziv_Dijagnoze,
            this.opis,
            this.edit,
            this.Delete});
            this.dataGrid_Pregled_Dijagnoze.EnableHeadersVisualStyles = false;
            this.dataGrid_Pregled_Dijagnoze.Location = new System.Drawing.Point(22, 70);
            this.dataGrid_Pregled_Dijagnoze.MultiSelect = false;
            this.dataGrid_Pregled_Dijagnoze.Name = "dataGrid_Pregled_Dijagnoze";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Pregled_Dijagnoze.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_Pregled_Dijagnoze.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid_Pregled_Dijagnoze.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_Pregled_Dijagnoze.RowTemplate.Height = 25;
            this.dataGrid_Pregled_Dijagnoze.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Pregled_Dijagnoze.Size = new System.Drawing.Size(738, 224);
            this.dataGrid_Pregled_Dijagnoze.TabIndex = 72;
            this.dataGrid_Pregled_Dijagnoze.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Pregled_Dijagnoze_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 67;
            this.label3.Text = "Opis:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 65;
            this.label1.Text = "Naziv:";
            // 
            // txt_Opis_Dijagnoze
            // 
            this.txt_Opis_Dijagnoze.Location = new System.Drawing.Point(165, 41);
            this.txt_Opis_Dijagnoze.Name = "txt_Opis_Dijagnoze";
            this.txt_Opis_Dijagnoze.Size = new System.Drawing.Size(131, 23);
            this.txt_Opis_Dijagnoze.TabIndex = 64;
            // 
            // txt_Naziv_Dijagnoze
            // 
            this.txt_Naziv_Dijagnoze.Location = new System.Drawing.Point(22, 41);
            this.txt_Naziv_Dijagnoze.Name = "txt_Naziv_Dijagnoze";
            this.txt_Naziv_Dijagnoze.Size = new System.Drawing.Size(119, 23);
            this.txt_Naziv_Dijagnoze.TabIndex = 62;
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
            // naziv_Dijagnoze
            // 
            this.naziv_Dijagnoze.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.naziv_Dijagnoze.HeaderText = "Naziv Dijagnoze";
            this.naziv_Dijagnoze.Name = "naziv_Dijagnoze";
            this.naziv_Dijagnoze.Width = 125;
            // 
            // opis
            // 
            this.opis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.opis.HeaderText = "Opis Dijagnoze";
            this.opis.Name = "opis";
            this.opis.Width = 120;
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
            // frm_Dijagnoze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 370);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.btn_Unos);
            this.Controls.Add(this.dataGrid_Pregled_Dijagnoze);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Opis_Dijagnoze);
            this.Controls.Add(this.txt_Naziv_Dijagnoze);
            this.Name = "frm_Dijagnoze";
            this.Text = "Dijagnoze";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Pregled_Dijagnoze)).EndInit();
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
        public System.Windows.Forms.DataGridView dataGrid_Pregled_Dijagnoze;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv_Dijagnoze;
        private System.Windows.Forms.DataGridViewTextBoxColumn opis;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Opis_Dijagnoze;
        private System.Windows.Forms.TextBox txt_Naziv_Dijagnoze;
    }
}