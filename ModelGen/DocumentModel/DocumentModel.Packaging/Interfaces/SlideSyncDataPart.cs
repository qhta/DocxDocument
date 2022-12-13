namespace DocumentModel.Packaging;

/// <summary>
/// Defines the SlideSyncDataPart
/// </summary>
public interface SlideSyncDataPart
{
  public String? ContentType { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
