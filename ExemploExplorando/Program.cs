using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "Rodolfo", sobrenome: "Pires"); // foi usado construtor para passar a classe reduzida
Pessoa p2 = new Pessoa(nome: "Eduaro", sobrenome: "Neves Queiroz");

Curso cursoDeIngles = new Curso ();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();