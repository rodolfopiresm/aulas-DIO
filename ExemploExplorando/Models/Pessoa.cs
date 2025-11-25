using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    { 
        public Pessoa()
        {
            
        }

        public Pessoa(string nome, string sobrenome) // construtor
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        private string _nome; // armazena o nome e i campo private so pode ser alterado pela propriedade
        private int _idade; // armazena a idade
        public string Nome // pode ser alterado externamente, fora da propriedade
        { 
            get => _nome.ToUpper(); // código reduzido opte por usar body expression
            // {
            //     return _nome.ToUpper(); // colocar o nome em maisculo
            // }
            
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio"); // se o nome for vazio retorna a mensagem entrando na excessão
                }

                _nome = value;
            } 
        }

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper(); // propriedade somente com get e juntando 2 string

        public int Idade 
        {
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menos que zero");
                }

                _idade = value;
            }
        }

        public void Apresentar ()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}