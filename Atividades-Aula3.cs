/* (6) Calculando a média de 4 notas e onome do aluno, caso seja
menor que 6 aperaça reprovado senão aprovado */

using System;

public class MediaAluno
{ 
    static void Main(string[] args)
   { // declarando array de notas e variavel nome do aluno
       double[] notas = new double[4];
       string aluno;
       Console.WriteLine("Digite o nome do aluno: ");
       aluno = Console.ReadLine();       
       
       // utilizando for para ler as notas e usando o (Length) em de querer alterar o numero de temos do array n alterar o codigo todo
       for( int i = 0; i < notas.Length; i++)
       {
           Console.WriteLine(" Insira a "+(i+1)+ "ª nota:");
           notas[i] =double.Parse(Console.ReadLine());
       }
       // declarando a variavel soma e lendo todos os valores inseridos
       double media, soma = 0;
       
       // cada vez que ler uma nota irá somar com outra nota
       for(int i = 0; i < notas.Length; i++)
       {
           soma += notas[i]; 
           
       }
       media = (soma/notas.Length);
       Console.WriteLine(aluno +" sua média é: " + media);
       
       if(media < 6)
       {
           Console.WriteLine(aluno+ " REPROVADO!");
       }
       else
       { 
           Console.WriteLine(aluno+ " APROVADO!");
       }
       }
   }

   public class Program
   {
    static void Main (string[] args)
    { // 2- Exiba 10% de um número

        // variáveis:
        double num, P;
        
        Console.WriteLine("Digite um valor e será calculada a porcentagem de 10% desse valor: ");
        num = double.Parse(Console.ReadLine());
        
        // calculo: 
        P = (10.0 / 100) * num;

        // imprimir no console:
        Console.WriteLine("10% de " + num + " e: " + P + "%");
        Console.ReadKey();
       }
    
    }
    
    public class MediaValor
    {
        public static void Main(string[] args)
        {
            // Calcule a media de 5 valores

            // declarando variáveis e array

            double [] valor = new double[5];
            double soma, media;

            // utilizando (for) para armazenar valores

            Console.WriteLine("Digite 5 valores para ser calcula a media: ")

            for(int i = 0; i < valor.Length; i++)
            {
                Console

            }

        }
    }

