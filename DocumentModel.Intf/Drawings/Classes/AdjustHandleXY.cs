namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   XY Adjust Handle.
/// </summary>
public class AdjustHandleXY: ModelElement
{
  /// <summary>
  ///   Horizontal Adjustment Guide
  /// </summary>
  public string? XAdjustmentGuide { get; set; }

  /// <summary>
  ///   Minimum Horizontal Adjustment
  /// </summary>
  public string? MinX { get; set; }

  /// <summary>
  ///   Maximum Horizontal Adjustment
  /// </summary>
  public string? MaxX { get; set; }

  /// <summary>
  ///   Vertical Adjustment Guide
  /// </summary>
  public string? YAdjustmentGuide { get; set; }

  /// <summary>
  ///   Minimum Vertical Adjustment
  /// </summary>
  public string? MinY { get; set; }

  /// <summary>
  ///   Maximum Vertical Adjustment
  /// </summary>
  public string? MaxY { get; set; }

  /// <summary>
  ///   Position.
  /// </summary>
  public AdjustPoint2DType? Position { get; set; }
}