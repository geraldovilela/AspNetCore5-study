using _01_RestWithASPNETCore.Models;
using _01_RestWithASPNETCore.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_RestWithASPNETCore.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private AppDBContext _context;
        public PersonServiceImplementation(AppDBContext context)
        {
            _context = context;
        }

        public Person Create(Person person)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
            return person;
        }

        public void Delete(long id)
        {
            var result = _context.Persons.SingleOrDefault(p => p.Id.Equals(id));
            if (result != null)
            {
                try
                {
                    _context.Persons.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public List<Person> FindAll()
        {

            return _context.Persons.ToList();
        }

        public Person FindById(long Id)
        {
            return _context.Persons.Find(Id);
        }

        public Person Update(Person person)
        {
            if (!Exists(person.Id)) return new Person();

            var result = _context.Persons.SingleOrDefault(p => p.Id.Equals(person.Id));

            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(person);
                    _context.SaveChanges();

                }
                catch (Exception)
                {

                    throw;
                }
            }
            return result;
        }

        private bool Exists(long Id)
        {
            return _context.Persons.Any(p => p.Id.Equals(Id));

        }
    }

}
