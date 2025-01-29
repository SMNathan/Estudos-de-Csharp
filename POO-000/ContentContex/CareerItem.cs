using Balta.NotificationContext;
using Balta.SharedContext;

namespace Balta.ContentContext {

        public class CareerItem : Base{
        public CareerItem(int order, string title, string descriptiom, Course course)
        {
            if (course == null)
            AddNotification(new Notification("Course", "Curso Inválido"));
            
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