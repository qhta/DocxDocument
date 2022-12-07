namespace DocumentModel.Drawings;

/// <summary>
/// Connector Non Visual Properties.
/// </summary>
public class NonVisualConnectorShapeDrawingPropertiesImpl: ModelElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectorShapeDrawingProperties>, NonVisualConnectorShapeDrawingProperties
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
  /// Non-Visual Connection Shape Drawing Properties.
  /// </summary>
  public NonVisualConnectionShapeProperties? NonVisualConnectionShapeProperties
  {
    get;
    set;
  }
  
}
