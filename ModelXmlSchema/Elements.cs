using System.Collections;
using System.Linq.Expressions;

using Microsoft.EntityFrameworkCore;

namespace ModelXmlSchema;
public class Elements(DbSet<Particle> particles) : IQueryable<Element>
{

  public IEnumerator<Element> GetEnumerator()
  {
    // ReSharper disable once NotDisposedResourceIsReturned
    return particles.OfType<Element>().GetEnumerator();
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    // ReSharper disable once NotDisposedResourceIsReturned
    return particles.OfType<Element>().GetEnumerator();
  }

  public Type ElementType => typeof(Element);

  public Expression Expression => particles.OfType<Element>().Expression;

  public IQueryProvider Provider => particles.OfType<Element>().Provider;

  public void Add(Element element)
  {
    particles.Add(element);
  }
}
