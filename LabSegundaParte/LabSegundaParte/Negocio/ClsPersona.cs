using LabSegundaParte.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LabSegundaParte.Negocio
{
    class ClsPersona
    {

        public String IMC(Persona persona)

        {
            
            double pesoideal = (persona.Peso) / (Math.Pow(persona.Altura, 2));
            Console.WriteLine("Peso ingresado: " + persona.Peso);
            Console.WriteLine("Altura ingresada: " + persona.Altura.ToString("00.00"));
            Console.WriteLine(pesoideal);
            


            if (pesoideal < 20.00)
            {
                return "Peso ideal ";

            }
            else
            {

                return "Tiene sobre peso";
            }




        }

        public String MayorDeEdad(Persona edad)

        {
            if (edad.Edad >= 18)
            {
                return "Es mayor de edad";

            }
            else
            {

                return "Es menor de edad";
            }


        }


    }

       
}
