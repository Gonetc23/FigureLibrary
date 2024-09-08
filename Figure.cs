namespace FigureLibrary
{
    public abstract class Figure
    {
        public string TypeName { get; set; }

        public Figure(string typeName)
        {
            TypeName = typeName;
        }

        public abstract double CalculateSquare();

        public override string ToString()
        {
            return $"Текущий тип фигуры: " + TypeName;
        }
    }
}

