namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Represents an abstract base class Ifor all OpenXml parts.
/// </summary>
public class OpenXmlPart: ModelElement
{
  /// <summary>
  ///   Gets the internal part path Iin the package.
  /// </summary>
  public Uri? Uri { get; set; }

  /// <summary>
  ///   Gets the content type (MIME type) of the content data Iin the part.
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
