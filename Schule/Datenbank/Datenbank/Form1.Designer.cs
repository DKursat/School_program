namespace Datenbank
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.datenbankZeiterfassungDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblmitarbeiterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nachnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arbeitszeitGesamtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mitarbeiterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datenbankZeiterfassungDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmitarbeiterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 163);
            this.button1.TabIndex = 0;
            this.button1.Text = "Messagebox der Vornamen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tblmitarbeiterBindingSource
            // 
            this.tblmitarbeiterBindingSource.DataMember = "tbl_mitarbeiter";
            this.tblmitarbeiterBindingSource.DataSource = this.datenbankZeiterfassungDataSetBindingSource;
         // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 200;
            // 
            // nachnameDataGridViewTextBoxColumn
            // 
            this.nachnameDataGridViewTextBoxColumn.DataPropertyName = "Nachname";
            this.nachnameDataGridViewTextBoxColumn.HeaderText = "Nachname";
            this.nachnameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nachnameDataGridViewTextBoxColumn.Name = "nachnameDataGridViewTextBoxColumn";
            this.nachnameDataGridViewTextBoxColumn.Width = 200;
            // 
            // vornameDataGridViewTextBoxColumn
            // 
            this.vornameDataGridViewTextBoxColumn.DataPropertyName = "Vorname";
            this.vornameDataGridViewTextBoxColumn.HeaderText = "Vorname";
            this.vornameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.vornameDataGridViewTextBoxColumn.Name = "vornameDataGridViewTextBoxColumn";
            this.vornameDataGridViewTextBoxColumn.Width = 200;
            // 
            // arbeitszeitGesamtDataGridViewTextBoxColumn
            // 
            this.arbeitszeitGesamtDataGridViewTextBoxColumn.DataPropertyName = "Arbeitszeit gesamt";
            this.arbeitszeitGesamtDataGridViewTextBoxColumn.HeaderText = "Arbeitszeit gesamt";
            this.arbeitszeitGesamtDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.arbeitszeitGesamtDataGridViewTextBoxColumn.Name = "arbeitszeitGesamtDataGridViewTextBoxColumn";
            this.arbeitszeitGesamtDataGridViewTextBoxColumn.Width = 200;
            // 
            // mitarbeiterIDDataGridViewTextBoxColumn
            // 
            this.mitarbeiterIDDataGridViewTextBoxColumn.DataPropertyName = "MitarbeiterID";
            this.mitarbeiterIDDataGridViewTextBoxColumn.HeaderText = "MitarbeiterID";
            this.mitarbeiterIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.mitarbeiterIDDataGridViewTextBoxColumn.Name = "mitarbeiterIDDataGridViewTextBoxColumn";
            this.mitarbeiterIDDataGridViewTextBoxColumn.Width = 200;
     
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource datenbankZeiterfassungDataSetBindingSource;
        private System.Windows.Forms.BindingSource tblmitarbeiterBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nachnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arbeitszeitGesamtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mitarbeiterIDDataGridViewTextBoxColumn;
    }
}

