# Diamante de X

## Sobre o projeto

O **Diamante de X** é um programa simples que desenha um diamante utilizando a letra "X" na tela. O jogador pode escolher o tamanho central do diamante, e o programa irá desenhá-lo de acordo com o valor inserido, dividindo-o em três partes: a parte superior, o meio e a parte inferior.

## Funcionalidades

- **Entrada do Usuário**: O usuário escolhe um número ímpar para determinar o tamanho central do diamante.
- **Desenho do Diamante**:
  - **Parte Superior**: A quantidade de espaços diminui e a quantidade de 'X' aumenta à medida que a parte superior é desenhada.
  - **Parte do Meio**: A linha central do diamante é desenhada com o número total de 'X' correspondente a entrada do usuário.
  - **Parte Inferior**: A quantidade de espaços aumenta e a quantidade de 'X' diminui à medida que a parte inferior é desenhada.

## Como Jogar

1. O programa solicita que o usuário insira um número ímpar para o tamanho central do diamante.
2. O diamante é desenhado em três partes: superior, do meio e inferior.

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.

## Como usar

1. Clone o repositório:

```sh
git clone https://github.com/estevaosantosribeiro/DiamanteDeX.git
```

2. Navegue até a pasta raiz do projeto:

```sh
cd DiamanteDeX
```

3. Restaure as dependências:

```sh
dotnet restore
```

4. Compile o projeto:

```sh
dotnet build
```

5. Execute o jogo:

```sh
dotnet run
```
