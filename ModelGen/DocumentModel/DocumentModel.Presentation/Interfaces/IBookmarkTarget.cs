namespace DocumentModel.Presentation;

/// <summary>
/// Defines the BookmarkTarget Class.
/// </summary>
public interface IBookmarkTarget // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// spid, this property is only available in Office 2010 and later.
  /// </summary>
  public UInt32? ShapeId { get ; set; }
  
  /// <summary>
  /// bmkName, this property is only available in Office 2010 and later.
  /// </summary>
  public String? BookmarkName { get ; set; }
  
}
