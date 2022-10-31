# Tipo de Dados em C#

string apresentacao  = "Olá, seja bem vindo!";<br>
int qtd = 1;<br>
double altura = 0.80;<br>
decimal dolar = 1.80M; // No caso de estarmos falando de valores monetários, precisamos atribuir o M no final do valor, 
para que as casas decimais fiquem corretas.<br>
bool condicao = true;

**Tipo DataTime**<br>
Declarando uma DateTime<br>
> DateTime dataAtual = DateTime;<br>

Podemos adicionar o Now ao final para que ele pegue a data atual do computador.<br>
DateTime dataAtual = DateTime.Now;<br>

Podemos também adicionar dias, horas, minutos e segundos a hora atual dessa forma:<br>

Adicionando +5 dias na data atual do computador.<br>
DateTime dataAtual = DateTime.Now.AddDays(5); <br>

Conseguimos manipular o formato da data também:<br>
>Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));<br>
Se precisarmos de hora e minutos podemos adicionar HH:mm, caso não basta colocar **dd/MM/yyyy**<br>