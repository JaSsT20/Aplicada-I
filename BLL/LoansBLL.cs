using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

public class LoansBLL

{
    private Context _context;

    public LoansBLL(Context context)
    {
        _context = context;
    }

    public bool Exist(int loanID)
    {
        return _context.Loans.Any( o => o.loanID == loanID);
    }

    public bool Insert(Loans loan)
    {
        _context.Loans.Add(loan);
        return _context.SaveChanges() > 0;
    }

    public bool Modify(Loans loan)
    {
        _context.Entry(loan).State = EntityState.Modified;
        return _context.SaveChanges() > 0;
    }

    public bool Save(Loans loan)
    {
        if (!Exist(loan.loanID))
            return this.Insert(loan);
        else
            return this.Modify(loan);
    }

    public bool Delete(Loans loan)
    {
        _context.Entry(loan).State = EntityState.Deleted;
        return _context.SaveChanges() > 0;
    }

    public Loans? Search(int loanID)
    {
        return _context.Loans.Where(o => o.loanID == loanID)
        .AsNoTracking().SingleOrDefault();
    }

    public List<Loans> GetList(Expression<Func<Loans, bool>> criterion)
    {
        return _context.Loans.AsNoTracking().Where(criterion).ToList();
    }
}