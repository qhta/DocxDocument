using System.Collections;

namespace DocumentModel.Interop.Core;

public interface Trendlines: IEnumerable
{
  IMsoTrendline Add
  (XlTrendlineType Type, object Order, object Period, object Forward, object Backward,
    object Intercept, object DisplayEquation, object DisplayRSquared, object Name);

  int Count { get; }
  new IEnumerator GetEnumerator();
  IMsoTrendline this[object Index] { get; }
}