namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LinePropertiesExtension Class.
/// </summary>
public class LinePropertiesExtensionImpl: ModelElement<DocumentFormat.OpenXml.Drawing.LinePropertiesExtension>, LinePropertiesExtension
{
  public LineSketchStyleProperties? LineSketchStyleProperties
  {
    get;
    set;
  }
  
}
