using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_project_intro.Models_funcionarios
{
    public class Funcionario
    {
        private string _name;
        public string Name 
        {
            get
            {
                return _name.ToUpper();
            }

            set
            {
                if (value == "") //Se o valor digitado for igual a nada execute abaixo
                {
                    throw new ArgumentException("O nome nao pode ser vazio");   
                } 
                else
                {
                    _name = value;
                }
            }
            //OBS: o set ele recebe o que o usuario digita
        }

        private string _cargo;
        public string Cargo { 

            get => _cargo.ToUpper(); 
            
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Nome para o cargo invalido!");
                }

                _cargo = value;
            }
         }

         private int _salario;
        public int Salario 
        {
            get => _salario;
            
            set
            {
                if (value < -1)
                {
                    throw new ArgumentException("Salario invalido");
                }

                _salario = value;
            }
        }
        
        public void Introducao()
        {
            Console.WriteLine($"FUNCIONARIO: {Name} Cargo: {Cargo} Salario: {Salario}");
        }
    }
}