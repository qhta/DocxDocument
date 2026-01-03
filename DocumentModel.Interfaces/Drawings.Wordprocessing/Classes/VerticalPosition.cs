namespace DocumentModel.Drawings.Wordprocessing;

/// <summary>
///   Vertical Positioning.
/// </summary>
public interface VerticalPosition: IModelElement
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
  ///   PercentagePositionVerticalOffset.
  /// </summary>
  public string? PercentagePositionVerticalOffset { get; set; }
}