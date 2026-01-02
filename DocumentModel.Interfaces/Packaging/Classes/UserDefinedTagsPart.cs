namespace DocumentModel.Packaging;

/// <summary>
///   Defines the UserDefinedTagsPart
/// </summary>
public class UserDefinedTagsPart: ModelElement
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}