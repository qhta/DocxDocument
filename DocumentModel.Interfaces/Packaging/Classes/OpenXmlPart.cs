namespace DocumentModel.Packaging;

/// <summary>
///   Represents an abstract base class for all OpenXml parts.
/// </summary>
public class OpenXmlPart: ModelElement
{
  /// <summary>
  ///   Gets the internal part path in the package.
  /// </summary>
  public Uri? Uri { get; set; }
  /// <summary>
  ///   Gets the content type (MIME type) of the content data in the part.
  /// </summary>
  public string? ContentType { get; set; }
  /// <summary>
  ///   Gets the relationship type of the part.
  /// </summary>
  public string? RelationshipType { get; set; }
  /// <summary>
  ///   Gets the root element of the current part.
  /// </summary>
  public ModelElement? RootElement { get; set; }
}