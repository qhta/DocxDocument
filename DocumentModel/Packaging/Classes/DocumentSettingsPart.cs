using DocumentModel;

namespace DocumentModel.Packaging;

/// <summary>
///   Defines the DocumentSettingsPart
/// </summary>
public record DocumentSettingsPart
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
  public DocumentSettings? Settings { get; set; }
}