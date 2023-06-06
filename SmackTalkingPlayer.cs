using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        static public string Taunt { get; } = "Come to Papa!";
    
      public override int Roll()
      {
        // Return a random number between 1 and DiceSize
            Console.WriteLine(SmackTalkingPlayer.Taunt);
            return new Random().Next(DiceSize) + 1;
        }

    }
}