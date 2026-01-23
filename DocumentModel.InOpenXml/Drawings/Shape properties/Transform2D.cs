namespace DocumentModel.Drawings;
/// <summary>
///   Represents a 2D transformation, including rotation, flipping, offset, and extents for a drawing element.
/// </summary>
public partial class Transform2D : ModelElement<DXD.Transform2D>
{
    /// <summary>
    ///   Rotation angle for the transformation.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.Transform2D.Rotation))]
    public Int32? Rotation { get => _Rotation; set => UpdateField(ref _Rotation, value, nameof(Rotation)); }

    private Int32? _Rotation;
    /// <summary>
    ///   Indicates whether the element is flipped horizontally.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.Transform2D.HorizontalFlip))]
    public bool? HorizontalFlip { get => _HorizontalFlip; set => UpdateField(ref _HorizontalFlip, value, nameof(HorizontalFlip)); }

    private bool? _HorizontalFlip;
    /// <summary>
    ///   Indicates whether the element is flipped vertically.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.Transform2D.VerticalFlip))]
    public bool? VerticalFlip { get => _VerticalFlip; set => UpdateField(ref _VerticalFlip, value, nameof(VerticalFlip)); }

    private bool? _VerticalFlip;
    /// <summary>
    ///   Offset point for the transformation.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.Transform2D.Offset))]
    public Point2DType? Offset { get => _Offset; set => UpdateField(ref _Offset, value, nameof(Offset)); }

    private Point2DType? _Offset;
    /// <summary>
    ///   Extents (width and height) for the transformation.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.Transform2D.Extents))]
    public PositiveSize2DType? Extents { get => _Extents; set => UpdateField(ref _Extents, value, nameof(Extents)); }

    private PositiveSize2DType? _Extents;
}