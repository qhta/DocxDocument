using DocumentModel.Drawings.Office;

namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the DiagramPersistLayoutPart
/// </summary>
public class DiagramPersistLayoutPart: ModelElement
{
  public String? ContentType { get; set; }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public Drawing? Drawing { get; set; }

  /// <summary>
  ///   Gets the ImageParts of the DiagramPersistLayoutPart
  /// </summary>
  public Collection<ImagePart>? ImageParts { get; set; }

  public String? RelationshipType { get; set; }
}