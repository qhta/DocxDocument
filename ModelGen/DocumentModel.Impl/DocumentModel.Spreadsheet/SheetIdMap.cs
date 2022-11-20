namespace DocumentModel.Spreadsheet;

/// <summary>
/// Sheet Id Map.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ISheetId))]
public class SheetIdMap: ISheetIdMap
{
  /// <summary>
  /// Sheet Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
