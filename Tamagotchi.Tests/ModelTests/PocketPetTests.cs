using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tamagotchi.Models;
using System.Collections.Generic; 
using Microsoft.Extensions.Configuration;
using System;

namespace Tamagotchi.Tests
{
  [TestClass]
  public class PocketPetTests : IDisposable
  {
    public IConfiguration Configuration { get; set; }

    public void Dispose()
    {
      PocketPet.ClearAll();
    }

    public PocketPetTests()
    {
      IConfigurationBuilder builder = new ConfigurationBuilder()
          .AddJsonFile("appsettings.json");
      Configuration = builder.Build();
      DBConfiguration.ConnectionString = Configuration["ConnectionStrings:TestConnection"];
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyListFromDatabase_PocketPetList()
    {
      //Arrange
      List<PocketPet> newPetList = new List<PocketPet> { };
      //Act
      List<PocketPet> result = PocketPet.GetAll();
      //Assert
      CollectionAssert.AreEqual(newPetList, result);
    }

    [TestMethod]
    public void ReferenceTypes_ReturnsTrueBecauseBothPocketPetsAreSameReference_Bool()
    {
      PocketPet firstPet = new PocketPet(1, "Anastasia");
      PocketPet copyOfFirstPet = firstPet;
      copyOfFirstPet.Name = "Puddle";
      Assert.AreEqual(firstPet.Name, copyOfFirstPet.Name);
    }

    [TestMethod]
    public void ValueTypes_ReturnsTrueBecauseValuesAreTheSame_Bool()
    {
      int test1 = 1;
      int test2 = 1;
      Assert.AreEqual(test1, test2);
    }

    [TestMethod]
    public void Save_SavesToDatabase_PocketPetList()
    {
      PocketPet testPocketPet = new PocketPet(1, "Simon");
      testPocketPet.Save();
      List<PocketPet> result = PocketPet.GetAll();
      List<PocketPet>testList = new List<PocketPet>{testPocketPet};
      CollectionAssert.AreEqual(testList, result);
    }

    
  }
}

//     [TestMethod]
//     public void PocketPetConstructor_CreatesInstanceOfPocketPet_PocketPet()
//     // NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
//     {
//       // Arrange
//       PocketPet newPet = new PocketPet(1, "Simon");
//       // Act
//       //not needed here
//       // Assert
//     Assert.AreEqual(typeof(PocketPet), newPet.GetType());
//     }

//     [TestMethod]
//     public void PocketPetConstructor_HasNameAttribute_String()
//     {
//       //arrange
//       PocketPet newPet = new PocketPet(1, "Simon");
//       //act
//       //assert
//       Assert.AreEqual("Simon", newPet.Name);
//     }
//     [TestMethod]
//     public void PocketPetConstructor_Has10HungerAtBirth_Int()
//     {
//       //arrange
//       PocketPet newPet = new PocketPet(1, "Simon");
//       //act
//       //assert
//       Assert.AreEqual(10, newPet.Hunger);
//     }
//     [TestMethod]
//     public void PocketPetConstructor_Has10HappinessAtBirth_Int()
//     {
//       //arrange
//       PocketPet newPet = new PocketPet(1, "Simon");
//       //act
//       //assert
//       Assert.AreEqual(10, newPet.Happiness);
//     }
//     [TestMethod]
//     public void PocketPetConstructor_Has10FatigueAtBirth_Int()
//     {
//       //arrange
//       PocketPet newPet = new PocketPet(1, "Simon");
//       //act
//       //assert
//       Assert.AreEqual(10, newPet.Fatigue);
//     }
//     [TestMethod]
//     public void Feed_Adds4Hunger_Int()
//     {
//       //arrange
//       PocketPet newPet = new PocketPet(1, "Simon");
//       //act
//       newPet.Feed();
//       //assert
//       Assert.AreEqual(14, newPet.Hunger);
//     }
//     [TestMethod]
//     public void Rumpus_Adds4Happiness_Int()
//     {
//       //arrange
//       PocketPet newPet = new PocketPet(1, "Simon");
//       //act
//       newPet.Rumpus();
//       //assert
//       Assert.AreEqual(14, newPet.Happiness);
//     }
//     [TestMethod]
//     public void Sleep_Adds4Fatigue_Int()
//     {
//       //arrange
//       PocketPet newPet = new PocketPet(1, "Simon");
//       //act
//       newPet.Sleep();
//       //assert
//       Assert.AreEqual(14, newPet.Fatigue);
//     }
//     [TestMethod]
//     public void Time_Subtracts1Hunger1Happiness1Fatigue_Int()
//     {
//       //arrange
//       PocketPet newPet = new PocketPet(1, "Simon");
//       //act
//       newPet.Time();
//       //assert
//       Assert.AreEqual(9, newPet.Hunger);
//       Assert.AreEqual(9, newPet.Happiness);
//       Assert.AreEqual(9, newPet.Fatigue);
//     }
//     [TestMethod]
//     public void FoodFight_Adds3Hunger3HappinessSubtracts3Fatigue_Int()
//     {
//       //arrange
//       PocketPet newPet = new PocketPet(1, "Simon");
//       //act
//       newPet.FoodFight();
//       //assert
//       Assert.AreEqual(13, newPet.Hunger);
//       Assert.AreEqual(13, newPet.Happiness);
//       Assert.AreEqual(7, newPet.Fatigue);
//     }

    

//     [TestMethod]
//     public void Find_ReturnsCorrectPocketPet_PocketPet()
//     {
//       //Arrange
//       int petPocketId01 = 1;
//       int petPocketId02 = 2;
//       string name1 = "Simon";
//       string name2 = "Archipelago";
//       PocketPet newPet1 = new PocketPet(petPocketId01, name1);
//       PocketPet newPet2 = new PocketPet(petPocketId02, name2);
//       //Act
//       PocketPet result = PocketPet.Find(2);
//       //Assert
//       Assert.AreEqual(newPet2, result);
//     }
//   }
// }