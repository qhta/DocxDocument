namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DocumentSettingsPart
/// </summary>
public interface DocumentSettingsPart
{
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the DocumentSettingsPart
  /// </summary>
  public DocumentModel.Packaging.ImagePart? ImageParts { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.Settings? Settings { get ; set; }
  
}
