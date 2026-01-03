namespace DocumentModel.Packaging;

/// <summary>
///   Defines the CustomPropertyPart
/// </summary>
public interface CustomPropertyPart: IModelElement
{
  public string? RelationshipType { get; set; }
}