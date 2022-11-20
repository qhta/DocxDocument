namespace DocumentModel.Spreadsheet;

/// <summary>
/// Calculated Item.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPivotArea))]
public class CalculatedItem: ICalculatedItem
{
  /// <summary>
  /// Field Index
  /// </summary>
  public uint? Field
  {
    get;
    set;
  }
  
  /// <summary>
  /// Calculated Item Formula
  /// </summary>
  public string? Formula
  {
    get;
    set;
  }
  
  /// <summary>
  /// Calculated Item Location.
  /// </summary>
  public DocumentModel.Spreadsheet.IPivotArea? PivotArea
  {
    get;
    set;
  }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
