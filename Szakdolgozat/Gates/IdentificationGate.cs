using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumGateSimulator.Kapuk
{
    internal class IdentificationGate : Gate
    {
        public double[,] matrix { get; } = new double[,] { { 1, 0 }, { 0, 1 } };
        public string name => "Identification";

        public void DisplayGate(Graphics g, Pen pen, Point start)
        {
            g.DrawImage(Image.FromFile("Identification.png"), new Rectangle(start, new Size(50, 50)));
            g.DrawLine(pen, new Point(start.X - 50, start.Y + 25), new Point(start.X, start.Y + 25));
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                result += "[ ";
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result += matrix[i, j].ToString("0.##") + " ";
                }
                result += "]\n";
            }
            return result;
        }
    }
}
