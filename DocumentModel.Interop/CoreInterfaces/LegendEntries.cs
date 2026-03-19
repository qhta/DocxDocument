using System.Collections;

namespace DocumentModel.Interop.Core;

public interface LegendEntries: IEnumerable
{
  object Parent { get; }
  int Count { get; }
  new IEnumerator GetEnumerator();
  object Application { get; }
  int Creator { get; }
  LegendEntry this[object Index] { get; }
}