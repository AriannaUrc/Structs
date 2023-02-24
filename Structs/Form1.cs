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
            if (dim > 0)
            {
                dim--;
                Visualizza();
            }
            else
            {
                MessageBox.Show("Non ci sono elementi da eliminare");
            }
        }

        private void modifica_button_Click(object sender, EventArgs e)
        {
            if (int.Parse(posizioneMod_textbox.Text)>=0 && int.Parse(posizioneMod_textbox.Text)<dim)
            {
                p[int.Parse(posizioneMod_textbox.Text)].nome = nuovoNome_textbox.Text;
                p[int.Parse(posizioneMod_textbox.Text)].prezzo = float.Parse(nuovoNome_textbox.Text);
                Visualizza();
            }
            else
            {
                MessageBox.Show("La posizione inserità non è valida");
            }
            
        }
    }
}
