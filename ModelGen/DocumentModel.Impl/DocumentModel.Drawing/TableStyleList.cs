namespace DocumentModel.Drawing;

/// <summary>
/// Table Style List.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.ITableStyleEntry))]
public class TableStyleList: ITableStyleList
{
  /// <summary>
  /// Default
  /// </summary>
  public string? Default
  {
    get;
    set;
  }
  
}
