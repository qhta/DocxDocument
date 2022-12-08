namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NonVisualContentPartProperties Class.
/// </summary>
public class NonVisualContentPartPropertiesImpl: ModelElementImpl, NonVisualContentPartProperties
{
  public DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.NonVisualContentPartProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.NonVisualContentPartProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public NonVisualDrawingProperties1? NonVisualDrawingProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// NonVisualInkContentPartProperties.
  /// </summary>
  public NonVisualInkContentPartProperties? NonVisualInkContentPartProperties
  {
    get;
    set;
  }
  
}
