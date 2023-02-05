using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

public class PaymentsBLL

{
    private Context _context;

    public PaymentsBLL(Context context)
    {
        _context = context;
    }

    public bool Exist(int paymentID)
    {
        return _context.Payments.Any( o => o.paymentID == paymentID);
    }

    public bool Insert(Payments payment)
    {
        _context.Payments.Add(payment);
        return _context.SaveChanges() > 0;
    }

    public bool Modify(Payments payment)
    {
        _context.Entry(payment).State = EntityState.Modified;
        return _context.SaveChanges() > 0;
    }

    public bool Save(Payments payment)
    {
        if (!Exist(payment.paymentID))
            return this.Insert(payment);
        else
            return this.Modify(payment);
    }

    public bool Delete(Payments payment)
    {
        _context.Entry(payment).State = EntityState.Deleted;
        return _context.SaveChanges() > 0;
    }

    public Payments? Search(int paymentID)
    {
        return _context.Payments.Where(o => o.paymentID == paymentID)
        .AsNoTracking().SingleOrDefault();
    }

    public List<Payments> GetList(Expression<Func<Payments, bool>> criterion)
    {
        return _context.Payments.AsNoTracking().Where(criterion).ToList();
    }
}