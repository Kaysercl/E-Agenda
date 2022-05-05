using E_Agenda.WinApp.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Agenda.WinApp.Telas
{
    public partial class TelaCadastroItens : Form
    {
        public readonly Tarefa tarefa;

        public TelaCadastroItens(Tarefa tarefa)
        {
            InitializeComponent();
            this.tarefa = tarefa;
            tarefaselecionada.Text = tarefa.titulo;

            foreach (Item item in tarefa.Itens)
            {
                ListItens.Items.Add(item);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Descricao_Click(object sender, EventArgs e)
        {

        }

        public List<Item> ItensAdicionados
        {
            get
            {
                return ListItens.Items.Cast<Item>().ToList();
            }
        }
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> titulos = ItensAdicionados.Select(x => x.titulo).ToList();

            if (titulos.Count == 0 || titulos.Contains(Titulo.Text) == false)
            {
                Item item = new Item();

                item.titulo = Titulo.Text;

                if (status.SelectedIndex == 0)
                {
                    item.concluido = false;
                }
                else if (status.SelectedIndex == 1)
                {
                    item.concluido = true;
                }

                ListItens.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
