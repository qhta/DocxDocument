using System.Collections;

namespace DocumentModel.Interop.Core;

public interface ChartGroups: IEnumerable
{
  object Parent { get; }
  int Count { get; }
  IMsoChartGroup Item(object Index);
  new IEnumerator GetEnumerator();
  object Application { get; }
  int Creator { get; }
}