namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WebSettingsPart
/// </summary>
public interface IWebSettingsPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  public String? ContentType { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.IWebSettings? WebSettings { get ; set; }
  
}
