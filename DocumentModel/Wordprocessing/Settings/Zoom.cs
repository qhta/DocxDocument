namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Magnification Setting.
/// </summary>
[TypeConverter(typeof(ZoomTypeConverter))]
public class IZoom: ModelElement
{
  /// <summary>
  ///   IZoom Type
  /// </summary>
  public PresetZoomKind? Kind { get; set; }

  /// <summary>
  ///   IZoom Percentage
  /// </summary>
  public int? Percent { get; set; }
}
