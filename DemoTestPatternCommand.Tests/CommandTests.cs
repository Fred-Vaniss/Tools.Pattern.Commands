namespace DemoTestPatternCommand.Tests
{
    public class CommandTests
    {
        [Fact]
        public void TestAddPersonneCommand()
        {
            //Arrange
            IList<Personne> items = new List<Personne>();
            Personne personne = new Personne() { Nom = "Doe", Prenom = "John" };
            AddPersonCommand command = new AddPersonCommand(items, personne);

            //Act
            command.Execute();

            //Asserts
            Assert.NotEmpty(items);
            Assert.Equal(personne, items[0]);
            Assert.Equal(1, personne.Id);
        }


        [Fact]
        public void TestRemovePersonneCommand()
        {
            //Arrange
            IList<Personne> items = new List<Personne>
            {
                new Personne() { Nom = "Doe", Prenom = "John", Id = 1}
            };
            DeletePersonCommand command = new DeletePersonCommand(items, 1);
            
            //Act
            command.Execute();
            
            
            //Asserts
            Assert.Empty(items);
        }

        [Fact]
        public void TestFailedRemovePersonneCommand()
        {
            //Arrange
            IList<Personne> items = new List<Personne>();
            DeletePersonCommand command = new DeletePersonCommand(items, 1);
            
            //Act
            
            //Asserts
            KeyNotFoundException exception = Assert.Throws<KeyNotFoundException>(() => command.Execute());
            Assert.Equal("Person with Id 1 not found" ,exception.Message);
        }
    }
}