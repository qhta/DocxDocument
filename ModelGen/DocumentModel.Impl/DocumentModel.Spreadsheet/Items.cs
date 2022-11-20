namespace DocumentModel.Spreadsheet;

/// <summary>
/// Field Items.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IItem))]
public class Items: IItems
{
  /// <summary>
  /// Field Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
