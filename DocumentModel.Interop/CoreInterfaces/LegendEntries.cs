using System.Collections;

namespace DocumentModel.Interop.Core;

public interface LegendEntries: IEnumerable
{
  int Count { get; }
  new IEnumerator GetEnumerator();
  LegendEntry this[object Index] { get; }
}