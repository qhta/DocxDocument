namespace DocumentModel.Drawings.Pictures;
/// <summary>
///   Non-Visual Picture Drawing Properties.
/// </summary>
public partial class NonVisualPictureDrawingProperties : ModelElement<DXDP.NonVisualDrawingProperties>
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