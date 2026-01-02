namespace DocumentModel.Drawings.Wordprocessing;

/// <summary>
///   Horizontal Positioning.
/// </summary>
public class HorizontalPosition: ModelElement
{
  /// <summary>
  ///   Horizontal Position Relative Base
  /// </summary>
  public HorizontalRelativePositionKind? RelativeFrom { get; set; }
  /// <summary>
  ///   Relative Horizontal Alignment.
  /// </summary>
  public string? HorizontalAlignment { get; set; }
  /// <summary>
  ///   Absolute Position Offset.
  /// </summary>
  public string? PositionOffset { get; set; }
  /// <summary>
  ///   PercentagePositionHeightOffset, this property is only available in Office 2010 and later..
  /// </summary>
  public string? PercentagePositionHeightOffset { get; set; }
}