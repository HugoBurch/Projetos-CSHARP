# Projetos-C#

Coleção de exercícios e pequenos projetos de console em **C# (.NET 9)**, criados para praticar os fundamentos da linguagem e da programação orientada a objetos: classes, herança, propriedades, construtores, enumerações e vetores.

Cada pasta é uma solução independente (`.sln`) e pode ser executada separadamente.

---

## Projetos

| Pasta | Tema | O que pratica |
|---|---|---|
| [`EXconcessionária`](./EXconcessionária) | Cadastro de veículos | Herança, construtores com `base`, propriedades com `protected set`, `ToString()`, vetores |
| [`Enumerações`](./Enumerações) | Pedido com status | `enum` tipado, organização em `Entities`/`Enums`, inicializador de objeto, `DateTime.Now` |
| [`ExVetor`](./ExVetor) | Reserva de quartos | Vetor de objetos, leitura de dados do console, laços `for` |
| [`Matrix`](./Matrix) | Matrizes | Projeto `EXmatriz` (somente o `.csproj` está no repositório) |

### EXconcessionária

Cadastro de veículos pelo terminal. O usuário informa quantos veículos deseja cadastrar e, para cada um, digita modelo, ano, número de portas e marca, separados por espaço. Ao final, a lista de veículos é exibida.

Estrutura de classes:

- `Veiculos`: classe base com `Marca`, `Modelo` e `Ano`.
- `CarrosBasic`: herda de `Veiculos` e adiciona `Portas`, com `ToString()` personalizado.
- `CarrosCompletos`: herda de `Veiculos` e adiciona `Portas`, `Ar` e `DirecaoHidraulica`.
- `Motos`: herda de `Veiculos` (ainda sem atributos próprios).

Exemplo de entrada:

```
Quantos veículos deseja cadastrar? 1
Cadastro do veículo 1: (Modelo, Ano, Portas, Marca)
Gol 2020 4 Volkswagen
```

### Enumerações

Modela um pedido (`Order`) com `Id`, `Moment` e `Status`. O status é um enum (`OrderStatus`) com os valores `PendingPayment`, `Processing`, `Shipped` e `Delivered`. O programa cria um pedido e o imprime no console.

### ExVetor

Simula o aluguel de quartos (posições de 0 a 9 do vetor). O usuário informa quantos quartos serão alugados e, para cada um, nome, e-mail e número do quarto. Depois, o programa lista os quartos ocupados com os dados de cada hóspede (classe `Dados`).

## Estrutura do repositório

```
Projetos-C--main/
├── EXconcessionária/
│   ├── EXconcessionária.sln
│   └── EXconcessionária/
│       ├── Program.cs
│       └── Concessionaria/
│           ├── Veiculos.cs
│           ├── Carros.cs
│           └── Motos.cs
├── Enumerações/
│   ├── Enumerações.sln
│   └── Enumerações/
│       ├── Program.cs
│       └── Entities/
│           ├── Order.cs
│           └── Enums/OrderStatus.cs
├── ExVetor/
│   ├── ExVetor.sln
│   └── ExVetor/
│       ├── Program.cs
│       └── Dados.cs
└── Matrix/
    └── EXmatrix/
        └── EXmatriz.csproj
```

## Pré-requisitos

- [.NET SDK 9](https://dotnet.microsoft.com/download) ou superior.

```bash
dotnet --version
```

## Como executar

Clone o repositório, entre na pasta do projeto desejado e execute:

```bash
git clone https://github.com/HugoBurch/Projetos-C-.git
cd Projetos-C-/ExVetor/ExVetor
dotnet run
```

Troque `ExVetor/ExVetor` pela pasta do projeto que quiser rodar (por exemplo, `Enumerações/Enumerações`). Também é possível abrir o arquivo `.sln` de cada pasta no Visual Studio.

## Conceitos praticados

- Programação orientada a objetos: classes, herança, encapsulamento e sobrescrita de `ToString()`
- Propriedades (`get`/`set`, `protected set`) e construtores
- Enumerações (`enum`)
- Vetores (arrays) de objetos
- Entrada e saída no console, conversão de tipos com `int.Parse` e `Split`
- Organização de código em namespaces e pastas

## Pontos de melhoria

Observações sobre o código atual, úteis como próximos passos de estudo:

- **EXconcessionária:** o programa pede 4 valores (modelo, ano, portas e marca), mas valida apenas `values.Length < 3`; com 3 valores ocorre um erro de índice. As classes `CarrosCompletos` e `Motos` ainda não são usadas no `Program.cs`.
- **ExVetor:** o vetor tem tamanho fixo de 10; um número de quarto fora de 0 a 9 gera exceção. Também não há tratamento de entrada inválida (`int.Parse`).
- **Matrix:** apenas o `.csproj` foi versionado; falta o código-fonte (`Program.cs`).
- **Repositório:** as pastas `bin/` e `obj/` estão versionadas; recomenda-se adicionar um `.gitignore` para projetos .NET e removê-las do controle de versão.

## Autor

[Hugo Burch](https://github.com/HugoBurch)
