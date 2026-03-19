using System.Collections;

namespace DocumentModel.Interop.Core;

public interface SeriesCollection: IEnumerable
{
  object Parent { get; }

  IMsoSeries Add
    (object Source, XlRowCol Rowcol = XlRowCol.xlColumns, object SeriesLabels, object CategoryLabels, object Replace);

  int Count { get; }
  object Extend(object Source, object Rowcol, object CategoryLabels);
  IMsoSeries Item(object Index);
  new IEnumerator GetEnumerator();

  object Paste
  (XlRowCol Rowcol = XlRowCol.xlColumns, object SeriesLabels, object CategoryLabels, object Replace,
    object NewSeries);

  IMsoSeries NewSeries();
  object Application { get; }
  int Creator { get; }
  IMsoSeries this[object Index] { get; }
}