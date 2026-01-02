using DocumentModel;
namespace DocumentModel.Packaging;

/// <summary>
///   Defines the DocumentSettingsPart
/// </summary>
public class DocumentSettingsPart: ModelElement
{
  public string? ContentType { get; set; }
  /// <summary>
  ///   Gets the ImageParts of the DocumentSettingsPart
  /// </summary>
  public Collection<ImagePart>? ImageParts { get; set; }
  public string? RelationshipType { get; set; }
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public IDocumentSettings? Settings { get; set; }
}