# Dominando Funções em JavaScript com a Blip

## Desafio 1 - Conversão de mensagens para caixa alta em plataformas de Chatbot

Você foi contratado como desenvolvedor júnior em uma startup que está criando uma plataforma de inteligência conversacional para automatizar conversas entre marcas e clientes em múltiplos canais digitais. Seu primeiro desafio é ajudar a equipe a padronizar as mensagens automáticas enviadas aos usuários. Para isso, você deve criar uma função que receba uma mensagem de entrada e retorne a mesma mensagem, mas com todas as letras minúsculas convertidas para maiúsculas. Isso garantirá que as respostas automáticas sejam sempre claras e padronizadas, independentemente de como o usuário escreveu. Sua solução deve ser implementada como uma função simples, sem o uso de bibliotecas externas, e funcionar para qualquer mensagem composta apenas por letras, números, espaços e sinais de pontuação comuns.

Implemente uma função que receba uma string representando a mensagem enviada por um usuário e retorne a mesma mensagem, mas com todas as letras minúsculas convertidas para maiúsculas. Não altere números, espaços ou sinais de pontuação. Considere que a entrada sempre será uma string não vazia.

* Entrada

Uma única linha contendo a mensagem enviada pelo usuário. A mensagem pode conter letras, números, espaços e sinais de pontuação comuns.

* Saída

Uma única linha contendo a mensagem convertida, com todas as letras minúsculas transformadas em maiúsculas. Números, espaços e sinais de pontuação devem permanecer inalterados.

* Exemplos

A tabela abaixo apresenta exemplos de entrada e saída:

| Entrada | Saída |
| :--- | :--- |
| ola, tudo bem? | OLA, TUDO BEM? |
| Bem-vindo ao chatBot123! | BEM-VINDO AO CHATBOT123! |
| Como posso ajudar voce hoje? | COMO POSSO AJUDAR VOCE HOJE? |
| ok, obrigado! | OK, OBRIGADO! |

* Solução
```js
// Lê a mensagem enviada pelo usuário
const mensagem = gets();

// TODO: Converta todas as letras minúsculas da mensagem para maiúsculas
// Dica: existe um método nativo de string para isso

function paraCaixaAlta(texto){
  return texto.toUpperCase();
}

const mensagemPadronizada = paraCaixaAlta(mensagem)

// Imprima a mensagem padronizada
print(mensagemPadronizada);
```

## Desafio 2 - Saudação Personalizada Para Plataforma De Conversa Multicanal

Você foi contratado como desenvolvedor júnior em uma startup que está criando uma plataforma de inteligência conversacional para automatizar conversas entre marcas e clientes em múltiplos canais digitais. Seu primeiro desafio é ajudar a equipe a padronizar as saudações automáticas enviadas aos usuários. Para isso, você deve criar uma função que receba o nome do canal digital (por exemplo, "WhatsApp", "Instagram", "Webchat") e o nome do cliente, e retorne uma mensagem personalizada de saudação no formato correto. A plataforma precisa garantir que cada saudação siga o padrão: "Ola, [nome do cliente]! Bem-vindo ao canal [nome do canal]." Certifique-se de implementar a função de forma que ela possa ser facilmente adaptada para outros canais no futuro, utilizando parâmetros para os nomes. Não utilize bibliotecas externas.

Implemente uma função que receba dois parâmetros: o nome do canal e o nome do cliente, ambos como strings. A função deve retornar a mensagem de saudação personalizada conforme o padrão especificado acima.

* Entrada

Duas strings separadas por uma quebra de linha: a primeira representa o nome do canal digital, e a segunda representa o nome do cliente.

* Saída

Uma única string contendo a mensagem de saudação personalizada, exatamente no formato especificado.

* Exemplos

A tabela abaixo apresenta exemplos de entrada e saída:

| Entrada | Saída |
| :--- | :--- |
| WhatsApp<br>Lucas | Ola, Lucas! Bem-vindo ao canal WhatsApp. |
| Instagram<br>Ana | Ola, Ana! Bem-vindo ao canal Instagram. |
| Webchat<br>Joao | Ola, Joao! Bem-vindo ao canal Webchat. |
| Telegram<br>Maria | Ola, Maria! Bem-vindo ao canal Telegram. |

* Solução

```js
// Lê as entradas do usuário
const canal = gets();
const cliente = gets();

// TODO: Imprima a mensagem de saudação personalizada no formato solicitado usando os valores lidos

function saudacao(nomeCliente, canalRecebido){
  mensagem = ("Ola, " + nomeCliente + "! Bem-vindo ao canal " + canalRecebido + ".")
  return mensagem
}

const mensagemFinal = saudacao(cliente, canal)
print(mensagemFinal);
```

## Desafio 3 - Saudação Inteligente Para Bots Multicanais

Você foi contratado como desenvolvedor júnior em uma startup que está criando uma plataforma de inteligência conversacional para automatizar conversas entre marcas e clientes em múltiplos canais digitais. Seu primeiro desafio é ajudar a equipe a construir uma função que simule o comportamento de um bot de saudação. O bot deve receber uma mensagem do usuário e responder de acordo com o canal digital informado. Cada canal tem uma saudação personalizada: para "whatsapp", o bot responde "Ola, este e o WhatsAppBot!"; para "telegram", responde "Ola, este e o TelegramBot!"; para "webchat", responde "Ola, este e o WebChatBot!". Se o canal informado não for reconhecido, o bot deve responder "Canal nao suportado". Sua tarefa é implementar uma função que, dado o nome do canal, retorne a saudação correta. Não utilize bibliotecas externas e implemente a lógica em apenas uma função com retorno.

* Entrada

Uma única string representando o nome do canal digital. Os valores possíveis são: whatsapp, telegram, webchat ou qualquer outro valor não listado.

* Saída

Uma única string contendo a saudação personalizada para o canal informado, ou "Canal nao suportado" caso o canal não seja reconhecido.

* Exemplos

A tabela abaixo apresenta exemplos de entrada e saída:

| Entrada | Saída |
| :--- | :--- |
| whatsapp | Ola, este e o WhatsAppBot! |
| telegram | Ola, este e o TelegramBot! |
| webchat | Ola, este e o WebChatBot! |
| email | Canal nao suportado |

* Solução

```js
// Função que retorna a saudação personalizada conforme o canal informado
function saudacaoBot(canal) {
    // TODO: Retorne a saudação correta para cada canal ou "Canal nao suportado" se não reconhecido
    switch (canal){
      case "whatsapp":
      return "Ola, este e o WhatsAppBot!"
      
      case "telegram":
      return "Ola, este e o TelegramBot!"
      
      case "webchat":
      return "Ola, este e o WebChatBot!"
      
      default:
      return "Canal nao suportado"
    }
}

// Entrada do usuário
const canal = gets();

// Chama a função e imprime a resposta
print(saudacaoBot(canal));
```