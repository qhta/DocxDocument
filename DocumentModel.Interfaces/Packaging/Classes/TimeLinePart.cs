namespace DocumentModel.Packaging;

/// <summary>
///   Defines the TimeLinePart
/// </summary>
public interface TimeLinePart
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}