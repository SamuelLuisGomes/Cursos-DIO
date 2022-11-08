using ExemploFundamentos.Common.Models; // Caminho referente a pasta Models e a class Pessoa está dentro dessa pasta.











// ---Listas---
// Criando uma lista
// List<string> listaString = new List<string>();

// listaString.Add("SP");
// listaString.Add("BA");
// listaString.Add("RJ");

// Console.WriteLine("Percorrendo a Lista com FOR");
// for(int contador = 0; contador < listaString.Count; contador++){
//     Console.WriteLine($"Posição {contador}° - {listaString[contador]}");
// }

// Console.WriteLine("Percorrendo a Lista com FOREACH");
// int contadorForeach = 0;
// foreach (string estados in listaString)
// {
//     Console.WriteLine($"Posição n° {contadorForeach} - {estados}");
//     contadorForeach++;
// }

// // Declarando um array
// int[] arrayInteiros = new int[3]; 

// Adicionando valores aos índices
// arrayInteiros[0] = 72; 
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;

// ---Redimencionando um array---
// Criando um novo array onde a sua capacidade é a capacidade do arrayInteiros * 2.
// int[] arrayInteirosDobrados = new int[arrayInteiros.Length * 2];
// // Estou copiando os dados  do arrayInteiros para o arrayInteirosDobrados, copiando tudo que está no 1° array.
// Array.Copy(arrayInteiros, arrayInteirosDobrados, arrayInteiros.Length);


// Com o "Resize" podemos alterar o tamanho do Array, dessa forma estamos passando como referência o arrayInteiros e dobrando seu tamanho.
// Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// Usando o "Length" podemos obter o tamanho da váriavel!
// Usando o FOR
// Console.WriteLine("Percorrendo o Array com o FOR");
// for(int contador = 0; contador < arrayInteiros.Length; contador++){
    
//     Console.WriteLine($"Possição n° {contador} - {arrayInteiros[contador]}");
// }
// // Usando o FOREACH
// Console.WriteLine("Percorrendo o Array com o FOREACH");
// foreach (int valor in arrayInteiros)
// {
//     Console.WriteLine(valor);
// }


//----Estruturas de Repetição----
// ----Criando um FOR----

// int numero = 5;

// for(int contador = 0; contador <= 10; contador++){

//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }

// ----Criando um While----

// int numero = 5;
// int contador = 0;

// while(contador <= 10 ){
//     Console.WriteLine($"{contador}° Execução: {numero} x {contador} = {numero * contador}");
//     contador++;

// }

// ----Criando Do While----

// int soma = 0, numero = 0;

// do{
//     Console.WriteLine("Digite um número (0 para encerar!!)");

//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// } while(numero != 0);
//     Console.WriteLine($"Total da soma dos números digitados é: {soma}");

// ----Criando um menu interativo----

// string opcao;
// bool exibirMenu = true;

// while (exibirMenu)
// {

//     Console.WriteLine("Digite a opção: ");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerar");

//     opcao = Console.ReadLine();

//     switch (opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de Clientes\n");
//             break;

//         case "2":
//             Console.WriteLine("Busca de Clientes\n");
//             break;

//         case "3":
//             Console.WriteLine("Apagar Clientes\n");
//             break;

//         case "4":
//             Console.WriteLine("Encerar\n");
//             exibirMenu = false; // Usamos para sair do while e executar o último console.
//             // Enviroment.Exit(0); //Encerra o programa, sem executar mais nada abaixo desse comando!!
//             break;
        
//         default:
//             Console.WriteLine("Opção Inválida!");
//             break;
//     }
// }
//     Console.WriteLine("O programa se encerrou!!");




// Testando Calculadora

// Instanciando a Calculadora.
// Calculadora calc = new Calculadora();

// // Utilizando os métodos criados na Calculadora
// calc.Somar(5,4);
// calc.Subtair(10,8);
// calc.Multiplicar(8,15);
// calc.Dividir(154523156, 1542);
// calc.Potencia(5,5);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(9);



//---Conversão de String---
// int inteiro = 5; // Declarando
// string a = inteiro.ToString(); // Convertendo

//---Tipos de Conversão---
// Cast - Casting

// Declarando e exibindo a variável
// Convertendo
// Convert == int a = Convert.ToInt32("2");
// Parse == int a = int.Parce("2");


// ---Tipo DataTime---
// DateTime dataAtual = DateTime.Now; // Declarando uma DateTime
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm")); // Configurando o formato do DateTime

// ---Tipos de Dados---
// string apresentacao  = "Olá, seja bem vindo!";
// int qtd = 1;
// double altura = 0.80;
// decimal dolar = 1.80M;
// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade: " + qtd);
// Console.WriteLine("Valor da variável altura: " + altura);
// Console.WriteLine("Valor da variável dolar: " + dolar);
// Console.WriteLine("Valor da variável condição: " + condicao);

//---Criando um pessoa---
//  Pessoa p = new Pessoa(); // instanciando uma nova pessoa.
// p.Nome = "Samuel Gomes"; // Adicionando o Nome
//  p.idade = 19; // Adicionando a Idade
//  p.Apresentar(); // Aqui estou chamando o método para apresentar as informações da Pessoa.

