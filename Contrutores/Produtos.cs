using System;
using System.Collections.Generic;
using System.Text;

namespace Contrutores
{
    public class Produtos
    {
        //public Produtos() //Usado para overload/sobrecarga de métodos.
        //{
            
        //}
        public Produtos(int Id)//Se não houver este construtor instanciando a lista, haverá uma exceção de objeto se iniciando com null.
        {
            //Não tem problem o construtor, construir algo sem nada.
            Complementos = new List<Complemento>();
            //Sempre que for quiser iniciar a propriedade ou lista diferente de nulo, deve ser usado um construtor.
            this.Id = Id;
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public List<Complemento> Complementos { get; set; }

    }
}
