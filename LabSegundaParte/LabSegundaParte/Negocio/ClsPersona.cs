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
<<<<<<< Updated upstream
        public String IMC(Persona peso)

        {
            peso.Peso = peso.Peso / Math.Pow(peso.Altura, 2);

            if (peso.Peso <= 20)
            {
                return ("Peso ideal "); 

            }
            else
            {

                return ("Tiene sobre peso");
            }
=======
        public string Person(Promedio Nota1)
        public double persona = new persona.Peso(); 
>>>>>>> Stashed changes


        }

        public String MayorDeEdad(Persona edad)
       
        {
            if (edad.Edad >= 18)
            {
                return ("Es mayor de edad");

            }
            else
            {

                return ("Es menor de edad");
            }


        }
        

    }

       
}
