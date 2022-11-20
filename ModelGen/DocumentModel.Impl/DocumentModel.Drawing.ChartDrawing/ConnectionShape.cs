namespace DocumentModel.Drawing.ChartDrawing;

/// <summary>
/// Connection Shape.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.IShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.IStyle))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.INonVisualConnectorShapeDrawingProperties))]
public class ConnectionShape: IConnectionShape
{
  /// <summary>
  /// Reference to Custom Function
  /// </summary>
  public string? Macro
  {
    get;
    set;
  }
  
  /// <summary>
  /// Publish to Server
  /// </summary>
  public bool? Published
  {
    get;
    set;
  }
  
  /// <summary>
  /// Connector Non Visual Properties.
  /// </summary>
  public DocumentModel.Drawing.ChartDrawing.INonVisualConnectorShapeDrawingProperties? NonVisualConnectorShapeDrawingProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Properties.
  /// </summary>
  public DocumentModel.Drawing.ChartDrawing.IShapeProperties? ShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Connection Shape Style.
  /// </summary>
  public DocumentModel.Drawing.ChartDrawing.IStyle? Style
  {
    get;
    set;
  }
  
}
