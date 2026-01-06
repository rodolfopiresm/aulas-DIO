# Entendendo Estrutura de Decisão e Repetição de JavaScript com a Blip

## Desafio 1 - Bot Command Recognition Challenge

Na BotMakers Inc., uma empresa inovadora de criação de bots, você foi contratado para ajudar a equipe de desenvolvimento a testar o módulo de identificação de comandos. Os bots recebem mensagens dos usuários e precisam responder corretamente de acordo com o comando enviado. Cada mensagem pode ser um dos seguintes comandos: "start", "stop" ou "pause". Se o comando não for reconhecido, o bot deve responder com "unknown command". Sua tarefa é implementar a lógica de decisão que permite ao bot identificar o comando recebido e responder de acordo.

Implemente um programa que leia uma string representando o comando enviado ao bot e imprima a resposta apropriada. Utilize estruturas condicionais para determinar a resposta correta. Não utilize bibliotecas externas. O programa deve ser capaz de diferenciar entre os comandos válidos e qualquer outro texto enviado.

### Entrada

Uma única string representando o comando enviado ao bot. Os comandos válidos são "start", "stop" e "pause". Qualquer outro valor deve ser tratado como comando desconhecido.

### Saída

Imprima "Bot started" se o comando for "start", "Bot stopped" se for "stop", "Bot paused" se for "pause" e "unknown command" para qualquer outro valor.

* Exemplos

A tabela abaixo apresenta exemplos de entrada e saída:

| Entrada | Saída |
| :--- | :--- |
| start | Bot started |
| stop | Bot stopped |
| pause | Bot paused |
| hello | unknown command |

* Solução

```js
// IMPORTANTE: As funções "gets" e "print" são acessíveis globalmente e têm as seguintes funcionalidades: 
// - "gets": lê UMA linha com dados de entrada (inputs) do usuário;
// - "print": imprime um texto de saída (output) e pula uma linha ("\n") automaticamente;
// Use a estrutura abaixo para implementar a lógica do desafio.

const comando = gets(); // Lê o comando enviado ao bot

// TODO: Use estruturas condicionais para imprimir a resposta correta de acordo com o comando recebido

if (comando === "start") {
    print("Bot started")
} else if (comando === "stop") {
    print("Bot stopped")
} else if (comando === "pause") {
    print("Bot paused")
} else {
    print("unknown command")
}
```

## Desafio 2 - Chatbot Corporativo: Núcleo de decição com Switch Case

Você foi contratado pela ChatBotX, uma startup inovadora que desenvolve assistentes virtuais para empresas de diversos setores. Seu primeiro desafio é criar o núcleo de decisão de um chatbot corporativo, responsável por responder rapidamente a comandos básicos dos usuários. Cada comando recebido pelo chatbot corresponde a uma ação específica, como mostrar o horário de funcionamento, informar o telefone de contato, listar serviços ou encerrar a conversa. Para garantir respostas rápidas e precisas, a equipe de desenvolvimento decidiu que a lógica de decisão deve ser implementada utilizando a estrutura switch case. Sua tarefa é construir essa lógica, garantindo que o chatbot responda corretamente a cada comando reconhecido e retorne uma mensagem padrão para comandos desconhecidos.

Implemente um programa que leia uma string representando o comando enviado ao chatbot e utilize uma estrutura de decisão para determinar a resposta apropriada. Os comandos reconhecidos são: "horario", "telefone", "servicos" e "sair". Para qualquer outro comando, o chatbot deve responder com "Comando invalido". Não utilize bibliotecas externas e siga exatamente os textos especificados para as respostas.

* Entrada

Uma única string representando o comando enviado ao chatbot. Os comandos são sensíveis a letras minúsculas e não possuem espaços.

* Saída

Uma única string com a resposta do chatbot, de acordo com o comando recebido. Para comandos não reconhecidos, imprima "Comando invalido".

* Exemplos

A tabela abaixo apresenta exemplos de entrada e saída:

| Entrada | Saída |
| :--- | :--- |
| horario | Atendemos das 8h as 18h |
| telefone | Nosso telefone e 4002-8922 |
| servicos | Oferecemos suporte, vendas e consultoria |
| ajuda | Comando invalido |

* Solução

