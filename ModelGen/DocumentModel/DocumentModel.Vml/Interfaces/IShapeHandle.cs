namespace DocumentModel.Vml;

/// <summary>
/// Shape Handle.
/// </summary>
public interface IShapeHandle // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Handle Position
  /// </summary>
  public System.String? Position { get ; set; }
  
  /// <summary>
  /// Handle Polar Center
  /// </summary>
  public System.String? Polar { get ; set; }
  
  /// <summary>
  /// Handle Coordinate Mapping
  /// </summary>
  public System.String? Map { get ; set; }
  
  /// <summary>
  /// Invert Handle's X Position
  /// </summary>
  public System.Boolean? InvertX { get ; set; }
  
  /// <summary>
  /// Invert Handle's Y Position
  /// </summary>
  public System.Boolean? InvertY { get ; set; }
  
  /// <summary>
  /// Handle Inversion Toggle
  /// </summary>
  public System.Boolean? Switch { get ; set; }
  
  /// <summary>
  /// Handle X Position Range
  /// </summary>
  public System.String? XRange { get ; set; }
  
  /// <summary>
  /// Handle Y Position Range
  /// </summary>
  public System.String? YRange { get ; set; }
  
  /// <summary>
  /// Handle Polar Radius Range
  /// </summary>
  public System.String? RadiusRange { get ; set; }
  
}
