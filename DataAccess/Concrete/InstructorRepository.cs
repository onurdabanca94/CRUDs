using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete;

public class InstructorRepository : IInstructorRepository
{
    private List<Instructor> _instructors;
    public InstructorRepository()
    {
        _instructors = new List<Instructor> 
        {
            new Instructor{ Id = 1, Name = "Bounty",Surname = "Chocolate" , ProfessionFields = ".Net"},
            new Instructor{ Id = 2, Name = "Cubun", Surname = "Doritos", ProfessionFields = "Java"},
            new Instructor{ Id = 3, Name = "Snackers", Surname = "Fitnut", ProfessionFields = "Python"}
        };
    }
    public void Add(Instructor entity)
    {
        _instructors.Add(entity);
    }

    public void Delete(int id)
    {
        Instructor instructorDel = _instructors.FirstOrDefault(x => x.Id == id);
        if (instructorDel != null)
        {
            _instructors.Remove(instructorDel);
        }
        else
        {
            Console.WriteLine("There is no instructor like this.");
        }
    }

    public List<Instructor> GetAll()
    {
        return _instructors;
    }

    public Instructor GetById(int id)
    {
        Instructor instructor = _instructors.FirstOrDefault(i => i.Id == id);
        if (instructor != null)
        {
            Console.WriteLine("Instructor Name: " + instructor.Name + "Instructor Profession: " + instructor.ProfessionFields);
        }
        else
        {
            Console.WriteLine("There is no instructor like this.");
        }

        return _instructors.FirstOrDefault(i => i.Id == id);
    }

    public void Update(Instructor instructor)
    {
        Instructor instructorUpt = _instructors.FirstOrDefault(u => u.Id == instructor.Id);
        if (instructor != null)
        {
            instructorUpt.Name = instructor.Name;
            instructorUpt.Surname = instructor.Surname;
        }
        else
        {
            Console.WriteLine("There is no instructor like this.");
        }
    }
}
