namespace DocumentModel.Packaging;

/// <summary>
/// Represents an abstract base class for all OpenXml parts.
/// </summary>
public interface OpenXmlPart // : DocumentModel.Packaging.OpenXmlPartContainer
{
  /// <summary>
  /// Gets the internal part path in the package.
  /// </summary>
  public Uri? Uri { get ; set; }
  
  /// <summary>
  /// Gets the content type (MIME type) of the content data in the part.
  /// </summary>
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the relationship type of the part.
  /// </summary>
  public String? RelationshipType { get ; set; }
  
}
