namespace DocumentModel.Packaging;

/// <summary>
/// Represents the type of part referenced by a .
/// </summary>
public class DataPartImpl: ModelObjectImpl, DataPart
{
  public DocumentFormat.OpenXml.Packaging.DataPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.DataPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Gets the internal part path in the package.
  /// </summary>
  public Uri? Uri
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the content type (MIME type) of the data in the part.
  /// </summary>
  public String? ContentType
  {
    get => (String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.DataPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
