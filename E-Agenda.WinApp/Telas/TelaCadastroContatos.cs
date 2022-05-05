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
    public partial class TelaCadastroContatos : Form
    {
        private Contato contato = new Contato();

        public TelaCadastroContatos()
        {
            InitializeComponent();
        }

        public Contato Contato
        {
            get { return contato; }
            set
            {
                contato = value;
            }
        }

       
    }
}
