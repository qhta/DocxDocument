using System.Collections;

namespace DocumentModel.Interop.Core;

public interface FullSeriesCollection: IEnumerable
{
  int Count { get; }
  new IEnumerator GetEnumerator();
  IMsoSeries this[object Index] { get; }
}