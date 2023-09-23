# Plano de Testes de Software

Testes de usabilidade são fundamentais para garantir que um sistema de criação de currículos seja eficiente, intuitivo e atenda às necessidades dos usuários. Abaixo, apresentamos um conjunto de planos de testes de usabilidade relacionados ao nosso sistema de criação de currículos:  
 
| **Caso de Teste 1: Acesso de Usuário** |                            |
|--------------------------------------|----------------------------|
| **Requisito Referente**              | (RF-01)                    |
|             **Descrição**                         | O usuário deve possuir acesso de maneira simplificada à plataforma, ao utilizar seu e-mail e senha como chaves de acesso à mesma. |
| **Objetivo do Teste**                | Checar se o sistema concretiza o acesso ao sistema de maneira correta e segura. |
| **Passos**                            | **Critérios de Êxito**      |
| 1. Inserir informações como e-mail e senha na tela de login. Caso não possua conta, haverá um botão de cadastro. | A plataforma deve salvar os dados do usuário e redirecioná-lo para a tela principal da plataforma. |
| 2. Após o login, o usuário é redirecionado para a tela de adicionar informações no perfil. Após a realização dessa etapa, ele será redirecionado para a tela principal da plataforma. | A plataforma deve salvar os dados referentes ao perfil do usuário. |


| **Caso de Teste 2: Personalização de Currículo** |                        |
|--------------------------------------|----------------------------|
| **Requisito Referente**                          | (RF-02/RF-03/RF-10) |
|           **Descrição**                                       | O usuário deve ter a possibilidade de customização de seu currículo, adicionando e mudando informações existentes, além do uso de estilos inseridos previamente no desenvolvimento da página para tornar os currículos mais agradáveis e únicos. |
| **Objetivo do Teste**                            | Analisar a facilidade na troca de estilos pré-programados e verificar a intuitividade no uso da ferramenta de troca de visuais. |
| **Passos**                                          | **Critérios de Êxito** |
| 1) Ao entrar na tela inicial da plataforma, o usuário recebe uma solicitação de criação de um currículo após concluir o seu perfil. | A plataforma deve salvar o seu currículo. |
| 2) O usuário terá uma opção na tela de alteração do currículo. | - **Critérios de Êxito 1:** Ser direcionado para uma tela que permite o usuário utilizar inúmeras ferramentas intuitivas para auxiliar e estilizar o currículo ao critério do mesmo. - **Critérios de Êxito 2:** Usuário ver as mudanças em seu currículo após editar suas escolhas. 

| **Caso de Teste 3: Filtragem e Buscas** |                             |
|--------------------------------------|----------------------------|
| **Requisitos Referentes**               | (RF-07/RF-09) |
|           **Descrição**                              | A plataforma precisa fornecer uma fácil opção de busca por currículos e juntamente uma ferramenta de filtragem por capacidades e especializações dos candidatos a busca de vagas. |
| **Objetivo do Teste**                   | Verificar intuitividade e efetividade do sistema em busca e filtragem de currículos. |
| **Passos**                                      | **Critérios de Êxito** |
|1) Após a criação do currículo, uma barra de busca será exibida no cabeçalho da página indicando acesso liberado para buscar currículos.|                    
|2) Ao clicar na lupa, filtros serão exibidos ao lado liberando precisão na busca.|                                                                     
|3) Usuário confirma os filtros e efetua a busca na lupa. |- **Critérios de Êxito:** Usuários terão acesso a uma página específica com currículos previamente filtrados para busca. |

| **Caso de Teste 4: Enriquecimento e Compatibilidade**         |                       |
|-------------------------------------------------|----------------------------|
| **Requisitos Referentes**                                | (RF-08/RF-09/RF-10) |
| **Descrição**                 | A plataforma deve entregar funcionalidades com compatibilidade e integração a outras redes sociais do usuário cadastrado, a ponto de expandir os ramos de conexão do mesmo. |
| **Objetivos do Teste**                                  | Verificar a vitalidade de conexão e integração de outras redes sociais vinculadas ao perfil do usuário. |
| **Passos**                                          | **Critérios de Êxito** |
| 1) Ao terminar a criação de currículo, o usuário terá uma opção no canto superior direito indicando no perfil uma opção de adicionar outras redes sociais. |
| 2) Usuário deve preencher com suas credenciais da rede social desejada para vincular ao site. |
| 3) Quando o usuário clicar na opção, será direcionado para aba de associar links. |- **Critérios de Êxito:** Usuário deve poder cadastrar e validar suas redes sociais ao currículo e perfil criado, obtendo acesso ao se conectar com outros usuários. |