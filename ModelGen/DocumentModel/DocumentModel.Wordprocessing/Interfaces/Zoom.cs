namespace DocumentModel.Wordprocessing;

/// <summary>
/// Magnification Setting.
/// </summary>
public interface Zoom
{
  /// <summary>
  /// Zoom Type
  /// </summary>
  public PresetZoomKind? Val { get ; set; }
  
}
