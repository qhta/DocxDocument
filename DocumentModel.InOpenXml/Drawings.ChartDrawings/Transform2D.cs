namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the Transform2D Class.
/// </summary>
[OpenXmlType(typeof(DXO10DCD.Transform2D))]
[DataContract]
[XmlRoot("Transform2D", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public partial class Transform2D: ModelElement<DXO10DCD.Transform2D>
{
  /// <summary>
  /// Specifies the rotation.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10DCD.Transform2D.Rotation))]
  public Int32? Rotation
  {
    get => _Rotation ??= GetProperty<Int32?>(GetUpdatableElement()?.Rotation);
    set => UpdateField(ref _Rotation, value, nameof(Rotation));
  }

  private Int32? _Rotation;

  /// <summary>
  /// Specifies the horizontal flip.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10DCD.Transform2D.HorizontalFlip))]
  public bool? HorizontalFlip
  {
    get => _HorizontalFlip ??= GetProperty<bool?>(GetUpdatableElement()?.HorizontalFlip);
    set => UpdateField(ref _HorizontalFlip, value, nameof(HorizontalFlip));
  }

  private bool? _HorizontalFlip;

  /// <summary>
  /// Specifies the vertical flip.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10DCD.Transform2D.VerticalFlip))]
  public bool? VerticalFlip
  {
    get => _VerticalFlip ??= GetProperty<bool?>(GetUpdatableElement()?.VerticalFlip);
    set => UpdateField(ref _VerticalFlip, value, nameof(VerticalFlip));
  }

  private bool? _VerticalFlip;

  /// <summary>
  /// Specifies the offset.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10DCD.Transform2D.Offset))]
  public Point2DType? Offset
  {
    get => _Offset ??= GetProperty<Point2DType?>(GetUpdatableElement()?.Offset);
    set => UpdateField(ref _Offset, value, nameof(Offset));
  }

  private Point2DType? _Offset;

  /// <summary>
  /// Specifies the extents.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10DCD.Transform2D.Extents))]
  public PositiveSize2DType? Extents
  {
    get => _Extents ??= GetProperty<PositiveSize2DType?>(GetUpdatableElement()?.Extents);
    set => UpdateField(ref _Extents, value, nameof(Extents));
  }

  private PositiveSize2DType? _Extents;
}