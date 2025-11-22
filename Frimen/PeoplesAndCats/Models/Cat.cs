namespace PeoplesAndCats.Models;
public class Cat
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public int PeopleId {get; set;}
    public People People {get; set;}
}