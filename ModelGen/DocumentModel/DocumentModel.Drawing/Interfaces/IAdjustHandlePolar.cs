namespace DocumentModel.Drawing;

/// <summary>
/// Polar Adjust Handle.
/// </summary>
public interface IAdjustHandlePolar // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Radial Adjustment Guide
  /// </summary>
  public System.String? RadialAdjustmentGuide { get ; set; }
  
  /// <summary>
  /// Minimum Radial Adjustment
  /// </summary>
  public System.String? MinRadial { get ; set; }
  
  /// <summary>
  /// Maximum Radial Adjustment
  /// </summary>
  public System.String? MaxRadial { get ; set; }
  
  /// <summary>
  /// Angle Adjustment Guide
  /// </summary>
  public System.String? AngleAdjustmentGuide { get ; set; }
  
  /// <summary>
  /// Minimum Angle Adjustment
  /// </summary>
  public System.String? MinAngle { get ; set; }
  
  /// <summary>
  /// Maximum Angle Adjustment
  /// </summary>
  public System.String? MaxAngle { get ; set; }
  
  /// <summary>
  /// Shape Position Coordinate.
  /// </summary>
  public DocumentModel.Drawing.IAdjustPoint2DType? Position { get ; set; }
  
}
