using System.Collections;

namespace DocumentModel.Interop.Core;

public partial interface Points: IEnumerable
{
  public int Count { get; }
  public ChartPoint this[int Index] { get; }
}
