namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ValAxExtension Class.
/// </summary>
public class ValAxExtensionImpl: ModelElementImpl, ValAxExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.ValAxExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.ValAxExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ValAxExtensionImpl(): base() {}
  
  public ValAxExtensionImpl(DocumentFormat.OpenXml.Drawing.Charts.ValAxExtension openXmlElement): base(openXmlElement)
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
