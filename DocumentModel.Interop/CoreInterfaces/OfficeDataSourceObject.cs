
namespace DocumentModel.Interop.Core;

public interface OfficeDataSourceObject
{
  string ConnectString { get; set; }
  string Table { get; set; }
  string DataSource { get; set; }
  object Columns { get; }
  int RowCount { get; }
  object Filters { get; }
  int Move(MsoMoveRow MsoMoveRow, int RowNbr = 1);

  void Open
    (string bstrSrc = "", string bstrConnect = "", string bstrTable = "", int fOpenExclusive = 0, int fNeverPrompt = 1);

  void SetSortOrder
  (string SortField1, bool SortAscending1 = true, string SortField2 = "", bool SortAscending2 = true,
    string SortField3 = "", bool SortAscending3 = true);

  void ApplyFilter();
}