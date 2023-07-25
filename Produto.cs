using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseDeProduto
{
    internal class Produto
    {

        public string nome;
        public string descricao;
        public int quantidade;
        public double preco;
        public bool status;

        public void ProdutosNoConsole()
        {
            Console.WriteLine($"Seu produto mencionado foi {nome} \n Descrição: {descricao} \n Quantidade: {quantidade} unidades  \n Preço: R$ {preco} reais  \n Estoque:{status}");



        } 

        public void DesativarProduto()
        {

            quantidade= 0;
            status= false;  


        }








    }
}
