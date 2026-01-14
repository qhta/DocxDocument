namespace DocumentModel.Drawings;

/// <summary>
///   Represents a transform effect, allowing adjustment of scaling, skew, and shift for a drawing element.
/// </summary>
public interface TransformEffect
{
  /// <summary>
  ///   Horizontal scaling ratio.
  /// </summary>
  public Int32? HorizontalRatio { get; set; }

  /// <summary>
  ///   Vertical scaling ratio.
  /// </summary>
  public Int32? VerticalRatio { get; set; }

  /// <summary>
  ///   Horizontal skew value.
  /// </summary>
  public Int32? HorizontalSkew { get; set; }

  /// <summary>
  ///   Vertical skew value.
  /// </summary>
  public Int32? VerticalSkew { get; set; }

  /// <summary>
  ///   Horizontal shift value.
  /// </summary>
  public Int64? HorizontalShift { get; set; }

  /// <summary>
  ///   Vertical shift value.
  /// </summary>
  public Int64? VerticalShift { get; set; }
}