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
            float val_pag; //Variavel para armazenar valor do pagamento
            const string separador = ";"; //variável para auxiliar na concatenação dos dados que serão salvos no arquivo .txt
                                          //para posterior uso em programas para tratamento de dados (Excel, PowerBI, SQL...)
            Console.WriteLine("-------------Cadastro de Clientes-------------");
            Console.WriteLine("Digite o nome do cliente:");
            string var_nome = Console.ReadLine();
            Console.WriteLine("O cliente é Pessoa Física ou Jurídidca?\n Digite (f) para Física e (j) para Jurídica.");
            string var_tipo = Console.ReadLine();

            switch (var_tipo)
            {
                case "f":
                Pessoa_Fisica pf = new Pessoa_Fisica();
                //Atribuição da váriavel ao atributo da classe para posterior leitura
                pf.nome = var_nome;
                Console.WriteLine("Digite o CPF: ");
                string var_cpf = Console.ReadLine();
                pf.cpf = var_cpf;
                Console.WriteLine("Digite a data de Nascimento:");
                string var_nascimento = Console.ReadLine();
                pf.data_nascimento = var_nascimento; 
                Console.WriteLine("Valor da compra:");
                val_pag = float.Parse(Console.ReadLine());
                pf.Pagar_Imposto(val_pag);
                //Comandos que mostram as informações após serem digitadas
                Console.WriteLine("--------- Pessoa Física ---------");
                Console.WriteLine("Nome...............: " + pf.nome);
                Console.WriteLine("CPF................: " + pf.cpf);
                Console.WriteLine("Data de Nascimento.: " + pf.data_nascimento);
                Console.WriteLine("Valor de Compra....: " + pf.valor.ToString("C"));
                Console.WriteLine("Valor do Imposto...: " + pf.valor_imposto.ToString("C")); //To string para converter float para string e formatar tipo moeda
                Console.WriteLine("Total a Pagar......: " + pf.total.ToString("C"));
                //Código para gravar as informações em um arquivo txt
                //A linha abaixo define a localização do arquivo base txt.
                string texto = @"E:\Senai - Back-End\Codificação Back-End\Cadastro_Clientes\base_clientes.txt";

                //Definição do método para escrita dos dados no arquivo .txt
                using (StreamWriter sw = new StreamWriter(texto)) 
                {
                    sw.WriteLine("Pessoa Física"+separador+pf.nome+separador+pf.cpf+separador+pf.data_nascimento+separador+
                    pf.valor.ToString("C")+separador+pf.valor_imposto.ToString("C")+separador+pf.total.ToString("C"));
                    


                }
                Console.WriteLine ("Dados Gravados com sucesso!");

                break;
            }
            
            

        }

    }


}
