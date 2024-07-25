using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using QuantumGateSimulator.Kapuk;

namespace QuantumGateSimulator
{
    public class Qubit
    {
        public double amplitude0;
        public double GetAmplitude0() { return amplitude0; }
        public void SetAmplitude0(double amplitude) { amplitude0 = amplitude; }

        private double amplitude1;
        public double GetAmplitude1() { return amplitude1; }
        public void SetAmplitude1(double amplitude) { amplitude1 = amplitude; }

        public Qubit() { }
        public Qubit(Qubit other)
        {
            this.amplitude0 = other.amplitude0;
            this.amplitude1 = other.amplitude1;
        }

        public Qubit(double amplitude0, double amplitude1)
        {
            this.amplitude0 = amplitude0;
            this.amplitude1 = amplitude1;
        }

        public void Transforms(Gate k)
        {          
            double newAmplitude0 = k.matrix[0, 0] * amplitude0 + k.matrix[0, 1] * amplitude1;
            double newAmplitude1 = k.matrix[1, 0] * amplitude0 + k.matrix[1, 1] * amplitude1;

            amplitude0 = newAmplitude0;
            amplitude1 = newAmplitude1;
        }

        public override string ToString()
        {
            return $"|ψ⟩ = {amplitude0:0.00}|0⟩  {amplitude1:0.00}|1⟩";
        }
        public string VectorToString()
        {
            return $"{amplitude0:0.00}\n{amplitude1:0.00}";
        }
    }
}
