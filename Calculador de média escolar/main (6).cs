using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Digite o nome do aluno:");
        string nome;
        nome = Console.ReadLine();
        
        Console.WriteLine ("Digite a primeeira nota do aluno:");
        double nota1;
        nota1 = double.Parse(Console.ReadLine());
        
        Console.WriteLine ("Digite a segunda nota do aluno:");
        double nota2;
        nota2 = double.Parse(Console.ReadLine());
        
        Console.WriteLine ("Digite a terceira nota do aluno:");
        double nota3;
        nota3 = double.Parse(Console.ReadLine());
        
        Console.WriteLine ("Digite a última nota do aluno:");
        double nota4;
        nota4 = double.Parse(Console.ReadLine());
        
        double media;
        media = (nota1 + nota2 + nota3 + nota4) / 4;
        
        Console.WriteLine("A MÉDIA FINAL DO ALUNO É DE:" + media);
        
        if (media < 6.0)  {
            Console.WriteLine("ESTE ALUNO FOI REPROVADO");
        }
        else if (media > 6.0) {
            Console.WriteLine("ESTE ALUNO FOI APROVADO");
        }
        
        Console.WriteLine("Deseja calcular a média de outro aluno digite 'x' se deseja encerrar o programa digite 's' ");
        char repetir;
        repetir = char.Parse(Console.ReadLine());
        
        if (repetir == 's') {
         Console.WriteLine("Seu programa de calcular média escolar, foi concluído e finalizado com sucesso");
        }
        
        while (repetir == 'x') {
            Console.WriteLine ("Digite o nome do aluno:");
            nome = Console.ReadLine();
            
            Console.WriteLine ("Digite a primeeira nota do aluno:");
            nota1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine ("Digite a segunda nota do aluno:");
            nota2 = double.Parse(Console.ReadLine());
            
            Console.WriteLine ("Digite a terceira nota do aluno:");
            nota3 = double.Parse(Console.ReadLine());
            
            Console.WriteLine ("Digite a última nota do aluno:");
            nota4 = double.Parse(Console.ReadLine());
            
            media = (nota1 + nota2 + nota3 + nota4) / 4;
            
            Console.WriteLine("A MÉDIA FINAL DO ALUNO É DE:" + media);
            
            if (media < 6.0)  {
            Console.WriteLine("ESTE ALUNO FOI REPROVADO");
        }
        else if (media > 6.0) {
            Console.WriteLine("ESTE ALUNO FOI APROVADO");
        }
        Console.WriteLine("Deseja calcular a média de outro aluno digite 'x' ");
        repetir = char.Parse(Console.ReadLine());
        
        if (repetir != 'x') {
         Console.WriteLine("Seu programa de calcular média escolar, foi concluído e finalizado com sucesso");
        }
            
        }
    
    }
}
