using System.Collections;

namespace DocumentModel.Interop.Core;

public interface Points: IEnumerable
{
  object Parent { get; }
  int Count { get; }
  ChartPoint Item(int Index);
  new IEnumerator GetEnumerator();
  object Application { get; }
  int Creator { get; }
  ChartPoint this[int Index] { get; }
}