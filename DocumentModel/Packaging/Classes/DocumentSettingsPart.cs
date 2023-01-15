using DocumentModel.Wordprocessing;

namespace DocumentModel.Packaging;

/// <summary>
///   Defines the DocumentSettingsPart
/// </summary>
public class DocumentSettingsPart
{
  public String? ContentType { get; set; }

  /// <summary>
  ///   Gets the ImageParts of the DocumentSettingsPart
  /// </summary>
  public Collection<ImagePart>? ImageParts { get; set; }

  public String? RelationshipType { get; set; }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public Settings? Settings { get; set; }
}