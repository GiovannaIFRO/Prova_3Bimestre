using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova3_Bimestre.classes
{
    internal class Medico : Funcionario
    {
        public string CRM { get; set; }
        public double HoraExtra { get; set; }
        public string Especialidade { get; set; }

        public Medico(string cRM, double horaExtra, string especialidade, string nome, string cpf, int matricula, DateTime dataNasc, string sexo, double salario):
        base (nome, cpf, matricula, dataNasc, sexo, salario)
        {
            CRM = cRM;
            HoraExtra = horaExtra;
            Especialidade = especialidade;
        }

        public void Beneficio(double salario)
        {
            double beneficio = salario * 0.20;
            salario = beneficio + salario;

            Console.WriteLine($"Seu salário é de {salario}R$");
        }

    }
}
