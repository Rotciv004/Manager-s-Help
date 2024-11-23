using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Manager_s_Help
{
    public partial class Form1 : Form
    {
        int idp = -1;

        public bool email()
        {
            this.pERSOANETableAdapter.Email_exista(this.databaseDataSet.PERSOANE, emailtextBox.Text);

            DataTable d = this.databaseDataSet.PERSOANE;


            if (d.Rows.Count != 0)
            {
                MessageBox.Show("Acest email este deja folosit");
                return false;
            }
            return true;
        }

        public bool nume()
        {
            this.pERSOANETableAdapter.Nume_exista(this.databaseDataSet.PERSOANE, numetextBox.Text);

            DataTable d = this.databaseDataSet.PERSOANE;


            if (d.Rows.Count != 0)
            {
                MessageBox.Show("Acest nume este deja folosit");
                return false;
            }
            return true;
        }

        public bool parola()
        {
            this.pERSOANETableAdapter.Parola_exista(this.databaseDataSet.PERSOANE, parolatextBox.Text);

            DataTable d = this.databaseDataSet.PERSOANE;


            if (d.Rows.Count != 0)
            {
                MessageBox.Show("Aceasta parola este deja folosita");
                return false;
            }
            return true;
        }

        public int exista_email()
        {
            this.pERSOANETableAdapter.Email_exista(this.databaseDataSet.PERSOANE, textBox_Email.Text);

            DataTable d = this.databaseDataSet.PERSOANE;

            if (d.Rows.Count != 0)
                return int.Parse(d.Rows[0]["idp"].ToString());
            else
                return -1;
        }

        public int exista_parola()
        {
            this.pERSOANETableAdapter.Parola_exista(this.databaseDataSet.PERSOANE, textBox_Parola.Text);

            DataTable d = this.databaseDataSet.PERSOANE;

            if (d.Rows.Count != 0)
                return int.Parse(d.Rows[0]["idp"].ToString());
            else
                return -1;
        }

        public bool nr_curent_exista()
        {
            if (textBox_Nr_curent.Text != "")
                return true;
            else
                MessageBox.Show("Trebuie sa introduci un numar curent mai mare decat ultimul numar curent din list ta");

            return false;
        }
        public bool denumire_obiec_exista()
        {
            if (textBox_Denumire_obiect.Text != "")
                return true;
            else
                MessageBox.Show("Trebuie sa introduci un obiect");

            return false;
        }

        public bool cantitate_exista()
        {
            if (textBox_Cantitate.Text != "")
                return true;
            else
                MessageBox.Show("Trebuie sa intorduci o cantitate");

            return false;
        }

        public bool valoare_exista()
        {
            if (textBox_Valoare.Text != "")
                return true;
            else
                MessageBox.Show("Trebuie sa intorduci un pret");

            return false;
        }

        public bool numar_inventar_exista()
        {
            if (textBox_Nr_inventar.Text != "")
                return true;
            else
                MessageBox.Show("Trebuie sa intorduci un numar de invenat");

            return false;
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.OBIECTE' table. You can move, or remove it, as needed.
            this.oBIECTETableAdapter.Fill(this.databaseDataSet.OBIECTE);
            // TODO: This line of code loads data into the 'databaseDataSet.OBIECTE' table. You can move, or remove it, as needed.
            this.oBIECTETableAdapter.Fill(this.databaseDataSet.OBIECTE);
            databaseDataSet.EnforceConstraints = false;
            
            this.pERSOANETableAdapter.Fill(this.databaseDataSet.PERSOANE);

            this.oBIECTETableAdapter.Fill(this.databaseDataSet.OBIECTE);

            listView_Obiecte.View = View.Details;
        }

    

        public void tabPage3_Click(object sender, EventArgs e)
        {

        }
       
        private void button_Creaza_cont_nou_Click(object sender, EventArgs e)
        {
            if (numetextBox.Text == "")
                MessageBox.Show("Trebuie sa introduci un nume");
            else
            if (nume())
                if (emailtextBox.Text == "")
                    MessageBox.Show("Trebuie sa introduci un email");
                else
                if (email())
                    if (parolatextBox.Text == "")
                        MessageBox.Show("Trebuie sa introduci o parola");
                    else
                    if (parola())
                        if (confirmare_parolatextBox.Text != parolatextBox.Text)
                            MessageBox.Show("Re confirmati parola");
                        else
                        {
                            this.pERSOANETableAdapter.Fill(this.databaseDataSet.PERSOANE);

                            int mx_idp = int.Parse(pERSOANETableAdapter.Max_Persoane().ToString());

                            pERSOANETableAdapter.Insert_Persoane(mx_idp + 1, numetextBox.Text, emailtextBox.Text, parolatextBox.Text);

                            numetextBox.Text = string.Empty;
                            emailtextBox.Text = string.Empty;
                            parolatextBox.Text = string.Empty;
                            confirmare_parolatextBox.Text = string.Empty;

                            this.pERSOANETableAdapter.Fill(this.databaseDataSet.PERSOANE);

                            MessageBox.Show("Felicitari, ai creat un cont nou");
                        }
        }

        private void button_Conectare_Click(object sender, EventArgs e)
        {
            bool ok = false;

            if (textBox_Email.Text == "")
                MessageBox.Show("Trebuie sa introduci un email");
            else
            if (textBox_Parola.Text == "")
                MessageBox.Show("Trebuie sa introduci o parola");
            else
                if (exista_parola() != exista_email() || exista_parola() == -1 || exista_email() == -1)
                MessageBox.Show("Acest cont nu exsista");
            else
            if (idp != -1)
                MessageBox.Show("Esti deja conectat intr-un cont, apasa butonul DECONECTARE pentru a parasi contul curent");
            else
                ok = true;

            if (ok)
            {
                idp = exista_email();

                textBox_Email.Text = string.Empty;
                textBox_Parola.Text = string.Empty;

                this.oBIECTETableAdapter.Fill(this.databaseDataSet.OBIECTE);

                DataTable obiecte = this.databaseDataSet.OBIECTE;

                this.pERSOANETableAdapter.Fill(this.databaseDataSet.PERSOANE);

                for (int i = 0; i < obiecte.Rows.Count; ++i)
                    if (int.Parse(obiecte.Rows[i]["idp"].ToString()) == idp)
                    {
                        string[] arr = new string[7];
                        ListViewItem itm;

                        arr[0] = obiecte.Rows[i]["ido"].ToString();
                        arr[1] = obiecte.Rows[i]["Obiect"].ToString();
                        arr[2] = obiecte.Rows[i]["Cantitate"].ToString();
                        arr[3] = obiecte.Rows[i]["Valoare"].ToString();
                        arr[4] = obiecte.Rows[i]["Data_achizitionarii"].ToString();
                        arr[5] = obiecte.Rows[i]["Data_expirarii"].ToString();
                        arr[6] = obiecte.Rows[i]["Numar_inventariere"].ToString();

                        itm = new ListViewItem(arr);
                        listView_Obiecte.Items.Add(itm);
                    }

                this.oBIECTETableAdapter.Fill(this.databaseDataSet.OBIECTE);
                DataTable ob = databaseDataSet.OBIECTE;


                for (int i=0; i<ob.Rows.Count;++i)
                    if (int.Parse(ob.Rows[i]["idp"].ToString()) == idp)
                        comboBox_Stergere.Items.Add(ob.Rows[i]["ido"].ToString());


                MessageBox.Show("Te-ai conectat cu succes");
            }
        }

        private void button_Deconectare_Click(object sender, EventArgs e)
        {
            if (idp != -1)
            {
                idp = -1;
                MessageBox.Show("Te-ai deconectat cu succes");

                listView_Obiecte.Items.Clear();   

                this.oBIECTETableAdapter.Fill(this.databaseDataSet.OBIECTE);
                this.pERSOANETableAdapter.Fill(this.databaseDataSet.PERSOANE);

                comboBox_Stergere.Items.Clear();
            }
            else
                MessageBox.Show("Nu esti conectat in nici un cont");
        }

        private void button_Sterge_Click(object sender, EventArgs e)
        {
            if (comboBox_Stergere.Text != "")
            { 
                listView_Obiecte.Items[int.Parse(comboBox_Stergere.Text)-1].Remove();

                comboBox_Stergere.Items.Remove(comboBox_Stergere.Text);
            }
        }

        private void comboBox_Stergere_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Adauga_Click(object sender, EventArgs e)
        {
            if (idp != -1)
            {
                if (nr_curent_exista() && denumire_obiec_exista() && cantitate_exista() && valoare_exista() && numar_inventar_exista())
                {
                    this.oBIECTETableAdapter.Fill(this.databaseDataSet.OBIECTE);

                    DataTable obiecte = this.databaseDataSet.OBIECTE;

                    oBIECTETableAdapter.Insert_Obiecte(idp, int.Parse(textBox_Nr_curent.Text), textBox_Denumire_obiect.Text, textBox_Cantitate.Text, int.Parse(textBox_Valoare.Text), dateTimePicker_Data_achizitionarii.Value.ToShortDateString(), dateTimePicker_Data_expirarii.Value.ToShortDateString(), int.Parse(textBox_Nr_inventar.Text));

                    this.oBIECTETableAdapter.Fill(this.databaseDataSet.OBIECTE);

                    comboBox_Stergere.Items.Add(textBox_Nr_curent.Text);

                    listView_Obiecte.Items.Clear();

                    textBox_Denumire_obiect.Text = string.Empty;
                    textBox_Cantitate.Text = string.Empty;
                    textBox_Valoare.Text = string.Empty;
                    dateTimePicker_Data_achizitionarii.ResetText();
                    dateTimePicker_Data_expirarii.ResetText();
                    textBox_Nr_inventar.Text = string.Empty;
                    textBox_Nr_curent.Text= string.Empty;   

                    for (int i = 0; i < obiecte.Rows.Count; ++i)
                        if (int.Parse(obiecte.Rows[i]["idp"].ToString()) == idp)
                        {
                            string[] arr = new string[7];
                            ListViewItem itm;

                            arr[0] = obiecte.Rows[i]["ido"].ToString();
                            arr[1] = obiecte.Rows[i]["Obiect"].ToString();
                            arr[2] = obiecte.Rows[i]["Cantitate"].ToString();
                            arr[3] = obiecte.Rows[i]["Valoare"].ToString();
                            arr[4] = obiecte.Rows[i]["Data_achizitionarii"].ToString();
                            arr[5] = obiecte.Rows[i]["Data_expirarii"].ToString();
                            arr[6] = obiecte.Rows[i]["Numar_inventariere"].ToString();

                            itm = new ListViewItem(arr);
                            listView_Obiecte.Items.Add(itm);
                        }

                    this.oBIECTETableAdapter.Fill(this.databaseDataSet.OBIECTE);
                }
            }
            else
                MessageBox.Show("Trebuie sa te conectezi pentru a adauga un obiect");
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
    }
}
