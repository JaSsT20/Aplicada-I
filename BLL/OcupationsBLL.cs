using Microsoft.EntityFrameworkCore;
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

    public bool Modify(Ocupations ocupations)
    {
        _context.Entry(ocupations).State = EntityState.Modified;
        return _context.SaveChanges() > 0;
    }

    public bool Save(Ocupations ocupations)
    {
        if (!Existe(ocupations.OcupationId))
            return this.Insert(ocupations);
        else
            return this.Modify(ocupations);
    }

    public bool Delete(Ocupations ocupations)
    {
        _context.Entry(ocupations).State = EntityState.Deleted;
        return _context.SaveChanges() > 0;
    }

    public Ocupations? Search(int OcupationId)
    {
        return _context.Ocupations.Where(o => o.OcupationId == OcupationId)
        .AsNoTracking().SingleOrDefault();
    }
}