namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WebSettingsPart
/// </summary>
[ContentMime("application/vnd.openxmlformats-officedocument.wordprocessingml.webSettings+xml")]
[RelationshipUri("http://schemas.openxmlformats.org/officeDocument/2006/relationships/webSettings")]
public interface WebSettingsPart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? ContentType { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.WebSettings? WebSettings { get ; set; }
  
}
