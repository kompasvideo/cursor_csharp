namespace PeoplesAndCats.Models;
public class EFPeopleRepository : IPeopleRepository
{
    private readonly ApplicationDbContext _context;
    public EFPeopleRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public IQueryable<People> Peoples => _context.Peoples;
}