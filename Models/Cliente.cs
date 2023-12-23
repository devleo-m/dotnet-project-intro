using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Propriedades basicas####
namespace dotnet_project_intro.Models
{
    public class Cliente
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Saudacao()
        {
            Console.WriteLine($"CLIENTE: {Name} {Age} anos");
        }

    }
}
//Propriedades basicas####