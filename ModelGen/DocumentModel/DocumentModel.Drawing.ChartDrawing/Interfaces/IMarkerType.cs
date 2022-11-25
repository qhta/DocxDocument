namespace DocumentModel.Drawing.ChartDrawing;

/// <summary>
/// Defines the MarkerType Class.
/// </summary>
public interface IMarkerType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Relative X Coordinate.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? XPosition { get ; set; }
  
  /// <summary>
  /// Relative Y Coordinate.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? YPosition { get ; set; }
  
}
