namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the BookmarkTarget Class.
/// </summary>
public interface IBookmarkTarget // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// spid, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? ShapeId { get ; set; }
  
  /// <summary>
  /// bmkName, this property is only available in Office 2010 and later.
  /// </summary>
  public string? BookmarkName { get ; set; }
  
}
