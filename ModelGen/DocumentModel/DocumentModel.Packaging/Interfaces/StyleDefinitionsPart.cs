namespace DocumentModel.Packaging;

/// <summary>
/// Defines the StyleDefinitionsPart
/// </summary>
[ContentMime("application/vnd.openxmlformats-officedocument.wordprocessingml.styles+xml")]
[RelationshipUri("http://schemas.openxmlformats.org/officeDocument/2006/relationships/styles")]
public interface StyleDefinitionsPart // : DocumentModel.Packaging.StylesPart
{
  public String? ContentType { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
