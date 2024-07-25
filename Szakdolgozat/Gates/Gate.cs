using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumGateSimulator.Kapuk
{
    public interface Gate
    {
        string name { get; }
        double[,] matrix { get; }
        void DisplayGate(Graphics g, Pen pen, Point start);
    }
}
