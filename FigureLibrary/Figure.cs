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

//Напишите на C# библиотеку для поставки внешним клиентам,
//которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.
//Дополнительно к работоспособности оценим:
//Юнит - тесты
//Легкость добавления других фигур
//Вычисление площади фигуры без знания типа фигуры в compile-time
//Проверку на то, является ли треугольник прямоугольным 