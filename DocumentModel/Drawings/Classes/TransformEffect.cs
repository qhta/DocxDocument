namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Transform Effect.
/// </summary>
public class TransformEffect: ModelElement
{
  /// <summary>
  ///   Horizontal Ratio
  /// </summary>
  public Int32? HorizontalRatio { get; set; }

  /// <summary>
  ///   Vertical Ratio
  /// </summary>
  public Int32? VerticalRatio { get; set; }

  /// <summary>
  ///   Horizontal Skew
  /// </summary>
  public Int32? HorizontalSkew { get; set; }

  /// <summary>
  ///   Vertical Skew
  /// </summary>
  public Int32? VerticalSkew { get; set; }

  /// <summary>
  ///   Horizontal Shift
  /// </summary>
  public Int64? HorizontalShift { get; set; }

  /// <summary>
  ///   Vertical Shift
  /// </summary>
  public Int64? VerticalShift { get; set; }
}