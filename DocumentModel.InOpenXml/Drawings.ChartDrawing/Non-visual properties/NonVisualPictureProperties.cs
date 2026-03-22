namespace DocumentModel.Drawings.ChartDrawing;
/// <summary>
/// Describes non-visual properties for a picture in chart drawings, including general drawing properties and picture-specific drawing settings.
/// </summary>
[OpenXmlType(typeof(DXDCD.NonVisualPictureProperties))]
public class NonVisualPictureProperties: ModelElement<DXDCD.NonVisualPictureProperties>
{
  /// <summary>
  /// General non-visual properties for the picture, such as identifier, name, and metadata.
  /// </summary>
  [OpenXmlProperty(nameof(DXDCD.NonVisualPictureProperties.NonVisualDrawingProperties))]
  public NonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get => _NonVisualDrawingProperties;
    set => UpdateField(ref _NonVisualDrawingProperties, value, nameof(NonVisualDrawingProperties));
  }
  private NonVisualDrawingProperties? _NonVisualDrawingProperties;
  /// <summary>
  /// Non-visual drawing properties specific to the picture, including resizing preferences, locking options, and extension data.
  /// </summary>
  [OpenXmlProperty(nameof(DXDCD.NonVisualPictureProperties.NonVisualPictureDrawingProperties))]
  public NonVisualPictureDrawingProperties? NonVisualPictureDrawingProperties
  {
    get => _NonVisualPictureDrawingProperties;
    set => UpdateField(ref _NonVisualPictureDrawingProperties, value, nameof(NonVisualPictureDrawingProperties));
  }
  private NonVisualPictureDrawingProperties? _NonVisualPictureDrawingProperties;
}