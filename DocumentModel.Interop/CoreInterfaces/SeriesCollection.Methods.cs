using System.Collections;

namespace DocumentModel.Interop.Core;

public partial interface SeriesCollection
{
  public IMsoSeries Add
    (object Source, XlRowCol Rowcol, object SeriesLabels, object CategoryLabels, object Replace);
  public object Extend(object Source, object Rowcol, object CategoryLabels);
  public new IEnumerator GetEnumerator();
  public object Paste
  (XlRowCol Rowcol, object SeriesLabels, object CategoryLabels, object Replace,
    object NewSeries);
  public IMsoSeries NewSeries();
}
