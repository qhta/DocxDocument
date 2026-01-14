namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the magnification setting for a Wordprocessing document.
/// This class provides properties for specifying the zoom type and zoom percentage, enabling control over the document's display magnification.
/// </summary>
public class Zoom
{
  /// <summary>
  /// Zoom type, specifying the preset magnification mode.
  /// </summary>
  public PresetZoomKind? Kind { get; set; }

  /// <summary>
  /// Zoom percentage, specifying the magnification level as a percentage.
  /// </summary>
  public int? Percent { get; set; }
}