namespace DocumentModel.Drawings.ChartDrawing;
/// <summary>
/// Describes non-visual properties for a shape in chart drawings, including general drawing properties and shape-specific drawing settings.
/// </summary>
[OpenXmlType(typeof(DXDCD.NonVisualShapeProperties))]
public class NonVisualShapeProperties: ModelElement<DXDCD.NonVisualShapeProperties>
{
  /// <summary>
  /// General non-visual properties for the shape, such as identifier, name, and metadata.
  /// </summary>
  [OpenXmlProperty(nameof(DXDCD.NonVisualShapeProperties.NonVisualDrawingProperties))]
  public NonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get => _NonVisualDrawingProperties;
    set => UpdateField(ref _NonVisualDrawingProperties, value, nameof(NonVisualDrawingProperties));
  }
  private NonVisualDrawingProperties? _NonVisualDrawingProperties;
  /// <summary>
  /// Non-visual drawing properties specific to the shape, including text box indication, locking options, and extension data.
  /// </summary>
  [OpenXmlProperty(nameof(DXDCD.NonVisualShapeProperties.NonVisualShapeDrawingProperties))]
  public NonVisualShapeDrawingProperties? NonVisualShapeDrawingProperties
  {
    get => _NonVisualShapeDrawingProperties;
    set => UpdateField(ref _NonVisualShapeDrawingProperties, value, nameof(NonVisualShapeDrawingProperties));
  }
  private NonVisualShapeDrawingProperties? _NonVisualShapeDrawingProperties;
}