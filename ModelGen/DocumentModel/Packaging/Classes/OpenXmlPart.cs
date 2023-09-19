namespace DocumentModel.Packaging;


/// <summary>
///   Represents an abstract base class for all OpenXml parts.
/// </summary>
public partial class OpenXmlPart
{
  
  /// <summary>
  ///   Gets the internal part path in the package.
  /// </summary>
  public Uri? Uri { get; set; }
  
  
  /// <summary>
  ///   Gets the content type (MIME type) of the content data in the part.
  /// </summary>
  public String? ContentType { get; set; }
  
  
  /// <summary>
  ///   Gets the relationship type of the part.
  /// </summary>
  public String? RelationshipType { get; set; }
  
  
  /// <summary>
  ///   Gets the root element of the current part.
  ///               Returns null when the current part is empty or is not an XML content type.
  /// </summary>
  [Nullable((Byte)2)]
  public DocumentModel.OpenXmlElement? RootElement { get; set; }
  
}
