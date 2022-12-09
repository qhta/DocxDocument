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
  
  public LineSketchStyleProperties? LineSketchStyleProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
