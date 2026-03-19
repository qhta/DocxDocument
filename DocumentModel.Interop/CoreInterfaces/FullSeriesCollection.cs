using System.Collections;

namespace DocumentModel.Interop.Core;

public interface FullSeriesCollection: IEnumerable
{
  object Parent { get; }
  int Count { get; }
  new IEnumerator GetEnumerator();
  object Application { get; }
  int Creator { get; }
  IMsoSeries this[object Index] { get; }
}