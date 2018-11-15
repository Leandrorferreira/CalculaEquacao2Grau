using System;

namespace Eq2Grau.Models
{
    public class Calculos
    {
        public double Converte(string str)
        {
            double inteiro = Convert.ToDouble(str); 
            return inteiro;
        }

        public string CalcRaiz1(Parametros p)
        {
            double a = Converte(p.stra);
            double b = Converte(p.strb);
            double c = Converte(p.strc);
            double formula, parte0, parte1, parte2, parte3, parte4;

            //Inicia calculo

            parte0 = Math.Pow(b, 2);
            parte1 = b * -1;
            parte2 = 4 * a * c;
            parte3 = Math.Round(Math.Sqrt(parte0 - parte2));
            parte4 = b * -1;
            formula = (parte4 + parte3) / 2 * a;
            if (formula == 0)
            {
                return "Solução Inexistente";
            }
            else
            {
                return formula.ToString();
            }
        }

        public string CalcRaiz2(Parametros p)
        {
            double a = Converte(p.stra);
            double b = Converte(p.strb);
            double c = Converte(p.strc);
            double formula, parte0, parte1, parte2, parte3, parte4;

            //Inicia calculo

            parte0 = Math.Pow(b, 2);
            parte1 = b * -1;
            parte2 = 4 * a * c;
            parte3 = Math.Round(Math.Sqrt(parte0 - parte2));
            parte4 = b * -1;
            formula = (parte4 - parte3)/ 2 * a;
            if (formula == 0)
            {
                return "Solução Inexistente";
            }
            else
            {
                return formula.ToString();
            }
        }
    }
}