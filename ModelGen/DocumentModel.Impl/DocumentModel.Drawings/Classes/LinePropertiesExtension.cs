namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LinePropertiesExtension Class.
/// </summary>
public class LinePropertiesExtensionImpl: ModelElementImpl, LinePropertiesExtension
{
  public DocumentFormat.OpenXml.Drawing.LinePropertiesExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.LinePropertiesExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public LinePropertiesExtensionImpl(): base() {}
  
  public LinePropertiesExtensionImpl(DocumentFormat.OpenXml.Drawing.LinePropertiesExtension openXmlElement): base(openXmlElement)
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
  
  public DocumentModel.Drawings.LineSketchStyleProperties? LineSketchStyleProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
