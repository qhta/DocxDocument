namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the Transform2D Class.
/// </summary>
[OpenXmlType(typeof(DXO10DCD.Transform2D))]
public class Transform2D: ModelElement<DXO10DCD.Transform2D>
{
  /// <summary>
  /// Specifies the rotation.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10DCD.Transform2D.Rotation))]
  public Int32? Rotation { get => _Rotation; set => UpdateField(ref _Rotation, value, nameof(Rotation)); }

  private Int32? _Rotation;

  /// <summary>
  /// Specifies the horizontal flip.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10DCD.Transform2D.HorizontalFlip))]
  public bool? HorizontalFlip
  {
    get => _HorizontalFlip;
    set => UpdateField(ref _HorizontalFlip, value, nameof(HorizontalFlip));
  }

  private bool? _HorizontalFlip;

  /// <summary>
  /// Specifies the vertical flip.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10DCD.Transform2D.VerticalFlip))]
  public bool? VerticalFlip
  {
    get => _VerticalFlip;
    set => UpdateField(ref _VerticalFlip, value, nameof(VerticalFlip));
  }

  private bool? _VerticalFlip;

  /// <summary>
  /// Specifies the offset.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10DCD.Transform2D.Offset))]
  public Point2DType? Offset { get => _Offset; set => UpdateField(ref _Offset, value, nameof(Offset)); }

  private Point2DType? _Offset;

  /// <summary>
  /// Specifies the extents.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10DCD.Transform2D.Extents))]
  public PositiveSize2DType? Extents { get => _Extents; set => UpdateField(ref _Extents, value, nameof(Extents)); }

  private PositiveSize2DType? _Extents;
}