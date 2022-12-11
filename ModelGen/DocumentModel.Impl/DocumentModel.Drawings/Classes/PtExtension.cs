namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PtExtension Class.
/// </summary>
public class PtExtensionImpl: ModelElementImpl, PtExtension
{
  public DocumentFormat.OpenXml.Drawing.PtExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.PtExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PtExtensionImpl(): base() {}
  
  public PtExtensionImpl(DocumentFormat.OpenXml.Drawing.PtExtension openXmlElement): base(openXmlElement)
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
  
  public NonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
