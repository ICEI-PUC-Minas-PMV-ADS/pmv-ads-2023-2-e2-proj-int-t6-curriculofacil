# Especificações do Projeto

A definição exata do problema e os pontos mais relevantes a serem tratados neste projeto foi consolidada com a participação dos usuários em um trabalho de imersão feita pelos membros da equipe a partir da observação dos usuários em seu local natural e por meio de entrevistas. Os detalhes levantados nesse processo foram consolidados na forma de personas e histórias de usuários. 

## Personas

As personas levantadas durante o processo de entendimento do problema são apresentadas na Figuras que se seguem. 

<h3>Persona 1</h3>
<table>
      <tr>
        <td>Nome/Idade</td>
        <td>Marina - 25 anos</td>
      </tr>
      <tr>
        <td>Profissão</td>
        <td>Recém-formada em Design Gráfico</td>
      </tr>
      <tr>
        <td>História</td>
        <td>Marina acaba de se formar em Design Gráfico e está em busca de sua primeira oportunidade profissional. </td>
      </tr>
      <tr>
        <td>Motivação</td>
        <td>Ela deseja destacar suas habilidades de design de maneira única em seu currículo.</td>
      </tr>
      <tr>
        <td>Desafio</td>
        <td>Um site permitiria que Marina criasse um currículo interativo, com seções dedicadas a seu portfólio, projetos destacados. </td>
      </tr>
      <tr>
        <td>Ferramenta em uso atualmente: </td>
        <td>Word </td>
      </tr>
</table>

<br><br>

<h3>Persona 2</h3>
<table>
      <tr>
        <td>Nome/Idade</td>
        <td>Ricardo – 32 anos</td>
      </tr>
      <tr>
        <td>Profissão</td>
        <td>Engenheiro</td>
      </tr>
      <tr>
        <td>História</td>
        <td>Ricardo trabalhou por muitos anos como engenheiro, mas recentemente decidiu mudar para o campo de marketing digital.</td>
      </tr>
      <tr>
        <td>Motivação</td>
        <td>Ele gostaria de realçar suas habilidades transferíveis e sua paixão pela nova área em seu currículo.</td>
      </tr>
      <tr>
        <td>Desafio</td>
        <td>Com um site, ele poderia criar uma seção onde detalharia como suas habilidades de análise e resolução de problemas se relacionam com o marketing digital. Além disso, poderia incorporar links para artigos</td>
      </tr>
      <tr>
        <td>Ferramenta em uso atualmente: </td>
        <td>OnlineCv</td>
      </tr>
</table>

<br><br>

<h3>Persona 3</h3>
<table>
      <tr>
        <td>Nome/Idade</td>
        <td>Carla – 38 anos</td>
      </tr>
      <tr>
        <td>Profissão</td>
        <td>Graduada em Psicologia, com pós-graduação em Gestão de Pessoas</td>
      </tr>
      <tr>
        <td>História</td>
        <td>Carla é uma profissional dedicada e apaixonada pelo seu trabalho como gestora de Recursos Humanos. Ela trabalha em uma empresa de médio porte há mais de 10 anos e desempenha um papel crucial na seleção de novos talentos para a organização.</td>
      </tr>
      <tr>
        <td>Motivação</td>
        <td>No entanto, Carla enfrentou uma dificuldade recorrente no seu dia a dia: a busca e filtragem de currículos </td>
      </tr>
      <tr>
        <td>Desafio</td>
        <td>Carla deseja encontrar uma solução que simplifique e agilize seu processo de recrutamento, permitindo-lhe encontrar candidatos com as habilidades e experiência permitidas de maneira mais rápida e precisa.</td>
      </tr>
      <tr>
        <td>Ferramenta em uso atualmente: </td>
        <td>Canvas</td>
      </tr>
</table>

## Histórias de Usuários

