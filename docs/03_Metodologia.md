# Metodologia

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Documentação de Especificação</a></span>

Nessa seção, serão apresentadas as ferramentas utilizadas para o desenvolvimento do projeto, tanto para o gerenciamento dos códigos e artefatos produzidos no decorrer de seu desenvolvimento, quanto na organização da equipe em cada uma das tarefas propostas em reunião.

O grupo se organizará a partir da metodologia ágil Kanban, que permite a melhor gestão de tarefas e conduz cada atividade por meio de um fluxo de trabalho estabelecido, de maneira visual ideal para nossa equipe com menos colaboradores.

## Relação de Ambientes de Trabalho


| Plataforma  | Finalidade |
| ------------ | ------------ |
| [Github](https://desktop.github.com/ "Github")  | Respositório, Metodologia & Documentação   |
| [Discord](https://discord.com/ "Discord"), [Whatsapp](https://www.whatsapp.com/?lang=pt_BR "Whatsapp")  | Reuniões, planejamento do grupo |
| [Figma](https://www.figma.com/ "Figma") | Desenho de tela (Wireframing), Diagramas & UI/UX |

## Controle de Versão
A ferramenta de controle de versão adotada no projeto foi o
[Git](https://git-scm.com/), sendo que o [Github](https://github.com)
foi utilizado para hospedagem do repositório.

O projeto segue a seguinte convenção para o nome de branches:

- `main`: versão estável já testada do software
- `teste`: versão já testada do software, porém instável e também edições propostas da  documentação
- `dev`: versão de desenvolvimento com altas chances de bug

Quanto à gerência de issues, o projeto adota a seguinte convenção para
etiquetas:

- `documentação`: melhorias ou acréscimos à documentação
- `bug`: uma funcionalidade encontra-se com problemas
- `melhoria`: uma funcionalidade precisa ser melhorada
- `novaFuncionalidade`: uma nova funcionalidade precisa ser introduzida
- `invalido`: adição errada ou não documentada

Optamos por 3 branchs para versionamento do projeto sendo a `dev` direcionada ao desenvolvimento em versão alpha, ou seja, commits para desenvolvimento sem o debate em grupo e sem testes. No branch `teste` direcionamos a versão beta, ou seja, no processo de testes e debate e com altas chances de bug. Ápos passar por essas duas etapas direcionados com merges para o branch `main`, quando estável e testado.


## Gerenciamento de Projeto

### Divisão de Papéis

##### A equipe se dividiu seguindo o formato proposto pela metodologia Kanban.

- Flow Master: D

- Backend:


- Mobile


- Front (React)
 

- UI/UX


### Processo

O planejamento foi feito utilizando o Github Projects, com o sistema automatizado Kanban. 

Nele temos o direcionamento de tarefas já integrado ao issues do github que quando criadas são automaticamente adicionadas a coluna `Backlog` (Limite de 5), após verificadas são direcionadas para a aba `Começar`, que são tarefas esperando início. Ao serem iniciadas são movidas para a aba `Em Progresso` (Limite de 6, cada um sempre com uma tarefa) e quando completadas movidas para a coluna de `Revisão` para verificação e finalmente quando completadas para aba `Pronto`.
![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/dashdine/assets/98277143/e9364549-6077-46d7-b907-56a7747f18db)

### Ferramentas


| Ferramenta  | Finalidade |
| ------------ | ------------ |
| [Visual Studio Code](https://code.visualstudio.com/ "Visual Studio Code") | Editor de código |
|[Insomnia](https://insomnia.rest/download)| Teste de API|
| [Github Desktop](https://desktop.github.com/ "Github Desktop")  | Controle de branchs, merges e commit com integração ao Visual Studio Code   |
| [Github Projects](https://docs.github.com/en/issues/planning-and-tracking-with-projects/learning-about-projects/about-projects "Github Projects")  | Utilizado para a gestão do projeto e tarefas no modelo Kanban |
| [Discord](https://discord.com/ "Discord")  | Reuniões e avisos/notas |
| [Whatsapp](https://www.whatsapp.com/?lang=pt_BR "Whatsapp")   | Planejamento |
| [Figma](https://www.figma.com/ "Figma") | Desenho de tela (Wireframing) e Diagramas |

O **Visual Studio Code** foi escolhido porque ele possui integração com o **Github Desktop** permitindo visualizar e intercalar o desenvolvimento rapidamente entre os branchs e visualizar commits relevantes.
O **Github Projects** foi escolhido como gerenciamento de projeto devido a integração dos issues direto no repositório.
