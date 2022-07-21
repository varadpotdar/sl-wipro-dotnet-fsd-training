using SchoolManagement.Data.Models;

namespace SchoolManagement.Data
{
    public class AppDbInitializer
    {
        public  static void seed (IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope=applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AddDbContext>();
                if(!context.Students.Any())
                {
                    context.Students.AddRange(new Student()

                    {
                       
                        Name = "Varad",
                        Address = "Pune",
                        Email = "Varad@gmail.com",
                        Class = "10",
                        Marks = 90
                       
                    },
                    new Student()
                    {
                        
                        Name = "Ankit",
                        Address = "Pune",
                        Email = "Ankit@gmail.com",
                        Class = "10",
                        Marks = 85
                        
                    }
                    );

                    context.SaveChanges();
                }
            
            }
                    
        }
    }
}
