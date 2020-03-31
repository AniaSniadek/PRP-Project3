namespace Projekt_bazodanowy
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PobierzTrener = new System.Windows.Forms.Button();
            this.DodajTrenera = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PobierzZespol = new System.Windows.Forms.Button();
            this.PobierzPrezes = new System.Windows.Forms.Button();
            this.PobierzHale = new System.Windows.Forms.Button();
            this.PobierzZawodnik = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.EdytujTrenera = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UsunTrenera = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.DodajZawodnika = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.EdytujZawodnika = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.UsunZawodnika = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(478, 285);
            this.dataGridView1.TabIndex = 6;
            // 
            // PobierzTrener
            // 
            this.PobierzTrener.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.064F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PobierzTrener.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PobierzTrener.Location = new System.Drawing.Point(834, 131);
            this.PobierzTrener.Name = "PobierzTrener";
            this.PobierzTrener.Size = new System.Drawing.Size(166, 33);
            this.PobierzTrener.TabIndex = 7;
            this.PobierzTrener.Text = "Wyświetl Trenerów";
            this.PobierzTrener.UseVisualStyleBackColor = true;
            this.PobierzTrener.Click += new System.EventHandler(this.PobierzTrener_Click);
            // 
            // DodajTrenera
            // 
            this.DodajTrenera.Font = new System.Drawing.Font("Lucida Console", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DodajTrenera.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.DodajTrenera.Location = new System.Drawing.Point(133, 129);
            this.DodajTrenera.Name = "DodajTrenera";
            this.DodajTrenera.Size = new System.Drawing.Size(104, 31);
            this.DodajTrenera.TabIndex = 8;
            this.DodajTrenera.Text = "Dodaj";
            this.DodajTrenera.UseVisualStyleBackColor = true;
            this.DodajTrenera.Click += new System.EventHandler(this.DodajTrenera_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.DodajTrenera);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Console", 9.792F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 323);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 187);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj Trenera";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Lucida Console", 8.064F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(133, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(142, 21);
            this.textBox2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(22, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nazwisko:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(22, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Id:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Lucida Console", 8.064F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(133, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 21);
            this.textBox1.TabIndex = 9;
            // 
            // PobierzZespol
            // 
            this.PobierzZespol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.064F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PobierzZespol.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PobierzZespol.Location = new System.Drawing.Point(833, 22);
            this.PobierzZespol.Name = "PobierzZespol";
            this.PobierzZespol.Size = new System.Drawing.Size(166, 33);
            this.PobierzZespol.TabIndex = 10;
            this.PobierzZespol.Text = "Wyświetl Zespół";
            this.PobierzZespol.UseVisualStyleBackColor = true;
            this.PobierzZespol.Click += new System.EventHandler(this.PobierzZespol_Click);
            // 
            // PobierzPrezes
            // 
            this.PobierzPrezes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.064F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PobierzPrezes.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PobierzPrezes.Location = new System.Drawing.Point(833, 75);
            this.PobierzPrezes.Name = "PobierzPrezes";
            this.PobierzPrezes.Size = new System.Drawing.Size(167, 33);
            this.PobierzPrezes.TabIndex = 11;
            this.PobierzPrezes.Text = "Wyświetl Prezesa";
            this.PobierzPrezes.UseVisualStyleBackColor = true;
            this.PobierzPrezes.Click += new System.EventHandler(this.PobierzPrezes_Click);
            // 
            // PobierzHale
            // 
            this.PobierzHale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.064F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PobierzHale.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PobierzHale.Location = new System.Drawing.Point(834, 186);
            this.PobierzHale.Name = "PobierzHale";
            this.PobierzHale.Size = new System.Drawing.Size(167, 33);
            this.PobierzHale.TabIndex = 12;
            this.PobierzHale.Text = "Wyświetl Hale";
            this.PobierzHale.UseVisualStyleBackColor = true;
            this.PobierzHale.Click += new System.EventHandler(this.PobierzHale_Click);
            // 
            // PobierzZawodnik
            // 
            this.PobierzZawodnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.064F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PobierzZawodnik.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PobierzZawodnik.Location = new System.Drawing.Point(834, 249);
            this.PobierzZawodnik.Name = "PobierzZawodnik";
            this.PobierzZawodnik.Size = new System.Drawing.Size(167, 33);
            this.PobierzZawodnik.TabIndex = 13;
            this.PobierzZawodnik.Text = "Wyświetl Zawodników";
            this.PobierzZawodnik.UseVisualStyleBackColor = true;
            this.PobierzZawodnik.Click += new System.EventHandler(this.PobierzZawodnik_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.EdytujTrenera);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Console", 9.792F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(400, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 187);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edytuj Trenera";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Lucida Console", 8.064F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox3.Location = new System.Drawing.Point(133, 39);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(142, 21);
            this.textBox3.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(22, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nazwisko:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(22, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Id:";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Lucida Console", 8.064F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox4.Location = new System.Drawing.Point(133, 77);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(142, 21);
            this.textBox4.TabIndex = 9;
            // 
            // EdytujTrenera
            // 
            this.EdytujTrenera.Font = new System.Drawing.Font("Lucida Console", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EdytujTrenera.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.EdytujTrenera.Location = new System.Drawing.Point(133, 129);
            this.EdytujTrenera.Name = "EdytujTrenera";
            this.EdytujTrenera.Size = new System.Drawing.Size(104, 31);
            this.EdytujTrenera.TabIndex = 8;
            this.EdytujTrenera.Text = "Edytuj";
            this.EdytujTrenera.UseVisualStyleBackColor = true;
            this.EdytujTrenera.Click += new System.EventHandler(this.EdytujTrenera_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.UsunTrenera);
            this.groupBox3.Font = new System.Drawing.Font("Lucida Console", 9.792F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(791, 347);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 145);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Usuń Trenera";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Lucida Console", 8.064F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox5.Location = new System.Drawing.Point(66, 41);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(142, 21);
            this.textBox5.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Console", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(22, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Id:";
            // 
            // UsunTrenera
            // 
            this.UsunTrenera.Font = new System.Drawing.Font("Lucida Console", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UsunTrenera.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.UsunTrenera.Location = new System.Drawing.Point(79, 89);
            this.UsunTrenera.Name = "UsunTrenera";
            this.UsunTrenera.Size = new System.Drawing.Size(104, 31);
            this.UsunTrenera.TabIndex = 8;
            this.UsunTrenera.Text = "Usuń";
            this.UsunTrenera.UseVisualStyleBackColor = true;
            this.UsunTrenera.Click += new System.EventHandler(this.UsunTrenera_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox9);
            this.groupBox4.Controls.Add(this.textBox8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.textBox6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.textBox7);
            this.groupBox4.Controls.Add(this.DodajZawodnika);
            this.groupBox4.Font = new System.Drawing.Font("Lucida Console", 9.792F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox4.Location = new System.Drawing.Point(12, 533);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(357, 259);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dodaj Zawodnika";
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Lucida Console", 8.064F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox9.Location = new System.Drawing.Point(198, 159);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(142, 21);
            this.textBox9.TabIndex = 16;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Lucida Console", 8.064F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox8.Location = new System.Drawing.Point(198, 118);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(142, 21);
            this.textBox8.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Console", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label9.Location = new System.Drawing.Point(22, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Data urodzenia:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Console", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label8.Location = new System.Drawing.Point(22, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Numer:";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Lucida Console", 8.064F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox6.Location = new System.Drawing.Point(198, 41);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(142, 21);
            this.textBox6.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(22, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nazwisko:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Console", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(22, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Id:";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Lucida Console", 8.064F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox7.Location = new System.Drawing.Point(198, 79);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(142, 21);
            this.textBox7.TabIndex = 9;
            // 
            // DodajZawodnika
            // 
            this.DodajZawodnika.Font = new System.Drawing.Font("Lucida Console", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DodajZawodnika.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.DodajZawodnika.Location = new System.Drawing.Point(133, 208);
            this.DodajZawodnika.Name = "DodajZawodnika";
            this.DodajZawodnika.Size = new System.Drawing.Size(104, 31);
            this.DodajZawodnika.TabIndex = 8;
            this.DodajZawodnika.Text = "Dodaj";
            this.DodajZawodnika.UseVisualStyleBackColor = true;
            this.DodajZawodnika.Click += new System.EventHandler(this.DodajZawodnika_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox10);
            this.groupBox5.Controls.Add(this.textBox11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.textBox12);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.textBox13);
            this.groupBox5.Controls.Add(this.EdytujZawodnika);
            this.groupBox5.Font = new System.Drawing.Font("Lucida Console", 9.792F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox5.Location = new System.Drawing.Point(400, 533);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(357, 259);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Edytuj Zawodnika";
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Lucida Console", 8.064F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox10.Location = new System.Drawing.Point(198, 159);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(142, 21);
            this.textBox10.TabIndex = 16;
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Lucida Console", 8.064F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox11.Location = new System.Drawing.Point(198, 118);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(142, 21);
            this.textBox11.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Console", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label10.Location = new System.Drawing.Point(22, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Data urodzenia:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Console", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label11.Location = new System.Drawing.Point(22, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Numer:";
            // 
            // textBox12
            // 
            this.textBox12.Font = new System.Drawing.Font("Lucida Console", 8.064F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox12.Location = new System.Drawing.Point(198, 41);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(142, 21);
            this.textBox12.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Console", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(22, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "Nazwisko:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Console", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label13.Location = new System.Drawing.Point(22, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 16);
            this.label13.TabIndex = 10;
            this.label13.Text = "Id:";
            // 
            // textBox13
            // 
            this.textBox13.Font = new System.Drawing.Font("Lucida Console", 8.064F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox13.Location = new System.Drawing.Point(198, 79);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(142, 21);
            this.textBox13.TabIndex = 9;
            // 
            // EdytujZawodnika
            // 
            this.EdytujZawodnika.Font = new System.Drawing.Font("Lucida Console", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EdytujZawodnika.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.EdytujZawodnika.Location = new System.Drawing.Point(133, 208);
            this.EdytujZawodnika.Name = "EdytujZawodnika";
            this.EdytujZawodnika.Size = new System.Drawing.Size(104, 31);
            this.EdytujZawodnika.TabIndex = 8;
            this.EdytujZawodnika.Text = "Edytuj";
            this.EdytujZawodnika.UseVisualStyleBackColor = true;
            this.EdytujZawodnika.Click += new System.EventHandler(this.EdytujZawodnika_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox14);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.UsunZawodnika);
            this.groupBox6.Font = new System.Drawing.Font("Lucida Console", 9.792F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox6.Location = new System.Drawing.Point(791, 587);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(253, 145);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Usuń Zawodnika";
            // 
            // textBox14
            // 
            this.textBox14.Font = new System.Drawing.Font("Lucida Console", 8.064F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox14.Location = new System.Drawing.Point(66, 41);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(142, 21);
            this.textBox14.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Console", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label14.Location = new System.Drawing.Point(22, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 16);
            this.label14.TabIndex = 10;
            this.label14.Text = "Id:";
            // 
            // UsunZawodnika
            // 
            this.UsunZawodnika.Font = new System.Drawing.Font("Lucida Console", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UsunZawodnika.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.UsunZawodnika.Location = new System.Drawing.Point(79, 89);
            this.UsunZawodnika.Name = "UsunZawodnika";
            this.UsunZawodnika.Size = new System.Drawing.Size(104, 31);
            this.UsunZawodnika.TabIndex = 8;
            this.UsunZawodnika.Text = "Usuń";
            this.UsunZawodnika.UseVisualStyleBackColor = true;
            this.UsunZawodnika.Click += new System.EventHandler(this.UsunZawodnika_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(686, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 20);
            this.label15.TabIndex = 19;
            this.label15.Text = "ilość";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(514, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(166, 20);
            this.label16.TabIndex = 20;
            this.label16.Text = "Liczba elementów:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1057, 800);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.PobierzZawodnik);
            this.Controls.Add(this.PobierzHale);
            this.Controls.Add(this.PobierzPrezes);
            this.Controls.Add(this.PobierzZespol);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PobierzTrener);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "REST API";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button PobierzTrener;
        private System.Windows.Forms.Button DodajTrenera;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button PobierzZespol;
        private System.Windows.Forms.Button PobierzPrezes;
        private System.Windows.Forms.Button PobierzHale;
        private System.Windows.Forms.Button PobierzZawodnik;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button EdytujTrenera;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button UsunTrenera;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button DodajZawodnika;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Button EdytujZawodnika;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button UsunZawodnika;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}

