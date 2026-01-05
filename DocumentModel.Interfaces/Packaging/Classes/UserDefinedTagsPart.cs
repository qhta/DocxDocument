namespace DocumentModel.Packaging;

/// <summary>
///   Defines the UserDefinedTagsPart
/// </summary>
public interface UserDefinedTagsPart:
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}