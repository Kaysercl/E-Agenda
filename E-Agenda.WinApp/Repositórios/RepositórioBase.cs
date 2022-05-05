using E_Agenda.WinApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinApp
{
    
    

    public class RepositórioBase <T> where T : EntidadeBase
    {
        public List<T> registros = new List<T>();        

    }
}
