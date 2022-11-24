namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the MediaBookmark Class.
/// </summary>
public interface IMediaBookmark // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// name, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// time, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Time { get ; set; }
  
}
