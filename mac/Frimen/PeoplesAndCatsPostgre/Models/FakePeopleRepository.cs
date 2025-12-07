namespace PeoplesAndCats.Models;
public class FakePeopleRepository : IPeopleRepository
{
    public IQueryable<People> Peoples => new List<People>
    {
        new People { Id = 1, Name = "John Doe", Age = 30 },
        new People { Id = 2, Name = "Jane Doe", Age = 25 },
    }.AsQueryable<People>();
}