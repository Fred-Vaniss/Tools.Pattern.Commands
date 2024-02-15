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
    }
}