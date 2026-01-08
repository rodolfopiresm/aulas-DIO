# Modelando Estruturas com Objetos em JavaScript com Blip

## Desafio 1 - Message Formatter: Estruturando Mensagens Para Plataforma Conversacional

Você foi contratado como desenvolvedor júnior em uma startup que está criando uma plataforma de inteligência conversacional para automatizar conversas entre marcas e clientes em múltiplos canais digitais. Seu primeiro desafio é ajudar a equipe a estruturar as mensagens trocadas entre usuários e bots. Para isso, você deve criar uma classe chamada Message, que representa uma mensagem enviada em uma conversa. Cada mensagem possui um remetente (sender) e um conteúdo (content). Sua tarefa é implementar um método que, ao receber uma string no formato "sender: content", crie uma instância da classe Message e retorne uma resposta formatada no padrão "From sender: content". Se a entrada não contiver o caractere ":", a resposta deve ser "Invalid message".

Implemente a classe e o método de acordo com as especificações, sem utilizar bibliotecas externas. O programa deve ler uma única string de entrada e produzir a saída conforme descrito.

* Entrada

Uma única string no formato "sender: content", onde sender e content são sequências de caracteres sem restrições específicas. Caso o caractere ":" não esteja presente, considere a mensagem inválida.

* Saída

Uma única string. Se a entrada for válida, imprima "From sender: content", mantendo exatamente o sender e o content originais. Se a entrada for inválida, imprima "Invalid message".

* Exemplos

A tabela abaixo apresenta exemplos de entrada e saída:

| Entrada (Origem) | Saída (Mensagem) |
| :--- | :--- |
| Bot | Hello, how can I help you? |
| From Bot | Hello, how can I help you? |
| User | I need support |
| From User | I need support |
| System | System update scheduled |
| System | Invalid message |
| Agent | Please wait a moment |
| From Agent | Please wait a moment |

* Solução

```js
// IMPORTANTE: As funções "gets" e "print" são acessíveis globalmente e têm as seguintes funcionalidades: 
// - "gets": lê UMA linha com dados de entrada (inputs) do usuário;
// - "print": imprime um texto de saída (output) e pula uma linha ("\n") automaticamente;
// Abaixo segue o template de código para este desafio, o qual pode ou não utilizar tais funções.

class Message {
    constructor(sender, content) {
        this.sender = sender;
        this.content = content;
    }

    format() {
        // Retorna a mensagem formatada conforme o padrão solicitado
        return `From ${this.sender}: ${this.content}`;
    }
}

// Lê a entrada do usuário
const input = gets();

// TODO: Verifique se a entrada contém ":", se sim, crie a instância de Message e imprima a mensagem formatada; caso contrário, imprima "Invalid message".

if (input.includes(":")) {
  const partes = input.split(":");
  
  const remetente = partes[0];
  const conteudo = partes[1];
  
  const mensagem = new Message(remetente, conteudo);
  
  print(mensagem.format());
  
}else {
  print("Invalid message")
}
```

## Desafio 2 - Como Identificar O Canal De Origem Em Mensagens De Chatbots

Você foi contratado como desenvolvedor júnior em uma startup que está criando uma plataforma de inteligência conversacional para automatizar conversas entre marcas e clientes em múltiplos canais digitais. Seu primeiro desafio é ajudar a equipe a identificar rapidamente o canal de origem de cada mensagem recebida, para que o sistema possa direcionar a conversa ao bot correto. Cada mensagem chega como um objeto contendo as propriedades "canal" (com o nome do canal digital, como "whatsapp", "instagram", "webchat" ou "sms") e "texto" (com o conteúdo da mensagem). Sua tarefa é criar uma função que, ao receber uma string JSON representando esse objeto, retorne apenas o nome do canal em letras minúsculas. Se a propriedade "canal" não existir ou estiver vazia, a função deve retornar "indefinido". Não utilize bibliotecas externas.

Implemente a lógica de extração do canal a partir do objeto recebido, garantindo que o sistema sempre saiba de onde veio cada mensagem. Lembre-se de tratar corretamente casos em que a propriedade não está presente ou está vazia.

* Entrada

Uma única string no formato JSON representando um objeto com as propriedades "canal" e "texto".

