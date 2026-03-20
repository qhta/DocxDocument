
namespace DocumentModel.Interop.Core;

public interface OfficeDataSourceObject
{
  public string ConnectString { get; set; }
  public string Table { get; set; }
  public string DataSource { get; set; }
  public object Columns { get; }
  public int RowCount { get; }
  public object Filters { get; }
  public int Move(MsoMoveRow MsoMoveRow, int RowNbr);

  public void Open
    (string bstrSrc, string bstrConnect, string bstrTable, int fOpenExclusive, int fNeverPrompt);

  public void SetSortOrder
  (string SortField1, bool SortAscending1, string SortField2, bool SortAscending2,
    string SortField3, bool SortAscending3);

  public void ApplyFilter();
}
