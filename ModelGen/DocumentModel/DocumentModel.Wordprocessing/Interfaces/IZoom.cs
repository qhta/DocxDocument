namespace DocumentModel.Wordprocessing;

/// <summary>
/// Magnification Setting.
/// </summary>
public interface IZoom // : DocumentModel.ITypedOpenXmlLeafElement
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
