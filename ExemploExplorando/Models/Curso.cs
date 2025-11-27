using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno) // do void pra frente e uma assinatura de metodo
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count; // contar quantidade de alunos na lista
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do Curso de: {Nome}");

            for (int count = 0; count < Alunos.Count; count++)
            {
              //string texto = "N° " + count + " - " + Alunos[count].NomeCompleto;  //concatenação de string usa o " + " para junção
              string texto = $"N° {count + 1} - {Alunos[count].NomeCompleto}"; // interpolação de string, usa o " $ " e o " {valores mudam} "
              Console.WriteLine(texto);  
            }

            // foreach (Pessoa aluno in Alunos) modo sem concatenação de string
            // {
            //     Console.WriteLine(aluno.NomeCompleto);
            // }
        }
    }
}