
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinApp.Entidades
{
    public class Contato : EntidadeBase
    {
        public string nome { get; set; }

        public string email { get; set; }

        public string telefone { get; set; }
        
        public string empresa { get; set; } 

        public string cargo { get; set; }   

        public override string ToString()
        {
            return $"Nome: {nome} / Email {email} / Telefone {telefone} / " +
                $"Empresa {empresa} / Cargo {cargo} ";
        }

        public override string Validar()
        {
            StringBuilder sb = new StringBuilder();
            EmailAddressAttribute e = new EmailAddressAttribute();

            if (string.IsNullOrEmpty(nome))
                sb.AppendLine("O nome não pode estar vazio");
            if (string.IsNullOrEmpty(email))
                sb.AppendLine("O Email não pode estar vazio");
            if (!e.IsValid(email))
                sb.AppendLine("Email inválido");
            if (string.IsNullOrEmpty(telefone))
                sb.AppendLine("O Telefone não pode estar vazio");           

            if (sb.Length == 0)
                sb.Append("REGISTRO_VALIDO");

            return sb.ToString();
        }
    }


}
