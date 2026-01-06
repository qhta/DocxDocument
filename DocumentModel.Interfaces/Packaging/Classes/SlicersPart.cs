namespace DocumentModel.Packaging;

/// <summary>
///   Defines the SlicersPart
/// </summary>
public interface SlicersPart
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}