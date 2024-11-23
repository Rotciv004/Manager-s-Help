namespace Manager_s_Help
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_Creaza_cont_nou = new System.Windows.Forms.Button();
            this.confirmare_parolatextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.parolatextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numetextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button_Conectare = new System.Windows.Forms.Button();
            this.button_Deconectare = new System.Windows.Forms.Button();
            this.textBox_Parola = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_Nr_curent = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePicker_Data_expirarii = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Data_achizitionarii = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Stergere = new System.Windows.Forms.ComboBox();
            this.listView_Obiecte = new System.Windows.Forms.ListView();
            this.Nr_crt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nume_obiect = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantitate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Valoare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data_achizitionarii = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data_expirarii = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nr_inventar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_Adauga = new System.Windows.Forms.Button();
            this.textBox_Nr_inventar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button_Sterge = new System.Windows.Forms.Button();
            this.textBox_Valoare = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_Cantitate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_Denumire_obiect = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.databaseDataSet = new Manager_s_Help.DatabaseDataSet();
            this.pERSOANEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pERSOANETableAdapter = new Manager_s_Help.DatabaseDataSetTableAdapters.PERSOANETableAdapter();
            this.oBIECTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oBIECTETableAdapter = new Manager_s_Help.DatabaseDataSetTableAdapters.OBIECTETableAdapter();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSOANEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oBIECTEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1390, 508);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::Manager_s_Help.Properties.Resources.LOGO;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1382, 479);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Acasa";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(295, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(659, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Am crea aceasta aplicatie pentru toti cei care doresc s[ administreze un spatiu m" +
    "ult mai simplu si mult mai usor.";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::Manager_s_Help.Properties.Resources.LOGO;
            this.tabPage2.Controls.Add(this.button_Creaza_cont_nou);
            this.tabPage2.Controls.Add(this.confirmare_parolatextBox);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.parolatextBox);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.emailtextBox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.numetextBox);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1382, 479);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Creaza cont";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_Creaza_cont_nou
            // 
            this.button_Creaza_cont_nou.Location = new System.Drawing.Point(332, 140);
            this.button_Creaza_cont_nou.Name = "button_Creaza_cont_nou";
            this.button_Creaza_cont_nou.Size = new System.Drawing.Size(116, 23);
            this.button_Creaza_cont_nou.TabIndex = 8;
            this.button_Creaza_cont_nou.Text = "Creaza cont nou";
            this.button_Creaza_cont_nou.UseVisualStyleBackColor = true;
            this.button_Creaza_cont_nou.Click += new System.EventHandler(this.button_Creaza_cont_nou_Click);
            // 
            // confirmare_parolatextBox
            // 
            this.confirmare_parolatextBox.Location = new System.Drawing.Point(129, 112);
            this.confirmare_parolatextBox.Name = "confirmare_parolatextBox";
            this.confirmare_parolatextBox.Size = new System.Drawing.Size(319, 22);
            this.confirmare_parolatextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(3, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Confirmare parola:";
            // 
            // parolatextBox
            // 
            this.parolatextBox.Location = new System.Drawing.Point(129, 84);
            this.parolatextBox.Name = "parolatextBox";
            this.parolatextBox.Size = new System.Drawing.Size(319, 22);
            this.parolatextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(73, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Parola:";
            // 
            // emailtextBox
            // 
            this.emailtextBox.Location = new System.Drawing.Point(129, 56);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(319, 22);
            this.emailtextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(79, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // numetextBox
            // 
            this.numetextBox.Location = new System.Drawing.Point(129, 28);
            this.numetextBox.Name = "numetextBox";
            this.numetextBox.Size = new System.Drawing.Size(319, 22);
            this.numetextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(77, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nume:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::Manager_s_Help.Properties.Resources.LOGO;
            this.tabPage3.Controls.Add(this.button_Conectare);
            this.tabPage3.Controls.Add(this.button_Deconectare);
            this.tabPage3.Controls.Add(this.textBox_Parola);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.textBox_Email);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1382, 479);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Conectare";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // button_Conectare
            // 
            this.button_Conectare.Location = new System.Drawing.Point(184, 84);
            this.button_Conectare.Name = "button_Conectare";
            this.button_Conectare.Size = new System.Drawing.Size(98, 23);
            this.button_Conectare.TabIndex = 18;
            this.button_Conectare.Text = "Conectare";
            this.button_Conectare.UseVisualStyleBackColor = true;
            this.button_Conectare.Click += new System.EventHandler(this.button_Conectare_Click);
            // 
            // button_Deconectare
            // 
            this.button_Deconectare.Location = new System.Drawing.Point(288, 84);
            this.button_Deconectare.Name = "button_Deconectare";
            this.button_Deconectare.Size = new System.Drawing.Size(93, 23);
            this.button_Deconectare.TabIndex = 17;
            this.button_Deconectare.Text = "Deconectare";
            this.button_Deconectare.UseVisualStyleBackColor = true;
            this.button_Deconectare.Click += new System.EventHandler(this.button_Deconectare_Click);
            // 
            // textBox_Parola
            // 
            this.textBox_Parola.Location = new System.Drawing.Point(62, 56);
            this.textBox_Parola.Name = "textBox_Parola";
            this.textBox_Parola.Size = new System.Drawing.Size(319, 22);
            this.textBox_Parola.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(6, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Parola:";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(62, 28);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(319, 22);
            this.textBox_Email.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(12, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Email:";
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = global::Manager_s_Help.Properties.Resources.LOGO;
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.textBox_Nr_curent);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.dateTimePicker_Data_expirarii);
            this.tabPage4.Controls.Add(this.dateTimePicker_Data_achizitionarii);
            this.tabPage4.Controls.Add(this.comboBox_Stergere);
            this.tabPage4.Controls.Add(this.listView_Obiecte);
            this.tabPage4.Controls.Add(this.button_Adauga);
            this.tabPage4.Controls.Add(this.textBox_Nr_inventar);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.button_Sterge);
            this.tabPage4.Controls.Add(this.textBox_Valoare);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.textBox_Cantitate);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.textBox_Denumire_obiect);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1382, 479);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Administrare";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(9, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 16);
            this.label15.TabIndex = 34;
            // 
            // textBox_Nr_curent
            // 
            this.textBox_Nr_curent.Location = new System.Drawing.Point(130, 20);
            this.textBox_Nr_curent.Name = "textBox_Nr_curent";
            this.textBox_Nr_curent.Size = new System.Drawing.Size(319, 22);
            this.textBox_Nr_curent.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(50, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 16);
            this.label14.TabIndex = 32;
            this.label14.Text = "Nr. curent:";
            // 
            // dateTimePicker_Data_expirarii
            // 
            this.dateTimePicker_Data_expirarii.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Data_expirarii.Location = new System.Drawing.Point(130, 160);
            this.dateTimePicker_Data_expirarii.Name = "dateTimePicker_Data_expirarii";
            this.dateTimePicker_Data_expirarii.Size = new System.Drawing.Size(319, 22);
            this.dateTimePicker_Data_expirarii.TabIndex = 30;
            // 
            // dateTimePicker_Data_achizitionarii
            // 
            this.dateTimePicker_Data_achizitionarii.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Data_achizitionarii.Location = new System.Drawing.Point(130, 132);
            this.dateTimePicker_Data_achizitionarii.Name = "dateTimePicker_Data_achizitionarii";
            this.dateTimePicker_Data_achizitionarii.Size = new System.Drawing.Size(319, 22);
            this.dateTimePicker_Data_achizitionarii.TabIndex = 29;
            // 
            // comboBox_Stergere
            // 
            this.comboBox_Stergere.FormattingEnabled = true;
            this.comboBox_Stergere.Location = new System.Drawing.Point(12, 253);
            this.comboBox_Stergere.Name = "comboBox_Stergere";
            this.comboBox_Stergere.Size = new System.Drawing.Size(195, 24);
            this.comboBox_Stergere.TabIndex = 28;
            this.comboBox_Stergere.SelectedIndexChanged += new System.EventHandler(this.comboBox_Stergere_SelectedIndexChanged);
            // 
            // listView_Obiecte
            // 
            this.listView_Obiecte.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nr_crt,
            this.Nume_obiect,
            this.Cantitate,
            this.Valoare,
            this.Data_achizitionarii,
            this.Data_expirarii,
            this.Nr_inventar});
            this.listView_Obiecte.HideSelection = false;
            this.listView_Obiecte.Location = new System.Drawing.Point(455, 18);
            this.listView_Obiecte.Name = "listView_Obiecte";
            this.listView_Obiecte.Size = new System.Drawing.Size(918, 434);
            this.listView_Obiecte.TabIndex = 23;
            this.listView_Obiecte.UseCompatibleStateImageBehavior = false;
            this.listView_Obiecte.View = System.Windows.Forms.View.Details;
            // 
            // Nr_crt
            // 
            this.Nr_crt.Text = "Nr.Ctr.";
            this.Nr_crt.Width = 70;
            // 
            // Nume_obiect
            // 
            this.Nume_obiect.Text = "Nume obiect";
            this.Nume_obiect.Width = 213;
            // 
            // Cantitate
            // 
            this.Cantitate.Text = "Cantitate";
            this.Cantitate.Width = 127;
            // 
            // Valoare
            // 
            this.Valoare.Text = "Valoare";
            this.Valoare.Width = 130;
            // 
            // Data_achizitionarii
            // 
            this.Data_achizitionarii.Text = "Data achizitionarii";
            this.Data_achizitionarii.Width = 144;
            // 
            // Data_expirarii
            // 
            this.Data_expirarii.Text = "Data expirarii";
            this.Data_expirarii.Width = 118;
            // 
            // Nr_inventar
            // 
            this.Nr_inventar.Text = "Nr. inventar";
            this.Nr_inventar.Width = 105;
            // 
            // button_Adauga
            // 
            this.button_Adauga.Location = new System.Drawing.Point(374, 254);
            this.button_Adauga.Name = "button_Adauga";
            this.button_Adauga.Size = new System.Drawing.Size(75, 23);
            this.button_Adauga.TabIndex = 22;
            this.button_Adauga.Text = "Adauga";
            this.button_Adauga.UseVisualStyleBackColor = true;
            this.button_Adauga.Click += new System.EventHandler(this.button_Adauga_Click);
            // 
            // textBox_Nr_inventar
            // 
            this.textBox_Nr_inventar.Location = new System.Drawing.Point(130, 188);
            this.textBox_Nr_inventar.Name = "textBox_Nr_inventar";
            this.textBox_Nr_inventar.Size = new System.Drawing.Size(319, 22);
            this.textBox_Nr_inventar.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(50, 191);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 16);
            this.label12.TabIndex = 20;
            this.label12.Text = "Nr inventar:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(35, 163);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 16);
            this.label13.TabIndex = 18;
            this.label13.Text = "Data expirarii:";
            // 
            // button_Sterge
            // 
            this.button_Sterge.Location = new System.Drawing.Point(223, 254);
            this.button_Sterge.Name = "button_Sterge";
            this.button_Sterge.Size = new System.Drawing.Size(75, 23);
            this.button_Sterge.TabIndex = 17;
            this.button_Sterge.Text = "Sterge";
            this.button_Sterge.UseVisualStyleBackColor = true;
            this.button_Sterge.Click += new System.EventHandler(this.button_Sterge_Click);
            // 
            // textBox_Valoare
            // 
            this.textBox_Valoare.Location = new System.Drawing.Point(130, 104);
            this.textBox_Valoare.Name = "textBox_Valoare";
            this.textBox_Valoare.Size = new System.Drawing.Size(319, 22);
            this.textBox_Valoare.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(9, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Data achizitionarii:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(9, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Valoare / buc (lei):";
            // 
            // textBox_Cantitate
            // 
            this.textBox_Cantitate.Location = new System.Drawing.Point(130, 76);
            this.textBox_Cantitate.Name = "textBox_Cantitate";
            this.textBox_Cantitate.Size = new System.Drawing.Size(319, 22);
            this.textBox_Cantitate.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(55, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Cantitate:";
            // 
            // textBox_Denumire_obiect
            // 
            this.textBox_Denumire_obiect.Location = new System.Drawing.Point(130, 48);
            this.textBox_Denumire_obiect.Name = "textBox_Denumire_obiect";
            this.textBox_Denumire_obiect.Size = new System.Drawing.Size(319, 22);
            this.textBox_Denumire_obiect.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(9, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 16);
            this.label11.TabIndex = 9;
            this.label11.Text = "Denumire obiect:";
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pERSOANEBindingSource
            // 
            this.pERSOANEBindingSource.DataMember = "PERSOANE";
            this.pERSOANEBindingSource.DataSource = this.databaseDataSet;
            // 
            // pERSOANETableAdapter
            // 
            this.pERSOANETableAdapter.ClearBeforeFill = true;
            // 
            // oBIECTEBindingSource
            // 
            this.oBIECTEBindingSource.DataMember = "OBIECTE";
            this.oBIECTEBindingSource.DataSource = this.databaseDataSet;
            // 
            // oBIECTETableAdapter
            // 
            this.oBIECTETableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 532);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSOANEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oBIECTEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource pERSOANEBindingSource;
        private DatabaseDataSetTableAdapters.PERSOANETableAdapter pERSOANETableAdapter;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Creaza_cont_nou;
        private System.Windows.Forms.TextBox confirmare_parolatextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox parolatextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numetextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Conectare;
        private System.Windows.Forms.Button button_Deconectare;
        private System.Windows.Forms.TextBox textBox_Parola;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_Adauga;
        private System.Windows.Forms.TextBox textBox_Nr_inventar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button_Sterge;
        private System.Windows.Forms.TextBox textBox_Valoare;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_Cantitate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_Denumire_obiect;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView listView_Obiecte;
        private System.Windows.Forms.ColumnHeader Nr_crt;
        private System.Windows.Forms.ColumnHeader Nume_obiect;
        private System.Windows.Forms.ColumnHeader Cantitate;
        private System.Windows.Forms.ColumnHeader Valoare;
        private System.Windows.Forms.ColumnHeader Data_achizitionarii;
        private System.Windows.Forms.ColumnHeader Data_expirarii;
        private System.Windows.Forms.ColumnHeader Nr_inventar;
        private System.Windows.Forms.ComboBox comboBox_Stergere;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Data_expirarii;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Data_achizitionarii;
        private System.Windows.Forms.TextBox textBox_Nr_curent;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.BindingSource oBIECTEBindingSource;
        private DatabaseDataSetTableAdapters.OBIECTETableAdapter oBIECTETableAdapter;
    }
}

