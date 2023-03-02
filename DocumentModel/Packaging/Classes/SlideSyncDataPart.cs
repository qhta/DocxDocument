namespace DocumentModel.Packaging;

/// <summary>
///   Defines the SlideSyncDataPart
/// </summary>
public record SlideSyncDataPart
{
  public String? ContentType { get; set; }

  public String? RelationshipType { get; set; }
}