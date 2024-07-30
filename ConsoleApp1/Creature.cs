/*
 Создание класса «Океанариум» с информацией о «мешканцах» Океанариуме. 
Створить класс для каждого места океана. Они могут получить информацию 
о каждом морском дне. Реализуйте подтримку итератора для класа «Океанариум». 
Протестируйте возможность использования foreach для океанариума
 */

namespace ConsoleApp1
{
    public class Creature
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Size { get; set; }

        public Creature(string name, string description, double size)
        {
            Name = name;
            Description = description;
            Size = size;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nSize: {Size}\nDescription: {Description}";
        }
    }
}
