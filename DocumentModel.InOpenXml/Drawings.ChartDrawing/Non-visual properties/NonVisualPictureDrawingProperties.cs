namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
///   Describes non-visual properties for a picture in chart drawings, including resizing preferences, locking options, and extension data.
/// </summary>
[OpenXmlType(typeof(DXDCD.NonVisualPictureDrawingProperties))]
public class NonVisualPictureDrawingProperties: ModelElement<DXDCD.NonVisualPictureDrawingProperties>
{
  /// <summary>
  ///   Indicates whether the picture should prefer relative resizing when scaled within its container.
  /// </summary>
  [OpenXmlProperty(nameof(DXDCD.NonVisualPictureDrawingProperties.PreferRelativeResize))]
  public bool? PreferRelativeResize
  {
    get => _PreferRelativeResize;
    set => UpdateField(ref _PreferRelativeResize, value, nameof(PreferRelativeResize));
  }

  private bool? _PreferRelativeResize;

  /// <summary>
  ///   Specifies locking options that restrict editing or manipulation of the picture.
  /// </summary>
  [OpenXmlProperty(nameof(DXDCD.NonVisualPictureDrawingProperties.PictureLocks))]
  public PictureLocks? PictureLocks
  {
    get => _PictureLocks;
    set => UpdateField(ref _PictureLocks, value, nameof(PictureLocks));
  }

  private PictureLocks? _PictureLocks;

  /// <summary>
  ///   Extension list for additional or future non-visual picture properties.
  /// </summary>
  [OpenXmlProperty(nameof(DXDCD.NonVisualPictureDrawingProperties.NonVisualPicturePropertiesExtensionList))]
  public NonVisualPicturePropertiesExtensionList? NonVisualPicturePropertiesExtensionList
  {
    get => _NonVisualPicturePropertiesExtensionList;
    set => UpdateField(ref _NonVisualPicturePropertiesExtensionList, value,
      nameof(NonVisualPicturePropertiesExtensionList));
  }

  private NonVisualPicturePropertiesExtensionList? _NonVisualPicturePropertiesExtensionList;
}