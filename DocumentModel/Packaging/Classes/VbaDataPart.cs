namespace DocumentModel.Packaging;

/// <summary>
/// Defines the VbaDataPart
/// </summary>
public partial class VbaDataPart
{
  public String? ContentType { get; }
  
  public String? RelationshipType { get; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.VbaSuppData? VbaSuppData { get; set; }
  
}
