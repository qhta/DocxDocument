using System.Collections;

namespace DocumentModel.Interop.Core;

public interface ChartGroups: IEnumerable
{
  public int Count { get; }
  public IMsoChartGroup Item(object Index);
  public new IEnumerator GetEnumerator();
}
