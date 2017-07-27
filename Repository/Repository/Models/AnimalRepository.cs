using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repository.Models;

namespace Repository
{
    public abstract class AnimalRepository : IAnimalRepository
    {
        private readonly AnimalContest _animalContest;

        public AnimalRepository(AnimalContest animalContest)
        {
            _animalContest = animalContest;
        }

        public void Add(Animal animal)
        {
            _animalContest.Animals.Add(animal);
        }


        public void Delete(Animal animal)
        {
            _animalContest.Animals.Remove(animal);
        }


        public void Dispose()
        {
            _animalContest.Dispose();
        }

        public Animal Get(string name)
        {
            return _animalContest.Animals.FirstOrDefault(animal => animal.Name.Equals(name));
        }

        public void Save()
        {
            _animalContest.SaveChanges();
        }

        public void Update(Animal animal)
        {
            var dbAnimal = _animalContest.Animals.FirstOrDefault(an => an.Id.Equals(animal.Id));
            if (dbAnimal != null) { dbAnimal.Name = animal.Name; }
        }
    }
}