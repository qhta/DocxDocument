namespace DocumentModel.Drawings;

/// <summary>
/// Non-Visual Shape Properties.
/// </summary>
public class NonVisualShapePropertiesImpl: ModelElementImpl, NonVisualShapeProperties
{
  public DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualShapeProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualShapeProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Chart Non Visual Properties.
  /// </summary>
  public NonVisualDrawingProperties3? NonVisualDrawingProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Non-Visual Shape Drawing Properties.
  /// </summary>
  public NonVisualShapeDrawingProperties? NonVisualShapeDrawingProperties
  {
    get;
    set;
  }
  
}
