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

namespace E_Agenda.WinApp
{
    public partial class TelaCadastroTarefas : Form
    {
        public Tarefa tarefa = new Tarefa();

        public TelaCadastroTarefas(Tarefa tarefa)
        {
            InitializeComponent();

            this.tarefa = tarefa;
        }

        public TelaCadastroTarefas()
        {
            InitializeComponent();
        }

        public Tarefa Tarefa
        {
            get { return tarefa; }
            set 
            { 
                tarefa = value;
                
            }
        }            

        private void button1_Click(object sender, EventArgs e)
        {
            tarefa.titulo = txtTitulo.Text;
        }
       

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            tarefa.prioridade = 2;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            tarefa.prioridade = 1;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            tarefa.prioridade = 3;
        }
    }
}
