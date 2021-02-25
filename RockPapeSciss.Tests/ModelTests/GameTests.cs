using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Game;

namespace Game.Tests
{
  [TestClass]
  public class MoveTests
  {
    [TestMethod]
    public void MoveConstructor_CreatesMoveObject_Move()
    {
      Move newMove = new Move("rock");
      Assert.AreEqual(typeof(Move), newMove.GetType());
      //newMove.Test;
    }
    [TestMethod]
    public void GetMove_ReturnsMove_String()
    {
      Move newMove = new Move("rock");
      Assert.AreEqual("rock", newMove.UserMove);
    }
    [TestMethod]
    public void SetMove_SetsMove_String()
    {
      string firstMove = "rock";
      Move newMove = new Move(firstMove);
      string secondMove = "paper";
      newMove.UserMove = secondMove;
      string result = newMove.UserMove;
      Assert.AreEqual(secondMove, result);
    }
    
  }
}