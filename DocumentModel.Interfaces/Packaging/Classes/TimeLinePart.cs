namespace DocumentModel.Packaging;

/// <summary>
///   Defines the TimeLinePart
/// </summary>
public interface TimeLinePart: OpenXmlPart
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}