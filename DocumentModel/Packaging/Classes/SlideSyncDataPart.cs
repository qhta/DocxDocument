namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the SlideSyncDataPart
/// </summary>
public class SlideSyncDataPart: ModelElement
{
  public String? ContentType { get; set; }

  public String? RelationshipType { get; set; }
}