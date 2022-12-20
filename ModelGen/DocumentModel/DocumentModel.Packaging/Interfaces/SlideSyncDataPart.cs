namespace DocumentModel.Packaging;

/// <summary>
/// Defines the SlideSyncDataPart
/// </summary>
public partial interface SlideSyncDataPart
{
  public String? ContentType { get; }
  
  public String? RelationshipType { get; }
  
}
