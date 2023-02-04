using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

public class PersonBLL

{
    private Context _context;

    public PersonBLL(Context context)
    {
        _context = context;
    }

    public bool Exist(int PersonID)
    {
        return _context.Person.Any( o => o.personID == PersonID);
    }

    public bool Insert(Person person)
    {
        _context.Person.Add(person);
        return _context.SaveChanges() > 0;
    }

    public bool Modify(Person person)
    {
        _context.Entry(person).State = EntityState.Modified;
        return _context.SaveChanges() > 0;
    }

    public bool Save(Person person)
    {
        if (!Exist(person.personID))
            return this.Insert(person);
        else
            return this.Modify(person);
    }

    public bool Delete(Person person)
    {
        _context.Entry(person).State = EntityState.Deleted;
        return _context.SaveChanges() > 0;
    }

    public Person? Search(int personID)
    {
        return _context.Person.Where(o => o.personID == personID)
        .AsNoTracking().SingleOrDefault();
    }

    public List<Person> GetList(Expression<Func<Person, bool>> criterion)
    {
        return _context.Person.AsNoTracking().Where(criterion).ToList();
    }
}