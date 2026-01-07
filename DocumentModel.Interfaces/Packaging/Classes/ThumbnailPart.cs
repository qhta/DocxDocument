namespace DocumentModel.Packaging;

/// <summary>
///   Defines the ThumbnailPart
/// </summary>
public interface ThumbnailPart: OpenXmlPart
{
  public string? RelationshipType { get; set; }
}