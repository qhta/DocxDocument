using System.Collections;

namespace DocumentModel.Interop.Core;

public interface Trendlines: IEnumerable
{
  object Parent { get; }

  IMsoTrendline Add
  (XlTrendlineType Type, object Order, object Period, object Forward, object Backward,
    object Intercept, object DisplayEquation, object DisplayRSquared, object Name);

  int Count { get; }
  new IEnumerator GetEnumerator();
  object Application { get; }
  int Creator { get; }
  IMsoTrendline this[object Index] { get; }
}