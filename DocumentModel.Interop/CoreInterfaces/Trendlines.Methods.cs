using System.Collections;

namespace DocumentModel.Interop.Core;

public partial interface Trendlines
{
  public IMsoTrendline Add
  (XlTrendlineType Type, object Order, object Period, object Forward, object Backward,
    object Intercept, object DisplayEquation, object DisplayRSquared, object Name);
  public new IEnumerator GetEnumerator();
}
