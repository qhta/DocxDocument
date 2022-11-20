namespace DocumentModel.Spreadsheet;

/// <summary>
/// DDE Item definition.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IValues))]
public class DdeItem: IDdeItem
{
  /// <summary>
  /// DDE Name
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// OLE
  /// </summary>
  public bool? UseOle
  {
    get;
    set;
  }
  
  /// <summary>
  /// Advise
  /// </summary>
  public bool? Advise
  {
    get;
    set;
  }
  
  /// <summary>
  /// Data is an Image
  /// </summary>
  public bool? PreferPicture
  {
    get;
    set;
  }
  
  /// <summary>
  /// DDE Name Values.
  /// </summary>
  public DocumentModel.Spreadsheet.IValues? Values
  {
    get;
    set;
  }
  
}
