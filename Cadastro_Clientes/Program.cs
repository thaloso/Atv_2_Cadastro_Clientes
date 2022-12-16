//Atividade solicitada para avaliação de aprendizagem do curso de programação back-end oferecido pelo SENAI
using System; // Utilização da biblioteca System do C#
using System.IO; //Utilização da biblioteca para editar e ler o arquivo para cadastro das informações

namespace Cadastro_Clientes
{
    //Estrutura do programa
    class Program
    {
        static void Main(string[] args)
        {
            float val_pag;

            Console.WriteLine("-------------Cadastro de Clientes-------------");
            Console.WriteLine("Digite o nome do cliente:");
            string var_nome = Console.ReadLine();
            Console.WriteLine("O cliente é Pessoa Física ou Jurídidca?\n Digite (f) para Física e (j) para Jurídica.");
            string var_tipo = Console.ReadLine();

            switch (var_tipo)
            {
                case "f":
                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.nome = var_nome;
                Console.WriteLine("Digite o CPF: ");
                string var_cpf = Console.ReadLine();
                pf.cpf = var_cpf;
                Console.WriteLine("Digite a data de Nascimento:");
                string var_nascimento = Console.ReadLine();
                pf.data_nascimento = var_nascimento;
                break;
            }
            
            

        }

    }


}
