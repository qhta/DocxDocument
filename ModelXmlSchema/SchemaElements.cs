using System.Collections;
using System.Linq.Expressions;

using Microsoft.EntityFrameworkCore;

namespace ModelXmlSchema;
public class SchemaElements(DbSet<SchemaParticle> particles) : IQueryable<SchemaElement>
{

  public IEnumerator<SchemaElement> GetEnumerator()
  {
    // ReSharper disable once NotDisposedResourceIsReturned
    return particles.OfType<SchemaElement>().GetEnumerator();
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    // ReSharper disable once NotDisposedResourceIsReturned
    return particles.OfType<SchemaElement>().GetEnumerator();
  }

  public Type ElementType => typeof(SchemaElement);

  public Expression Expression => particles.OfType<SchemaElement>().Expression;

  public IQueryProvider Provider => particles.OfType<SchemaElement>().Provider;

  public void Add(SchemaElement element)
  {
    particles.Add(element);
  }
}
