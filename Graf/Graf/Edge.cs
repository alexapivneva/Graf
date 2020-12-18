using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graf
{
    class Edge
    {
        int x1, x2, y1, y2;
        string weight;

        public Edge(int x1, int y1, int x2, int y2, string weight)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.weight = weight;
        }

        public int X1
        {
            get { return x1; }
            set { value = x1; }
        }

        public int Y1
        {
            get { return y1; }
            set { value = y1; }
        }

        public int X2
        {
            get { return x2; }
            set { value = x2; }
        }

        public int Y2
        {
            get { return y2; }
            set { value = y2; }
        }
        string Weight
        {
            get { return weight; }
            set { value = weight; }
        }

        
    }
}

