namespace DocumentModel.Wordprocessing;

/// <summary>
/// Magnification Setting.
/// </summary>
public interface IZoom // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Zoom Type
  /// </summary>
  public PresetZoomValues? Val { get ; set; }
  
  /// <summary>
  /// Zoom Percentage
  /// </summary>
  public string? Percent { get ; set; }
  
}
