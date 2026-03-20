using System.Collections;

namespace DocumentModel.Interop.Core;

public interface FullSeriesCollection: IEnumerable
{
  public int Count { get; }
  public new IEnumerator GetEnumerator();
  public IMsoSeries this[object Index] { get; }
}
