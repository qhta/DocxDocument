using System.Collections;

namespace DocumentModel.Interop.Core;

public interface SeriesCollection: IEnumerable
{
  IMsoSeries Add
    (object Source, XlRowCol Rowcol, object SeriesLabels, object CategoryLabels, object Replace);

  int Count { get; }
  object Extend(object Source, object Rowcol, object CategoryLabels);
  
  new IEnumerator GetEnumerator();

  object Paste
  (XlRowCol Rowcol, object SeriesLabels, object CategoryLabels, object Replace,
    object NewSeries);

  IMsoSeries NewSeries();
  IMsoSeries this[object Index] { get; }
}