namespace DocumentModel.Drawings.ChartDrawing;
/// <summary>
/// Describes the size and positioning of a shape anchored relative to other elements in chart drawings, including anchor points and contained graphical elements.
/// </summary>
[OpenXmlType(typeof(DXDCD.RelativeAnchorSize))]
[XmlRoot("RelativeAnchorSize", Namespace = "DocumentModel.Drawings.ChartDrawing")]
public class RelativeAnchorSize : ModelElement<DXDCD.RelativeAnchorSize>
{
 /// <summary>
 /// Starting anchor point for the shape within the drawing canvas.
 /// </summary>
 [OpenXmlElement(typeof(DXDCD.FromAnchor))]
 public FromAnchor? FromAnchor { get => _FromAnchor; set => UpdateField(ref _FromAnchor, value, nameof(FromAnchor)); }

 private FromAnchor? _FromAnchor;
 /// <summary>
 /// Ending anchor point for the shape within the drawing canvas.
 /// </summary>
 [OpenXmlElement(typeof(DXDCD.ToAnchor))]
 public ToAnchor? ToAnchor { get => _ToAnchor; set => UpdateField(ref _ToAnchor, value, nameof(ToAnchor)); }

 private ToAnchor? _ToAnchor;
 /// <summary>
 /// Shape element contained within the anchor.
 /// </summary>
 [OpenXmlElement(typeof(DXDCD.Shape))]
 public Shape? Shape { get => _Shape; set => UpdateField(ref _Shape, value, nameof(Shape)); }

 private Shape? _Shape;
 /// <summary>
 /// Group shape element contained within the anchor.
 /// </summary>
 [OpenXmlElement(typeof(DXDCD.GroupShape))]
 public GroupShape? GroupShape { get => _GroupShape; set => UpdateField(ref _GroupShape, value, nameof(GroupShape)); }

 private GroupShape? _GroupShape;
 /// <summary>
 /// Graphic frame element contained within the anchor.
 /// </summary>
 [OpenXmlElement(typeof(DXDCD.GraphicFrame))]
 public GraphicFrame? GraphicFrame { get => _GraphicFrame; set => UpdateField(ref _GraphicFrame, value, nameof(GraphicFrame)); }

 private GraphicFrame? _GraphicFrame;
 /// <summary>
 /// Connection shape element contained within the anchor.
 /// </summary>
 [OpenXmlElement(typeof(DXDCD.ConnectionShape))]
 public ConnectionShape? ConnectionShape { get => _ConnectionShape; set => UpdateField(ref _ConnectionShape, value, nameof(ConnectionShape)); }

 private ConnectionShape? _ConnectionShape;
 /// <summary>
 /// Picture element contained within the anchor.
 /// </summary>
 [OpenXmlElement(typeof(DXDCD.Picture))]
 public Picture? Picture { get => _Picture; set => UpdateField(ref _Picture, value, nameof(Picture)); }

 private Picture? _Picture;
}