using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tamagotchi.Models;
using System.Collections.Generic; 
using System;

namespace Tamagotchi.Tests
{
  [TestClass]
  public class PocketPetTests
  {
    [TestMethod]
    public void PocketPetConstructor_CreatesInstanceOfPocketPet_PocketPet()
    // NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    {
      // Arrange
      PocketPet newPet = new PocketPet("Simon");
      // Act
      //not needed here
      // Assert
    Assert.AreEqual(typeof(PocketPet), newPet.GetType());
    }

    [TestMethod]
    public void PocketPetConstructor_HasNameAttribute_String()
    {
      //arrange
      PocketPet newPet = new PocketPet("Simon");
      //act
      //assert
      Assert.AreEqual("Simon", newPet.Name);
    }
    [TestMethod]
    public void PocketPetConstructor_Has10HungerAtBirth_Int()
    {
      //arrange
      PocketPet newPet = new PocketPet("Simon");
      //act
      //assert
      Assert.AreEqual(10, newPet.Hunger);
    }
    [TestMethod]
    public void PocketPetConstructor_Has10HappinessAtBirth_Int()
    {
      //arrange
      PocketPet newPet = new PocketPet("Simon");
      //act
      //assert
      Assert.AreEqual(10, newPet.Happiness);
    }
    [TestMethod]
    public void PocketPetConstructor_Has10FatigueAtBirth_Int()
    {
      //arrange
      PocketPet newPet = new PocketPet("Simon");
      //act
      //assert
      Assert.AreEqual(10, newPet.Fatigue);
    }
  }
}