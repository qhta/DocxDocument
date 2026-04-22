namespace DocumentModel.Drawings.ChartDrawing;
/// <summary>
/// Describes a group shape in chart drawings, including non-visual and visual properties, contained shapes, child groups, graphic frames, connections, and pictures.
/// </summary>
/// <remarks>
/// <para>The following table lists the possible child types:</para>
/// <list type="bullet">
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties"/> <c>&lt;cdr:grpSpPr&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.ChartDrawing.ConnectionShape"/> <c>&lt;cdr:cxnSp&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.ChartDrawing.GraphicFrame"/> <c>&lt;cdr:graphicFrame&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShape"/> <c>&lt;cdr:grpSp&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGroupShapeProperties"/> <c>&lt;cdr:nvGrpSpPr&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.ChartDrawing.Picture"/> <c>&lt;cdr:pic&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.ChartDrawing.Shape"/> <c>&lt;cdr:sp&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart"/> <c>&lt;cdr14:contentPart&gt;</c></description></item>
/// </list>
/// </remarks>
[OpenXmlType(typeof(DXDCD.GroupShape))]
[XmlRoot("GroupShape", Namespace = "DocumentModel.Drawings.ChartDrawing")]
public partial class GroupShape : ModelElement<DXDCD.GroupShape>
{
  /// <summary>
  /// Non-visual properties for the group shape, such as identifiers, names, and metadata.
  /// </summary>
  [OpenXmlElement(typeof(DXDCD.NonVisualGroupShapeProperties))]
  public NonVisualGroupShapeProperties? NonVisualGroupShapeProperties { get => _NonVisualGroupShapeProperties; set => UpdateField(ref _NonVisualGroupShapeProperties, value, nameof(NonVisualGroupShapeProperties)); }

  private NonVisualGroupShapeProperties? _NonVisualGroupShapeProperties;
  /// <summary>
  /// Visual properties and formatting for the group shape.
  /// </summary>
  [OpenXmlElement(typeof(DXDCD.GroupShapeProperties))]
  public GroupShapeProperties? GroupShapeProperties { get => _GroupShapeProperties; set => UpdateField(ref _GroupShapeProperties, value, nameof(GroupShapeProperties)); }

  private GroupShapeProperties? _GroupShapeProperties;
  /// <summary>
  /// Shape element contained within the group.
  /// </summary>
  [OpenXmlElement(typeof(DXDCD.Shape))]
  public Shape? Shape { get => _Shape; set => UpdateField(ref _Shape, value, nameof(Shape)); }

  private Shape? _Shape;
  /// <summary>
  /// Child group shape element for nested grouping.
  /// </summary>
  [OpenXmlElement(typeof(DXDCD.GroupShape))]
  public GroupShape? ChildGroupShape { get => _ChildGroupShape; set => UpdateField(ref _ChildGroupShape, value, nameof(ChildGroupShape)); }

  private GroupShape? _ChildGroupShape;
  /// <summary>
  /// Graphic frame element contained within the group.
  /// </summary>
  [OpenXmlElement(typeof(DXDCD.GraphicFrame))]
  public GraphicFrame? GraphicFrame { get => _GraphicFrame; set => UpdateField(ref _GraphicFrame, value, nameof(GraphicFrame)); }

  private GraphicFrame? _GraphicFrame;
  /// <summary>
  /// Connection shape element contained within the group.
  /// </summary>
  [OpenXmlElement(typeof(DXDCD.ConnectionShape))]
  public ConnectionShape? ConnectionShape { get => _ConnectionShape; set => UpdateField(ref _ConnectionShape, value, nameof(ConnectionShape)); }

  private ConnectionShape? _ConnectionShape;
  /// <summary>
  /// Picture element contained within the group.
  /// </summary>
  [OpenXmlElement(typeof(DXDCD.Picture))]
  public Picture? Picture { get => _Picture; set => UpdateField(ref _Picture, value, nameof(Picture)); }

  private Picture? _Picture;
}