namespace DocumentModel.Drawings.ChartDrawing;
/// <summary>
/// Describes the transformation properties for a graphic frame in chart drawing, including rotation, flipping, offset, and extents for precise visual positioning and scaling.
/// </summary>
[OpenXmlType(typeof(DXDCD.Transform))]
[DataContract]
[XmlRoot("Transform", Namespace = "DocumentModel.Drawings.ChartDrawing")]
public partial class Transform : ModelElement<DXDCD.Transform>
{
  /// <summary>
  /// Rotation angle in degrees.
  /// </summary>
  [OpenXmlProperty(nameof(DXDCD.Transform.Rotation))]
  public Int32? Rotation { get => _Rotation; set => UpdateField(ref _Rotation, value, nameof(Rotation)); }

  private Int32? _Rotation;
  /// <summary>
  /// Indicates horizontal flip transformation.
  /// </summary>
  [OpenXmlProperty(nameof(DXDCD.Transform.HorizontalFlip))]
  public bool? HorizontalFlip { get => _HorizontalFlip; set => UpdateField(ref _HorizontalFlip, value, nameof(HorizontalFlip)); }

  private bool? _HorizontalFlip;
  /// <summary>
  /// Indicates vertical flip transformation.
  /// </summary>
  [OpenXmlProperty(nameof(DXDCD.Transform.VerticalFlip))]
  public bool? VerticalFlip { get => _VerticalFlip; set => UpdateField(ref _VerticalFlip, value, nameof(VerticalFlip)); }

  private bool? _VerticalFlip;
  /// <summary>
  /// Offset point specifying the position of the graphic frame.
  /// </summary>
  [OpenXmlProperty(nameof(DXDCD.Transform.Offset))]
  public Point2DType? Offset { get => _Offset; set => UpdateField(ref _Offset, value, nameof(Offset)); }

  private Point2DType? _Offset;
  /// <summary>
  /// Extents specifying the size of the graphic frame.
  /// </summary>
  [OpenXmlProperty(nameof(DXDCD.Transform.Extents))]
  public PositiveSize2DType? Extents { get => _Extents; set => UpdateField(ref _Extents, value, nameof(Extents)); }

  private PositiveSize2DType? _Extents;
}