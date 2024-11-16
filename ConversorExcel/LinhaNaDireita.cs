using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorExcel
{
    public partial class LinhaNaDireita : Form
    {
        private List<Linha> linhaslado; 
        public LinhaNaDireita(List<Linha> entrada)
        {
            InitializeComponent();
            linhaslado = entrada;
        }

        private void LinhaNaDireita_Load(object sender, EventArgs e)
        {
            foreach(Linha linhaLado in linhaslado)
            {
                checkedListBox1.Items.Add(linhaLado.LinhaCod, linhaLado.Direita);
            }
        }
        public List<Linha> LinhasNovas()
        {
            return linhaslado;
        }

        private void LinhaNaDireita_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<Linha> linhasAlteradas = new List<Linha>();
            foreach(string linha in checkedListBox1.Items)
            {
                Linha linhalado = new Linha();
                if (checkedListBox1.CheckedItems.Contains(linha))
                {
                    linhalado.Direita = true;
                }
                linhalado.LinhaCod = linha;
                linhasAlteradas.Add(linhalado);
            }
            linhaslado = linhasAlteradas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
