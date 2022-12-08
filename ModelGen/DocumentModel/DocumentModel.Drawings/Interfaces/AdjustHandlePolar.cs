namespace DocumentModel.Drawings;

/// <summary>
/// Polar Adjust Handle.
/// </summary>
public interface AdjustHandlePolar
{
  /// <summary>
  /// Radial Adjustment Guide
  /// </summary>
  public String? RadialAdjustmentGuide { get ; set; }
  
  /// <summary>
  /// Minimum Radial Adjustment
  /// </summary>
  public String? MinRadial { get ; set; }
  
  /// <summary>
  /// Maximum Radial Adjustment
  /// </summary>
  public String? MaxRadial { get ; set; }
  
  /// <summary>
  /// Angle Adjustment Guide
  /// </summary>
  public String? AngleAdjustmentGuide { get ; set; }
  
  /// <summary>
  /// Minimum Angle Adjustment
  /// </summary>
  public String? MinAngle { get ; set; }
  
  /// <summary>
  /// Maximum Angle Adjustment
  /// </summary>
  public String? MaxAngle { get ; set; }
  
  /// <summary>
  /// Shape Position Coordinate.
  /// </summary>
  public AdjustPoint2DType? Position { get ; set; }
  
}
