# **[T�tulo do Projeto] - Aplica��o de Blog Simples com MVC e API RESTful**

## **1. Apresenta��o**

Bem-vindo ao reposit�rio do projeto **[T�tulo do Projeto]**. Este projeto � uma entrega do MBA DevXpert Full Stack .NET e � referente ao m�dulo **Introdu��o ao Desenvolvimento ASP.NET Core**.
O objetivo principal desenvolver uma aplica��o de blog que permite aos usu�rios criar, editar, visualizar e excluir posts e coment�rios, tanto atrav�s de uma interface web utilizando MVC quanto atrav�s de uma API RESTful.
Descreva livremente mais detalhes do seu projeto aqui.

### **Autor(es)**
- **Nome 1**
- **Nome 2**

## **2. Proposta do Projeto**

O projeto consiste em:

- **Aplica��o MVC:** Interface web para intera��o com o blog.
- **API RESTful:** Exposi��o dos recursos do blog para integra��o com outras aplica��es ou desenvolvimento de front-ends alternativos.
- **Autentica��o e Autoriza��o:** Implementa��o de controle de acesso, diferenciando administradores e usu�rios comuns.
- **Acesso a Dados:** Implementa��o de acesso ao banco de dados atrav�s de ORM.

## **3. Tecnologias Utilizadas**

- **Linguagem de Programa��o:** C#
- **Frameworks:**
  - ASP.NET Core MVC
  - ASP.NET Core Web API
  - Entity Framework Core
- **Banco de Dados:** SQL Server
- **Autentica��o e Autoriza��o:**
  - ASP.NET Core Identity
  - JWT (JSON Web Token) para autentica��o na API
- **Front-end:**
  - Razor Pages/Views
  - HTML/CSS para estiliza��o b�sica
- **Documenta��o da API:** Swagger

## **4. Estrutura do Projeto**

A estrutura do projeto � organizada da seguinte forma:


- src/
  - Blog.Web/ - Projeto MVC
  - Blog.Api/ - API RESTful
  - Blog.Data/ - Modelos de Dados e Configura��o do EF Core
- README.md - Arquivo de Documenta��o do Projeto
- FEEDBACK.md - Arquivo para Consolida��o dos Feedbacks
- .gitignore - Arquivo de Ignora��o do Git

## **5. Funcionalidades Implementadas**

- **CRUD para Posts e Coment�rios:** Permite criar, editar, visualizar e excluir posts e coment�rios.
- **Autentica��o e Autoriza��o:** Diferencia��o entre usu�rios comuns e administradores.
- **API RESTful:** Exposi��o de endpoints para opera��es CRUD via API.
- **Documenta��o da API:** Documenta��o autom�tica dos endpoints da API utilizando Swagger.

## **6. Como Executar o Projeto**

### **Pr�-requisitos**

- .NET SDK 8.0 ou superior
- SQL Server
- Visual Studio 2022 ou superior (ou qualquer IDE de sua prefer�ncia)
- Git

### **Passos para Execu��o**

1. **Clone o Reposit�rio:**
   - `git clone https://github.com/seu-usuario/nome-do-repositorio.git`
   - `cd nome-do-repositorio`

2. **Configura��o do Banco de Dados:**
   - No arquivo `appsettings.json`, configure a string de conex�o do SQL Server.
   - Rode o projeto para que a configura��o do Seed crie o banco e popule com os dados b�sicos

3. **Executar a Aplica��o MVC:**
   - `cd src/Blog.Mvc/`
   - `dotnet run`
   - Acesse a aplica��o em: http://localhost:5000

4. **Executar a API:**
   - `cd src/Blog.Api/`
   - `dotnet run`
   - Acesse a documenta��o da API em: http://localhost:5001/swagger

## **7. Instru��es de Configura��o**

- **JWT para API:** As chaves de configura��o do JWT est�o no `appsettings.json`.
- **Migra��es do Banco de Dados:** As migra��es s�o gerenciadas pelo Entity Framework Core. N�o � necess�rio aplicar devido a configura��o do Seed de dados.

## **8. Documenta��o da API**

A documenta��o da API est� dispon�vel atrav�s do Swagger. Ap�s iniciar a API, acesse a documenta��o em:

http://localhost:5001/swagger

## **9. Avalia��o**

- Este projeto � parte de um curso acad�mico e n�o aceita contribui��es externas. 
- Para feedbacks ou d�vidas utilize o recurso de Issues
- O arquivo `FEEDBACK.md` � um resumo das avalia��es do instrutor e dever� ser modificado apenas por ele.
