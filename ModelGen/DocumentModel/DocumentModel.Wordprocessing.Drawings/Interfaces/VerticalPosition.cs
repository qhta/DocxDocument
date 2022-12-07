namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Vertical Positioning.
/// </summary>
public interface VerticalPosition
{
  /// <summary>
  /// Vertical Position Relative Base
  /// </summary>
  public VerticalRelativePositionKind? RelativeFrom { get ; set; }
  
}
