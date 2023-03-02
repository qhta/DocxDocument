using DocumentModel;

namespace DocumentModel.Packaging;

/// <summary>
///   Defines the ExtendedFilePropertiesPart
/// </summary>
public record ExtendedFilePropertiesPart
{
  public String? ContentType { get; set; }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public ContentProperties? Properties { get; set; }

  public String? RelationshipType { get; set; }
}