namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the CatAxExtension Class.
/// </summary>
public class CatAxExtensionImpl: ModelElementImpl, CatAxExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.CatAxExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.CatAxExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public CatAxExtensionImpl(): base() {}
  
  public CatAxExtensionImpl(DocumentFormat.OpenXml.Drawing.Charts.CatAxExtension openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get => (System.String?)OpenXmlElement?.Uri?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Uri = (System.String?)value;
    }
  }
  
  public DocumentModel.Drawings13.Charts.NumberingFormat? NumberingFormat
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
