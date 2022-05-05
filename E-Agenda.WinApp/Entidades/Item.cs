using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinApp.Entidades
{
    public class Item : EntidadeBase
    {
        public string titulo { get; set; } 

        public bool concluido { get; set; }

        public override string Validar()
        {
            throw new NotImplementedException();
        }

        public void Concluir()
        {
            concluido = true;
        }

        internal void MarcarPendente()
        {
            concluido = false;
        }
    }
}
