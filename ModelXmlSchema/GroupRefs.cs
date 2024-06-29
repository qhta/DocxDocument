using System.Collections;
using System.Linq.Expressions;

using Microsoft.EntityFrameworkCore;

namespace ModelXmlSchema;
public class GroupRefs(DbSet<Particle> particles) : IQueryable<GroupRef>
{

  public IEnumerator<GroupRef> GetEnumerator()
  {
    // ReSharper disable once NotDisposedResourceIsReturned
    return particles.OfType<GroupRef>().GetEnumerator();
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    // ReSharper disable once NotDisposedResourceIsReturned
    return particles.OfType<GroupRef>().GetEnumerator();
  }

  public Type ElementType => typeof(GroupRef);

  public Expression Expression => particles.OfType<GroupRef>().Expression;

  public IQueryProvider Provider => particles.OfType<GroupRef>().Provider;

  public void Add(GroupRef element)
  {
    particles.Add(element);
  }
}
