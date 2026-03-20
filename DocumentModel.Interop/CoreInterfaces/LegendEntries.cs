using System.Collections;

namespace DocumentModel.Interop.Core;

public interface LegendEntries: IEnumerable
{
  public int Count { get; }
  public new IEnumerator GetEnumerator();
  public LegendEntry this[object Index] { get; }
}
