namespace DocumentModel.Packaging;

/// <summary>
/// Defines the StyleDefinitionsPart
/// </summary>
public interface IStyleDefinitionsPart // : DocumentModel.Packaging.IStylesPart
{
  public System.String? ContentType { get ; set; }
  
  public System.String? RelationshipType { get ; set; }
  
  public System.String? TargetName { get ; set; }
  
  public System.String? TargetPath { get ; set; }
  
}
