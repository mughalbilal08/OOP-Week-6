using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EZInput;
using Packman;

namespace Pacman_game
{
    internal class Pacman
    {
       static void Main(string[] args)
        {
            string path = "savemaze";
            Grid mazeGrid = new Grid(24,71,path);
            packman player = new packman(9,20,mazeGrid);
            Ghost g1 = new Ghost(15,39,"left", 'H', 0.1F,' ',mazeGrid);
            Ghost g2 = new Ghost(20, 57, "up", 'V', 0.2F, ' ', mazeGrid);
            Ghost g3 = new Ghost(19, 26, "up", 'R', 1F, ' ', mazeGrid);
            Ghost g4 = new Ghost(18, 21, "up", 'C', 0.5F, ' ', mazeGrid);
            List<Ghost> enemies = new List<Ghost>();
            enemies.Add(g1);
            enemies.Add(g2);
            enemies.Add(g3);
            enemies.Add(g4);
            mazeGrid.Draw();
         
            bool gameRunning = true;
            while (gameRunning)
            {
                
                player.Print(111,112);
                player.Remove(9, 20);
                player.Move();
                
                foreach (Ghost g in enemies)
                {
                    g.Remove(9,20);
                    g.move();
                   
                }
               
                    gameRunning = false;
                
            }
            Console.ReadKey();
        }
    }
}
