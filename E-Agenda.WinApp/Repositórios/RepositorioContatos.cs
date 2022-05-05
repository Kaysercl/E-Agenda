using E_Agenda.WinApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinApp.Repositórios
{
    public class RepositórioContatos: RepositórioBase<Contato>
    {
        private int contador = 0;

        List<Contato> contatos;

        public RepositórioContatos()
        {

        }

        public void Inserir(Contato contato)
        {
            contato.Id = ++contador;
            registros.Add(contato);
        }

        public List<Contato> SelecionarTodos()
        {
            contatos = new List<Contato>();

            foreach (Contato c in registros)
            {
                contatos.Add(c);
            }

            return contatos;
        }
    }
}
