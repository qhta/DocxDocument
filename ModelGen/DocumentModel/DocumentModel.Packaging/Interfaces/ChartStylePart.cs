namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ChartStylePart
/// </summary>
[ContentMime("application/vnd.ms-office.chartstyle+xml")]
[RelationshipUri("http://schemas.microsoft.com/office/2011/relationships/chartStyle")]
public interface ChartStylePart // : DocumentModel.Packaging.OpenXmlPart
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.ChartStyle? ChartStyle { get ; set; }
  
  public String? ContentType { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
