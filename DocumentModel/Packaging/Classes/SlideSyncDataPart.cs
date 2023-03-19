namespace DocumentModel.Packaging;

/// <summary>
///   Defines the SlideSyncDataPart
/// </summary>
public class SlideSyncDataPart: ModelElement
{
  public String? ContentType { get; set; }

  public String? RelationshipType { get; set; }
}