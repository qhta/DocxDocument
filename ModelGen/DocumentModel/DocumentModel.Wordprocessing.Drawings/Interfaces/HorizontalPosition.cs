namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Horizontal Positioning.
/// </summary>
public interface HorizontalPosition
{
  /// <summary>
  /// Horizontal Position Relative Base
  /// </summary>
  public HorizontalRelativePositionKind? RelativeFrom { get ; set; }
  
}
