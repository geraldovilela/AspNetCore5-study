using _01_RestWithASPNETCore.Models;
using System;
using System.Collections.Generic;

namespace _01_RestWithASPNETCore.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindById(long Id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
