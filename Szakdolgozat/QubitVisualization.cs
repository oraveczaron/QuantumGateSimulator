using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumGateSimulator
{
    public class QubitVisualization
    {
        private Graphics g;

        private int radius;
        public int GetRadius()
        {
            return radius;
        }
        private int centerX;
        public int GetCenterX()
        {
            return centerX;
        }
        private int centerY;
        public int GetCenterY()
        {
            return centerY;
        }

        double amp0;
        double amp1;
        public QubitVisualization() {}

        public QubitVisualization(Graphics g, int radius, int centerX, int centerY, double amp0, double amp1)
        {
            this.g = g;

            this.radius = radius;
            this.centerX = centerX;
            this.centerY = centerY;

            this.amp0 = amp0;
            this.amp1 = amp1;
            Visualize();
        }

        public void Visualize()
        {
            EclipseVisualization();
            VectorVisualiztion();
        }
        public void EclipseVisualization() 
        {
            g.DrawEllipse(new Pen(Color.Black), centerX - radius, centerY - radius, radius * 2, radius * 2);
            CrossVisualization();

        }

        public void VectorVisualiztion()
        {
            double qubitX = centerX + radius * amp0; 
            double qubitY = centerY - radius * amp1; 

            g.DrawLine(new Pen(Color.Red, 2), centerX, centerY, (float)qubitX, (float)qubitY);



            g.DrawLine(new Pen(Color.Blue, 1), centerX, (float)qubitY, (float)qubitX, (float)qubitY);
            g.DrawLine(new Pen(Color.Blue, 1), (float)qubitX, centerY, (float)qubitX, (float)qubitY);
        }

        private void CrossVisualization()
        {
            g.DrawLine(new Pen(Color.Black), centerX - radius, centerY, centerX + radius, centerY);
            g.DrawLine(new Pen(Color.Black), centerX, centerY - radius, centerX, centerY + radius);
        }

    }
}
