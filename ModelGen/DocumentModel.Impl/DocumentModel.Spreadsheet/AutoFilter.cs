namespace DocumentModel.Spreadsheet;

/// <summary>
/// AutoFilter Settings.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IFilterColumn))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ISortState))]
public class AutoFilter: IAutoFilter
{
  /// <summary>
  /// Cell or Range Reference
  /// </summary>
  public string? Reference
  {
    get;
    set;
  }
  
}
