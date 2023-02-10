using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    Double salarioh, hstrabalhadas, hsextras, salariohex, salarioex, 
    salariofinal; 
    String entrada;
    
    Console.WriteLine("Quantidade de horas trabalhas ao longo do mês:");
    entrada = Console.ReadLine();
    hstrabalhadas = Double.Parse(entrada);
    Console.WriteLine("Salário por hora de trabalho concedida:");
    entrada = Console.ReadLine();
    salarioh = Double.Parse(entrada);
    hsextras = hstrabalhadas - 160.0;
    salariohex = salarioh * 1.5;
    salarioex = salariohex * hsextras;
    salariofinal = (salariohex * hsextras) + (160.0 + salarioh);
    Console.WriteLine("Salário: " + 160.0*salarioh);
    Console.WriteLine("Salário das horas extras é: " + salarioex);
    Console.WriteLine("O salário final é: " + salariofinal);
  }
}