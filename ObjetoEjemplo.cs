using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoConsola2025
{
    public class ObjetoEjemplo
    {
        public int Id { get; set; } = 7;
        public string Name { get; set; } = "Nombre Objeto Prueba";
        public bool IsVerdadero { get; set; } = true;

    }

    public class Lapiz
    {
        public string TipoDeGrafito { get; set; } = "H2";
        public bool TieneGoma { get; set; } = true;
        public string Color { get; set; } = "Amarillo";

        ///El primer termino se refiere a privicidad del elemento
        ///El segundo termino puede referirse a que la funcion puede ser accedida sin tener que inicializar un objeto (Puede estar O no)
        ///El termino que sigue se refiere a lo que devuelve la funcion (Esto se devuelve en el return;)
        ///El termino siguiente es el nombre de la funcion (Por Convencion de buenas practicas se utiliza la sintaxis de Camello)
        ///Eltermino final es un Parentesis que contiene(Dentro del parentesis) Lo que recibe la funcion.
        ///Se delimita por llaves y todos los caminos deben tener un return con lo que se devuelve
        public static Lapiz LapizMordido(Lapiz objetoDeEntrada)
        {
            objetoDeEntrada.TieneGoma = false;
            
            return objetoDeEntrada;
        }
    }
}

