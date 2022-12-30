namespace DocumentModel.Vml;

/// <summary>
/// Shape Handle.
/// </summary>
public partial class ShapeHandle
{
  /// <summary>
  /// Handle Position
  /// </summary>
  public String? Position { get; set; }
  
  /// <summary>
  /// Handle Polar Center
  /// </summary>
  public String? Polar { get; set; }
  
  /// <summary>
  /// Handle Coordinate Mapping
  /// </summary>
  public String? Map { get; set; }
  
  /// <summary>
  /// Invert Handle's X Position
  /// </summary>
  public Boolean? InvertX { get; set; }
  
  /// <summary>
  /// Invert Handle's Y Position
  /// </summary>
  public Boolean? InvertY { get; set; }
  
  /// <summary>
  /// Handle Inversion Toggle
  /// </summary>
  public Boolean? Switch { get; set; }
  
  /// <summary>
  /// Handle X Position Range
  /// </summary>
  public String? XRange { get; set; }
  
  /// <summary>
  /// Handle Y Position Range
  /// </summary>
  public String? YRange { get; set; }
  
  /// <summary>
  /// Handle Polar Radius Range
  /// </summary>
  public String? RadiusRange { get; set; }
  
}
