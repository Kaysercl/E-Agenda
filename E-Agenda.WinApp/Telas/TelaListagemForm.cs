using E_Agenda.WinApp.Entidades;
using E_Agenda.WinApp.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Agenda.WinApp
{
    public partial class TelaListagemForm : Form

    {
        RepositórioTarefas repositorioTarefas;

        public TelaListagemForm()
        {
            repositorioTarefas = new RepositórioTarefas();

            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabTarefas)
            {
                InserirTarefa();
            }
        }   
        
        private void InserirTarefa()
        {
            TelaCadastroTarefas tela = new TelaCadastroTarefas(new Tarefa());

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioTarefas.Inserir(tela.Tarefa);

                CarregarListas();
            }
        }

        private void CarregarListas()
        {
            carregartarefas();
        }

        private void carregartarefas()
        {
            List<Tarefa> listadetarefas = repositorioTarefas.SelecionarTodos();

            listTarefasPendentes.Items.Clear();

            foreach (Tarefa t in listadetarefas)
            {
                listTarefasPendentes.Items.Add(t);
            }
        }

        public void btnEditar_Click(object sender, EventArgs e)
        {
            {
                Tarefa tarefaSelecionada = (Tarefa)listTarefasPendentes.SelectedItem;              
                
                if (tarefaSelecionada == null)
                {
                    MessageBox.Show("Selecione uma tarefa");
                    return;
                }

                TelaCadastroTarefas telaCadastro = new TelaCadastroTarefas();

                telaCadastro.Tarefa = tarefaSelecionada;

                DialogResult res = telaCadastro.ShowDialog();

                if (res == DialogResult.OK)
                {
                    repositorioTarefas.Editar(telaCadastro.tarefa);                    
                }
            }
        }

        

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listTarefasPendentes.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa");
                return;
            }

            TelaCadastroItens tela = new TelaCadastroItens(tarefaSelecionada);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                List <Item> itens = tela.ItensAdicionados;
            }

        }
    }
}
