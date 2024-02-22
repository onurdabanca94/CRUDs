using Business.Abstract;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class GenericManager<T> : IGenericService<T> where T : class
{
    private readonly IGenericRepository<T> _genericRepository;
    public GenericManager(IGenericRepository<T> genericRepository)
    {
        _genericRepository = genericRepository;
    }

    public void Add(T entity)
    {
        _genericRepository.Add(entity);
    }

    public void Delete(int id)
    {
        _genericRepository.Delete(id);
    }

    public List<T> GetAll()
    {
        return _genericRepository.GetAll();
    }

    public T GetById(int id)
    {
        return _genericRepository.GetById(id);
    }

    public void Update(T entity)
    {
        _genericRepository.Update(entity);
    }
}
