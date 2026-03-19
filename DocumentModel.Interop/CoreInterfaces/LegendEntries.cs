using System.Collections;

namespace DocumentModel.Interop.Core;

public interface LegendEntries: IEnumerable
{
  object Parent { get; }
  int Count { get; }
  LegendEntry Item(object Index);
  new IEnumerator GetEnumerator();
  object Application { get; }
  int Creator { get; }
  LegendEntry this[object Index] { get; }
}