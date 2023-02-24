using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Structs
{
    public partial class Form1 : Form
    {
        public struct prodotto
        {
            public string nome;
            public float prezzo;
        }


        public prodotto[] p= new prodotto[100];
        int dim;

        public Form1()
        {
            InitializeComponent();
            dim = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        public string ProdString(prodotto p)
        {
            return "Nome: " + p.nome + "  Prezzo: " + p.prezzo.ToString();
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




        private void output_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void salva_button_Click(object sender, EventArgs e)
        {
            p[dim].nome = nome.Text;
            p[dim].prezzo = float.Parse(prezzo.Text);
            dim++;
            Visualizza();
        }
        private void cancella_button_Click(object sender, EventArgs e)
        {
            int indice = Ricerca(nomeDaCancellare_textbox.Text);
            if (indice >= 0)
            {
                for (int i = indice; i < dim-1; i++)
                {
                    p[indice].nome = p[indice+1].nome;
                    p[indice].prezzo = p[indice+1].prezzo;
                }
                dim--;

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
                p[indice].nome = nuovoNome_textbox.Text;
                p[indice].prezzo = float.Parse(nuovoPrezzo_textbox.Text);
                Visualizza();
            }
            else
            {
                MessageBox.Show("Non è stato trovato tale elemento");
            }

        }
    }
}
