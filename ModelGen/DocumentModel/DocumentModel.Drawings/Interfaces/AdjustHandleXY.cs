namespace DocumentModel.Drawings;

/// <summary>
/// XY Adjust Handle.
/// </summary>
public interface AdjustHandleXY // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Horizontal Adjustment Guide
  /// </summary>
  public String? XAdjustmentGuide { get ; set; }
  
  /// <summary>
  /// Minimum Horizontal Adjustment
  /// </summary>
  public String? MinX { get ; set; }
  
  /// <summary>
  /// Maximum Horizontal Adjustment
  /// </summary>
  public String? MaxX { get ; set; }
  
  /// <summary>
  /// Vertical Adjustment Guide
  /// </summary>
  public String? YAdjustmentGuide { get ; set; }
  
  /// <summary>
  /// Minimum Vertical Adjustment
  /// </summary>
  public String? MinY { get ; set; }
  
  /// <summary>
  /// Maximum Vertical Adjustment
  /// </summary>
  public String? MaxY { get ; set; }
  
  /// <summary>
  /// Position.
  /// </summary>
  public AdjustPoint2DType? Position { get ; set; }
  
}
