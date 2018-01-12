# WebAPI-ValidationModel
WebAPI-ValidationModel


Validando Models em WebAPIs
Atualmente em meu dia a dia estou buscando da melhor forma usar código limpo (Clean Code) e aplicar isso nos meus projetos.

Abaixo segue um exemplo onde o programador repetiu várias vezes a mesma função e isso fere os princípios do DRY (Don’t Repeat Yourself).


Esse check para o ModelState.IsValid poderia ser refatorado e não ter a necessidade de repetir ele toda vez, o que realmente importa para o nosso controller é o return do Json e só! Para resolver esse problema: podemos fazer da seguinte forma:

Criar um ModelStateValidationActionFilterAttribute (o nome até lembra aqueles produtos Tabajara® :P)


Feito isso, basta apenas decorar os métodos:


Ou você pode apenas usar o atributo antes da declaração da classe e todos os métodos do controller irão herdar essa propriedade.

<a href="https://medium.com/@thiagoloureiro/validando-models-em-webapis-e2471949b49c">https://medium.com/@thiagoloureiro/validando-models-em-webapis-e2471949b49c</a>
