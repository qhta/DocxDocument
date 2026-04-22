namespace DocumentModel.Drawings.ChartDrawing;
/// <summary>
/// Describes the size and positioning of a shape anchored absolutely within a chart drawing, including anchor points, extent, and contained graphical elements.
/// </summary>
[OpenXmlType(typeof(DXDCD.AbsoluteAnchorSize))]
[XmlRoot("AbsoluteAnchorSize", Namespace = "DocumentModel.Drawings.ChartDrawing")]
public partial class AbsoluteAnchorSize : ModelElement<DXDCD.AbsoluteAnchorSize>
{
  /// <summary>
  /// Starting anchor point for the shape within the drawing canvas.
  /// </summary>
  [OpenXmlElement(typeof(DXDCD.FromAnchor))]
  public FromAnchor? FromAnchor { get => _FromAnchor; set => UpdateField(ref _FromAnchor, value, nameof(FromAnchor)); }

  private FromAnchor? _FromAnchor;
  /// <summary>
  /// Extent specifying the width and height of the anchored shape.
  /// </summary>
  [OpenXmlElement(typeof(DXDCD.Extent))]
  public Extent? Extent { get => _Extent; set => UpdateField(ref _Extent, value, nameof(Extent)); }

  private Extent? _Extent;
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