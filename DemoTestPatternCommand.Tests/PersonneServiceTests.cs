using Models.Repositories;
using Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTestPatternCommand.Tests
{
    public class PersonneServiceTests
    {
        [Fact]
        public void AddPersonTest()
        {
            //Arrange
            IPersonneRepository repository = new PersonneService();
            Personne personne = new Personne() { Nom = "Doe", Prenom = "John" };
            
            //Act
            repository.Insert(personne);
            IEnumerable<Personne> personnes = repository.Get();

            //Assert
            Assert.Single(personnes);
            Assert.Equal(1, personnes.First().Id);
        }

        [Fact]
        public void DeletePersonTest()
        {
            //Arrange
            IPersonneRepository repository = new PersonneService();
            Personne personne = new Personne() { Nom = "Doe", Prenom = "John" };
            
            //Act
            repository.Insert(personne);
            repository.Delete(1);
            IEnumerable<Personne> personnes = repository.Get();
            
            //Assert
            Assert.Empty(personnes);
        }
    }
}
