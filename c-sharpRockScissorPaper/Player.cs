using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharpRockScissorPaper
{
    public class Player // private เพราะ ไม่อยากให้
    {
        public string Name { get; private set; }
        public int HP { get; private set; }
        public string Action { get; set; }

        public Player(string name)
        {
            HP = 3; // กำนหดแต้ม hp 
            Name = name;
        }

        public void deHp()
        {
            HP--;
        }
    }

    public class GM
    {
        public Player player1 { get; private set; }
        public Player player2 { get; private set; }

        public GM(string p1Name , string p2Name)
        {
            player1 = new Player(p1Name);
            player2 = new Player(p2Name);
        }

        public void playeraction(bool Isplayer1, string action)
        {
            if (Isplayer1)
            {
                player1.Action = action;
            }
            else
            {
                player2.Action = action;
            }
        }

        public void cal()
        {
            if(player1.Action == "R" && player2.Action == "R")
            {
                //draw
                Console.WriteLine(" Draw");
            }
            else if (player1.Action == "R" && player2.Action == "S")
            {
                player2.deHp();
                Console.WriteLine(player1.Name + " Win");
            }
            else if (player1.Action == "R" && player2.Action == "P")
            {
                player1.deHp();
                Console.WriteLine(player2.Name + " Win");
            }
            else if (player1.Action == "S" && player2.Action == "S")
            {
                //draw
                Console.WriteLine(" Draw");
            }
            else if (player1.Action == "S" && player2.Action == "R")
            {
                player1.deHp();
                Console.WriteLine(player2.Name + " Win");
            }
            else if (player1.Action == "S" && player2.Action == "P")
            {
                player2.deHp();
                Console.WriteLine(player1.Name + " Win");
            }
            else if (player1.Action == "P" && player2.Action == "P")
            {
                
                Console.WriteLine(" Draw");
            }
            else if (player1.Action == "P" && player2.Action == "S")
            {
                player1.deHp();
                Console.WriteLine(player2.Name + " Win");
            }
            else if (player1.Action == "P" && player2.Action == "R")
            {
                player2.deHp();
                Console.WriteLine(player1.Name + " Win");
            }
        }

        public bool gameover()
        {
            return !(player1.HP <= 0 || player2.HP <= 0); // ! เพื่อ ค่าที่เอามาใช้ มันตรงกันข้าม
           
            //ไม่งั้นเกมจะออกจาก mrthod แล้วจบทันที
        }

        public Player winner()
        {
            if (player1.HP <= 0) return player2;
            else return player1;
        }
    }
}
