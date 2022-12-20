namespace DocumentModel.Packaging;

/// <summary>
/// Represents the type of part referenced by a .
/// </summary>
public partial class DataPartImpl: ModelObjectImpl, DataPart
{
  public DocumentFormat.OpenXml.Packaging.DataPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.DataPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DataPartImpl(): base() {}
  
  public DataPartImpl(DocumentFormat.OpenXml.Packaging.DataPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets the internal part path in the package.
  /// </summary>
  public Uri? Uri
  {
    get => (System.Uri?)OpenXmlElement?.Uri;
  }
  
  /// <summary>
  /// Gets the content type (MIME type) of the data in the part.
  /// </summary>
  public String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
  }
  
}
