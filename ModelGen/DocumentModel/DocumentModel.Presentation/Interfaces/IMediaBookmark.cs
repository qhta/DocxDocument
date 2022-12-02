namespace DocumentModel.Presentation;

/// <summary>
/// Defines the MediaBookmark Class.
/// </summary>
public interface IMediaBookmark // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// name, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// time, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? Time { get ; set; }
  
}
