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
      PocketPet newPet = new PocketPet();
      // Act
      //not needed here
      // Assert
    Assert.AreEqual(typeof(PocketPet), newPet.GetType());
    }
  }
}