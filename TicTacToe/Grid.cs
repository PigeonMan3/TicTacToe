using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace TicTacToe
{
    public class Grid
    {
        protected string[,] _grid = new string[3, 3]; // [kolom, rij]
        protected string _uitvoer;

        public Grid()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    _grid[j, i] = "_";
                }
            }
            _uitvoer = "";
        }

        public string GridPrinten()
        {
            _uitvoer = "     A   B   C" + Environment.NewLine;
            for (int i = 0; i < 3; i++)
            {
                _uitvoer += " " + (i + 1);
                for (int j = 0; j < 3; j++)
                {
                    _uitvoer += " | " + _grid[j, i].ToString();
                }
                _uitvoer += "\n";
            }

            return _uitvoer;
        }

        public void GridInvullenSpeler(string Kolom, int Rij)
        {
            int KolomCijfer = 0;
            switch(Kolom.ToUpper())
            {
                case "A":
                    KolomCijfer = 0; break;
                case "B":
                    KolomCijfer = 1; break;
                case "C":
                    KolomCijfer = 2; break;
                default:
                    Environment.Exit(1); break;
            }
            Rij -= 1;
            if (_grid[KolomCijfer, Rij].Contains("_") == false)
            {
                Environment.Exit(1);
            }
            else
            {
                _grid[KolomCijfer, Rij] = "X";
            }
        }



    }
}