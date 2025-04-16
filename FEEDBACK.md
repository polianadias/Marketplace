# Feedback - Avaliação Geral

## Front End
### Navegação
  * Pontos positivos:
    - Possui estrutura básica de views e rotas do template MVC.

  * Pontos negativos:
    - Apenas setup básico do template, sem implementação real das funcionalidades.
    - Faltam views e rotas específicas para os casos de uso do projeto.

### Design
    - Será avaliado na entrega final

### Funcionalidade
  * Pontos positivos:
    - Setup inicial do projeto MVC com estrutura básica.

  * Pontos negativos:
    - Não há implementação concreta dos casos de uso especificados.
    - Apenas estrutura base do template sem desenvolvimento real.
    - Faltam funcionalidades essenciais do front-end.

## Back End
### Arquitetura

  * Pontos negativos:
    - Arquitetura excessivamente complexa com camadas desnecessárias (Aplicação, Domínio, Contexto, IoC, Repositório).
    - Todas essas camadas deveriam ser unificadas em uma única camada Core devido ao nível de complexidade exigido.
    - Recomenda-se "Deixar o arsenal técnico para desafios que exigem complexidade".
    - Tempo investido em arquitetura complexa em detrimento das funcionalidades essenciais.

### Funcionalidade
  * Pontos positivos:
    - Implementação básica de CRUD na API.

  * Pontos negativos:
    - Não utiliza SQLite conforme especificado.
    - Ausência de migrations automáticas.
    - Falta de seed de dados automático.
    - Ausência de validação/sanitização de dados de entrada nas controllers da API.
    - Falta implementação dos casos de uso conforme especificação.

### Modelagem
  * Pontos positivos:
    - Presença de estrutura básica de entidades.

  * Pontos negativos:
    - Camadas de abstração desnecessárias que poderiam ser unificadas.
    - Faltam implementações necessárias de acordo com a especificação.

## Projeto
### Organização
  * Pontos positivos:
    - Uso da pasta `src` na raiz.
    - Arquivo de solução (`.sln`) presente.
    - Arquivo `FEEDBACK.md` presente.

  * Pontos negativos:
    - Excesso de projetos e camadas para um escopo simples.
    - A organização, embora tecnicamente correta, está superdimensionada para as necessidades.

### Documentação
  * Pontos positivos:
    - Repositório com `README.md` presente.
    - Arquivo `FEEDBACK.md` presente.

  * Pontos negativos:
    - README.md é apenas um template sem personalização.
    - Falta documentação específica do projeto.

### Instalação

  * Pontos negativos:
    - Não utiliza SQLite conforme especificado.
    - Ausência de migrations automáticas.
    - Falta de seed de dados.
    - Sem instruções claras de instalação e configuração.