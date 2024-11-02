using ScottPlot;
using System;


namespace Parcial_2.metodos
{
    internal class ecuaciones
    {
        private double a, b, c;


        public ecuaciones(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void resolver1G(out double? x)
        {

            x = -b / a;


        }

        public void graficar1G(int grado, out double[] Xs, out double[] Ys)
        {
            Xs = Generate.Consecutive(100, 1, -50);
            Ys = new double[Xs.Length];
            if (grado == 1)
            {
                for (int i = 0; i < Xs.Length; i++)
                {
                    Ys[i] = a * Xs[i] + b;
                }
            }
            else if (grado == 2)
            {
                for (int i = 0; i < Xs.Length; i++)
                {
                    Ys[i] = a * Math.Pow(Xs[i], 2) + b * Xs[i] + c;
                }
            }

        }




        public void resolver2G(out double? x1, out double? x2)
        {

            double discriminante = Math.Pow(b, 2) - 4 * a * c;
            if (discriminante > 0)
            {
                x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);


            }
            else if (discriminante == 0)
            {
                // Una solución real
                x1 = -b / (2 * a);
                x2 = 404;
            }
            else
            {
                x1 = 404;
                x2 = 404;

            }
        }


    }

}
