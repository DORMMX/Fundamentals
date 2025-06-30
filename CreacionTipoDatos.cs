
using System;

namespace Fundamentals
{
    internal class CreacionTipoDatos
    {

        /// <summary>
        /// Valores Constantes: Representan un conjunto de valores discretos y relacionados.
        ///Legibilidad: Mejora la legibilidad del código al usar nombres significativos en lugar de números.
        ///Tipo Numérico Subyacente: Por defecto, los enum son de tipo int, pero pueden ser byte, sbyte, short, ushort, uint, long, o ulong.
        ///Tipo de Valor: Son tipos de valor, lo que significa que cuando los asignas o los pasas, se copia su valor directamente.
        /// </summary>
        public enum DiaDeLaSemana
        {
            Lunes,    // Por defecto es 0
            Martes,   // Por defecto es 1
            Miercoles,
            Jueves,
            Viernes,
            Sabado,
            Domingo
        }
    }

    /// <summary>
    /// Un struct es un tipo de valor que se utiliza para encapsular un pequeño grupo de variables relacionadas que forman una unidad lógica. 
    /// Son muy parecidos a las clases en cuanto a que pueden tener campos, propiedades, métodos y eventos, pero fundamentalmente se comportan de manera diferente.
    /// 
    /// Tipo de Valor: La diferencia más importante es que son tipos de valor. Esto significa que cuando una struct se asigna a una nueva variable o se pasa como parámetro a un método, 
    /// se crea una copia completa de la struct. Los cambios en la copia no afectan al original.
    /// </summary>
    public struct Punto2D
    {
        public int X;
        public int Y;

        // Constructor de la struct
        public Punto2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Método de la struct
        public void Mover(int deltaX, int deltaY)
        {
            X += deltaX;
            Y += deltaY;
        }

        // Sobrescribimos ToString para una mejor representación
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
