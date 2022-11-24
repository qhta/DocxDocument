namespace DocumentModel.Drawing.ChartDrawing;

/// <summary>
/// Connection Shape.
/// </summary>
public interface IConnectionShape // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Reference to Custom Function
  /// </summary>
  public String? Macro { get ; set; }
  
  /// <summary>
  /// Publish to Server
  /// </summary>
  public Boolean? Published { get ; set; }
  
  /// <summary>
  /// Connector Non Visual Properties.
  /// </summary>
  public INonVisualConnectorShapeDrawingProperties? NonVisualConnectorShapeDrawingProperties { get ; set; }
  
  /// <summary>
  /// Shape Properties.
  /// </summary>
  public IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// Connection Shape Style.
  /// </summary>
  public IStyle? Style { get ; set; }
  
}
