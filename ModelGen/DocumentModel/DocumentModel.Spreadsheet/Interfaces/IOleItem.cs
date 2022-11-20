namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLE Link Item.
/// </summary>
public interface IOleItem // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// OLE Name
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// Icon
  /// </summary>
  public bool? Icon { get ; set; }
  
  /// <summary>
  /// Advise
  /// </summary>
  public bool? Advise { get ; set; }
  
  /// <summary>
  /// Object is an Image
  /// </summary>
  public bool? PreferPicture { get ; set; }
  
}
