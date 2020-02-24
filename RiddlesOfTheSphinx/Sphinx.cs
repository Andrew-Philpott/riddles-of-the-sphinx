using System;
using System.Collections.Generic;

namespace RiddlesOfTheSphinx {

  public class Sphinx {
    public List<Riddle> riddles = new List<Riddle>() {new Riddle("What has to be broken before you can use it?", "Egg"),  new Riddle("I’m tall when I’m young, and I’m short when I’m old. What am I?", "Candle"), new Riddle("What is full of holes but still holds water", "Sponge")};

    public Sphinx() {
    }

    public Riddle ReturnARandomRiddle() {
      Random rnd = new Random();
      int randomRiddleNumber = rnd.Next(riddles.Count);
      Riddle randomRiddle = riddles[randomRiddleNumber];
      return randomRiddle;
    }
  }
}