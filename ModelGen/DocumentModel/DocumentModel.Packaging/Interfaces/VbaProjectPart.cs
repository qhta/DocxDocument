namespace DocumentModel.Packaging;

/// <summary>
/// Defines the VbaProjectPart
/// </summary>
public partial interface VbaProjectPart
{
  public String? ContentType { get; }
  
  public String? RelationshipType { get; }
  
  /// <summary>
  /// Gets the VbaDataPart of the VbaProjectPart
  /// </summary>
  public DocumentModel.Packaging.VbaDataPart? VbaDataPart { get; }
  
}
