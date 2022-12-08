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
    get;
    set;
  }
  
  public LineSketchStyleProperties? LineSketchStyleProperties
  {
    get;
    set;
  }
  
}
