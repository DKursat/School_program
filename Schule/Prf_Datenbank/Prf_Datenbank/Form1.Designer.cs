namespace Prf_Datenbank
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strasseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kundenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._DB_Beispiel_BuchDataSet = new Prf_Datenbank._DB_Beispiel_BuchDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.kundenTableAdapter = new Prf_Datenbank._DB_Beispiel_BuchDataSetTableAdapters.KundenTableAdapter();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DB_Beispiel_BuchDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.strasseDataGridViewTextBoxColumn,
            this.ortDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kundenBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(205, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(948, 304);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 200;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // strasseDataGridViewTextBoxColumn
            // 
            this.strasseDataGridViewTextBoxColumn.DataPropertyName = "Strasse";
            this.strasseDataGridViewTextBoxColumn.HeaderText = "Strasse";
            this.strasseDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.strasseDataGridViewTextBoxColumn.Name = "strasseDataGridViewTextBoxColumn";
            this.strasseDataGridViewTextBoxColumn.Width = 200;
            // 
            // ortDataGridViewTextBoxColumn
            // 
            this.ortDataGridViewTextBoxColumn.DataPropertyName = "Ort";
            this.ortDataGridViewTextBoxColumn.HeaderText = "Ort";
            this.ortDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.ortDataGridViewTextBoxColumn.Name = "ortDataGridViewTextBoxColumn";
            this.ortDataGridViewTextBoxColumn.Width = 200;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.Width = 200;
            // 
            // kundenBindingSource
            // 
            this.kundenBindingSource.DataMember = "Kunden";
            this.kundenBindingSource.DataSource = this._DB_Beispiel_BuchDataSet;
            // 
            // _DB_Beispiel_BuchDataSet
            // 
            this._DB_Beispiel_BuchDataSet.DataSetName = "_DB_Beispiel_BuchDataSet";
            this._DB_Beispiel_BuchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 149);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tabelle Kunden in MessageBoxen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 149);
            this.button2.TabIndex = 2;
            this.button2.Text = "Tabelle Kunden in ListView anzeigen";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 322);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 147);
            this.button3.TabIndex = 3;
            this.button3.Text = "Feste Person in der Tabelle Kunden";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 480);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(187, 366);
            this.button4.TabIndex = 4;
            this.button4.Text = "Variable Person in der Tabelle Kunden speichern";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(205, 322);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(187, 147);
            this.button5.TabIndex = 5;
            this.button5.Text = "Feste Person in der Tabelle kunden löschen";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(398, 322);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(187, 146);
            this.button6.TabIndex = 6;
            this.button6.Text = "Variable Person Daten ändern";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(398, 480);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(187, 366);
            this.button7.TabIndex = 7;
            this.button7.Text = "Variable Person in der Tabelle Kunden löschen";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1159, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(180, 147);
            this.button8.TabIndex = 8;
            this.button8.Text = "Kunden aus einem Ort in ListView";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1159, 249);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(182, 146);
            this.button9.TabIndex = 9;
            this.button9.Text = "Kunden aus einem Ort in ListView";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(205, 510);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(187, 45);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(205, 603);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(187, 45);
            this.richTextBox2.TabIndex = 11;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(205, 695);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(187, 45);
            this.richTextBox3.TabIndex = 12;
            this.richTextBox3.Text = "";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(205, 780);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(187, 45);
            this.richTextBox4.TabIndex = 13;
            this.richTextBox4.Text = "";
            // 
            // richTextBox5
            // 
            this.richTextBox5.Location = new System.Drawing.Point(591, 510);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(187, 45);
            this.richTextBox5.TabIndex = 14;
            this.richTextBox5.Text = "";
            // 
            // richTextBox6
            // 
            this.richTextBox6.Location = new System.Drawing.Point(1159, 198);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(180, 45);
            this.richTextBox6.TabIndex = 15;
            this.richTextBox6.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1159, 426);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 33);
            this.comboBox1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 482);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 575);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Straße";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 667);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ort";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 752);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(592, 484);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1154, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "gesuchter Ort";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1154, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "gesuchter Ort(CB)";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(935, 350);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(165, 29);
            this.radioButton1.TabIndex = 24;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Kamp-Linfort";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.Form1_Load);
            // 
            // kundenTableAdapter
            // 
            this.kundenTableAdapter.ClearBeforeFill = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(935, 381);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(103, 29);
            this.radioButton2.TabIndex = 25;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Moers";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(935, 416);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(213, 29);
            this.radioButton3.TabIndex = 26;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Neukirchen-Vluyn";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(935, 451);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(142, 29);
            this.radioButton4.TabIndex = 27;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Rheinberg";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(930, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 25);
            this.label8.TabIndex = 28;
            this.label8.Text = "Ortswahl";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(1100, 667);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(243, 88);
            this.button10.TabIndex = 29;
            this.button10.Text = "Datenbanverbinden";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(1100, 758);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(243, 88);
            this.button11.TabIndex = 30;
            this.button11.Text = "Datenbankverbindung abbrechen";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 858);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.richTextBox6);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._DB_Beispiel_BuchDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton1;
        private _DB_Beispiel_BuchDataSet _DB_Beispiel_BuchDataSet;
        private System.Windows.Forms.BindingSource kundenBindingSource;
        private _DB_Beispiel_BuchDataSetTableAdapters.KundenTableAdapter kundenTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strasseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
    }
}

