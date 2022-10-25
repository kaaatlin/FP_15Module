// Напишите метод, который соберет всех учеников всех классов в один список, используя LINQ.
namespace FP_15Module
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
            };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join("\n", allStudents));
        }
        static string[] GetAllStudents(Classroom[] classes)
        {
            var joined = classes.SelectMany(x => x.Students).ToArray();
            return joined;
        }

        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }
}