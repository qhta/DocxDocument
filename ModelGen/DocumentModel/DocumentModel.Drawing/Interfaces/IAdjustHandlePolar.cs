namespace DocumentModel.Drawing;

/// <summary>
/// Polar Adjust Handle.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IPosition))]
public interface IAdjustHandlePolar // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Radial Adjustment Guide
  /// </summary>
  public string? RadialAdjustmentGuide { get ; set; }
  
  /// <summary>
  /// Minimum Radial Adjustment
  /// </summary>
  public string? MinRadial { get ; set; }
  
  /// <summary>
  /// Maximum Radial Adjustment
  /// </summary>
  public string? MaxRadial { get ; set; }
  
  /// <summary>
  /// Angle Adjustment Guide
  /// </summary>
  public string? AngleAdjustmentGuide { get ; set; }
  
  /// <summary>
  /// Minimum Angle Adjustment
  /// </summary>
  public string? MinAngle { get ; set; }
  
  /// <summary>
  /// Maximum Angle Adjustment
  /// </summary>
  public string? MaxAngle { get ; set; }
  
  /// <summary>
  /// Shape Position Coordinate.
  /// </summary>
  public DocumentModel.Drawing.IPosition? Position { get ; set; }
  
}
