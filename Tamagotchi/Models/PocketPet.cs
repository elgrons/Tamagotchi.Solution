using System.Collections.Generic;
using MySqlConnector;
using System;

namespace Tamagotchi.Models
{
  public class PocketPet
  {
    public string Name {get; set;}
    public int Hunger {get; set;}
    public int Happiness {get; set;}
    public int Fatigue {get; set;}

    public int Id { get; set; }

    private static List<PocketPet> _petparty = new List<PocketPet> { };
    public PocketPet(int id, string name)
    {
      Name = name;
      Hunger = 10;
      Happiness = 10;
      Fatigue = 10;
      Id = id;
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

    public override bool Equals(System.Object otherPocketPet)
    {
      if (!(otherPocketPet is PocketPet))
        {
          return false;
        }
        else
        {
          PocketPet newPocketPet = (PocketPet) otherPocketPet;
          bool idEquality = (this.Id == newPocketPet.Id);
          bool nameEquality = (this.Name == newPocketPet.Name);
          return (idEquality && nameEquality);
        }
    }

    public override int GetHashCode()
    {
      return Id.GetHashCode();
    }

    public void Save()
    {
      MySqlConnection conn = new MySqlConnection(DBConfiguration.ConnectionString);
      conn.Open();

      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;

      cmd.CommandText = "INSERT INTO pocketPets (name) VALUES (@PocketPetName);";
      MySqlParameter param = new MySqlParameter();
      param.ParameterName = "@PocketPetName";
      param.Value = this.Name;
      cmd.Parameters.Add(param);
      cmd.ExecuteNonQuery();
      Id = (int) cmd.LastInsertedId;

      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }

    public static List<PocketPet> GetAll()
    {
     // return _petparty;
    List<PocketPet> allPocketPets = new List<PocketPet> {};
    MySqlConnection conn = new MySqlConnection(DBConfiguration.ConnectionString);

    conn.Open();

    MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
     cmd.CommandText = "SELECT * FROM pocketPets;";

    MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;

    while (rdr.Read())
    {
        int petPocketId = rdr.GetInt32(0);
        string pocketPetName = rdr.GetString(1);
        PocketPet newPocketPet = new PocketPet(petPocketId, pocketPetName);
        allPocketPets.Add(newPocketPet);
    }
      conn.Close();
      if ( conn != null)
      {
        conn.Dispose();
      }
      return allPocketPets;
    }

    public static void ClearAll()
    {
      MySqlConnection conn = new MySqlConnection(DBConfiguration.ConnectionString);
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = "DELETE FROM pocketPets;";
      cmd.ExecuteNonQuery();

      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }

    public static PocketPet Find(int searchId)
    {
      // return _petparty[searchId-1];

      PocketPet placeholderPocketPet = new PocketPet(1, "Placeholder pet");
      return placeholderPocketPet;
    }

    public static PocketPet Delete(int searchId)
    {
      PocketPet pet = PocketPet.Find(searchId);
      _petparty.Remove(pet);
      return pet;
    }
  }
}