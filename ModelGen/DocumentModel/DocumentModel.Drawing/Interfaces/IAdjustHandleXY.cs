namespace DocumentModel.Drawing;

/// <summary>
/// XY Adjust Handle.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IPosition))]
public interface IAdjustHandleXY // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Horizontal Adjustment Guide
  /// </summary>
  public string? XAdjustmentGuide { get ; set; }
  
  /// <summary>
  /// Minimum Horizontal Adjustment
  /// </summary>
  public string? MinX { get ; set; }
  
  /// <summary>
  /// Maximum Horizontal Adjustment
  /// </summary>
  public string? MaxX { get ; set; }
  
  /// <summary>
  /// Vertical Adjustment Guide
  /// </summary>
  public string? YAdjustmentGuide { get ; set; }
  
  /// <summary>
  /// Minimum Vertical Adjustment
  /// </summary>
  public string? MinY { get ; set; }
  
  /// <summary>
  /// Maximum Vertical Adjustment
  /// </summary>
  public string? MaxY { get ; set; }
  
  /// <summary>
  /// Position.
  /// </summary>
  public DocumentModel.Drawing.IPosition? Position { get ; set; }
  
}
