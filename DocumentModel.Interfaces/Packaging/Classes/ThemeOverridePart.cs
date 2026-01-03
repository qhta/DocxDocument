using DocumentModel.Drawings;
namespace DocumentModel.Packaging;

/// <summary>
///   Defines the ThemeOverridePart
/// </summary>
public interface ThemeOverridePart: IModelElement
{
  public string? ContentType { get; set; }
  /// <summary>
  ///   Gets the ImageParts of the ThemeOverridePart
  /// </summary>
  public Collection<ImagePart>? ImageParts { get; set; }
  public string? RelationshipType { get; set; }
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public ThemeOverride? ThemeOverride { get; set; }
}