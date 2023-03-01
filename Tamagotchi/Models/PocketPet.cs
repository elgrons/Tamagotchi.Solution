using System.Collections.Generic;
using System;

namespace Tamagotchi.Models
{
  public class PocketPet
  {
    public string Name {get; set;}
    public int Hunger {get; set;}
    public int Happiness {get; set;}
    public int Fatigue {get; set;}

    public int Id { get; }

    private static List<PocketPet> _petparty = new List<PocketPet> { };
    public PocketPet(string name)
    {
      Name = name;
      Hunger = 10;
      Happiness = 10;
      Fatigue = 10;
      _petparty.Add(this);
      Id = _petparty.Count;
    }
    public void Feed()
    {
      this.Hunger += 4;
    }
    public void Rumpus()
    {
      this.Happiness += 4;
    }
    public void Sleep()
    {
      this.Fatigue += 4;
    }

    public void Time()
    {
      this.Hunger -= 1;
      this.Happiness -= 1;
      this.Fatigue -= 1;
    }

    public void FoodFight()
    {
      this.Happiness +=3;
      this.Hunger +=3;
      this.Fatigue -=3;
    } 

    public static List<PocketPet> GetAll()
    {
      return _petparty;
    }

    public static void ClearAll()
    {
      _petparty.Clear();
    }

    public static PocketPet Find(int searchId)
    {
      return _petparty[searchId-1];
    }
  }
}