```js
// IMPORTANTE: As funções "gets" e "print" são acessíveis globalmente e têm as seguintes funcionalidades: 
// - "gets": lê UMA linha com dados de entrada (inputs) do usuário;
// - "print": imprime um texto de saída (output) e pula uma linha ("\n") automaticamente;
// Abaixo segue o template de código para este desafio, o qual pode ou não utilizar tais funções.

// Lê o comando do usuário
const comando = gets();

// TODO: Implemente a estrutura switch case para decidir a resposta do chatbot com base no comando recebido

switch (comando) {
  case "horario":
    console.log("Atendemos das 8h as 18h")
    break
  case "telefone":
    console.log("Nosso telefone e 4002-8922")
    break
  case "servicos":
    console.log("Oferecemos suporte, vendas e consultoria")
    break
  default:
    console.log("Comando invalido")
}
```

## Desafio 3 - Contador de mensagens por tipo em conversas digitais

Em uma plataforma de inteligência conversacional, marcas automatizam diálogos com clientes em múltiplos canais digitais, como chatbots, redes sociais e aplicativos de mensagens. Para avaliar o comportamento desses robôs, a equipe de desenvolvimento precisa analisar quantas mensagens de um determinado tipo aparecem em uma conversa simulada.

Seu desafio é implementar um programa que, dado o tipo de mensagem que se deseja analisar, conte quantas mensagens desse tipo foram enviadas em um fluxo de conversa. Ao final, o programa deve exibir apenas a quantidade total de mensagens encontradas daquele tipo, em formato numérico.

Cada mensagem da conversa é identificada por um prefixo no início da linha: "BOT:" para mensagens automáticas do robô ou "USER:" para mensagens enviadas pelo cliente. O tipo de mensagem a ser contado será informado antes da lista de mensagens.

Importante: embora a conversa possa conter mensagens dos dois tipos (BOT: e USER:), o programa deve contar apenas as mensagens cujo prefixo corresponda ao tipo informado na primeira linha da entrada, ignorando as demais.

Utilize estruturas de repetição para processar todas as mensagens até o final da conversa. Não utilize bibliotecas externas.

* Entrada

A primeira linha contém o tipo de mensagem a ser contado ("BOT" ou "USER"). As linhas seguintes contêm as mensagens trocadas, cada uma iniciando com "BOT:" ou "USER:". A entrada termina quando for lida a linha "FIM", que indica o fim da conversa e não deve ser considerada na contagem.

* Saída

Imprima um único número inteiro representando a quantidade de mensagens do tipo especificado encontradas na conversa. Não imprima mensagens adicionais, apenas o número.

* Exemplos

No primeiro exemplo, por exemplo, a conversa possui 3 mensagens (BOT: Hello, USER: Hi e BOT: How can I help?), mas como o tipo a ser contado é BOT, apenas 2 delas são consideradas, resultando na saída 2.

| Entrada | Saída |
| :--- | :--- |
| **BOT**<br>BOT: Hello<br>USER: Hi<br>BOT: How can I help?<br>FIM | 2 |
| **USER**<br>USER: Hi<br>BOT: Welcome<br>USER: Need help<br>FIM | 2 |
| **BOT**<br>USER: Hello<br>USER: Info<br>FIM | 0 |
| **USER**<br>BOT: Hi<br>BOT: Anything else?<br>FIM | 0 |

* Solução

```js
// IMPORTANTE: As funções "gets" e "print" são acessíveis globalmente e têm as seguintes funcionalidades: 
// - "gets": lê UMA linha com dados de entrada (input) do usuário;
// - "print": imprime um texto de saída (output) e pula uma linha ("\n") automaticamente.

// Lê o tipo de mensagem a ser contado ("BOT" ou "USER")
const tipoMensagem = gets();
let contador = 0;

// TODO: Leia as mensagens até encontrar a linha "FIM"
// TODO: Para cada mensagem, verifique se ela começa com o tipo desejado (por exemplo: "BOT:" ou "USER:")
// TODO: Se começar com o tipo desejado, aumente o contador em 1

let mensagem = gets();

while (mensagem !== "FIM") {
    if (mensagem[0] === tipoMensagem[0]) {
        contador++;
    }
    mensagem = gets();
}

// Ao final, imprima a quantidade de mensagens do tipo escolhido
print(contador);
