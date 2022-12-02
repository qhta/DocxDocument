namespace DocumentModel.Packaging;

/// <summary>
/// Defines the StyleDefinitionsPart
/// </summary>
public interface IStyleDefinitionsPart // : DocumentModel.Packaging.IStylesPart
{
  public String? ContentType { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
