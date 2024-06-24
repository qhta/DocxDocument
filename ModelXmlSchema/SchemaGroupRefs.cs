using System.Collections;
using System.Linq.Expressions;

using Microsoft.EntityFrameworkCore;

namespace ModelXmlSchema;
public class SchemaGroupRefs(DbSet<SchemaParticle> particles) : IQueryable<SchemaGroupRef>
{

  public IEnumerator<SchemaGroupRef> GetEnumerator()
  {
    // ReSharper disable once NotDisposedResourceIsReturned
    return particles.OfType<SchemaGroupRef>().GetEnumerator();
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    // ReSharper disable once NotDisposedResourceIsReturned
    return particles.OfType<SchemaGroupRef>().GetEnumerator();
  }

  public Type ElementType => typeof(SchemaGroupRef);

  public Expression Expression => particles.OfType<SchemaGroupRef>().Expression;

  public IQueryProvider Provider => particles.OfType<SchemaGroupRef>().Provider;

  public void Add(SchemaGroupRef element)
  {
    particles.Add(element);
  }
}
