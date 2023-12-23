using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_project_intro.Models
{
    public class Construtores
    {
        public Construtores(string nome, string sobrenome) => FullName = nome+sobrenome;
        // public string Nome { get; set; }
        // public string Sobrenome { get; set; }
        // public string FullName => Nome+Sobrenome;
        public string FullName;
        public void Apresentacao(){
            Console.WriteLine($"Ola {FullName}");
        }
    }
}