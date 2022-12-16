namespace Cadastro_Clientes
{
    class Pessoa_Juridica : Clientes //Pessoa juridica herda atributos de clientes
    {
        //Atributos para pessoa jurídica
        public string cnpj {get; set;}
        public string ie {get; set;}

        //Método do pagamento te imposto para pessoa jurídica
        public override void Pagar_Imposto (float v)
        {
            this.valor = v;
            this.valor_imposto = this.valor * 20/100;
            this.total = this.valor + this.valor_imposto;

        }




    }




}