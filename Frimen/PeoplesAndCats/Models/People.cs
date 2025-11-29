namespace PeoplesAndCats.Models;
public class People
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public List<Cat> Cats { get; set; } = new();
}