using System;


class Program {
  public static void Main (string[] args) {
    DateTime agora = DateTime.Now;
    int hora = agora.Hour;

//aplicação que recebe a hora do dia e retorno com uma mensagem (bom dia, boa tarde, boa noite)
    
    if(hora <= 11){
      Console.WriteLine("Bom dia");
    }
    if(hora >= 12 && hora <= 18){
      Console.WriteLine("Boa tarde");
    }

     if(hora >= 19){
      Console.WriteLine("Boa noite");
    }
      Console.WriteLine("Diga seu nome");
      String nome = Console.ReadLine();

    Console.WriteLine("Digite a data de nascimento (formato: dd/mm/yyyy):");
    string dataDoNascimento = Console.ReadLine();

// calculo da idade
    
    if (DateTime.TryParseExact(dataDoNascimento, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dataNascimento))
            {
                DateTime dataAtual = DateTime.Today;
                int idade = dataAtual.Year - dataNascimento.Year;


              if (dataAtual < dataNascimento.AddYears(idade))
                {
                    idade--;
                }
              Console.WriteLine($"Seu nome é {nome} e você têm {idade} anos de idade");
}
     
  }
}
