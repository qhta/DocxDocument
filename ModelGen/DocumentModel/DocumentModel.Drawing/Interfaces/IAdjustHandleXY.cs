namespace DocumentModel.Drawing;

/// <summary>
/// XY Adjust Handle.
/// </summary>
public interface IAdjustHandleXY // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Horizontal Adjustment Guide
  /// </summary>
  public System.String? XAdjustmentGuide { get ; set; }
  
  /// <summary>
  /// Minimum Horizontal Adjustment
  /// </summary>
  public System.String? MinX { get ; set; }
  
  /// <summary>
  /// Maximum Horizontal Adjustment
  /// </summary>
  public System.String? MaxX { get ; set; }
  
  /// <summary>
  /// Vertical Adjustment Guide
  /// </summary>
  public System.String? YAdjustmentGuide { get ; set; }
  
  /// <summary>
  /// Minimum Vertical Adjustment
  /// </summary>
  public System.String? MinY { get ; set; }
  
  /// <summary>
  /// Maximum Vertical Adjustment
  /// </summary>
  public System.String? MaxY { get ; set; }
  
  /// <summary>
  /// Position.
  /// </summary>
  public DocumentModel.Drawing.IAdjustPoint2DType? Position { get ; set; }
  
}
