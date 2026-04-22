namespace DocumentModel.Drawings.ChartDrawing;
/// <summary>
/// Describes non-visual properties for a group shape in chart drawings, including general drawing properties and group-specific drawing settings.
/// </summary>
[OpenXmlType(typeof(DXDCD.NonVisualGroupShapeProperties))]
[XmlRoot("NonVisualGroupShapeProperties", Namespace = "DocumentModel.Drawings.ChartDrawing")]
public partial class NonVisualGroupShapeProperties : ModelElement<DXDCD.NonVisualGroupShapeProperties>
{
  /// <summary>
  /// General non-visual properties for the group shape, such as identifier, name, and metadata.
  /// </summary>
  [OpenXmlProperty(nameof(DXDCD.NonVisualGroupShapeProperties.NonVisualDrawingProperties))]
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get => _NonVisualDrawingProperties; set => UpdateField(ref _NonVisualDrawingProperties, value, nameof(NonVisualDrawingProperties)); }

  private NonVisualDrawingProperties? _NonVisualDrawingProperties;
  /// <summary>
  /// Non-visual drawing properties specific to the group shape, including locking options and extension data.
  /// </summary>
  [OpenXmlProperty(nameof(DXDCD.NonVisualGroupShapeProperties.NonVisualGroupShapeDrawingProperties))]
  public NonVisualGroupShapeDrawingProperties? NonVisualGroupShapeDrawingProperties { get => _NonVisualGroupShapeDrawingProperties; set => UpdateField(ref _NonVisualGroupShapeDrawingProperties, value, nameof(NonVisualGroupShapeDrawingProperties)); }

  private NonVisualGroupShapeDrawingProperties? _NonVisualGroupShapeDrawingProperties;
}