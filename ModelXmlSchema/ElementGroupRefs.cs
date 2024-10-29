using System.Collections;
using System.Linq.Expressions;

using Microsoft.EntityFrameworkCore;

namespace ModelXmlSchema;
public class ElementGroupRefs(DbSet<Particle> particles) : IQueryable<ElementGroupRef>
{

  public IEnumerator<ElementGroupRef> GetEnumerator()
  {
    // ReSharper disable once NotDisposedResourceIsReturned
    return particles.OfType<ElementGroupRef>().GetEnumerator();
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    // ReSharper disable once NotDisposedResourceIsReturned
    return particles.OfType<ElementGroupRef>().GetEnumerator();
  }

  public Type ElementType => typeof(ElementGroupRef);

  public Expression Expression => particles.OfType<ElementGroupRef>().Expression;

  public IQueryProvider Provider => particles.OfType<ElementGroupRef>().Provider;

  public void Add(ElementGroupRef element)
  {
    particles.Add(element);
  }
}
