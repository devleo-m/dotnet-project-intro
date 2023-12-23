using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_project_intro.Models_Pessoa
{
    public class Pessoa
    {
        public string name { get; set; }
        public int age { get; set; }
        public string profissao { get; set; }

        public void Saudacao(){
            Console.WriteLine($"Nome: {name} idade: {age} anos! profissao: {profissao}");
        }
    }
}