namespace DocumentModel.Drawings.ChartDrawing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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