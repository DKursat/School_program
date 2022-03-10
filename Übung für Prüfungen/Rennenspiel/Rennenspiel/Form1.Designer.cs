
namespace Rennenspiel
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_auto_eins = new System.Windows.Forms.Label();
            this.label_auto_zwei = new System.Windows.Forms.Label();
            this.auto_eins_text = new System.Windows.Forms.TextBox();
            this.auto_zwei_text = new System.Windows.Forms.TextBox();
            this.auto_eins_farbe = new System.Windows.Forms.TextBox();
            this.auto_zwei_farbe = new System.Windows.Forms.TextBox();
            this.auto_eins_geschwindigkeit = new System.Windows.Forms.TextBox();
            this.auto_zwei_geschwindigkeit = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Gewinner = new System.Windows.Forms.Label();
            this.berechnen = new System.Windows.Forms.Button();
            this.nullaufhunderteins = new System.Windows.Forms.Label();
            this.nullaufhundertzwei = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kandidat 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kandidat 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Auto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Auto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Farbe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Farbe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Von 0 auf 100 km/h";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(182, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Von 0 auf 100 km/h";
            // 
            // label_auto_eins
            // 
            this.label_auto_eins.AutoSize = true;
            this.label_auto_eins.Location = new System.Drawing.Point(56, 255);
            this.label_auto_eins.Name = "label_auto_eins";
            this.label_auto_eins.Size = new System.Drawing.Size(58, 13);
            this.label_auto_eins.TabIndex = 8;
            this.label_auto_eins.Text = "Kandidat 1";
            // 
            // label_auto_zwei
            // 
            this.label_auto_zwei.AutoSize = true;
            this.label_auto_zwei.Location = new System.Drawing.Point(182, 255);
            this.label_auto_zwei.Name = "label_auto_zwei";
            this.label_auto_zwei.Size = new System.Drawing.Size(58, 13);
            this.label_auto_zwei.TabIndex = 9;
            this.label_auto_zwei.Text = "Kandidat 2";
            // 
            // auto_eins_text
            // 
            this.auto_eins_text.Location = new System.Drawing.Point(12, 48);
            this.auto_eins_text.Name = "auto_eins_text";
            this.auto_eins_text.Size = new System.Drawing.Size(92, 20);
            this.auto_eins_text.TabIndex = 10;
            this.auto_eins_text.TextChanged += new System.EventHandler(this.auto_eins_text_TextChanged);
            // 
            // auto_zwei_text
            // 
            this.auto_zwei_text.Location = new System.Drawing.Point(185, 48);
            this.auto_zwei_text.Name = "auto_zwei_text";
            this.auto_zwei_text.Size = new System.Drawing.Size(92, 20);
            this.auto_zwei_text.TabIndex = 11;
            // 
            // auto_eins_farbe
            // 
            this.auto_eins_farbe.Location = new System.Drawing.Point(12, 99);
            this.auto_eins_farbe.Name = "auto_eins_farbe";
            this.auto_eins_farbe.Size = new System.Drawing.Size(92, 20);
            this.auto_eins_farbe.TabIndex = 12;
            // 
            // auto_zwei_farbe
            // 
            this.auto_zwei_farbe.Location = new System.Drawing.Point(185, 99);
            this.auto_zwei_farbe.Name = "auto_zwei_farbe";
            this.auto_zwei_farbe.Size = new System.Drawing.Size(92, 20);
            this.auto_zwei_farbe.TabIndex = 13;
            // 
            // auto_eins_geschwindigkeit
            // 
            this.auto_eins_geschwindigkeit.Location = new System.Drawing.Point(12, 151);
            this.auto_eins_geschwindigkeit.Name = "auto_eins_geschwindigkeit";
            this.auto_eins_geschwindigkeit.Size = new System.Drawing.Size(92, 20);
            this.auto_eins_geschwindigkeit.TabIndex = 14;
            // 
            // auto_zwei_geschwindigkeit
            // 
            this.auto_zwei_geschwindigkeit.Location = new System.Drawing.Point(185, 151);
            this.auto_zwei_geschwindigkeit.Name = "auto_zwei_geschwindigkeit";
            this.auto_zwei_geschwindigkeit.Size = new System.Drawing.Size(92, 20);
            this.auto_zwei_geschwindigkeit.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(139, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "vs";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(105, 290);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Der Gewinner ist";
            // 
            // Gewinner
            // 
            this.Gewinner.AutoSize = true;
            this.Gewinner.Location = new System.Drawing.Point(119, 320);
            this.Gewinner.Name = "Gewinner";
            this.Gewinner.Size = new System.Drawing.Size(52, 13);
            this.Gewinner.TabIndex = 18;
            this.Gewinner.Text = "Gewinner";
            // 
            // berechnen
            // 
            this.berechnen.Location = new System.Drawing.Point(12, 202);
            this.berechnen.Name = "berechnen";
            this.berechnen.Size = new System.Drawing.Size(92, 23);
            this.berechnen.TabIndex = 19;
            this.berechnen.Text = "Lets go Ahead";
            this.berechnen.UseVisualStyleBackColor = true;
            this.berechnen.Click += new System.EventHandler(this.berechnen_Click);
            // 
            // nullaufhunderteins
            // 
            this.nullaufhunderteins.AutoSize = true;
            this.nullaufhunderteins.Location = new System.Drawing.Point(56, 277);
            this.nullaufhunderteins.Name = "nullaufhunderteins";
            this.nullaufhunderteins.Size = new System.Drawing.Size(74, 13);
            this.nullaufhunderteins.TabIndex = 20;
            this.nullaufhunderteins.Text = "nullaufhundert";
            // 
            // nullaufhundertzwei
            // 
            this.nullaufhundertzwei.AutoSize = true;
            this.nullaufhundertzwei.Location = new System.Drawing.Point(199, 277);
            this.nullaufhundertzwei.Name = "nullaufhundertzwei";
            this.nullaufhundertzwei.Size = new System.Drawing.Size(74, 13);
            this.nullaufhundertzwei.TabIndex = 21;
            this.nullaufhundertzwei.Text = "nullaufhundert";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 380);
            this.Controls.Add(this.nullaufhundertzwei);
            this.Controls.Add(this.nullaufhunderteins);
            this.Controls.Add(this.berechnen);
            this.Controls.Add(this.Gewinner);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.auto_zwei_geschwindigkeit);
            this.Controls.Add(this.auto_eins_geschwindigkeit);
            this.Controls.Add(this.auto_zwei_farbe);
            this.Controls.Add(this.auto_eins_farbe);
            this.Controls.Add(this.auto_zwei_text);
            this.Controls.Add(this.auto_eins_text);
            this.Controls.Add(this.label_auto_zwei);
            this.Controls.Add(this.label_auto_eins);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_auto_eins;
        private System.Windows.Forms.Label label_auto_zwei;
        private System.Windows.Forms.TextBox auto_eins_text;
        private System.Windows.Forms.TextBox auto_zwei_text;
        private System.Windows.Forms.TextBox auto_eins_farbe;
        private System.Windows.Forms.TextBox auto_zwei_farbe;
        private System.Windows.Forms.TextBox auto_eins_geschwindigkeit;
        private System.Windows.Forms.TextBox auto_zwei_geschwindigkeit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label Gewinner;
        private System.Windows.Forms.Button berechnen;
        private System.Windows.Forms.Label nullaufhunderteins;
        private System.Windows.Forms.Label nullaufhundertzwei;
    }
}

