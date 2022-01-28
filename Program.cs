using System;

namespace Newschool{


class MainClass {
  public static void Main (string[] args) {
Console.WriteLine("Hello, World!");
Console.WriteLine("Semaphore" + Semaphore.Green);
  }

  

  
}

enum Semaphore{
      Red = 100,
      Yellow = 200,
      Green = 300
  }
}