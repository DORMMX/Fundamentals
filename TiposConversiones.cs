namespace Fundamentals
{
    // Struct para representar un punto 2D
    public struct Punto
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Punto(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Conversión IMPLÍCITA de Punto a Coordenada
        // Asumimos que un Punto SIEMPRE se puede convertir a Coordenada sin pérdida significativa,
        // o que la lógica de mapeo es segura por diseño.
        public static implicit operator Coordenada(Punto p)
        {
            // En un escenario real, harías una conversión más compleja
            // Aquí, simplemente mapeamos X a Latitud y Y a Longitud (ejemplo simplificado)
            return new Coordenada(p.X / 100.0, p.Y / 100.0);
        }

        // Conversión EXPLÍCITA de Punto a int (solo tomamos X, hay pérdida de Y)
        // Se requiere un cast porque estamos perdiendo información (la coordenada Y)
        public static explicit operator int(Punto p)
        {
            return p.X;
        }

        public override string ToString() => $"Punto({X}, {Y})";
    }

    // Struct para representar una coordenada geográfica
    public struct Coordenada
    {
        public double Latitud { get; set; }
        public double Longitud { get; set; }

        public Coordenada(double lat, double lon)
        {
            Latitud = lat;
            Longitud = lon;
        }

        // Conversión EXPLÍCITA de Coordenada a Punto
        // Requiere un cast porque estamos truncando doubles a ints, lo que implica pérdida de precisión
        public static explicit operator Punto(Coordenada c)
        {
            return new Punto((int)(c.Latitud * 100), (int)(c.Longitud * 100));
        }

        public override string ToString() => $"Coordenada({Latitud:F2}, {Longitud:F2})";
    }
}
