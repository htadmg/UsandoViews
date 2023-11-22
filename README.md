# Projeto UsandoViews
![image](https://github.com/htadmg/UsandoViews/assets/124289385/95e79452-77be-4d98-8da1-c0eb42f4272f)

Este é um projeto simples em ASP.NET Core que demonstra um CRUD (Create, Read, Update, Delete) básico para operações em uma lista de usuários. O projeto utiliza o padrão MVC (Model-View-Controller) para gerenciar as operações.
## Tecnologias Utilizadas
- ASP.NET Core
- C#
- Razor Pages
- Bootstrap 5

## Configuração do Projeto

Para executar este projeto localmente, certifique-se de ter o .NET 5 SDK instalado. Após clonar o repositório, navegue até o diretório do projeto e execute os seguintes comandos no terminal:
O comando dotnet restore instalará as dependências necessárias e dotnet run iniciará o servidor local para que você possa acessar o projeto no navegador através do endereço https://localhost:5001.
# Projeto UsandoViews

Este projeto exemplifica um CRUD (Create, Read, Update, Delete) simples em ASP.NET Core utilizando Views para manipulação de usuários.

## Estrutura do Projeto

O projeto contém os seguintes arquivos e diretórios principais:

- **HomeController.cs:** Contém a lógica dos controladores para as ações de exibição, cadastro e exclusão de usuários.
- **Usuario.cs (no diretório Models):** Define a estrutura do modelo de usuário e métodos estáticos para manipulação de uma lista simulada de usuários.
- **Views (diretório):** Contém as diferentes visualizações em formato .cshtml para as operações CRUD.

## Funcionalidades Principais

### HomeController

- **Index:** Apresenta a página principal e exibe a quantidade de usuários cadastrados.
- **Cadastrar:** Permite adicionar um novo usuário ou editar um existente.
- **Usuarios:** Exibe uma lista de usuários cadastrados.
- **Excluir:** Oferece a opção de excluir um usuário.

### Usuario.cs

- **Listagem:** Simula uma lista de usuários e fornece métodos estáticos para manipular essa lista, como salvar, excluir e retornar a lista.

## Instruções de Uso

Para executar este projeto, siga as etapas abaixo:

1. Certifique-se de ter o SDK .NET Core instalado na sua máquina.
2. Abra o projeto em sua IDE (Visual Studio, Visual Studio Code, etc.).
3. Execute o projeto e acesse a URL correspondente ao servidor local.

## Dependências e Requisitos

- **SDK .NET Core 5.0**
- **Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation** (referenciado no arquivo .csproj)
## Funcionalidades
- Página Principal (Index): Exibe o número total de usuários cadastrados.
- Cadastro de Usuário (Cadastrar): Permite adicionar um novo usuário ou atualizar um existente. É possível acessar esta página para criar um novo usuário ou editar um existente.
- Lista de Usuários (Usuarios): Mostra uma tabela com os usuários cadastrados, exibindo seus nomes, e-mails e ações disponíveis, como editar ou excluir.
- Exclusão de Usuário (Excluir): Ao tentar excluir um usuário, uma confirmação é solicitada antes de realizar a exclusão.
## Estrutura do Projeto
- Controller (HomeController): Gerencia as requisições HTTP e controla o fluxo da aplicação.
- Model (Usuario): Representa a entidade de usuário, mantém a lista de usuários e métodos para adicionar, editar e excluir usuários.
- Views: Contém as páginas HTML que representam a interface do usuário
## Como Contribuir

Se deseja contribuir para este projeto, sinta-se à vontade para enviar pull requests com melhorias, correções de bugs ou novos recursos.

## Autor

Este projeto foi criado por Agata Domingues.
