namespace DocumentModel.Packaging;

/// <summary>
///   Defines the EmbeddedPackagePart
/// </summary>
public interface EmbeddedPackagePart: IModelElement
{
  public string? RelationshipType { get; set; }
}