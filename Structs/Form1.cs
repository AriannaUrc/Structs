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




        private void output_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void salva_button_Click(object sender, EventArgs e)
        {
            p[dim].nome = nome.Text;
            p[dim].prezzo = float.Parse(prezzo.Text);
            output.Items.Clear();
            dim++;

            for (int i = 0; i < dim; i++)
            {
                output.Items.Add(ProdString(p[i]));
            }

        }
        private void cancella_button_Click(object sender, EventArgs e)
        {
            if (dim > 0)
            {
                dim--;
                output.Items.Clear();
                for (int i = 0; i < dim; i++)
                {
                    output.Items.Add(ProdString(p[i]));
                }
            }
            else
            {
                MessageBox.Show("Non ci sono elementi da eliminare");
            }
        }
    }
}
