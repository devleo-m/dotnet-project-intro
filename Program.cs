using dotnet_project_intro.Models; //arquivo da class Cliente
using dotnet_project_intro.Models_funcionarios; //arquivo da class Funcionario
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
