namespace DocumentModel.Drawings;

/// <summary>
/// Non-Visual Shape Properties.
/// </summary>
public class NonVisualShapePropertiesImpl: ModelElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualShapeProperties>, NonVisualShapeProperties
{
  /// <summary>
  /// Chart Non Visual Properties.
  /// </summary>
  public NonVisualDrawingProperties2? NonVisualDrawingProperties
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
