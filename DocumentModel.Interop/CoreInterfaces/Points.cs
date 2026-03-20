using System.Collections;

namespace DocumentModel.Interop.Core;

public interface Points: IEnumerable
{
  public int Count { get; }
  public new IEnumerator GetEnumerator();
  public ChartPoint this[int Index] { get; }
}
