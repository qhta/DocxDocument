namespace DocumentModel.Drawings.ChartDrawing;
/// <summary>
/// Describes a connection shape in chart drawings, including macro references, publishing options, non-visual connector properties, shape formatting, and style settings.
/// </summary>
/// <remarks>
/// <para>The following table lists the possible child types:</para>
/// <list type="bullet">
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.ChartDrawing.ShapeProperties"/> <c>&lt;cdr:spPr&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.ChartDrawing.Style"/> <c>&lt;cdr:style&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectorShapeDrawingProperties"/> <c>&lt;cdr:nvCxnSpPr&gt;</c></description></item>
/// </list>
/// </remarks>
[OpenXmlType(typeof(DXDCD.ConnectionShape))]
[XmlRoot("ConnectionShape", Namespace = "DocumentModel.Drawings.ChartDrawing")]
public class ConnectionShape : ModelElement<DXDCD.ConnectionShape>
{
 /// <summary>
 /// Macro name or reference for custom functionality associated with the connection shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXDCD.ConnectionShape.Macro))]
 public string? Macro { get => _Macro; set => UpdateField(ref _Macro, value, nameof(Macro)); }

 private string? _Macro;
 /// <summary>
 /// Indicates whether the connection shape should be published to a server or external destination.
 /// </summary>
 [OpenXmlProperty(nameof(DXDCD.ConnectionShape.Published))]
 public bool? Published { get => _Published; set => UpdateField(ref _Published, value, nameof(Published)); }

 private bool? _Published;
 /// <summary>
 /// Non-visual properties for the connector shape, including drawing and connection settings.
 /// </summary>
 [OpenXmlElement(typeof(DXDCD.NonVisualConnectorShapeDrawingProperties))]
 public NonVisualConnectorShapeDrawingProperties? NonVisualConnectorShapeDrawingProperties { get => _NonVisualConnectorShapeDrawingProperties; set => UpdateField(ref _NonVisualConnectorShapeDrawingProperties, value, nameof(NonVisualConnectorShapeDrawingProperties)); }

 private NonVisualConnectorShapeDrawingProperties? _NonVisualConnectorShapeDrawingProperties;
 /// <summary>
 /// Formatting and visual properties for the connection shape.
 /// </summary>
 [OpenXmlElement(typeof(DXDCD.ShapeProperties))]
 public ShapeProperties? ShapeProperties { get => _ShapeProperties; set => UpdateField(ref _ShapeProperties, value, nameof(ShapeProperties)); }

 private ShapeProperties? _ShapeProperties;
 /// <summary>
 /// Style settings applied to the connection shape for appearance customization.
 /// </summary>
 [OpenXmlElement(typeof(DXDCD.Style))]
 public Style? Style { get => _Style; set => UpdateField(ref _Style, value, nameof(Style)); }

 private Style? _Style;
}