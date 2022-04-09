using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMPC.Clases
{
    public class ClsIMC
    {
        private const double KG = 2.2046;
        public String nombre { get; set; }
        public int edad { get; set; }
        public int altura { get; set; }
        public char sexo { get; set; }
        public int peso { get; set; }
        public double imc { get; set; }

        public ClsIMC(String _nombre, int _edad, int _altura, char _sexo, int _peso)
        {
            nombre = _nombre;
            edad = _edad;
            altura = _altura;
            peso = _peso;
            sexo = _sexo;
            peso = _peso;
        }
    
        public string prueba()
        {
            double pesoKG = this.peso / KG;
            double estaturaMTS = (double)this.altura / 100;
            double altu = (Math.Pow(estaturaMTS, 2));
            this.imc = peso / altu;
            this.imc = (Math.Round(this.imc,2));      
            return this.imc.ToString();
        }

        public string CalculosAdulto()
        {
            string mensaje = " ";
            if(imc < 18.5)
            {
                mensaje = "Su indice de masa corporal es bajo\n";
            }
            if(imc <= 24.9 && imc >= 18.5)
            {
                mensaje = "Su indice de masa corporal es normal\n";
            }
            if(imc <=29.9 && imc >= 25.0)
            {
                mensaje = "Su indice de masa corporal indica que tiene sobrepeso\n";
            }
            if(imc >= 30)
            {
                mensaje = "Su indice de masa corporal indica que tiene obesidad\n";
            }
            return mensaje;
        }

        public string CalculosNiños()
        {
            string mensaje = " ";
            if(edad == 2)
            {
               if(imc < 14.8)
                {
                    mensaje = "Su indice de masa corporal es bajo \n";
                }
               if(imc <=18.1 && imc >= 14.9)
                {
                    mensaje = "Su indice de masa corporal es normal \n";
                }
               if(imc <= 19.2 && imc >= 18.2)
                {
                    mensaje = "Su indice de masa corporal indica que tiene sobrepeso \n";
                }
               if(imc >= 19.3)
                {
                    mensaje = "Su indice de masa corporal indica que tiene obesidad \n";
                }
            }
            if(edad == 3)
            {
                if (imc < 14.6)
                {
                    mensaje = "Su indice de masa corporal es bajo \n";
                }
                if (imc <= 17.3 && imc >= 14.7)
                {
                    mensaje = "Su indice de masa corporal es normal \n";
                }
                if (imc <= 17.4 && imc >= 18.1)
                {
                    mensaje = "Su indice de masa corporal indica que tiene sobrepeso \n";
                }
                if (imc >= 18.2)
                {
                    mensaje = "Su indice de masa corporal indica que tiene obesidad \n";
                }
            }
            if(edad == 4)
            {
                if (imc < 14.0)
                {
                    mensaje = "Su indice de masa corporal es bajo \n";
                }
                if (imc <= 16.8 && imc >= 14.1)
                {
                    mensaje = "Su indice de masa corporal es normal \n";
                }
                if (imc <= 17.7 && imc >= 16.8)
                {
                    mensaje = "Su indice de masa corporal indica que tiene sobrepeso \n";
                }
                if (imc >= 17.8)
                {
                    mensaje = "Su indice de masa corporal indica que tiene obesidad \n";
                }
            }
            if(edad == 5)
            {
                if (imc < 13.8)
                {
                    mensaje = "Su indice de masa corporal es bajo \n";
                }
                if (imc <= 16.7 && imc >= 13.9)
                {
                    mensaje = "Su indice de masa corporal es normal \n";
                }
                if (imc <= 17.9 && imc >= 16.8)
                {
                    mensaje = "Su indice de masa corporal indica que tiene sobrepeso \n";
                }
                if (imc >= 18.0)
                {
                    mensaje = "Su indice de masa corporal indica que tiene obesidad \n";
                }
            }
            if (edad == 6)
            {
                if (imc < 13.8)
                {
                    mensaje = "Su indice de masa corporal es bajo \n";
                }
                if (imc <= 16.9 && imc >= 13.9)
                {
                    mensaje = "Su indice de masa corporal es normal \n";
                }
                if (imc <= 18.3 && imc >= 17.0)
                {
                    mensaje = "Su indice de masa corporal indica que tiene sobrepeso \n";
                }
                if (imc >= 18.4)
                {
                    mensaje = "Su indice de masa corporal indica que tiene obesidad \n";
                }
            }
            if (edad == 7)
            {
                //Bajo Peso
                if (imc < 13.7)
                {
                    mensaje = "Su indice de masa corporal es bajo \n";
                }
                //Peso Normal
                if (imc <= 17.3 && imc >= 13.8)
                {
                    mensaje = "Su indice de masa corporal es normal \n";
                }
                //Sobrepeso
                if (imc <= 19.1 && imc >= 17.4)
                {
                    mensaje = "Su indice de masa corporal indica que tiene sobrepeso \n";
                }
                //Obesidad
                if (imc >= 19.2)
                {
                    mensaje = "Su indice de masa corporal indica que tiene obesidad \n";
                }
            }
            if (edad == 8)
            {
                //Bajo Peso
                if (imc < 13.8)
                {
                    mensaje = "Su indice de masa corporal es bajo \n";
                }
                //Peso Normal
                if (imc <= 17.8 && imc >= 13.9)
                {
                    mensaje = "Su indice de masa corporal es normal \n";
                }
                //Sobrepeso
                if (imc <= 19.9 && imc >= 17.9)
                {
                    mensaje = "Su indice de masa corporal indica que tiene sobrepeso \n";
                }
                //Obesidad
                if (imc >= 20.0)
                {
                    mensaje = "Su indice de masa corporal indica que tiene obesidad \n";
                }
            }
            if (edad == 9)
            {
                //Bajo Peso
                if (imc < 13.9)
                {
                    mensaje = "Su indice de masa corporal es bajo \n";
                }
                //Peso Normal
                if (imc <= 18.5 && imc >= 14.0)
                {
                    mensaje = "Su indice de masa corporal es normal \n";
                }
                //Sobrepeso
                if (imc <= 20.9 && imc >= 18.6)
                {
                    mensaje = "Su indice de masa corporal indica que tiene sobrepeso \n";
                }
                //Obesidad
                if (imc >= 21.0)
                {
                    mensaje = "Su indice de masa corporal indica que tiene obesidad \n";
                }
            }
            if (edad == 10)
            {
                //Bajo Peso
                if (imc < 14.2)
                {
                    mensaje = "Su indice de masa corporal es bajo \n";
                }
                //Peso Normal
                if (imc <= 19.3 && imc >= 14.3)
                {
                    mensaje = "Su indice de masa corporal es normal \n";
                }
                //Sobrepeso
                if (imc <= 22.0 && imc >= 19.4)
                {
                    mensaje = "Su indice de masa corporal indica que tiene sobrepeso \n";
                }
                //Obesidad
                if (imc >= 22.1)
                {
                    mensaje = "Su indice de masa corporal indica que tiene obesidad \n";
                }
            }
            if (edad ==11)
            {
                //Bajo Peso
                if (imc < 14.5)
                {
                    mensaje = "Su indice de masa corporal es bajo \n";
                }
                //Peso Normal
                if (imc <= 20.1 && imc >= 14.6)
                {
                    mensaje = "Su indice de masa corporal es normal \n";
                }
                //Sobrepeso
                if (imc <= 23.1 && imc >= 20.2)
                {
                    mensaje = "Su indice de masa corporal indica que tiene sobrepeso \n";
                }
                //Obesidad
                if (imc >= 23.2)
                {
                    mensaje = "Su indice de masa corporal indica que tiene obesidad \n";
                }
            }
            if (edad == 12)
            {
                //Bajo Peso
                if (imc < 15.0)
                {
                    mensaje = "Su indice de masa corporal es bajo \n";
                }
                //Peso Normal
                if (imc <= 20.9 && imc >= 15.1)
                {
                    mensaje = "Su indice de masa corporal es normal \n";
                }
                //Sobrepeso
                if (imc <= 24.1 && imc >= 21.0)
                {
                    mensaje = "Su indice de masa corporal indica que tiene sobrepeso \n";
                }
                //Obesidad
                if (imc >= 24.2)
                {
                    mensaje = "Su indice de masa corporal indica que tiene obesidad \n";
                }
            }
            if (edad == 13)
            {
                //Bajo Peso
                if (imc < 15.4)
                {
                    mensaje = "Su indice de masa corporal es bajo \n";
                }
                //Peso Normal
                if (imc <= 21.7 && imc >= 15.5)
                {
                    mensaje = "Su indice de masa corporal es normal \n";
                }
                //Sobrepeso
                if (imc <= 25.0 && imc >= 21.8)
                {
                    mensaje = "Su indice de masa corporal indica que tiene sobrepeso \n";
                }
                //Obesidad
                if (imc >= 25.1)
                {
                    mensaje = "Su indice de masa corporal indica que tiene obesidad \n";
                }
            }
            if (edad == 14)
            {
                //Bajo Peso
                if (imc < 16.0)
                {
                    mensaje = "Su indice de masa corporal es bajo \n";
                }
                //Peso Normal
                if (imc <= 22.5 && imc >= 16.1)
                {
                    mensaje = "Su indice de masa corporal es normal \n";
                }
                //Sobrepeso
                if (imc <= 25.9 && imc >= 22.6)
                {
                    mensaje = "Su indice de masa corporal indica que tiene sobrepeso \n";
                }
                //Obesidad
                if (imc >= 26.0)
                {
                    mensaje = "Su indice de masa corporal indica que tiene obesidad \n";
                }
            }
            if (edad == 15)
            {
                //Bajo Peso
                if (imc < 16.5)
                {
                    mensaje = "Su indice de masa corporal es bajo \n";
                }
                //Peso Normal
                if (imc <= 23.3 && imc >= 16.6)
                {
                    mensaje = "Su indice de masa corporal es normal \n";
                }
                //Sobrepeso
                if (imc <= 26.7 && imc >= 23.4)
                {
                    mensaje = "Su indice de masa corporal indica que tiene sobrepeso \n";
                }
                //Obesidad
                if (imc >= 26.8)
                {
                    mensaje = "Su indice de masa corporal indica que tiene obesidad \n";
                }
            }
            if (edad == 16)
            {
                //Bajo Peso
                if (imc < 17.1)
                {
                    mensaje = "Su indice de masa corporal es bajo \n";
                }
                //Peso Normal
                if (imc <= 24.1 && imc >= 17.2)
                {
                    mensaje = "Su indice de masa corporal es normal \n";
                }
                //Sobrepeso
                if (imc <= 27.4 && imc >= 24.2)
                {
                    mensaje = "Su indice de masa corporal indica que tiene sobrepeso \n";
                }
                //Obesidad
                if (imc >= 27.5)
                {
                    mensaje = "Su indice de masa corporal indica que tiene obesidad \n";
                }
            }
            if (edad == 17)
            {
                //Bajo Peso
                if (imc < 17.6)
                {
                    mensaje = "Su indice de masa corporal es bajo \n";
                }
                //Peso Normal
                if (imc <= 24.8 && imc >= 17.7)
                {
                    mensaje = "Su indice de masa corporal es normal \n";
                }
                //Sobrepeso
                if (imc <= 28.1 && imc >= 24.9)
                {
                    mensaje = "Su indice de masa corporal indica que tiene sobrepeso \n";
                }
                //Obesidad
                if (imc >= 28.2)
                {
                    mensaje = "Su indice de masa corporal indica que tiene obesidad \n";
                }
            }
            if (edad == 18)
            {
                //Bajo Peso
                if (imc < 18.2)
                {
                    mensaje = "Su indice de masa corporal es bajo \n";
                }
                //Peso Normal
                if (imc <= 25.5 && imc >= 18.3)
                {
                    mensaje = "Su indice de masa corporal es normal \n";
                }
                //Sobrepeso
                if (imc <= 28.8 && imc >= 25.6)
                {
                    mensaje = "Su indice de masa corporal indica que tiene sobrepeso \n";
                }
                //Obesidad
                if (imc >= 28.9)
                {
                    mensaje = "Su indice de masa corporal indica que tiene obesidad \n";
                }
            }
            return mensaje;
        }

        public string CalculosNiñas()
        {
            string mensaje = " ";
            if (edad == 2)
            {
                //Bajo Peso
                if (imc < 14.4)
                {
                    mensaje = "Su indice de masa corporal es bajo \n";
                }
                //Peso Normal
                if (imc <= 17.9 && imc >= 14.5)
                {
                    mensaje = "Su indice de masa corporal es normal \n";
                }
                //Sobrepeso
                if (imc <= 19.0 && imc >= 18.0)
                {
                    mensaje = "Su indice de masa corporal indica que tiene sobrepeso \n";
                }
                //Obesidad
                if (imc >= 19.1)
                {
                    mensaje = "Su indice de masa corporal indica que tiene obesidad \n";
                }
            }
            if (edad == 3)
            {
                //Bajo Peso
                if (imc < 14.0)
                {
                    mensaje = "Su indice de masa corporal es bajo \n";
                }
                //Peso Normal
                if (imc <= 17.1 && imc >= 14.1)
                {
                    mensaje = "Su indice de masa corporal es normal \n";
                }
                //Sobrepeso
                if (imc <= 18.1 && imc >= 17.2)
                {
                    mensaje = "Su indice de masa corporal indica que tiene sobrepeso \n";
                }
                //Obesidad
                if (imc >= 18.2)
                {
                    mensaje = "Su indice de masa corporal indica que tiene obesidad \n";
                }
            }
            if (edad == 4)
            {
                //Bajo Peso
                if (imc < 13.7)
                {
                    mensaje = "Su indice de masa corporal es bajo \n";
                }
                //Peso Normal
                if (imc <= 16.7 && imc >= 13.8)
                {
                    mensaje = "Su indice de masa corporal es normal \n";
                }
                //Sobrepeso
                if (imc <= 17.9 && imc >= 16.8)
                {
                    mensaje = "Su indice de masa corporal indica que tiene sobrepeso \n";
                }
                //Obesidad
                if (imc >= 18.0)
                {
                    mensaje = "Su indice de masa corporal indica que tiene obesidad \n";
                }
            }
            if (edad == 5)
            {
                //Bajo Peso
                if (imc < 13.5)
                {
                    mensaje = "Su indice de masa corporal es bajo \n";
                }
                //Peso Normal
                if (imc <= 16.7 && imc >= 13.6)
                {
                    mensaje = "Su indice de masa corporal es normal \n";
                }
                //Sobrepeso
                if (imc <= 18.1 && imc >= 16.8)
                {
                    mensaje = "Su indice de masa corporal indica que tiene sobrepeso \n";
                }
                //Obesidad
                if (imc >= 18.2)
                {
                    mensaje = "Su indice de masa corporal indica que tiene obesidad \n";
                }
            }
            if (edad == 6)
            {
                //Bajo Peso
                if (imc < 13.4)
                {
                    mensaje = "Su indice de masa corporal es bajo \n";
                }
                //Peso Normal
                if (imc <= 17.0 && imc >= 13.5)
                {
                    mensaje = "Su indice de masa corporal es normal \n";
                }
                //Sobrepeso
                if (imc <= 18.7 && imc >= 17.1)
                {
                    mensaje = "Su indice de masa corporal indica que tiene sobrepeso \n";
                }
                //Obesidad
                if (imc >= 18.8)
                {
                    mensaje = "Su indice de masa corporal indica que tiene obesidad \n";
                }
            }
            if (edad == 7)
            {
                //Bajo Peso
                if (imc < 13.4)
                {
                    mensaje = "Su indice de masa corporal es bajo \n";
                }
                //Peso Normal
                if (imc <= 17.7 && imc >= 13.5)
                {
                    mensaje = "Su indice de masa corporal es normal \n";
                }
                //Sobrepeso
                if (imc <= 19.5 && imc >= 17.8)
                {
                    mensaje = "Su indice de masa corporal indica que tiene sobrepeso \n";
                }
                //Obesidad
                if (imc >= 19.6)
                {
                    mensaje = "Su indice de masa corporal indica que tiene obesidad \n";
                }
            }
            if (edad == 8)
            {
                //Bajo Peso
                if (imc < 13.6)
                {
                    mensaje = "Su indice de masa corporal es bajo \n";
                }
                //Peso Normal
                if (imc <= 18.2 && imc >= 13.7)
                {
                    mensaje = "Su indice de masa corporal es normal \n";
                }
                //Sobrepeso
                if (imc <= 20.5 && imc >= 18.3)
                {
                    mensaje = "Su indice de masa corporal indica que tiene sobrepeso \n";
                }
                //Obesidad
                if (imc >= 20.6)
                {
                    mensaje = "Su indice de masa corporal indica que tiene obesidad \n";
                }
            }
            if (edad == 9)
            {
                //Bajo Peso
                if (imc < 13.8)
                {
                    mensaje = "Su indice de masa corporal es bajo \n";
                }
                //Peso Normal
                if (imc <= 19.0 && imc >= 13.9)
                {
                    mensaje = "Su indice de masa corporal es normal \n";
                }
                //Sobrepeso
                if (imc <= 21.7 && imc >= 19.1)
                {
                    mensaje = "Su indice de masa corporal indica que tiene sobrepeso \n";
                }
                //Obesidad
                if (imc >= 21.8)
                {
                    mensaje = "Su indice de masa corporal indica que tiene obesidad \n";
                }
            }
            if (edad == 10)
            {
                //Bajo Peso
                if (imc < 14.0)
                {
                    mensaje = "Su indice de masa corporal es bajo \n";
                }
                //Peso Normal
                if (imc <= 19.9 && imc >= 14.1)
                {
                    mensaje = "Su indice de masa corporal es normal \n";
                }
                //Sobrepeso
                if (imc <= 22.9 && imc >= 20.0)
                {
                    mensaje = "Su indice de masa corporal indica que tiene sobrepeso \n";
                }
                //Obesidad
                if (imc >= 24.0)
                {
                    mensaje = "Su indice de masa corporal indica que tiene obesidad \n";
                }
            }
            if (edad == 11)
            {
                //Bajo Peso
                if (imc < 14.4)
                {
                    mensaje = "Su indice de masa corporal es bajo \n";
                }
                //Peso Normal
                if (imc <= 20.7 && imc >= 14.5)
                {
                    mensaje = "Su indice de masa corporal es normal \n";
                }
                //Sobrepeso
                if (imc <= 23.9 && imc >= 20.8)
                {
                    mensaje = "Su indice de masa corporal indica que tiene sobrepeso \n";
                }
                //Obesidad
                if (imc >= 24.0)
                {
                    mensaje = "Su indice de masa corporal indica que tiene obesidad \n";
                }
            }
            if (edad == 12)
            {
                //Bajo Peso
                if (imc < 14.8)
                {
                    mensaje = "Su indice de masa corporal es bajo \n";
                }
                //Peso Normal
                if (imc <= 21.7 && imc >= 14.9)
                {
                    mensaje = "Su indice de masa corporal es normal \n";
                }
                //Sobrepeso
                if (imc <= 25.1 && imc >= 21.8)
                {
                    mensaje = "Su indice de masa corporal indica que tiene sobrepeso \n";
                }
                //Obesidad
                if (imc >= 25.2)
                {
                    mensaje = "Su indice de masa corporal indica que tiene obesidad \n";
                }
            }
            if (edad == 13)
            {
                //Bajo Peso
                if (imc < 15.3)
                {
                    mensaje = "Su indice de masa corporal es bajo \n";
                }
                //Peso Normal
                if (imc <= 22.5 && imc >= 15.4)
                {
                    mensaje = "Su indice de masa corporal es normal \n";
                }
                //Sobrepeso
                if (imc <= 26.2 && imc >= 22.6)
                {
                    mensaje = "Su indice de masa corporal indica que tiene sobrepeso \n";
                }
                //Obesidad
                if (imc >=26.3 )
                {
                    mensaje = "Su indice de masa corporal indica que tiene obesidad \n";
                }
            }
            if (edad == 14)
            {
                //Bajo Peso
                if (imc < 15.8)
                {
                    mensaje = "Su indice de masa corporal es bajo \n";
                }
                //Peso Normal
                if (imc <= 23.2 && imc >= 15.9)
                {
                    mensaje = "Su indice de masa corporal es normal \n";
                }
                //Sobrepeso
                if (imc <= 27.1 && imc >= 23.2)
                {
                    mensaje = "Su indice de masa corporal indica que tiene sobrepeso \n";
                }
                //Obesidad
                if (imc >= 27.2)
                {
                    mensaje = "Su indice de masa corporal indica que tiene obesidad \n";
                }
            }
            if (edad == 15)
            {
                //Bajo Peso
                if (imc < 16.3)
                {
                    mensaje = "Su indice de masa corporal es bajo \n";
                }
                //Peso Normal
                if (imc <= 23.9 && imc >= 16.4)
                {
                    mensaje = "Su indice de masa corporal es normal \n";
                }
                //Sobrepeso
                if (imc <= 27.9 && imc >= 24.0)
                {
                    mensaje = "Su indice de masa corporal indica que tiene sobrepeso \n";
                }
                //Obesidad
                if (imc >= 28.0)
                {
                    mensaje = "Su indice de masa corporal indica que tiene obesidad \n";
                }
            }
            if (edad == 16)
            {
                //Bajo Peso
                if (imc < 16.8)
                {
                    mensaje = "Su indice de masa corporal es bajo \n";
                }
                //Peso Normal
                if (imc <= 24.5 && imc >= 16.9)
                {
                    mensaje = "Su indice de masa corporal es normal \n";
                }
                //Sobrepeso
                if (imc <= 28.7 && imc >= 24.6)
                {
                    mensaje = "Su indice de masa corporal indica que tiene sobrepeso \n";
                }
                //Obesidad
                if (imc >= 28.0)
                {
                    mensaje = "Su indice de masa corporal indica que tiene obesidad \n";
                }
            }
            if (edad == 17)
            {
                //Bajo Peso
                if (imc < 17.2)
                {
                    mensaje = "Su indice de masa corporal es bajo \n";
                }
                //Peso Normal
                if (imc <= 25.1 && imc >= 17.3)
                {
                    mensaje = "Su indice de masa corporal es normal \n";
                }
                //Sobrepeso
                if (imc <= 29.5 && imc >= 25.2)
                {
                    mensaje = "Su indice de masa corporal indica que tiene sobrepeso \n";
                }
                //Obesidad
                if (imc >= 29.6)
                {
                    mensaje = "Su indice de masa corporal indica que tiene obesidad \n";
                }
            }
            if (edad == 18)
            {
                //Bajo Peso
                if (imc < 17.8)
                {
                    mensaje = "Su indice de masa corporal es bajo \n";
                }
                //Peso Normal
                if (imc <= 25.5 && imc >= 17.9)
                {
                    mensaje = "Su indice de masa corporal es normal \n";
                }
                //Sobrepeso
                if (imc <= 30.1 && imc >= 25.6)
                {
                    mensaje = "Su indice de masa corporal indica que tiene sobrepeso \n";
                }
                //Obesidad
                if (imc >= 20.2)
                {
                    mensaje = "Su indice de masa corporal indica que tiene obesidad \n";
                }
            }
            return mensaje;
        }

        public string resultados()
        {
            string mensaje = " ";
            if(edad <= 18 && imc >= 2)
            {
                if (sexo == 'M')
                {
                    mensaje = CalculosNiños();
                }
                if (sexo == 'F')
                {
                    mensaje = CalculosNiñas();
                }
            }
            else
            {
                mensaje = CalculosAdulto();
            }
            
            return mensaje;

        }
        public string recomendacionesAlimentacion()
        {
            string mensaje = " ";
            //Bajo peso
            if(imc < 18.5)
            {
                mensaje = "Escoger alimentos tanto en cantidad como en calidad \n"+
                    "que proporcionen proteína, carbohidratos, acidos grasos etc \n"+
                    "No omitir ninguna comida, Consumir refacciones entre comidas \n"+
                    "Consumir por lo menos 400 gramos de frutas y verduras por día\n"+
                    "Para más información consulte a un especialista\n";
            }
            //Peso normal
            if (imc <= 24.9 && imc >= 18.5)
            {
                mensaje = "Tener un equilibrio entre alimentos y energía que consume \n"+
                    "Realizar de 4 a 5 comidas diaras para conseguir una buena digestión \n"+
                    "y asimilación de los nustrientes \n"+
                    "Evitar alimentos con altos niveles de grasa como la comida rápid \n"+
                    "Consumir alimentos de todos los grupos\n"+
                    "\nPara más información consulte a un especialista\n";
            }
            //Sobrepeso
            if (imc <= 29.9 && imc >= 25.0)
            {
                mensaje = "Comer alimentos bajos en calorías \n"+
                    "Comer alimentos muy poco elaborados \n"+
                    "En lo posible, no añadir grasas ni azucares al cocinar \n"+
                    "Preparar pequeñas cantidades \n"+
                    "Comer siempre en el mismo lugar \n"+
                    "En restaurantes pedir que nos preparen la comida sin grasas \n"+
                    "\nPara más información consulte a un especialista\n";
            }
            //Obesidad
            if (imc >= 30)
            {
                mensaje = "Comer alimentos bajos en calorías \n"+
                    "Planear comidas bajas en calorías y ricas en nutrientes \n"+
                    "Planear cada una de las comidas al dia \n"+
                    "Comer solo alimentos no elaborados \n"+
                    "Conocer las categorias alimentarias \n"+
                    "Hacer una lista de compras y limitarse a ella \n"+
                    "Comprar alimentos en su estado natural siempre que sea posible \n"+
                    "No agregar grasas ni azucares al cocinar \n"+
                    "\nPara más información consulte a un especialista\n";
            }

            return mensaje;
        }

        public string recomendacionesFisicas()
        {
            string mensaje = " ";

            //Bajo Peso
            if (imc < 18.5)
            {
                mensaje = "Realizar actividades fisicas cuando ya se haya aumentado el peso"+
                    "\nPara más información consulte a un especialista\n";
            }
            //Peso Normal
            if (imc <= 24.9 && imc >= 18.5)
            {
                mensaje = "Realizar actividades fisicas minimo 5 veces por semana \n"+
                    "Caminar 5 km \n" +
                    "Jugar baloncesto (encestar canastas) \n" +
                    "Bailar de forma intensa \n"+
                    "Nadar, saltar cuerda \n"+
                    "Andar en bicicleta \n"+
                    "\nPara más información consulte a un especialista\n";
            }
            //Sobrepeso y Obesidad
            if (imc >= 25.0)
            {
                mensaje = "En sus inicios caminar es una buena opción \n"+
                    "Es ideal realizar esta actividad fisica por lo menos 5 veces por semana \n"+
                    "El ejercicio debe de ser conservador, con el fin de desarrollar \n"+
                    "una condicion fisica cardiorespiratoria-metabolica y evitar lesiones \n"+
                    "Relizar los ejercicios cuando no haya una temperatura muy elevada ni muy baja \n"+
                    "No usar trajes termicos ni ropa extra para incrementar la sudoración \n"+
                    "Usar mancuernas mientras caminas para ejercitar brazos y piernas \n"+
                    "\nPara más información consulte a un especialista\n";
            }
            return mensaje;
        }

        public override string ToString()
        {
            String retorno = " ";
            if (edad <= 18 && imc >= 2)
            {
                if(sexo == 'M')
                {
                    retorno = $"Es un Niño \nNombre: {nombre} \nEdad: {edad} \nSexo: {sexo}\nSu altura es: {altura} \nSu peso es: {peso} \nSu IMC es: {imc}";
                }
                if(sexo == 'F')
                {
                    retorno = $"Es una Niña \nNombre: {nombre} \nEdad: {edad} \nSexo: {sexo}\nSu altura es: {altura} \nSu peso es: {peso} \nSu IMC es: {imc}";
                }
                
            }
            else
            {
                retorno = $"Es un adulto \nNombre: {nombre} \nEdad: {edad} \nSexo: {sexo}\nSu altura es: {altura} \nSu peso es: {peso} \nSu IMC es: {imc}";
            }
            return retorno;
        }

    }
}
