namespace DocumentModel.Drawing.ChartDrawing;

/// <summary>
/// Connector Non Visual Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.INonVisualConnectionShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.INonVisualDrawingProperties))]
public class NonVisualConnectorShapeDrawingProperties: INonVisualConnectorShapeDrawingProperties
{
  /// <summary>
  /// Chart Non Visual Properties.
  /// </summary>
  public DocumentModel.Drawing.ChartDrawing.INonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Non-Visual Connection Shape Drawing Properties.
  /// </summary>
  public DocumentModel.Drawing.ChartDrawing.INonVisualConnectionShapeProperties? NonVisualConnectionShapeProperties
  {
    get;
    set;
  }
  
}
