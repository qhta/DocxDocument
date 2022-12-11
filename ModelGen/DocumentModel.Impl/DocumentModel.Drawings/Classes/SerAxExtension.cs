namespace DocumentModel.Drawings;

/// <summary>
/// Defines the SerAxExtension Class.
/// </summary>
public class SerAxExtensionImpl: ModelElementImpl, SerAxExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.SerAxExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.SerAxExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SerAxExtensionImpl(): base() {}
  
  public SerAxExtensionImpl(DocumentFormat.OpenXml.Drawing.Charts.SerAxExtension openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get => (String?)OpenXmlElement?.Uri?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Uri = (System.String?)value;
    }
  }
  
  public NumberingFormat? NumberingFormat
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
