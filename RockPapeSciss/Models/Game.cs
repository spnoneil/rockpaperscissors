using System;

namespace Game
{
  public class Move
  {
    public string UserMove { get; set; }
    public Move(string move)
    {
      UserMove = move;
    }

  }
}