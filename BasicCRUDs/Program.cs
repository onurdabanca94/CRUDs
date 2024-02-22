using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;

CourseManager courseManager = new CourseManager(new CourseRepository());
CategoryManager categoryManager = new CategoryManager(new CategoryRepository());
InstructorManager instructorManager = new InstructorManager(new InstructorRepository());

Console.WriteLine("All courses: ");
courseManager.GetAll();

Console.WriteLine("Course 2 information: ");
courseManager.GetById(2);

Course courseNew = new Course { Id = 4, Name = "Course 4", Description = "Description 4", CategoryId = 4, InstructorName = "Onur"};
courseManager.Add(courseNew);
Console.WriteLine("New Course added.");
courseManager.GetAll();

Console.WriteLine("---------");
Course courseUpt = courseManager.GetById(1);
courseManager.Update(courseUpt);
Console.WriteLine("Kurs güncellendi.");
courseManager.GetById(1);

int courseIdToDel = 2;
courseManager.Delete(courseIdToDel);
Console.WriteLine($"ID {courseIdToDel} deleted.");
courseManager.GetAll();

Console.WriteLine("\n\nAll Categories: ");
categoryManager.GetAll();

Console.WriteLine("\nCategory adding..");
Category categoryNew = new Category { Id = 4, Name = "Category 4" };
categoryManager.Add(categoryNew);
Console.WriteLine("New category added.");
categoryManager.GetAll();

Console.WriteLine("Category 1 updating..");
Category categoryUpt = categoryManager.GetById(1);
categoryUpt.Name = "Updated Category";
categoryManager.Update(categoryUpt);
Console.WriteLine("Category Updated.");
categoryManager.GetById(1);

Console.WriteLine("Category 2 deleting..");
int categoryIdToDel = 2;
categoryManager.Delete(categoryIdToDel);
Console.WriteLine($"ID {categoryIdToDel} category deleted.");
categoryManager.GetAll();

Console.WriteLine("\n\nAll Instructors");
instructorManager.GetAll();

Console.WriteLine("\nInstructor adding..");
Instructor instructorNew = new Instructor { Id = 4, Name = "Biscut", Surname = "Faravula", ProfessionFields = "MVP" };
instructorManager.Add(instructorNew);
Console.WriteLine("New instructor added.");
instructorManager.GetAll();

Console.WriteLine("Instructor 1 updating..");
Instructor instructorUpt = instructorManager.GetById(1);
instructorUpt.Name = "Updated Instructor";
instructorManager.Update(instructorUpt);
Console.WriteLine("Instructor Updated.");
instructorManager.GetById(1);

Console.WriteLine("Instructor 2 deleting..");
int instructorIdToDel = 2;
instructorManager.Delete(instructorIdToDel);
Console.WriteLine($"ID {instructorIdToDel} instructor deleted.");
instructorManager.GetAll();