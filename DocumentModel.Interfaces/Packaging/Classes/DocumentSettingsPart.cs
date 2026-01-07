using DocumentModel;
namespace DocumentModel.Packaging;

/// <summary>
///   Defines the DocumentSettingsPart
/// </summary>
public interface DocumentSettingsPart: OpenXmlPart
{

  /// <summary>
  ///   Gets the ImageParts of the DocumentSettingsPart
  /// </summary>
  public ImageParts ImageParts { get; set; }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DocumentSettings? Settings { get; set; }
}