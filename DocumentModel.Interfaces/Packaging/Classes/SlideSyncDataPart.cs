namespace DocumentModel.Packaging;

/// <summary>
///   Defines the SlideSyncDataPart
/// </summary>
public interface SlideSyncDataPart: OpenXmlPart
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}