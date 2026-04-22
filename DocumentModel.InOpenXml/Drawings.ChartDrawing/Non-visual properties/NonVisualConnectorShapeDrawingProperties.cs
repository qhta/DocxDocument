namespace DocumentModel.Drawings.ChartDrawing;
/// <summary>
/// Describes non-visual properties for connector shapes in chart drawings, including general drawing properties and connection-specific settings.
/// </summary>
[OpenXmlType(typeof(DXDCD.NonVisualConnectorShapeDrawingProperties))]
[XmlRoot("NonVisualConnectorShapeDrawingProperties", Namespace = "DocumentModel.Drawings.ChartDrawing")]
public partial class NonVisualConnectorShapeDrawingProperties : ModelElement<DXDCD.NonVisualConnectorShapeDrawingProperties>
{
  /// <summary>
  /// General non-visual properties for the connector shape, such as ID, name, and metadata.
  /// </summary>
  [OpenXmlProperty(nameof(DXDCD.NonVisualConnectorShapeDrawingProperties.NonVisualDrawingProperties))]
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get => _NonVisualDrawingProperties; set => UpdateField(ref _NonVisualDrawingProperties, value, nameof(NonVisualDrawingProperties)); }

  private NonVisualDrawingProperties? _NonVisualDrawingProperties;
  /// <summary>
  /// Non-visual properties specific to connection shapes, including locks and connection endpoints.
  /// </summary>
  [OpenXmlProperty(nameof(DXDCD.NonVisualConnectorShapeDrawingProperties.NonVisualConnectionShapeProperties))]
  public NonVisualConnectionShapeProperties? NonVisualConnectionShapeProperties { get => _NonVisualConnectionShapeProperties; set => UpdateField(ref _NonVisualConnectionShapeProperties, value, nameof(NonVisualConnectionShapeProperties)); }

  private NonVisualConnectionShapeProperties? _NonVisualConnectionShapeProperties;
}