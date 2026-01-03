namespace DocumentModel.Packaging;

/// <summary>
///   Defines the UserDefinedTagsPart
/// </summary>
public interface UserDefinedTagsPart: IModelElement
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}