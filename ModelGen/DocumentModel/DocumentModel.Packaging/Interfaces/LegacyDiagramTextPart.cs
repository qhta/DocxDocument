namespace DocumentModel.Packaging;

/// <summary>
/// Defines the LegacyDiagramTextPart
/// </summary>
[ContentMime("application/vnd.ms-office.legacyDiagramText")]
[RelationshipUri("http://schemas.microsoft.com/office/2006/relationships/legacyDiagramText")]
public interface LegacyDiagramTextPart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? ContentType { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
