using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova3_Bimestre.classes
{
    internal class Administrativo : Funcionario
    {
        public string Funcao { get; set; }

        public Administrativo(string funcao, string nome, string cpf, int matricula, DateTime dataNasc, string sexo, double salario) :
        base(nome, cpf, matricula, dataNasc, sexo, salario)
        {
            Funcao = funcao;
        }

        public void Beneficio(double salario)
        {
            double beneficio = salario * 0.15;
            salario = beneficio + salario + 150.00;

            Console.WriteLine($"Seu salário é de {salario}R$");

        }
    }
}
