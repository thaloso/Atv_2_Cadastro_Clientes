namespace Cadastro_Clientes
{
    class Pessoa_Juridica : Clientes //Pessoa juridica herda atributos de clientes
    {
        //Atributos para pessoa jurídica
        public string cnpj {get; set;}
        

        //Método do pagamento te imposto para pessoa jurídica
        
        public override void Pagar_Imposto (float v)
        {
            //override muda o método de cálculo que pagar_imposto irá escrever caso o cliente seja pessoa jurídica
            this.valor = v;
            this.valor_imposto = this.valor * 20/100; //Cálculo do valor do imposto para Pessoa Jurídica
            this.total = this.valor + this.valor_imposto; //Cálculo do valor total do produto

        }




    }




}