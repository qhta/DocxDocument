namespace DocumentModel.Drawing.ChartDrawing;

/// <summary>
/// Defines the MarkerType Class.
/// </summary>
public interface IMarkerType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Relative X Coordinate.
  /// </summary>
  public IXPosition? XPosition { get ; set; }
  
  /// <summary>
  /// Relative Y Coordinate.
  /// </summary>
  public IYPosition? YPosition { get ; set; }
  
}
