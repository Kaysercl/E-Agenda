using E_Agenda.WinApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinApp
{
    public class RepositórioTarefas : RepositórioBase<Tarefa>
    {
        
        private int contador = 0;

        List<Tarefa> tarefas;

        public RepositórioTarefas()
        {

        }

        public virtual string Inserir(Tarefa tarefa)
        {
            string resultado = tarefa.Validar();


            if (resultado != "Registro Valido")
                return resultado;


            tarefa.Id = ++contador;
            registros.Add(tarefa);

            return "Registro Valido";
        }

        public virtual string Editar(Tarefa tarefa)
        {
            foreach (var item in registros)

            {
                if (item.Id == tarefa.Id)
                {
                    item.titulo = tarefa.titulo;
                    item.prioridade = tarefa.prioridade;

                    return "Registro Valido";
                }

            }
            return null;
        }

        public void AtualizarItens(Tarefa tarefaSelecionada,
            List<Item> itensConcluidos, List<Item> itensPendentes)
        {
            foreach (var item in itensConcluidos)
            {
                tarefaSelecionada.ConcluirItem(item);
            }

            foreach (var item in itensPendentes)
            {
                tarefaSelecionada.MarcarPendente(item);
            }

            //serializador.GravarTarefasEmArquivo(tarefas);//
        }

        public List<Tarefa> SelecionarTarefasPendentes()
        {
            List<Tarefa> pendenteAlta = tarefas.Where(x => x.CalcularPercentualConcluido() < 100 && x.prioridade == 1).ToList();
            List<Tarefa> pendenteNormal = tarefas.Where(x => x.CalcularPercentualConcluido() < 100 && x.prioridade == 2).ToList();
            List<Tarefa> pendenteBaixa = tarefas.Where(x => x.CalcularPercentualConcluido() < 100 && x.prioridade == 3).ToList();

            pendenteAlta.AddRange(pendenteNormal);
            pendenteAlta.AddRange(pendenteBaixa);

            return pendenteAlta;
        }



        public List<Tarefa> SelecionarTodos()
        {
            tarefas = new List<Tarefa>();

            foreach (Tarefa tarefa in registros)
            {
                tarefas.Add(tarefa);
            }

            return tarefas;
        }

        public object Filtrar(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
