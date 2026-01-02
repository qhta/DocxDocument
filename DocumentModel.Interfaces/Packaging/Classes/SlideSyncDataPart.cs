namespace DocumentModel.Packaging;

/// <summary>
///   Defines the SlideSyncDataPart
/// </summary>
public class SlideSyncDataPart: ModelElement
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}