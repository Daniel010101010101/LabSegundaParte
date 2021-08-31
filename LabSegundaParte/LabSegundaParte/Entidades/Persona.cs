using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSegundaParte.Entidades
{
    class Persona
    {

        private String nombre;
        private int edad;
        private String sexo;
        private double peso;
        private double altura;
        private double pesoideal;

     

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public double Peso { get => peso; set => peso = value; }
        public double Altura { get => altura; set => altura = value; }
        
        public double Pesoideal { get => pesoideal; set => pesoideal = value; }

        public Persona() { }

        public Persona(string nombre, int edad, string sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
        }

        public Persona(string nombre, int edad, string sexo, double peso, double altura)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Sexo = sexo;
            this.Peso = peso;
            this.Altura = altura;
        }

        public Persona(double peso, double altura)
        {
            this.Peso = peso;
            this.Altura = altura;
        }

       

        public override string ToString()
        {
            return "Nombre: " + Nombre +
                "\nEdad: " + Edad +
                "\nPeso: " + Peso +
                "\nAltura: " + Altura + 
                "\nSexo: " + Sexo;
        }
    }
}
