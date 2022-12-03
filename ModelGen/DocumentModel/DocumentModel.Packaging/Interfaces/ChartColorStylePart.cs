namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ChartColorStylePart
/// </summary>
[ContentMime("application/vnd.ms-office.chartcolorstyle+xml")]
[RelationshipUri("http://schemas.microsoft.com/office/2011/relationships/chartColorStyle")]
public interface ChartColorStylePart // : DocumentModel.Packaging.OpenXmlPart
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.ColorStyle? ColorStyle { get ; set; }
  
  public String? ContentType { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
