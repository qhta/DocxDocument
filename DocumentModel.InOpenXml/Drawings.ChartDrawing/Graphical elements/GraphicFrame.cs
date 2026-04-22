namespace DocumentModel.Drawings.ChartDrawing;
/// <summary>
/// Describes a graphic frame in chart drawings, including macro references, publishing options, non-visual properties, transformation settings, and contained graphical objects.
/// </summary>
/// <remarks>
/// <para>The following table lists the possible child types:</para>
/// <list type="bullet">
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Graphic"/> <c>&lt;a:graphic&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.ChartDrawing.Transform"/> <c>&lt;cdr:xfrm&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameProperties"/> <c>&lt;cdr:nvGraphicFramePr&gt;</c></description></item>
/// </list>
/// </remarks>
[OpenXmlType(typeof(DXDCD.GraphicFrame))]
[XmlRoot("GraphicFrame", Namespace = "DocumentModel.Drawings.ChartDrawing")]
public class GraphicFrame : ModelElement<DXDCD.GraphicFrame>
{
 /// <summary>
 /// Macro name or reference for custom functionality associated with the graphic frame.
 /// </summary>
 [OpenXmlProperty(nameof(DXDCD.GraphicFrame.Macro))]
 public string? Macro { get => _Macro; set => UpdateField(ref _Macro, value, nameof(Macro)); }
 private string? _Macro;

 /// <summary>
 /// Indicates whether the graphic frame should be published to a server or external destination.
 /// </summary>
 [OpenXmlProperty(nameof(DXDCD.GraphicFrame.Published))]
 public bool? Published { get => _Published; set => UpdateField(ref _Published, value, nameof(Published)); }
 private bool? _Published;

 /// <summary>
 /// Non-visual properties for the graphic frame, including identifiers, names, and metadata.
 /// </summary>
 [OpenXmlElement(typeof(DXDCD.NonVisualGraphicFrameProperties))]
 public NonVisualGraphicFrameProperties? NonVisualGraphicFrameProperties { get => _NonVisualGraphicFrameProperties; set => UpdateField(ref _NonVisualGraphicFrameProperties, value, nameof(NonVisualGraphicFrameProperties)); }
 private NonVisualGraphicFrameProperties? _NonVisualGraphicFrameProperties;

 /// <summary>
 /// Transformation settings for positioning, scaling, or rotating the graphic frame within the drawing canvas.
 /// </summary>
 [OpenXmlElement(typeof(DXDCD.Transform))]
 public Transform? Transform { get => _Transform; set => UpdateField(ref _Transform, value, nameof(Transform)); }
 private Transform? _Transform;

 /// <summary>
 /// Graphical object contained within the frame, such as charts, images, or diagrams.
 /// </summary>
 [OpenXmlElement(typeof(DXD.Graphic))]
 public Graphic? Graphic { get => _Graphic; set => UpdateField(ref _Graphic, value, nameof(Graphic)); }
 private Graphic? _Graphic;
}