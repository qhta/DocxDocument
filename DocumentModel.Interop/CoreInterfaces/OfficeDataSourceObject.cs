
namespace DocumentModel.Interop.Core;

public interface OfficeDataSourceObject
{
  string ConnectString { get; set; }
  string Table { get; set; }
  string DataSource { get; set; }
  object Columns { get; }
  int RowCount { get; }
  object Filters { get; }
  int Move(MsoMoveRow MsoMoveRow, int RowNbr);

  void Open
    (string bstrSrc, string bstrConnect, string bstrTable, int fOpenExclusive, int fNeverPrompt);

  void SetSortOrder
  (string SortField1, bool SortAscending1, string SortField2, bool SortAscending2,
    string SortField3, bool SortAscending3);

  void ApplyFilter();
}