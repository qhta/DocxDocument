namespace DocumentModel.Drawings.ChartDrawing;
/// <summary>
/// Describes non-visual properties for a graphic frame in chart drawings, including general drawing properties and frame-specific drawing settings.
/// </summary>
[OpenXmlType(typeof(DXDCD.NonVisualGraphicFrameProperties))]
[XmlRoot("NonVisualGraphicFrameProperties", Namespace = "DocumentModel.Drawings.ChartDrawing")]
public partial class NonVisualGraphicFrameProperties : ModelElement<DXDCD.NonVisualGraphicFrameProperties>
{
  /// <summary>
  /// General non-visual properties for the graphic frame, such as identifier, name, and metadata.
  /// </summary>
  [OpenXmlProperty(nameof(DXDCD.NonVisualGraphicFrameProperties.NonVisualDrawingProperties))]
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get => _NonVisualDrawingProperties; set => UpdateField(ref _NonVisualDrawingProperties, value, nameof(NonVisualDrawingProperties)); }

  private NonVisualDrawingProperties? _NonVisualDrawingProperties;
  /// <summary>
  /// Non-visual drawing properties specific to the graphic frame, including locking and editing restrictions.
  /// </summary>
  [OpenXmlProperty(nameof(DXDCD.NonVisualGraphicFrameProperties.NonVisualGraphicFrameDrawingProperties))]
  public NonVisualGraphicFrameDrawingProperties? NonVisualGraphicFrameDrawingProperties { get => _NonVisualGraphicFrameDrawingProperties; set => UpdateField(ref _NonVisualGraphicFrameDrawingProperties, value, nameof(NonVisualGraphicFrameDrawingProperties)); }

  private NonVisualGraphicFrameDrawingProperties? _NonVisualGraphicFrameDrawingProperties;
}