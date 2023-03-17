using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Structs
{
    public partial class Form1 : Form
    {
        public struct prodotto
        {
            public string nome;
            public float prezzo;
            public int quantita;
        }


        public prodotto[] p;
        int dim;

        public Form1()
        {
            InitializeComponent();
            dim = 0;
            prodotto[] p = new prodotto[100];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        public string ProdString(prodotto p)
        {
            return "Nome: " + p.nome + "  Prezzo: " + p.prezzo.ToString() + "  Quantità: " + p.quantita.ToString();
        }

        public void Visualizza()
        {
            output.Items.Clear();
            for (int i = 0; i < dim; i++)
            {
                output.Items.Add(ProdString(p[i]));
            }
        }

        public int Ricerca(string ricerca)
        {
            int indice = -1;

            for (int i = 0; i < dim; i++)
            {
                if (p[i].nome == ricerca)
                {
                    indice = i;
                }
            }

            return indice;
        }

        public float SommaPrezzi()
        {
            float somma = 0;

            for (int i = 0; i < dim; i++)
            {
                somma = somma + p[i].prezzo;
            }

            return somma;
        }

        public int PrezzoMin()
        {
            float prezzoMin = p[0].prezzo;
            int prezzoMinPos = 0;

            for (int i = 1; i < dim; i++)
            {
                if (p[i].prezzo < prezzoMin)
                {
                    prezzoMin = p[i].prezzo;
                    prezzoMinPos = i;
                }
            }

            return prezzoMinPos;
        }

        public int PrezzoMax()
        {
            float prezzoMax = p[0].prezzo;
            int prezzoMaxPos = 0;

            for (int i = 0; i < dim; i++)
            {
                if (p[i].prezzo > prezzoMax)
                {
                    prezzoMax = p[i].prezzo;
                    prezzoMaxPos = i;
                }
            }

            return prezzoMaxPos;
        }

        public void Crea()
        {
            if (!String.IsNullOrEmpty(nome.Text)&& !String.IsNullOrEmpty(prezzo.Text))
            {
                p[dim].nome = nome.Text;
                p[dim].prezzo = float.Parse(prezzo.Text);
                p[dim].quantita = 1;
                dim++;
            }
        }

        public bool ControlloDoppioni()
        {
            bool doppione=false;

            for (int i = 0; i < dim; i++)
            {
                if (p[i].nome == nome.Text && p[i].prezzo == float.Parse(prezzo.Text))
                {
                    p[i].quantita++;
                    doppione = true;
                }
            }
            return doppione;
        }

        public void Sconto()
        {
            for (int i = 0; i < dim; i++)
            {
                p[i].prezzo = p[i].prezzo*(100 - int.Parse(sconto_input.Text))/100;
            }
        }

        public void Cancellazione(int indice)
        {
            for (int i = 0; i < dim; i++)
            {
                p[i].prezzo = p[i].prezzo * (100 - int.Parse(sconto_input.Text)) / 100;
            }
        }

        public void Modifica(int indice)
        {
            p[indice].nome = nuovoNome_textbox.Text;
            p[indice].prezzo = float.Parse(nuovoPrezzo_textbox.Text);
        }

        public void Carica(char limite)
        {
            StreamReader sr = new StreamReader("dati.csv");

            string[] words = new string[2];

            string str = sr.ReadLine();
            dim = 0;


            while (str != null)
            {
                words = str.Split(limite);
                p[dim].nome = words[0];
                p[dim].prezzo = float.Parse(words[1]);
                dim++;
                str = sr.ReadLine();
            }

            sr.Close();
        }




        private void output_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void salva_button_Click(object sender, EventArgs e)
        {
            if (!ControlloDoppioni())
            {
                Crea();
            }
            Visualizza();
        }


        private void cancella_button_Click(object sender, EventArgs e)
        {
            int indice = Ricerca(nomeDaCancellare_textbox.Text);
            if (indice >= 0)
            {
                Cancellazione(indice);
                Visualizza();
            }
            else
            {
                MessageBox.Show("Non è stato trovato tale elemento");
            }
        }

        

        private void modifica_button_Click(object sender, EventArgs e)
        {
            int indice = Ricerca(nomeDaMod_textbox.Text);
            if ( indice >= 0)
            {
                Modifica(indice);
                Visualizza();
            }
            else
            {
                MessageBox.Show("Non è stato trovato tale elemento");
            }

        }

        private void sconto_button_Click(object sender, EventArgs e)
        {
            if (dim > 0)
            {
                if (int.Parse(sconto_input.Text) >= 0 && int.Parse(sconto_input.Text) <= 100)
                {
                    Sconto();
                    Visualizza();
                }
                else
                {
                    MessageBox.Show("Percentuale non accetttabile");
                }
            }
            else
            {
                MessageBox.Show("Non ci sono elementi");
            }
        }

        private void sommaPrezzi_button_Click(object sender, EventArgs e)
        {
            output.Items.Clear();
            if (dim > 0)
            {
                output.Items.Add("La somma dei prezzi è: " + SommaPrezzi().ToString());
            }
            else
            {
                MessageBox.Show("Non ci sono elementi");
            }
        }

        private void salva_buton_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("dati.csv", false);
            for (int i = 0; i < dim; i++)
            {
                sw.WriteLine(p[i].nome + ";" + p[i].prezzo);
            }
            sw.Close();
        }

        private void carica_button_Click(object sender, EventArgs e)
        {
            char limite = char.Parse(";");

            Carica(limite);
            Visualizza();
        }

        private void prezzo_min_button_Click(object sender, EventArgs e)
        {
            
            if (dim > 0)
            {
                int pos = PrezzoMin();
                output.Items.Clear();
                output.Items.Add("Il prodotto con costo minore costa " + p[pos].prezzo.ToString() + "€ e si chiama " + p[pos].nome);
            }
            else
            {
                MessageBox.Show("Non ci sono elementi");
            }
        }

        private void prezzo_max_button_Click(object sender, EventArgs e)
        {
            if (dim > 0)
            {
                int pos = PrezzoMax();
                output.Items.Clear();
                output.Items.Add("Il prodotto con costo maggiore costa " + p[pos].prezzo.ToString() + "€ e si chiama " + p[pos].nome);
            }
            else
            {
                MessageBox.Show("Non ci sono elementi");
            }
        }
    }
}
