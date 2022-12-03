namespace DocumentModel.Wordprocessing;

/// <summary>
/// Magnification Setting.
/// </summary>
public interface Zoom // : System.Boolean
{
  /// <summary>
  /// Zoom Type
  /// </summary>
  public PresetZoomKind? Val { get ; set; }
  
  /// <summary>
  /// Zoom Percentage
  /// </summary>
  public String? Percent { get ; set; }
  
}
