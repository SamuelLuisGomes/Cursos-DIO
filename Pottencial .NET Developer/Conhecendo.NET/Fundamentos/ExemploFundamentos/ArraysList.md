# Arrays e Listas
## Array
O array é uma estrutura de dados que armazena valores do mesmo tipo, com um tamanho fixo.

### **Declarando array:**
```
Criando e definindo o valor:
int    [] array = new int[4]

Criando e inserindo os valores omitindo o tamanho:
int    [] array = new int[]{42,75,74,61};

Criando e passando os valores
string [] nomes = {"Jan","Fev"}
```
### **Índice:**
É a posição de um determinado valor de um array, sempre começando com zero no C#.
```
Acessando os valores:

Nesse caso estou acessando o valor que está no índice 0.
int elemento = array[0];

Já aqui posso adicionar ou substituir o valor do índice 0.
array[0] = 42;
```
**Exemplo Array**
```
Declarando array:
int[] arrayInteiros = new int[3]; 

Adicionando valores aos índices:
arrayInteiros[0] = 72; 
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
```
**Redimencionar um Array**
Case seja preciso podemos redimensionar um array dessa forma:
```
Criando um novo array onde a sua capacidade é a capacidade do arrayInteiros * 2:
int[] arrayInteirosDobrados = new int[arrayInteiros.Length * 2];

Estou copiando os dados  do arrayInteiros para o arrayInteirosDobrados, copiando tudo que está no 1° array:
Array.Copy(arrayInteiros, arrayInteirosDobrados, arrayInteiros.Length);
```
Também é possível dessa:
```
Com o "Resize" podemos alterar o tamanho do Array, dessa forma estamos passando como referência o arrayInteiros e dobrando seu tamanho:
Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);
```
**Usando FOR e FOREACH para percorrer o array**
**FOR:**
```
Usando o "Length" podemos obter o tamanho da váriavel!

Console.WriteLine("Percorrendo o Array com o FOR");

for(int contador = 0; contador < arrayInteiros.Length; contador++){
    
    Console.WriteLine($"Possição n° {contador} - {arrayInteiros[contador]}");
}

```
**FOREACH:**
```
Console.WriteLine("Percorrendo o Array com o FOREACH");

foreach (int valor in arrayInteiros)
{
    Console.WriteLine(valor);
}
```
## Lista
**Exemplo Lista:**
```
Declarando Lista

List<string> listaString = new List<string>();

Adicionando Valores
listaString.Add("SP");
listaString.Add("BA");
listaString.Add("RJ");
```
**Percorrendo uma Lista com FOR e FOREACH**

**FOR:**
```
Console.WriteLine("Percorrendo a Lista com FOR");

for(int contador = 0; contador < listaString.Count; contador++){

    Console.WriteLine($"Posição {contador}° - {listaString[contador]}");
}
```
**FOREACH:**
```
Console.WriteLine("Percorrendo a Lista com FOREACH");

int contadorForeach = 0;
foreach (string estados in listaString)
{
    Console.WriteLine($"Posição n° {contadorForeach} - {estados}");
    contadorForeach++;
}
```
**Length:**
```
Usando ele podemos obter o tamanho da variável, exemplo: determinado array pode estar usando 5 índices.
```
**Count**
```
Usando ele podemos obter qual seu tamanho máximo, exemplo: Determinado array tem tamanho máximo de 8 índices.
```

