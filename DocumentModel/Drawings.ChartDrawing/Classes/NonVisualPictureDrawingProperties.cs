namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
///   Non-Visual Picture Drawing Properties.
/// </summary>
public record NonVisualPictureDrawingProperties
{
  /// <summary>
  ///   preferRelativeResize
  /// </summary>
  public Boolean? PreferRelativeResize { get; set; }

  /// <summary>
  ///   PictureLocks.
  /// </summary>
  public PictureLocks? PictureLocks { get; set; }

  /// <summary>
  ///   NonVisualPicturePropertiesExtensionList.
  /// </summary>
  public NonVisualPicturePropertiesExtensionList? NonVisualPicturePropertiesExtensionList { get; set; }
}