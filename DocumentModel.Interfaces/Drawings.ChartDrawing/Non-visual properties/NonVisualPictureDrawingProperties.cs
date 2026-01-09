namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
///   Describes non-visual properties for a picture in chart drawings, including resizing preferences, locking options, and extension data.
/// </summary>
public interface NonVisualPictureDrawingProperties
{
  /// <summary>
  ///   Indicates whether the picture should prefer relative resizing when scaled within its container.
  /// </summary>
  public bool? PreferRelativeResize { get; set; }

  /// <summary>
  ///   Specifies locking options that restrict editing or manipulation of the picture.
  /// </summary>
  public PictureLocks? PictureLocks { get; set; }

  /// <summary>
  ///   Extension list for additional or future non-visual picture properties.
  /// </summary>
  public NonVisualPicturePropertiesExtensionList? NonVisualPicturePropertiesExtensionList { get; set; }
}