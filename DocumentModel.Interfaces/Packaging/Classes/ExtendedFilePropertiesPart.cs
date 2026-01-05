using DocumentModel;
namespace DocumentModel.Packaging;

/// <summary>
///   Defines the ExtendedFilePropertiesPart
/// </summary>
public interface ExtendedFilePropertiesPart:
{
  public string? ContentType { get; set; }
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public ContentProperties? Properties { get; set; }
  public string? RelationshipType { get; set; }
}