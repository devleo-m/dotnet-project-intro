using dotnet_project_intro.Models_Cliente; //arquivo da class Cliente
using dotnet_project_intro.Models_Curso;
using dotnet_project_intro.Models_funcionarios;
using dotnet_project_intro.Models_Pessoa; //arquivo da class Funcionario
//Propriedades basicas####
//CLIENTE
Cliente cliente1 = new Cliente();

cliente1.Name = "Elisabete";
cliente1.Age = 62;
cliente1.Saudacao();
//Propriedades basicas####
//**************************************************

//Gets e setts
//Funcionario
 Funcionario funcionario1 = new Funcionario();
 //funcionario1.Name = ""; erro por conta do if na class funcionario
 funcionario1.Name= "Marcelo";
 funcionario1.Cargo = "Advogado";
 funcionario1.Salario = 5876;
 funcionario1.Introducao();
//Gets e setts
//**************************************************

//Metodos | Cursos
Pessoa pessoa1 = new Pessoa();
pessoa1.name = "Dayane";
Pessoa pessoa2 = new Pessoa();
pessoa2.name = "ArolNode";
Pessoa pessoa3 = new Pessoa();
pessoa3.name = "Fulano";

Curso ingles = new Curso();
ingles.nome = "Curso de Ingles";
ingles.Alunos = new List<Pessoa>();

ingles.AdicionarAluno(pessoa1);
ingles.AdicionarAluno(pessoa2);
ingles.AdicionarAluno(pessoa3);
ingles.ListarAlunos();