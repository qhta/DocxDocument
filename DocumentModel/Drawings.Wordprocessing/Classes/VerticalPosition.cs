namespace DocumentModel.Drawings.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Vertical Positioning.
/// </summary>
public class VerticalPosition: ModelElement
{
  /// <summary>
  ///   Vertical Position Relative Base
  /// </summary>
  public VerticalRelativePositionKind? RelativeFrom { get; set; }

  /// <summary>
  ///   Relative Vertical Alignment.
  /// </summary>
  public string? VerticalAlignment { get; set; }

  /// <summary>
  ///   PositionOffset.
  /// </summary>
  public string? PositionOffset { get; set; }

  /// <summary>
  ///   PercentagePositionVerticalOffset, this property is only available in Office 2010 and later..
  /// </summary>
  public string? PercentagePositionVerticalOffset { get; set; }
}