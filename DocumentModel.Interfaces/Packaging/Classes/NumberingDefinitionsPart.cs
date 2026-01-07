using DocumentModel.Wordprocessing;
namespace DocumentModel.Packaging;

/// <summary>
///   Defines the NumberingDefinitionsPart
/// </summary>
public interface NumberingDefinitionsPart: OpenXmlPart
{

  /// <summary>
  ///   Gets the ImageParts of the NumberingDefinitionsPart
  /// </summary>
  public ImageParts ImageParts { get; set; }
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public Numbering? Numbering { get; set; }

}