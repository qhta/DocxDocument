namespace DocumentModel.Packaging;

/// <summary>
/// Defines the StylesWithEffectsPart
/// </summary>
[ContentMime("application/vnd.ms-word.stylesWithEffects+xml")]
[RelationshipUri("http://schemas.microsoft.com/office/2007/relationships/stylesWithEffects")]
public interface StylesWithEffectsPart // : DocumentModel.Packaging.StylesPart
{
  public String? ContentType { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
