using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinApp.Entidades
{
    public class Tarefa : EntidadeBase 
    {
        public string titulo { get; set; }
        public int prioridade { get; set; }
        

        private List<Item> itens = new List<Item>();
        public List<Item> Itens { get { return itens; } }

        public override string ToString()
        {
            return $"Título: {titulo} / Prioridade {PrioridadeToStr()} ";
        }

        public void ConcluirItem(Item item)
        {
            Item itemTarefa = Itens.Find(x => x.Equals(item));

            itemTarefa?.Concluir();

            var percentual = CalcularPercentualConcluido();
            
        }

        public decimal CalcularPercentualConcluido()
        {
            if (Itens.Count == 0)
                return 0;

            int qtdConcluidas = Itens.Count(x => x.concluido);

            var percentualConcluido = (qtdConcluidas / (decimal)Itens.Count()) * 100;

            return Math.Round(percentualConcluido, 2);
        }

        public void MarcarPendente(Item item)
        {
            Item itemTarefa = Itens.Find(x => x.Equals(item));

            itemTarefa?.MarcarPendente();
        }

        public override string Validar()
        {
            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(titulo))
                sb.AppendLine("É necessário ter um título");

            if (prioridade == null)
                sb.AppendLine("A prioridade tem que ser selecionada");

            if (sb.Length == 0)
                sb.Append("Registro Valido");

                    return sb.ToString();
        }

        private string PrioridadeToStr()
        {
            if (prioridade == 1)
            {
                return "Alta";
            }

            else if (prioridade == 2)
            {
                return "Media";
            }

            else if (prioridade == 3)
            {
                return "Baixa";
            }

            return "";
        }
    }
}
