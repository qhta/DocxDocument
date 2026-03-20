
namespace DocumentModel.Interop.Core;

public partial interface OfficeDataSourceObject
{
  public int Move(MsoMoveRow MsoMoveRow, int RowNbr);
  public void Open
    (string bstrSrc, string bstrConnect, string bstrTable, int fOpenExclusive, int fNeverPrompt);
  public void SetSortOrder
  (string SortField1, bool SortAscending1, string SortField2, bool SortAscending2,
    string SortField3, bool SortAscending3);
  public void ApplyFilter();
}
