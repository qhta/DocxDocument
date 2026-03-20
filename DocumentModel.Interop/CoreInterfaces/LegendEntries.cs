using System.Collections;

namespace DocumentModel.Interop.Core;

public partial interface LegendEntries: IEnumerable
{
  public int Count { get; }
  public LegendEntry this[object Index] { get; }
}
