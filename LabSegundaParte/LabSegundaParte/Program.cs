using LabSegundaParte.Entidades;
using LabSegundaParte.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSegundaParte
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre: ");
            String nombre = Console.ReadLine();


            Console.WriteLine("Ingrese su edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese su sexo: ");
            String sexo = Console.ReadLine();

            Console.WriteLine("Ingrese su peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Peso ingresado: " + peso.ToString("000.00"));

            Console.WriteLine("Ingrese su altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Altura ingresado: " + altura.ToString("00.00"));


            Persona persona = new Persona(nombre, edad, sexo, peso, altura);
            Persona persona1 = new Persona(nombre, edad, sexo);

            ClsPersona clsPersona = new ClsPersona();
            Console.WriteLine(clsPersona.IMC(persona));
            Console.WriteLine(clsPersona.MayorDeEdad(persona1));

            Console.WriteLine(persona.ToString());
            Console.ReadLine();



        }
    }
}
