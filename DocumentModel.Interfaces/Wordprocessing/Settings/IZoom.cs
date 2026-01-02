namespace DocumentModel.Wordprocessing;

/// <summary>
///   Magnification Setting.
/// </summary>
public interface IZoom: IModelElement
{
  /// <summary>
  ///   Zoom Type
  /// </summary>
  public PresetZoomKind? Kind { get; set; }
  /// <summary>
  ///   Zoom Percentage
  /// </summary>
  public int? Percent { get; set; }
}