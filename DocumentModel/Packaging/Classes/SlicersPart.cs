namespace DocumentModel.Packaging;

/// <summary>
///   Defines the SlicersPart
/// </summary>
public record SlicersPart
{
  public String? ContentType { get; set; }

  public String? RelationshipType { get; set; }
}