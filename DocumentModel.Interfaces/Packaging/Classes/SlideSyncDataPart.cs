namespace DocumentModel.Packaging;

/// <summary>
///   Defines the SlideSyncDataPart
/// </summary>
public interface SlideSyncDataPart:
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}