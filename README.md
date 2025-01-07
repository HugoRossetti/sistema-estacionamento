# Sistema de Estacionamento

## Descrição do Projeto

Este é um projeto de sistema de estacionamento desenvolvido em **C#**. O objetivo é gerenciar a entrada e saída de veículos, calcular o valor a ser pago com base no tempo de permanência e exibir os veículos atualmente estacionados.

## Funcionalidades

1. **Cadastrar Veículo**

   - Solicita ao usuário a placa do veículo e a registra no sistema.

2. **Remover Veículo**

   - Remove um veículo do estacionamento após solicitar a placa e o tempo de permanência.
   - Calcula o valor a ser pago com base em um preço inicial e uma tarifa por hora.

3. **Listar Veículos**

   - Exibe todos os veículos que estão atualmente estacionados.

4. **Encerrar Programa**
   - Finaliza a execução do sistema.

## Estrutura do Projeto

O projeto é composto por:

1. **Classe `Estacionamento`**

   - Responsável por armazenar os dados dos veículos e realizar as operações principais (adicionar, remover e listar veículos).

2. **Interface do Usuário (CLI)**
   - Fornece um menu interativo para que o usuário escolha as opções desejadas.

## Como Executar

1. Certifique-se de ter o .NET SDK instalado em sua máquina.
2. Clone este repositório:
   ```bash
   git clone https://github.com/HugoRossetti/sistema-estacionamento.git
   ```
3. Navegue até a pasta do projeto:
   ```bash
   cd sistema-estacionamento
   ```
4. Compile e execute o projeto:
   ```bash
   dotnet run
   ```

## Exemplos de Uso

### Cadastrar Veículo

- Entrada:
  ```
  Digite a placa do veículo para estacionar: ABC-1234
  ```
- Saída:
  ```
  Veículo com placa ABC-1234 adicionado.
  ```

### Remover Veículo

- Entrada:
  ```
  Digite a placa do veículo para remover: ABC-1234
  Digite a quantidade de horas que o veículo permaneceu estacionado: 3
  ```
- Saída:
  ```
  O veículo ABC-1234 foi removido e o preço total foi de: R$ 35,00
  ```

### Listar Veículos

- Saída:
  ```
  Os veículos estacionados são:
  - ABC-1234
  - XYZ-5678
  ```

## Tecnologias Utilizadas

- Linguagem: C#
- Plataforma: .NET Core

## Melhoria Futura

- Adicionar persistência de dados (salvar informações em um arquivo ou banco de dados).
- Implementar uma interface gráfica.
- Adicionar validações mais robustas para as entradas do usuário.
- Calcular automaticamente o tempo de permanência utilizando data/hora de entrada e saída.

## Contribuição

Contribuições são bem-vindas! Siga os passos abaixo para contribuir:

1. Fork este repositório.
2. Crie uma branch para sua feature:
   ```bash
   git checkout -b feature/minha-feature
   ```
3. Commit suas mudanças:
   ```bash
   git commit -m "Adiciona nova funcionalidade"
   ```
4. Envie para sua branch:
   ```bash
   git push origin feature/minha-feature
   ```
5. Abra um Pull Request.

## Licença

Este projeto está sob a licença MIT. Consulte o arquivo LICENSE para mais detalhes.
