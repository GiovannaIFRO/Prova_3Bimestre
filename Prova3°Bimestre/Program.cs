
using Prova3_Bimestre.classes;

public class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1 - Médico\n"+
                "2 - Administrador\n"+
                "0 - Sair");
            int opcao= Convert.ToInt32(Console.ReadLine());

            if (opcao == 0)
            {
                break;
            }
            else if(opcao == 1)
            {

                Console.WriteLine("Digite seu nome: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite seu salário: ");
                double salario = Convert.ToDouble(Console.ReadLine());  

                Console.WriteLine("Digite a quantidade de horas extras: ");
                double HoraExtra = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite sua CRM: ");
                string CRM = Console.ReadLine();

                Console.WriteLine("Qual a sua especialidade?: ");
                string especialidade = Console.ReadLine();

                Console.WriteLine("Digite seu cpf: ");
                string cpf = Console.ReadLine();

                Console.WriteLine("Digite sua sexualidade: ");
                string sexo = Console.ReadLine();

                Console.WriteLine("Digite sua matricula: ");
                int matricula = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite sua data de nascimento");
                DateTime dataNasc = Convert.ToDateTime(Console.ReadLine());

                List <Medico> medicoList = new List<Medico>();
                Medico m = new Medico(CRM, HoraExtra, especialidade, nome, cpf, matricula, dataNasc, sexo, salario);
              
                medicoList.Add(m);

                m.Beneficio(salario);

            }
            else if(opcao == 2)
            {
                Console.WriteLine("Digite seu nome: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite seu salário: ");
                double salario = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite sua função: ");
                string funcao = Console.ReadLine();

                Console.WriteLine("Digite seu cpf: ");
                string cpf = Console.ReadLine();

                Console.WriteLine("Digite sua sexualidade: ");
                string sexo = Console.ReadLine();

                Console.WriteLine("Digite sua matricula: ");
                int matricula = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite sua data de nascimento");
                DateTime dataNasc = Convert.ToDateTime(Console.ReadLine());

                List<Administrativo> adminList = new List<Administrativo>();
                Administrativo a = new Administrativo(funcao, nome, cpf, matricula, dataNasc, sexo, salario);

                adminList.Add(a);

                foreach(Administrativo ad in adminList)
                {
                    Console.WriteLine(ad);
                }

                a.Beneficio(salario);

            }
        }
    }
}