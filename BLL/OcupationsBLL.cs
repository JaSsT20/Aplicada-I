using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

public class OcupationsBLL

{
    private Context _context;

    public OcupationsBLL(Context context)
    {
        _context = context;
    }

    public bool Exist(int OcupationId)
    {
        return _context.Ocupations.Any( o => o.OcupationId == OcupationId); // No entendi bien
    }

    public bool Insert(Ocupations ocupations)
    {
        _context.Ocupations.Add(ocupations);
        return _context.SaveChanges() > 0;
    }

    public bool Modify(Ocupations occupations)
    {
        _context.Entry(occupations).State = EntityState.Modified;
        return _context.SaveChanges() > 0;
    }

    public bool Save(Ocupations occupations)
    {
        if (!Exist(occupations.OcupationId))
            return this.Insert(occupations);
        else
            return this.Modify(occupations);
    }

    public bool Delete(Ocupations occupations)
    {
        _context.Entry(occupations).State = EntityState.Deleted;
        return _context.SaveChanges() > 0;
    }

    public Ocupations? Search(int OccupationId)
    {
        return _context.Ocupations.Where(o => o.OcupationId == OccupationId)
        .AsNoTracking().SingleOrDefault();
    }

    public List<Ocupations> GetList(Expression<Func<Ocupations, bool>> criterion)
    {
        return _context.Ocupations.AsNoTracking().Where(criterion).ToList();
    }
}