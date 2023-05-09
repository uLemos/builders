using System;
using System.Collections.Generic;
using System.Text;

namespace Contrutores
{
    class Computador : Produtos
    {
        //Se eu não colocar o Id como parâmetro, a classe vai requisitar
        //pois a classe de herança só incializa com seu construtor, sendo 
        //sendo que ele possui "Id" como parâmetro.
        public Computador(int Id) : base(Id) //Basta colocar ": base("parametro")", para puxar o parametro da base, ou seja, da classe instanciada.
        {
                        
        }
    }
}
