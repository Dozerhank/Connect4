using System;
using System.Collections.Generic;
using System.Text;

namespace Connect4
{
    public interface IWinner
    {
        //find winner in column c going up starting from (r,c)
        public bool straightup(int r, int c);
        //find winner in column c going down starting from (r,c)
        public bool straightdown(int r, int c);
        //find a winner in row r going left starting from (r,c)
        public bool left(int r, int c);
        //find a winner in row r going right starting from (r,c)
        public bool right(int r, int c);
        //find a winner in diagonal left going up starting from (r,c)
        public bool diagleftup(int r, int c);
        //find a winner in diagonal right going down starting from(r, c)
        public bool diagrightdown(int r, int c);
        //find a winner in diagonal left going down starting from(r, c)
        public bool diagleftdown(int r, int c);
        //find a winner in diagonal right going up starting from(r, c)
        public bool diagrightup(int r, int c);
        //return true if there is winner this function should use the previous one
        public bool winner();
    }

}
