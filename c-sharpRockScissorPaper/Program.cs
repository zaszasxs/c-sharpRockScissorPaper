using System;

namespace c_sharpRockScissorPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            // player 2 
            //var player1 = new Player("Jessie");
            //var player2 = new Player("Dab");

            // GM
            var gm = new GM ( "player1", "player2" );

            do // บังคับทำ
            {
                Console.WriteLine("Player1 : Rock Scissor Paper");
                var player1input = Console.ReadLine();
                gm.playeraction(true, player1input);

                Console.WriteLine("Player2 : Rock Scissor Paper");
                var player2input = Console.ReadLine();
                gm.playeraction(false, player2input);

                gm.cal();
            }
            while (gm.gameover());
            {
                var Win = gm.winner();
                Console.WriteLine(Win.Name  + " ชนะ");
            }

            

        }
    }
}