A partir da compreensão do dia a dia das personas identificadas para o projeto, foram registradas as seguintes histórias de usuários. 

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Marina  | Poder criar de forma simples um currículo eficiente| Me candidatar a uma vaga com uma maior taxa de sucesso                |
|Ricardo| Poder escolher qual estrutura de currículo se encaixa melhor a minha realidade| Para encaixar melhor as informações de experiencias |
|Carla | Poder procurar um currículo sobre uma profissão especifica|Encontrar o melhor candidato  |
|Ricardo| Poder ter disponível o currículo armazenado no site  |Para que empresas consigam me encontrar |
|Maria| | Permitir que possam administrar contas |
|Maria| Ter opções de baixar ou compartilhar o currículo. | Para que possa imprimi-lo ou compartilhá-lo em minhas redes  |
|Carla |Encontrar um candidato por meio de suas habilidades (hard skills)|Para encontrar candidatos que combinem com a cultura da empresa|
|Ricardo |Conseguir obter algum feedback sobre meu currículo|Para saber se obtive algum resultado com aquele currículo  |
|Ricardo|poder escolher templates diferentes para o mesmo currículo| Para ter outras opções e poder escolher a que melhor me atender  |


## Requisitos

O escopo funcional do projeto é definido por meio dos requisitos funcionais que descrevem as possibilidades interação dos usuários, bem como os requisitos não funcionais que descrevem os aspectos que o sistema deverá apresentar de maneira geral. Estes requisitos são apresentados a seguir. 

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| Os usuários registrados devem poder fazer login de maneira segura, usando suas credenciais de conta  | ALTA | 
|RF-002| Os usuários ou empresa devem ter a capacidade de criar, editar e excluir seus perfis incluindo a adição ou remoção de informações| ALTA |
|RF-003| Os usuários devem ter a opção de personalizar o design e a aparência visual de seus currículos, escolhendo entre diferentes modelos ou estilos. | ALTA |
|RF-004| Deve ter disponivel a possibilidade de contatar usuários aptos para determinada empresa ou vaga | MÉDIA |
|RF-005| Os usuários devem ser capazes de visualizar seus currículos no site antes de decidirem torná-los públicos ou compartilhá-los.    | ALTA |
|RF-006| Os usuários devem ter opções para definir a visibilidade de seus currículos, podendo torná-los públicos, privados ou acessíveis apenas por meio de links diretos.| MÉDIA |
|RF-007| Os empregadores ou recrutadores devem ser capazes de pesquisar currículos com base em critérios como habilidades, experiência ou localização.| MÉDIA |
|RF-008| Os usuários devem ter a opção de vincular seus perfis de redes sociais ao currículo, para fornecer mais informações sobre si mesmos.| BAIXA |
|RF-009| Os usuários devem poder compartilhar seus currículos por meio de links ou imprimir versões em formato legível. | BAIXA |
|RF-010| Os usuários devem poder adicionar seções personalizadas ao currículo, como um resumo profissional, portfólio ou prêmios.   | BAIXA |


### Requisitos não Funcionais

A tabela a seguir apresenta os requisitos não funcionais que o projeto deverá atender. 

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O site deve se acessível na web.  | ALTA | 
|RNF-002| O site deverá ser responsivo permitindo a visualização em um celular de forma adequada.  |  ALTA | 
|RNF-003| Funcionamento do site 24/7  |  MÉDIA | 
|RNF-004| O projeto deve ser entregue no final do semestre letivo |  BAIXA | 

## Restrições

As questões que limitam a execução desse projeto e que se configuram como obrigações claras para o desenvolvimento do projeto em questão são apresentadas na tabela a seguir. 

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|RE-01| O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data de 06/12/2023. |
|RE-02| O aplicativo deve se restringir às tecnologias básicas da Web no Frontend e Backend |
|RE-03| O projeto deve ser construído apenas por pessoas da equipe |

## Diagrama de Casos de Uso

<img src="img/Currículo fácil.jpeg" alt="Diagrama de Casos de Uso">
