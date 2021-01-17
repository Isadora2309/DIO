using System;

class Program {

  static void Main(string[] args) {
    int numeroDeFigurinhas = Int32.Parse(Console.ReadLine());
    int numeroDeFigurinhasCompradas = Int32.Parse(Console.ReadLine());
    int totalDeFigurinhas = 0;

    int[] albumDeFigurinha = new int[numeroDeFigurinhas];
    int[] figurinhas = new int[numeroDeFigurinhasCompradas];

    if (numeroDeFigurinhasCompradas > 0) {
      for (int i = 0; i < numeroDeFigurinhasCompradas; i++) {
      string figurinha = Console.ReadLine();

      if(!string.IsNullOrEmpty(figurinha)){
        figurinhas[i] = int.Parse(figurinha);
      }
    }

    int figurinhaIguais = 0;
    int repeticao = 0;
    int index = 0;

    for (int i = 0; i < numeroDeFigurinhasCompradas; i++) {
      if(repeticao > 1) {
        figurinhaIguais++;
      }

      if(repeticao <= 1) {
        albumDeFigurinha[index] = figurinhas[i];
        index++;
        totalDeFigurinhas++;
      }
      repeticao = 0;
      for (int j= i; j < numeroDeFigurinhasCompradas; j++){
        if (figurinhas[i] != 0) {
          if(figurinhas[i] == figurinhas[j]) {
            repeticao++;
          }
        }
      }
    }
    }

    int numeroDeFigurinhasQueFalta = numeroDeFigurinhas - totalDeFigurinhas;
    Console.WriteLine(numeroDeFigurinhasQueFalta);

  }

  }