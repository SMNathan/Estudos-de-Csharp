using Balta.ContentContext;

namespace Balta {

    public class Program {
        public static void Main(String[] args) {

            Console.Clear();

            var articles = new List<Article>
            {
                new Article("Artigos sobre OOP", "orientação-a-objetos"),
                new Article("Artigos sobre C#", "csharp"),
                new Article("Artigos sobre .NET", "dotnet")
            };

            // foreach (var article in articles) {

            //     Console.WriteLine(article.Id);
            //     Console.WriteLine(article.Title);
            //     Console.WriteLine(article.Url);
            // }

            var courses = new List<Course>();
            var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
            var courseCsharp = new Course("Fundamentos C#", "fundamentos-csharp");
            var courseMAUI = new Course("Fundamentos MAUI", "fundamentos-maui");
            courses.Add(courseOOP);
            courses.Add(courseCsharp);
            courses.Add(courseMAUI);

            var careers = new List<Career>();
            var careerDotNET = new Career("Especialista .NET", "especialista-dotnet");
            var careerItem = new CareerItem(1, "Comece por aqui", "", courseCsharp);
            var careerItem3 = new CareerItem(3, "Aprenda MAUI", "", courseMAUI);
            var careerItem2 = new CareerItem(2, "Aprenda Orientação a Objetos", "", courseOOP);
            careerDotNET.Items.Add(careerItem);
            careerDotNET.Items.Add(careerItem3);
            careerDotNET.Items.Add(careerItem2);

            careers.Add(careerDotNET);

            foreach (var career in careers) {

                Console.WriteLine(career.Title);

                foreach (var item in career.Items.OrderBy(x => x.Order)) {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course.Title);
                    Console.WriteLine(item.Course.Level);
                }
            }
        }
    }
}
