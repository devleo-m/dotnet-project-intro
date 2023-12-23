using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_project_intro.Models_Pessoa;

namespace dotnet_project_intro.Models_Curso
{
    public class Curso
    {
        public string nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public bool RemoverAluno(Pessoa Aluno){
            Alunos.Remove(Aluno);
            return true;

            // return Alunos.Remove(Aluno); //apenas desta forma tambem funciona
        }

        public void ListarAlunos(){
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.name);
            }
        }
        
        public int QuantidadeAlunosMatriculados(){
            int quantidade = Alunos.Count();
            return quantidade;
        }
    }

}