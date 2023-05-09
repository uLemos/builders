using System;
using System.Collections.Generic;

namespace Contrutores
{
    public class Program
    {
        static void Main(string[] args)
        {
            var complemento = new Complemento()
            {
                Id = 1,
                Descricao = "Teclado",
                Valor = 100
            };
            
            //var produtoOverLoad = new Produtos(); //Sobrecarga
            var produto = new Computador(1);

            produto.Descricao = "Dell";
            produto.Valor = 2000;
            produto.Complementos.Add(complemento);
            //Se a lista não for instanciada, não é possível insertar os valores, pelo fato de não haver os campos ainda, pois está nulo.

            //produto.Complementos = new List<Complemento>() 
            //{
            //    new Complemento()
            //    {
            //        Id = 1,
            //        Descricao = "Teclado",
            //        Valor = 100
            //    }
            //};
            Console.ReadKey();
        }
    }
}
