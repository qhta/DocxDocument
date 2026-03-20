using System.Collections;

namespace DocumentModel.Interop.Core;

public partial interface FullSeriesCollection: IEnumerable
{
  public int Count { get; }
  public IMsoSeries this[object Index] { get; }
}
