namespace DocumentModel.Wordprocessing;

/// <summary>
/// Magnification Setting.
/// </summary>
public interface IZoom // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Zoom Type
  /// </summary>
  public DocumentModel.Wordprocessing.PresetZoomKind? Val { get ; set; }
  
  /// <summary>
  /// Zoom Percentage
  /// </summary>
  public System.String? Percent { get ; set; }
  
}
