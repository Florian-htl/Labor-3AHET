using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    
    class Figur
    {
        public enum Color { WHITE , BLACK };
        Color color = Color.WHITE;
        int row =1;
        char col = 'A';

        public Figur (Color color, int row, char col)
        {
            this.color = color;
            this.row = row;
            this.col = col;

        }
        public int GetRow()
        {
            return row;
                
        
        }

        public int GetCol()
        {
            return col;


        }

        public virtual void MakeRandomMove()
        {

            Console.WriteLine("Nicht Implementiert");

        }
    }
}
