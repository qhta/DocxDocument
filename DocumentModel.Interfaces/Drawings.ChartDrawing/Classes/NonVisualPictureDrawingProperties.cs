namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
///   Non-Visual Picture Drawing Properties.
/// </summary>
public interface NonVisualPictureDrawingProperties:
{
  /// <summary>
  ///   preferRelativeResize
  /// </summary>
  public bool? PreferRelativeResize { get; set; }
  /// <summary>
  ///   PictureLocks.
  /// </summary>
  public PictureLocks? PictureLocks { get; set; }
  /// <summary>
  ///   NonVisualPicturePropertiesExtensionList.
  /// </summary>
  public NonVisualPicturePropertiesExtensionList? NonVisualPicturePropertiesExtensionList { get; set; }
}