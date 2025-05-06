# TaskManager Web

## Descrição

O **TaskManager Web** é uma aplicação web simples desenvolvida com ASP.NET Core, permitindo ao usuário gerenciar suas tarefas pessoais. A aplicação oferece funcionalidades para criar, editar, excluir e concluir tarefas. As tarefas são armazenadas em memória, sem o uso de banco de dados.

## Funcionalidades

- **Criar Tarefa**: Adicionar novas tarefas com nome e descrição.
- **Editar Tarefa**: Alterar o nome ou descrição de uma tarefa existente.
- **Excluir Tarefa**: Remover tarefas da lista.
- **Marcar como Concluída**: Marcar uma tarefa como concluída após a criação.
- **Interface Simples**: A interface é limpa e objetiva, com fácil navegação entre as funcionalidades.

## Tecnologias Utilizadas

- **ASP.NET Core**: Framework para desenvolvimento web.
- **HTML/CSS**: Marcação e estilização da interface.
- **C#**: Linguagem utilizada para a lógica da aplicação.

## Estrutura do Projeto

- **Models**: Contém o modelo de dados (TarefaModel) utilizado pela aplicação.
- **Controllers**: Gerencia a lógica da aplicação e as interações com o usuário.
- **Views**: Contém as páginas HTML que representam as diferentes funcionalidades.
- **wwwroot**: Pasta para arquivos estáticos, como CSS e imagens.

## Instruções de Execução

### Requisitos

- **.NET SDK** (versão 6.0 ou superior)
- **Visual Studio Code** (ou outra IDE compatível)

### Passos para Rodar a Aplicação

1. Clone este repositório:
   ```bash
   git clone https://github.com/BrunoFellipe10/TaskManager.web.git
