using DocumentModel.Drawings;

namespace DocumentModel.Packaging;

/// <summary>
///   Defines the ThemeOverridePart
/// </summary>
public record ThemeOverridePart
{
  public String? ContentType { get; set; }

  /// <summary>
  ///   Gets the ImageParts of the ThemeOverridePart
  /// </summary>
  public Collection<ImagePart>? ImageParts { get; set; }

  public String? RelationshipType { get; set; }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public ThemeOverride? ThemeOverride { get; set; }
}