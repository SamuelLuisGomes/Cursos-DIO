# **Clases**
É uma representação de um objeto do mundo real!.<br>
Como se fosse uma planta de uma casa, ela não é própriamente uma casa, mas a idéia de uma.

### **Ponto de Entrada do Sistema**
#### **Program.cs**
Ele é a porta de entrada do nosso sistema.

### **Caminhos Virtuais**
Os **namespaces** são os caminhos virtuais dentro do nosso projeto .NET, onde localizamos os arquivos. no caso:
    Para usarmos a class Pessoa que está dentro de Models, adicionamos:
 
- **using Fundamentos.Models;**

Depois disso podemos incluir a class Pessoa no projeto:

- **Pessoa p = new Pessoa();**

Porém uma coisa que temos que entender, estamos nos referenciando não só a Pessoa mas sim a class Pessoa dentro de Models, ou seja, ela na realidade não é somente **using Fundamentos.Models**, ela é dessa forma:

- **using Fundamentos.Models.Pessoa;**

Poderiamos Inserir outra class Pessoa desde que esteja em outro caminho(namespace).

### **Instanciando**
Para instanciarmos uma nova Pessoa temos que inserir:
- Pessoa p = new Pessoa();

A parte de **Pessoa p** é que estamos dizendo que queremos cirar uma nova planta com o nome p.<br>
Já o final que seria **= new Pessoa();** é quando realmente criamos essa planta, ou seja, a primeira parte diz qual o tipo da variável que eu quero, no caso seria uma variável do tipo _Pessoa_ e o nome, no caos _p_ e no final aplico o comando de criação.

# **Convenções**
## **Cases**
> São padrões de escrita.
São algumas convenções usadas por programadores para organizar seu código
### **Convenções case**
Existem diferentes cases entre eles:
- camelCase
- PascalCase
- snake_case
- spinal-case

Os usados no c# é usado o **camelCase** e o **PascalCase**<br>

Pessoa Física em cada case:<br>

camelCase = **pessoaFisica**<br>
PascalCase = **PessoaFisica**<br>
snake_case = **pessoa_fisica**<br>
spinal-case = **pessoa-fisica**<br>

Em classes, propriedades e métodos sempre usamos **PascalCase**<br>
Já em variáveis usamos o **camelCase**<br>

## **Escrita**
### **Nomes**
> Não é recomendada abreviações nos nomes.
### **Nome das Classes**
> Por convenção sempre o nome da Classe e o nome do arquivo sejão os mesmos.<br>
Exemplo Errado:<br>
Arquivo = Pessoa.cs<br>
Classe = public class PessoaFisica{}<br>
==================================<br>
Exemplo Certo:<br>
Arquivo = Pessoa.cs<br>
Classe = public class Pessoa{}<br>
### Caracteres Especiais
> O único caracter especial que pode ser usando no nome é o **underline**, seja no começo, meio ou final no nome.