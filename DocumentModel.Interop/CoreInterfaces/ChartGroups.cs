using System.Collections;

namespace DocumentModel.Interop.Core;

public interface ChartGroups: IEnumerable
{
  int Count { get; }
  IMsoChartGroup Item(object Index);
  new IEnumerator GetEnumerator();
}