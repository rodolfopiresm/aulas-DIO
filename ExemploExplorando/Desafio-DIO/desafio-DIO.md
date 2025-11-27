# Desafio Explorando Estruturas de Dados em .NET

## Lista de Sugestões Inteligentes

### Informações do Desafio

* Desafio
Em uma empresa que lidera projetos de Transformação Digital utilizando .NET e Inteligência Artificial, você faz parte da equipe de desenvolvedores responsável pelo motor de sugestões inteligentes do sistema. Esse motor recebe comandos dos usuários para registrar e remover sugestões tecnológicas, e ao final de cada interação, precisa apresentar as sugestões da lista, em ordem alfabética, para futura análise do algoritmo de IA.

Implemente um programa que processe uma sequência de comandos sobre uma lista de sugestões. Cada comando será “ADD ” para adicionar uma sugestão à lista, ou “REMOVE ” para remover. Após processar todos os comandos recebidos, seu programa deve exibir, em uma única linha, as sugestões restantes, separadas por espaços, ordenadas alfabeticamente. Se a lista estiver vazia, exiba apenas a palavra “VAZIO”.

* Entrada
A primeira linha contém um número inteiro N, representando a quantidade de comandos.
As próximas N linhas contêm comandos no formato:
“ADD sugestao” ou “REMOVE sugestao”, onde “sugestao” é um texto sem espaços.

* Saída
Exiba as sugestões restantes da lista em ordem alfabética e separadas por espaço, em uma única linha. Caso não haja sugestões, imprima "VAZIO".

* Exemplos
A tabela abaixo apresenta exemplos de entrada e saída:

| Entrada | Saída |
|--------|--------|
| 3  
ADD chatbot  
ADD cloud  
REMOVE chatbot | cloud |
| 2  
ADD mlapi  
REMOVE mlapi | VAZIO |
| 4  
ADD iot  
ADD azure  
ADD bot  
REMOVE iot | azure bot |

## Código com solução do desafio

```csharp using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Lê o número de comandos a serem processados
        int n = int.Parse(Console.ReadLine());

        // Inicializa a estrutura para armazenar sugestões únicas
        HashSet<string> sugestoes = new HashSet<string>(StringComparer.Ordinal);

        for (int i = 0; i < n; i++)
        {
            string linha = Console.ReadLine();

            // Divide o comando em ação (ADD/REMOVE) e sugestão
            int spaceIdx = linha.IndexOf(' ');
            string acao = linha.Substring(0, spaceIdx);
            string sugestao = linha.Substring(spaceIdx + 1);

            // TODO: Implemente o tratamento para as ações de adicionar e remover sugestões
            // Dica: utilize os métodos disponíveis na estrutura HashSet para gerenciar as sugestões
                  
            if (acao == "ADD")
            {
              sugestoes.Add(sugestao);
            }
            else if (acao == "REMOVE")
            {
              sugestoes.Remove(sugestao);
            }
        }

        // Ao final, exibe as sugestões em ordem alfabética separadas por espaço,
        // ou "VAZIO" se não houver elementos restantes
        if (sugestoes.Count == 0)
        {
            Console.WriteLine("VAZIO");
        }
        else
        {
            List<string> ordenadas = sugestoes.ToList();
            ordenadas.Sort(StringComparer.Ordinal);
            Console.WriteLine(string.Join(" ", ordenadas));
        }
    }
}
```

## Lista de Taregas de IA .NET

### Informações do Desafio  

* Desafio
A empresa DigitalBrains está implementando uma solução inovadora de Transformação Digital com .NET, integrando Inteligência Artificial à gestão de tarefas do time. O sistema ainda está em protótipo e, neste momento, a IA precisa de ajuda para processar uma lista de tarefas do dia eficientemente.

Cada tarefa é descrita por palavras separadas por espaços, recebidas como uma única linha de texto. A IA.NET precisa reorganizar a lista de tarefas de modo que as tarefas realizadas (“feito”) sejam movidas para o final da lista, preservando a ordem relativa das outras tarefas. Sua missão é implementar esse algoritmo usando apenas listas, conforme o estágio do projeto. Outros métodos não são permitidos, pois a equipe deseja validar a integração de estruturas de dados básicas. Não utilize bibliotecas externas à linguagem.

* Entrada
Uma única linha contendo os nomes das tarefas separadas por espaços. Cada tarefa é representada por uma palavra em caracteres ASCII sem acentuação. Pelo menos uma tarefa será apresentada e podem existir múltiplas ocorrências da palavra “feito”.

* Saída
Uma única linha contendo os nomes das tarefas reorganizadas, separados por espaço, de modo que todas as tarefas “feito” apareçam no final da lista, mantendo a ordem das demais tarefas.

* Exemplos
A tabela abaixo apresenta exemplos de entrada e saída:

| Entrada                           | Saída                              |
|-----------------------------------|-------------------------------------|
| email feito relatorio feito deploy | email relatorio deploy feito feito |
| feito feito teste                 | teste feito feito                  |
| apresentacao design feito         | apresentacao design feito          |

## Código com solução do Desafio

```csharp using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Lê uma linha contendo as tarefas separadas por espaço
        string input = Console.ReadLine();

        // Converte a entrada em uma lista de tarefas
        List<string> tarefas = new List<string>(input.Split(' '));

        // TODO: Separe as tarefas realizadas ("feito") das tarefas pendentes,
        //       mantendo a ordem relativa de ambas nas listas.
        // Dica: Percorra todas as tarefas e utilize duas listas diferentes.
        
        
        List<string> feitos = new List<string>();
        List<string> pendentes = new List<string>();
        
        foreach (string tarefa in tarefas)
        {
          if (tarefa == "feito")
              feitos.Add(tarefa);
          else
              pendentes.Add(tarefa);
        }
        
        // Após separar, coloque primeiro as pendentes e depois todas as "feito"
        // List<string> resultado = ... // Monte a lista final aqui
        
        List<string> resultado = new List<string>();
        resultado.AddRange(pendentes);
        resultado.AddRange(feitos);
        
        // Imprime as tarefas reordenadas
        Console.WriteLine(string.Join(" ", resultado));
    }
}