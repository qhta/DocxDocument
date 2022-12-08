namespace DocumentModel.Packaging;

/// <summary>
/// Represents an abstract base class for all OpenXml parts.
/// </summary>
public class OpenXmlPartImpl: DocumentModel.Packaging.OpenXmlPartContainerImpl, OpenXmlPart
{
  public new DocumentFormat.OpenXml.Packaging.OpenXmlPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.OpenXmlPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Gets the internal part path in the package.
  /// </summary>
  public Uri? Uri
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the content type (MIME type) of the content data in the part.
  /// </summary>
  public virtual String? ContentType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the relationship type of the part.
  /// </summary>
  public virtual String? RelationshipType
  {
    get;
    set;
  }
  
}
