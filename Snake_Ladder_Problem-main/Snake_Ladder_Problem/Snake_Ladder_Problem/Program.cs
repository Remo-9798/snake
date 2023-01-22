namespace Snake_Ladder_Problem
{
    class SnakeandLadder
    {
        int Position = 0;
        const int No_Play = 0;
        const int Ladder= 1;
        const int Snake_Bite = 2;
        const int WinningPosition = 100;

        static int DiceRoll()
        {
            Random random = new Random();
            int Dice = random.Next(1, 7);
            return Dice;
        }


        public void PlayerMove(string player)
        {
            int RollDice = DiceRoll();
            Random randomoption = new Random();
            int Checkoption = randomoption.Next(0, 3);
            

            switch (Checkoption)
            {
                case No_Play:
                    Position = Position;
                    break;

                case Ladder:
                    if (Position + RollDice > 100)
                    {
                        Position = Position;
                    }
                    else
                    {
                        Position += RollDice;
                    }
                    break;

                case Snake_Bite:
                    Position -= RollDice;
                    if (Position < 0)
                    {
                        Position = 0;
                    }
                     break;
            }


        }

        static void Main(string[] args)
        {


            SnakeandLadder Player1 = new SnakeandLadder();
            SnakeandLadder Player2 = new SnakeandLadder();

            Random randomturn = new Random();
            int Player_Turn = randomturn.Next(0, 2);
            

            while ((Player1.Position <= WinningPosition) && (Player2.Position <= WinningPosition))
            {
                if (Player_Turn == 0)
                {
                    if (Player1.Position == WinningPosition)
                    {
                        Console.WriteLine("Player one is winner");
                        break;
                    }
                    Player1.PlayerMove("Player 1");
                    Player_Turn = 1;
                    Console.WriteLine("Player 1 position " + Player1.Position);

                }
                else if (Player_Turn == 1)
                {
                    if (Player2.Position == WinningPosition)
                    {
                        Console.WriteLine("Player two is winner");
                        break;
                    }
                    Player2.PlayerMove("Player 2");
                    Player_Turn = 0;
                    Console.WriteLine("Player 2 position " + Player2.Position);
                }
            }

        }
    }
}
