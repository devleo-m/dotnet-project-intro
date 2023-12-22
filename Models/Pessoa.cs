using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_project_intro.Models
{
    public class Pessoa
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Saudacao()
        {
            Console.WriteLine($"Ola meu nome eh {Name} e tenho {Age}");
        }

    }
}