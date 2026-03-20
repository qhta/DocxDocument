using System.Collections;

namespace DocumentModel.Interop.Core;

public interface Points: IEnumerable
{
  int Count { get; }
  new IEnumerator GetEnumerator();
  ChartPoint this[int Index] { get; }
}