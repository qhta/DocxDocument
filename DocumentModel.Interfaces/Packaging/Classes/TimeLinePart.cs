namespace DocumentModel.Packaging;

/// <summary>
///   Defines the TimeLinePart
/// </summary>
public interface TimeLinePart: IModelElement
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}