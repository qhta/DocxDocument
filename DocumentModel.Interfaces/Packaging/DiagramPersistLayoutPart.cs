using DocumentModel.Drawings.Office;
namespace DocumentModel.Packaging;

/// <summary>
///   Defines the DiagramPersistLayoutPart
/// </summary>
public interface DiagramPersistLayoutPart: OpenXmlPart
{

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public Drawing? Drawing { get; set; }
  /// <summary>
  ///   Gets the ImageParts of the DiagramPersistLayoutPart
  /// </summary>
  public ImageParts ImageParts { get; set; }

}