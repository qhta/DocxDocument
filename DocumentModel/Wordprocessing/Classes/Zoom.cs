namespace DocumentModel.Wordprocessing;

/// <summary>
///   Magnification Setting.
/// </summary>
public class Zoom
{
  /// <summary>
  ///   Zoom Type
  /// </summary>
  public PresetZoomKind? Val { get; set; }

  /// <summary>
  ///   Zoom Percentage
  /// </summary>
  public int? Percent { get; set; }
}