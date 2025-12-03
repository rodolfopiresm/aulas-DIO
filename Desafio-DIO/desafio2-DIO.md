# Aplicando Conceitos de POO em C#

## Digital Assistand: Saudação Inteligente

### Informações do Desafio

* Desafio
Na vanguarda da transformação digital, uma equipe de desenvolvimento foi encarregada de criar uma assistente virtual inteligente utilizando conceitos de Programação Orientada a Objetos e a plataforma .NET. A primeira tarefa deste projeto inovador é construir uma classe simples chamada Saudacao, que será usada pelo sistema de Inteligência Artificial para cumprimentar os clientes de maneira personalizada, sempre que eles acessam o portal digital da empresa.

Você deve implementar uma classe que receba o nome de um cliente e produza uma mensagem de saudação padronizada. Ao receber o comando da IA com o nome do cliente, o sistema deve imprimir exatamente: "Bem-vindo, [nome]!", substituindo [nome] pelo valor informado na entrada. Não adicione espaços extras antes ou depois do nome.

Use apenas recursos básicos da linguagem para implementar a classe, seguindo os princípios de encapsulamento e uso de métodos. Não utilize bibliotecas externas.

* Entrada
Uma única string representando o nome do cliente, garantindo que não contém espaços antes ou depois do nome.

* Saída
Uma string contendo a saudação no seguinte formato: Bem-vindo, [nome]!

* Exemplos
A tabela abaixo apresenta exemplos de entrada e saída:

| Entrada | Saída |
|---------|-------|
|Lucas	  |Bem-vindo, Lucas!|
|AnaMaria    |Bem-vindo, AnaMaria!|
|R2D2	|Bem-vindo, R2D2!|

## Código com solução do Desafio

```csharp using System;

// Classe que deve gerar a saudação personalizada
public class Saudacao
{
    private readonly string nomeCliente;

    public Saudacao(string nomeCliente)
    {
        this.nomeCliente = nomeCliente;
    }

    public string ObterMensagem()
    {
        // TODO: Implemente a lógica para criar uma saudação personalizada usando o nome armazenado.
        // Dica: utilize interpolação de strings para incluir o nome na mensagem final.
        
        return $"Bem-vindo, {nomeCliente}!"; // Retorne a mensagem formatada corretamente aqui
    }
}

public class Program
{
    public static void Main()
    {
        // Entrada: lê o nome do cliente da entrada padrão
        string nome = Console.ReadLine();

        // Instancia a Saudacao passando o nome informado
        Saudacao s = new Saudacao(nome);

        // Saída: imprime a mensagem personalizada
        Console.WriteLine(s.ObterMensagem());
    }
}
```

## ChatBot.NET: Mensagem Inteligente

### Informações do Desafio 

* Desafio
No laboratório da empresa VisionTech, você foi convidado a aprimorar o ChatBot.NET — um sistema desenvolvido para interações inteligentes com clientes em portais digitais. O projeto faz parte da transformação digital da empresa, que aposta na união de .NET e Inteligência Artificial para automatizar e personalizar o atendimento.

Seu papel é criar uma classe chamada Mensagem, que armazene uma saudação enviada pelo cliente. Essa classe deve possuir um método chamado responder, que recebe uma frase de saudação e retorna uma resposta automática formatada pelo bot no seguinte padrão:


Formato: "BOT: Obrigado pela mensagem: [frase_recebida]"

Implemente a classe conforme a descrição e use-a para processar a saudação recebida na entrada, imprimindo a resposta gerada pelo método responder.

* Entrada
Uma linha contendo uma frase (string) enviada pelo cliente via ChatBot.NET.

* Saída
Uma linha contendo a resposta automática gerada pelo método responder seguindo o padrão especificado.

* Exemplos
A tabela abaixo apresenta exemplos de entrada e saída:

|Entrada|	Saída|
|---------|-------|
|Hello, I need some help|	BOT: Obrigado pela mensagem: Hello, I need some help|
|Good morning|	BOT: Obrigado pela mensagem: Good morning|
|Support needed asap|	BOT: Obrigado pela mensagem: Support needed asap|

## Código com solução do Desafio

```csharp using System;

namespace ChatBotNET
{
    // Classe responsável por armazenar e responder mensagens de saudação
    class Mensagem
    {
        private string saudacao;

        public Mensagem(string saudacao)
        {
            this.saudacao = saudacao;
        }

        // TODO: Modifique este método para personalizar a resposta do bot de acordo com critérios fornecidos pelo enunciado
        // Dica: avalie o conteúdo da saudação para determinar a resposta adequada

        public string responder()
        {
            // Atualmente, apenas retorna um padrão fixo. 
            // O aluno deve alterar para adaptar às regras do desafio.
            return $"BOT: Obrigado pela mensagem: {saudacao}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Lê a frase enviada pelo cliente via stdin
            string entrada = Console.ReadLine();
            
            // Instancia a classe Mensagem para processar a entrada
            Mensagem mensagem = new Mensagem(entrada);

            // Imprime a resposta do bot no formato especificado
            Console.WriteLine(mensagem.responder());
        }
    }
}
```