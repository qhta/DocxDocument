namespace DocumentModel.Wordprocessing;

/// <summary>
/// Magnification Setting.
/// </summary>
public partial interface Zoom
{
  /// <summary>
  /// Zoom Type
  /// </summary>
  public DocumentModel.Wordprocessing.PresetZoomKind? Val { get; set; }
  
  /// <summary>
  /// Zoom Percentage
  /// </summary>
  public String? Percent { get; set; }
  
}
