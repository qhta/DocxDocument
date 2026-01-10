using DocumentModel.Drawings;
namespace DocumentModel.Packaging;

/// <summary>
///   Defines the ThemeOverridePart
/// </summary>
public interface ThemeOverridePart: OpenXmlPart
{

  /// <summary>
  ///   Gets the ImageParts of the ThemeOverridePart
  /// </summary>
  public ImageParts ImageParts { get; set; }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public ThemeOverride? ThemeOverride { get; set; }
}