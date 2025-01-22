# DIO - Trilha .NET - Programação Orientada a Objetos
www.dio.me

## Desafio de Projeto
Este desafio me proporcionou a oportunidade de aplicar os conceitos de **Programação Orientada a Objetos** (POO) adquiridos na trilha .NET da DIO, focando em abstrações, herança e polimorfismo.

## Contexto
Neste desafio, fui desafiado a modelar um sistema simples de celulares. O sistema deveria ser capaz de abstrair a estrutura de um celular e permitir que diferentes marcas, como **Nokia** e **iPhone**, tivessem comportamentos específicos para suas funções. O objetivo era garantir o reuso de código enquanto mantinha a flexibilidade para personalizar ações de acordo com o tipo de celular.

## Proposta
O sistema deveria ser feito em .NET, com base em uma classe abstrata chamada **Smartphone**, e classes específicas para **Nokia** e **iPhone**. A proposta pedia que as classes seguissem um diagrama preestabelecido, com o foco em implementar comportamentos distintos entre as marcas de celular, como o método para instalar aplicativos.

## Regras e Validações
1. A classe **Smartphone** foi definida como **abstrata** para que servisse como modelo base para as outras classes.
2. As classes **Nokia** e **iPhone** deveriam ser derivadas da classe **Smartphone**, garantindo que elas compartilhassem algumas funcionalidades comuns, mas com implementações específicas.
3. O método **InstalarAplicativo** deveria ser sobrescrito em ambas as classes filhas, já que a maneira de instalar aplicativos seria diferente para cada tipo de celular.

## Paradigma Utilizado
Este desafio é um exemplo clássico de **Programação Orientada a Objetos (POO)**. Ao usar **herança**, **polimorfismo** e **encapsulamento**, consegui criar um sistema modular, reutilizável e com a capacidade de ser facilmente estendido:

- **Herança**: As classes **Nokia** e **iPhone** herdam da classe **Smartphone**, o que permite reutilizar funcionalidades comuns, como o número do celular.
- **Polimorfismo**: Ao sobrescrever o método **InstalarAplicativo**, cada celular tem seu próprio comportamento ao instalar um aplicativo.
- **Encapsulamento**: Os detalhes internos de cada celular, como número e modelo, são protegidos dentro das classes, oferecendo uma interface simples para interações com o usuário.

## Melhorias e Personalizações
Para tornar o projeto mais autêntico e alinhado com minhas preferências e aprendizados, fiz algumas mudanças significativas:

1. **Método `ExibirModelo`:**  
   Implementei um método que exibe o modelo do celular de forma simples. Ao invés de exigir um parâmetro adicional, o método agora acessa diretamente a propriedade `Modelo`, o que torna o código mais limpo e fácil de reutilizar.

2. **Entrada Dinâmica para Instalar Aplicativo:**  
   A interação foi aprimorada permitindo que o usuário forneça o nome do aplicativo diretamente via **Console.ReadLine()** no método **InstalarAplicativo**. Isso torna a experiência mais interativa e realista.

3. **Menu Interativo no Console:**  
   Em vez de um simples fluxo linear, criei um menu interativo no console. Isso não só torna o programa mais dinâmico, mas também facilita o teste das funcionalidades, permitindo ao usuário escolher entre várias opções, como ver a hora, ligar o celular, tocar música e instalar aplicativos.

4. **Comportamentos Personalizados para Cada Celular:**  
   Mantive a ideia de que cada modelo de celular deve ter comportamentos exclusivos, mas fiz isso de forma a garantir que o código fosse reutilizável. Por exemplo, a lógica para instalar aplicativos foi diferente para o **Nokia** e o **iPhone**, refletindo as características de cada um.

## Conclusão
Esse desafio não só reforçou meus conhecimentos sobre **POO**, mas também me deu a oportunidade de implementar funcionalidades adicionais que tornam o projeto mais interativo e autêntico. O uso da **herança** e do **polimorfismo** permitiu que o código fosse flexível o suficiente para lidar com diferentes tipos de celulares e comportamentos sem duplicação de código.

Esse projeto foi uma experiência importante no meu aprendizado de **.NET** e me ajudou a entender como construir sistemas modulares e reutilizáveis, aproveitando ao máximo os conceitos de orientação a objetos.

