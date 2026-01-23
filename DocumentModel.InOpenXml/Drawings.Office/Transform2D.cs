namespace DocumentModel.Drawings.Office;
/// <summary>
///   Defines the Transform2D Class.
/// </summary>
public partial class Transform2D : ModelElement<DXOD.Transform2D>
{
    /// <summary>
    ///   Rotation
    /// </summary>
    [OpenXmlProperty(nameof(DXOD.Transform2D.Rotation))]
    public Int32? Rotation { get => _Rotation; set => UpdateField(ref _Rotation, value, nameof(Rotation)); }

    private Int32? _Rotation;
    /// <summary>
    ///   Horizontal Flip
    /// </summary>
    [OpenXmlProperty(nameof(DXOD.Transform2D.HorizontalFlip))]
    public bool? HorizontalFlip { get => _HorizontalFlip; set => UpdateField(ref _HorizontalFlip, value, nameof(HorizontalFlip)); }

    private bool? _HorizontalFlip;
    /// <summary>
    ///   Vertical Flip
    /// </summary>
    [OpenXmlProperty(nameof(DXOD.Transform2D.VerticalFlip))]
    public bool? VerticalFlip { get => _VerticalFlip; set => UpdateField(ref _VerticalFlip, value, nameof(VerticalFlip)); }

    private bool? _VerticalFlip;
    /// <summary>
    ///   Offset.
    /// </summary>
    [OpenXmlProperty(nameof(DXOD.Transform2D.Offset))]
    public Point2DType? Offset { get => _Offset; set => UpdateField(ref _Offset, value, nameof(Offset)); }

    private Point2DType? _Offset;
    /// <summary>
    ///   Extents.
    /// </summary>
    [OpenXmlProperty(nameof(DXOD.Transform2D.Extents))]
    public PositiveSize2DType? Extents { get => _Extents; set => UpdateField(ref _Extents, value, nameof(Extents)); }

    private PositiveSize2DType? _Extents;
}