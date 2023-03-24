namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Magnification Setting.
/// </summary>
[TypeConverter(typeof(ZoomTypeConverter))]
public class Zoom: ModelElement
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