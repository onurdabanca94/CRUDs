using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete;

public class CategoryRepository : ICategoryRepository
{
    private List<Category> _categories;
    public CategoryRepository()
    {
        _categories = new List<Category> 
        {
            new Category { Id = 1, Name = "Category First"},
            new Category { Id = 2, Name = "Category Second"},
            new Category { Id = 3, Name = "Category Third"}
        };
    }
    public void Add(Category entity)
    {
        _categories.Add(entity);
    }

    public void Delete(int id)
    {
        Category category = _categories.FirstOrDefault(c => c.Id == id);
        if (category != null)
        {
            _categories.Remove(category);
        }
        else 
        {
            Console.WriteLine("There is no category like this.");
        }
    }

    public List<Category> GetAll()
    {
        foreach (var category in _categories)
        {
            Console.WriteLine($"{category.Name}");
        }
        return _categories;
    }

    public Category GetById(int id)
    {
        Category category = _categories.FirstOrDefault(c => c.Id == id);
        if(category != null)
        {
            Console.WriteLine("Category Name: " + category.Name);
        }
        else
        {
            Console.WriteLine("There is no category like this");
        }

        return _categories.FirstOrDefault(c => c.Id == id);
    }

    public void Update(Category categoryUpdate)
    {
        Category categoryUpt = _categories.FirstOrDefault(c => c.Id == categoryUpdate.Id);
        if (categoryUpt != null)
        {
            categoryUpt.Name = categoryUpdate.Name;
        }
        else
        {
            Console.WriteLine("There is no category like this.");
        }
    }
}
