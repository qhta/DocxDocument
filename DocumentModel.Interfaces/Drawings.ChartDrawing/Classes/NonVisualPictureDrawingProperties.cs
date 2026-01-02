namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
///   Non-Visual Picture Drawing Properties.
/// </summary>
public class NonVisualPictureDrawingProperties: ModelElement
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