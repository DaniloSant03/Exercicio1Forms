using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_18._12
{
    class Retangulo
    {
        double @base;
        double altura;
        double area;

        public Retangulo()
        {
            this.@base = 0;
            this.altura = 0;
        }

        public Retangulo(double @base, double altura)
        {
            this.@base = @base;
            this.altura = altura;
        }

        public void SetBase()
        {
            this.@base = 0;
        }

        public void SetBase(double @base)
        {
            this.@base = @base;
        }

        public void SetAltura()
        {
            this.altura = 0;
        }

        public void SetAltura(double altura)
        {
            this.altura = altura;
        }

        public double GetBase()
        {
            return this.@base;
        }

        public double GetAltura()
        {
            return this.altura;
        }

        public double GetArea()
        {
            return this.area;
        }

        public double CalcularArea()
        {
            area = @base * altura;
            return area;

        }


    }
}
