namespace Datenbanken_V2
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
            this.Button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nachnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arbeitszeitGesamtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mitarbeiterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblmitarbeiterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datenbank_ZeiterfassungDataSet = new Datenbanken_V2.Datenbank_ZeiterfassungDataSet();
            this.tbl_mitarbeiterTableAdapter = new Datenbanken_V2.Datenbank_ZeiterfassungDataSetTableAdapters.tbl_mitarbeiterTableAdapter();
            this.ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Nachname = new System.Windows.Forms.TextBox();
            this.Vorname = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmitarbeiterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datenbank_ZeiterfassungDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(0, 0);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(244, 131);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "Messagebox ausgabe Mitarbeiter";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nachnameDataGridViewTextBoxColumn,
            this.vornameDataGridViewTextBoxColumn,
            this.arbeitszeitGesamtDataGridViewTextBoxColumn,
            this.mitarbeiterIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblmitarbeiterBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(250, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1531, 437);
            this.dataGridView1.TabIndex = 1;
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
            // 
            // tblmitarbeiterBindingSource
            // 
            this.tblmitarbeiterBindingSource.DataMember = "tbl_mitarbeiter";
            this.tblmitarbeiterBindingSource.DataSource = this.datenbank_ZeiterfassungDataSet;
            // 
            // datenbank_ZeiterfassungDataSet
            // 
            this.datenbank_ZeiterfassungDataSet.DataSetName = "Datenbank_ZeiterfassungDataSet";
            this.datenbank_ZeiterfassungDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_mitarbeiterTableAdapter
            // 
            this.tbl_mitarbeiterTableAdapter.ClearBeforeFill = true;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(210, 461);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(265, 31);
            this.ID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 497);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nachname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 531);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vorname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 567);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Arbeitzeit gesamt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 608);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "MitarbeiterID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Einfügen der Personen";
            // 
            // Nachname
            // 
            this.Nachname.Location = new System.Drawing.Point(210, 498);
            this.Nachname.Name = "Nachname";
            this.Nachname.Size = new System.Drawing.Size(265, 31);
            this.Nachname.TabIndex = 9;
            // 
            // Vorname
            // 
            this.Vorname.Location = new System.Drawing.Point(210, 535);
            this.Vorname.Name = "Vorname";
            this.Vorname.Size = new System.Drawing.Size(265, 31);
            this.Vorname.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(210, 572);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(265, 31);
            this.textBox4.TabIndex = 11;
            this.textBox4.Text = "Keine Eingabe erforderlich";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(210, 609);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(265, 31);
            this.textBox5.TabIndex = 12;
            this.textBox5.Text = "Keine Eingabe erforderlich";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 646);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(458, 44);
            this.button2.TabIndex = 13;
            this.button2.Text = "Absenden";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1905, 730);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Vorname);
            this.Controls.Add(this.Nachname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmitarbeiterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datenbank_ZeiterfassungDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Datenbank_ZeiterfassungDataSet datenbank_ZeiterfassungDataSet;
        private System.Windows.Forms.BindingSource tblmitarbeiterBindingSource;
        private Datenbank_ZeiterfassungDataSetTableAdapters.tbl_mitarbeiterTableAdapter tbl_mitarbeiterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nachnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arbeitszeitGesamtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mitarbeiterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Nachname;
        private System.Windows.Forms.TextBox Vorname;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button2;
    }
}

