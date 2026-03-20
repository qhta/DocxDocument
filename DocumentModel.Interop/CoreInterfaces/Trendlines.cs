using System.Collections;

namespace DocumentModel.Interop.Core;

public interface Trendlines: IEnumerable
{
  public IMsoTrendline Add
  (XlTrendlineType Type, object Order, object Period, object Forward, object Backward,
    object Intercept, object DisplayEquation, object DisplayRSquared, object Name);

  public int Count { get; }
  public new IEnumerator GetEnumerator();
  public IMsoTrendline this[object Index] { get; }
}
