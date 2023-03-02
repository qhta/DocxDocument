namespace DocumentModel.Packaging;

/// <summary>
///   Defines the TimeLinePart
/// </summary>
public record TimeLinePart
{
  public String? ContentType { get; set; }

  public String? RelationshipType { get; set; }
}