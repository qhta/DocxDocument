using System.Collections;

namespace DocumentModel.Interop.Core;

public partial interface Trendlines: IEnumerable
{
  public int Count { get; }
  public IMsoTrendline this[object Index] { get; }
}
