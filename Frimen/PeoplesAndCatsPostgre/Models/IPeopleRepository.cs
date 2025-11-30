namespace PeoplesAndCats.Models;
public interface IPeopleRepository
{
    IQueryable<People> Peoples { get; }
}