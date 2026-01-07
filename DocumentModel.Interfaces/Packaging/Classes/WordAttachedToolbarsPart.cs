namespace DocumentModel.Packaging;

/// <summary>
///   Defines the WordAttachedToolbarsPart
/// </summary>
public interface WordAttachedToolbarsPart: OpenXmlPart
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}