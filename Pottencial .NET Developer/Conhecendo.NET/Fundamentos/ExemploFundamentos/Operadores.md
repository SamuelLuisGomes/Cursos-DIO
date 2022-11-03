# Operadores Atribuição
## Convertendo Operadores
Existem duas formas de converter no C#
- Convert
- Parse

Usamos desta forma:<br>
**Convert** <br>
int a = Convert.ToInt32("2");<br>
**Parse**<br>
int a = int.Parce("2");<br>

Ambos são classes que podemos usar para converter um valor para outro, por exemplo uma string para int.
A diferença entre eles é:<br>

A diferença entre eles é na hora de converter um número **null**  <br>
**Convert** <br>
Ele vai retornar **0**<br>
**Parse**<br>
Já o Parce irá apresentar um erro.<br>

O mais indicado é usar o **Convert**, pois é comum em uma aplicação retornar o valor **null**, se estivermos utilizando o **Parce** nossa aplicação irá parar enquando com o **Convert** poderemos continuar rodando a aplicação, criando uma validação para o **0** se necessário.<br>

## Convertendo String<br>
No C# não utilizamos **Convert** ou **Parce** quando se trata de converter _string_, pois podemos fazer dessa forma:<br>
- string a = inteiro.ToString();<br>

Fazemos dessa forma por que o C# já tem por caracteristica que tudo dentro dele seja possível utilizar o ToStrin();<br>

## Conversão impícita
Se tentarmos converter um int para um long é possível:<br>
int a = 5;<br>
long b = a;

Nesse caso estamos fazendo uma converção implícita, porém se invertemos os tipos não será possível

long a = 5;<br>
int b = a;

Não será possível pois o **long** suporta até **trilhões** e o **int bilhões**, podemos contornar isso fazendo o seguinte:

long a = 5;<br>
int b = Convert.Int32(a);

Porém seu programa pode quebrar se o número contido no **"a"** for maior que bilhão.<br>

# Operadores Aritmédicos

