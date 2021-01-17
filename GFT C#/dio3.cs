using System;
using System.Text;

class MainClass {
  public static void Main (string[] args) {
        String  c1; //declare as suas variaveis
        String  c2;
        String  c3;

        c1 = Console.ReadLine(); //insira suas variaveis
        c2 = Console.ReadLine();
        c3 = Console.ReadLine();

      if ((c1 == "vertebrado") && (c2 == "ave")  && (c3 == "carnivoro")) {
      
      Console.WriteLine("aguia\n");
      //complete o desafio
    }

     if ((c1 == "vertebrado") && (c2 == "ave")  && (c3 == "onivoro")) {
      
      Console.WriteLine("pomba\n");
      //complete o desafio
    }

     if ((c1 == "vertebrado") && (c2 == "mamifero")  && (c3 == "onivoro")) {
      
      Console.WriteLine("homem\n");
      //complete o desafio
    }

     if ((c1 == "vertebrado") && (c2 == "mamifero")  && (c3 == "herbivoro")) {
      
      Console.WriteLine("vaca\n");
      //complete o desafio
    }

     if ((c1 == "invertebrado") && (c2 == "inseto")  && (c3 == "hematofago")) {
      
      Console.WriteLine("pulga\n");
      //complete o desafio
    }

     if ((c1 == "invertebrado") && (c2 == "inseto")  && (c3 == "herbivoro")) {
      
      Console.WriteLine("lagarta\n");
      //complete o desafio
    }

    if ((c1  == "invertebrado") && (c2  == "anelideo") && (c3 == "onivoro")) {
      Console.WriteLine("minhoca\n");
    }

    if ((c1  == "invertebrado") && (c2  == "anelideo") && (c3 == "hematofago")) {
      Console.WriteLine("sanguessuga\n");
    }
  }
}