namespace DocumentModel.Packaging;

/// <summary>
///   Defines the UserDefinedTagsPart
/// </summary>
public record UserDefinedTagsPart
{
  public String? ContentType { get; set; }

  public String? RelationshipType { get; set; }
}