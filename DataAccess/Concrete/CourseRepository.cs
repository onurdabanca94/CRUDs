using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete;

public class CourseRepository : ICourseRepository
{
    private List<Course> _courses;
    public CourseRepository()
    {
        _courses = new List<Course>()
        {
            new Course{ Id = 1, CategoryId = 1, Description = "Desc 1", Name = "Course 1", InstructorName = "Onur"},
            new Course{ Id = 2, CategoryId = 2, Description = "Desc 2", Name = "Course 2", InstructorName = "Ömür"},
            new Course{ Id = 3, CategoryId = 3, Description = "Desc 3", Name = "Course 3", InstructorName = "Kömür"}
        };
    }
    public void Add(Course course)
    {
        _courses.Add(course);
    }

    public void Delete(int id)
    {
        Course courseDel = _courses.FirstOrDefault(c => c.Id == id);
        if (courseDel != null)
        {
            _courses.Remove(courseDel);
        }
        else
        {
            Console.WriteLine("There is no course like this");
        }
    }

    public List<Course> GetAll()
    {
        foreach (var course in _courses)
        {
            Console.WriteLine("Course Name: " + course.Name + "Description: " + course.Description);
        }
        return _courses;
    }

    public Course GetById(int id)
    {
        Course course = _courses.FirstOrDefault(c => c.Id == id);
        Console.WriteLine("Course Name: "+ course.Name + "Description: " + course.Description);
        return _courses.FirstOrDefault(c => c.Id == id);
    }

    public void Update(Course courseNew)
    {
        Course course = _courses.FirstOrDefault(c => c.Id == courseNew.Id);
        if (course != null)
        {
            course.Name = courseNew.Name;
            course.Description = courseNew.Description;
            course.CategoryId = courseNew.CategoryId;
            course.InstructorName = courseNew.InstructorName;
        }
        else
        {
            Console.WriteLine("There is no course like this.");
        }
    }
}
