namespace Balta.ContentContext {

        public class CareerItem {
        public CareerItem(int order, string title, string descriptiom, Course course)
        {
            if (course == null)
            throw new System.Exception("O curso não pode ser Nulo");
            
            Order = order;
            Title = title;
            Descriptiom = descriptiom;
            Course = course;
        }

        public int Order { get; set; }
        public string Title { get; set; }
        public string Descriptiom { get; set; }
        public Course Course { get; set; }
    }
}