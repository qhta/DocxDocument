namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLE Link.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IOleItems))]
public class OleLink: IOleLink
{
  /// <summary>
  /// OLE Link Relationship
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// OLE Link ProgID
  /// </summary>
  public string? ProgId
  {
    get;
    set;
  }
  
  /// <summary>
  /// OLE Link Items.
  /// </summary>
  public IOleItems? OleItems
  {
    get;
    set;
  }
  
}
