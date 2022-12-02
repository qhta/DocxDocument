namespace DocumentModel.Drawing;

/// <summary>
/// Defines the MarkerType Class.
/// </summary>
public interface IMarkerType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Relative X Coordinate.
  /// </summary>
  public String? XPosition { get ; set; }
  
  /// <summary>
  /// Relative Y Coordinate.
  /// </summary>
  public String? YPosition { get ; set; }
  
}
