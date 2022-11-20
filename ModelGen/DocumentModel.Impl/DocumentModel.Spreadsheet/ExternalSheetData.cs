namespace DocumentModel.Spreadsheet;

/// <summary>
/// External Sheet Data Set.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExternalRow))]
public class ExternalSheetData: IExternalSheetData
{
  /// <summary>
  /// Sheet Id
  /// </summary>
  public uint? SheetId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Last Refresh Resulted in Error
  /// </summary>
  public bool? RefreshError
  {
    get;
    set;
  }
  
}
