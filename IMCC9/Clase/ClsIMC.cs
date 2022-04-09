using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMCC9.Clase
{
    internal class ClsIMC
    {
        private const double KG = 2.2046;

        public int edad { get; }
        public String nombre { get; }
        public double altura { get; }
        public string sexo { get; }
        public int peso { get; }
        public double imc { get; set; }


        //public string prueba()
        //{
        //    this.edad = 18;
        //    this.sexo = 'F';
        //    this.altura = 160;
        //    this.peso = 130;

        //double pesoKG = this.peso / KG;
        //double estaturaMTS = (double)this.altura / 100;
        //double altu = (Math.Pow(estaturaMTS, 2));
        //    this.imc = pesoKG / altu;

        //    return imc.ToString();

        //}

        //public ClsIMC(int _edad, string _nom, double _altura, string _sexo, int _peso)
        //{
        //    edad = _edad;
        //    nombre = _nom;
        //    altura = _altura;
        //    peso = _peso;
        //    sexo = _sexo;
        //}

        public ClsIMC()
        {
        }

        public string datos()
        {
            string mensaje = "";
            int edad;
            string nombre;
            double altura;
            string sexo;
            int peso;

            Console.WriteLine("\n\t\tBIENVENIDO VAMOS A CALCULAR TU IMC");
            Console.WriteLine("Ingrese su edad");
            edad = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("\nIngrese su nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("\nIngrese su altura en centimetros");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("\nIngrese su sexo");
            sexo = Console.ReadLine();

            Console.WriteLine("\nIngrese su peso en libras");
            peso = Convert.ToInt16(Console.ReadLine());

            double pesoKG = peso / KG;
            double estaturaMTS = (double)altura / 100;
            double altu = (Math.Pow(estaturaMTS, 2));

            imc = pesoKG / altu;
            Console.WriteLine($"\n\t\t{nombre} su IMC es de: {imc}");

            if (imc < 18.5)
            {
                Console.WriteLine("\t\tBajo peso (Oye come más)");
            }
            if (imc>= 18.5 && imc<24.9)
            {
                Console.WriteLine("\t\tNormal (Estas saludable)");
            }
            if (imc>= 24.9 && imc<30)
            {
                Console.WriteLine("\t\tSobrepeso (Bájale a las tortillas)");
            }
            if (imc > 30)
            {
                Console.WriteLine("\t\tObecidad (Oye, ejercitate y cuida de tu salud)");
            }

            return mensaje;
        }

    }
}