* Saída

Uma única string contendo o nome do canal em letras minúsculas, ou "indefinido" caso a propriedade "canal" não exista ou esteja vazia.

* Exemplos

A tabela abaixo apresenta exemplos de entrada e saída:

| Entrada | Saída |
| :--- | :--- |
| {"canal":"whatsapp","texto":"Oi, preciso de ajuda"} | whatsapp |
| {"canal":"Instagram","texto":"Quero saber mais"} | instagram |
| {"texto":"Mensagem sem canal"} | indefinido |
| {"canal":"","texto":"Teste de canal vazio"} | indefinido |

```js
// IMPORTANTE: As funções "gets" e "print" são acessíveis globalmente e têm as seguintes funcionalidades: 
// - "gets": lê UMA linha com dados de entrada (inputs) do usuário;
// - "print": imprime um texto de saída (output) e pula uma linha ("\n") automaticamente;
// Use este template para começar o desafio.

// Lê a entrada JSON da mensagem
const entrada = gets();

// TODO: Analise a string JSON recebida e imprima o canal em letras minúsculas,
// ou "indefinido" caso a propriedade "canal" não exista ou esteja vazia.

const mensagem = JSON.parse(entrada);

if (mensagem.canal) {
    print(mensagem.canal.toLowerCase());
} else {
    print("indefinido");
}
```

## Desafio 3 - Conversão De Mensagem Para Objeto Em Chatbot
Em um ambiente de inteligência conversacional, marcas inovadoras utilizam robôs de atendimento para interagir com clientes em múltiplos canais digitais. Você faz parte da equipe de tecnologia responsável por garantir que as mensagens automáticas estejam sempre personalizadas e corretas. Para isso, cada mensagem enviada pelo robô deve ser registrada em um objeto contendo o nome do cliente e o texto da mensagem. Sua tarefa é criar uma função que, ao receber uma string no formato "nome:mensagem", construa um objeto com as propriedades "cliente" e "texto", e retorne uma resposta formatada como "Para [cliente]: [texto]". Se a entrada não contiver o caractere ":", a resposta deve ser "Formato invalido".

Implemente a lógica utilizando estruturas com objetos, sem bibliotecas externas. O programa deve processar apenas uma linha de entrada por execução.

* Entrada

Uma única string no formato "nome:mensagem", onde "nome" e "mensagem" são sequências de caracteres sem o caractere ":". Caso a string não contenha ":", considere a entrada inválida.

* Saída

Uma string formatada como "Para [cliente]: [texto]", onde [cliente] é o nome extraído antes do ":", e [texto] é a mensagem após o ":". Se a entrada for inválida, imprima "Formato invalido".

* Exemplos

A tabela abaixo apresenta exemplos de entrada e saída:

| Entrada | Saída |
| :--- | :--- |
| Lucas:Seu pedido foi enviado | Para Lucas: Seu pedido foi enviado |
| Ana:Bem vinda ao nosso canal | Para Ana: Bem vinda ao nosso canal |
| Mensagem sem separador | Formato invalido |
| Joao:Desconto exclusivo para voce | Para Joao: Desconto exclusivo para voce |

```js
// IMPORTANTE: As funções "gets" e "print" são acessíveis globalmente e têm as seguintes funcionalidades: 
// - "gets": lê UMA linha com dados de entrada (inputs) do usuário;
// - "print": imprime um texto de saída (output) e pula uma linha ("\n") automaticamente;
// Use este template para praticar a manipulação de objetos e strings.

// Lê a entrada do usuário
const entrada = gets();

// TODO: Verifique se a entrada contém ":" e, se sim, separe o nome e a mensagem em variáveis distintas

// Dica: Use split para dividir a string e, se for válido, crie um objeto com as propriedades "cliente" e "texto".
// Imprima a resposta formatada conforme o exemplo ou "Formato invalido" se não houver ":".

if (entrada.includes(":")) {
  
  const partes = entrada.split(":");
  
  const dadosMensagem = {
    cliente: partes[0],
    texto: partes[1]
  };
  print(`Para ${dadosMensagem.cliente}: ${dadosMensagem.texto}`);
  
}else {
  print("Formato invalido");
}
```