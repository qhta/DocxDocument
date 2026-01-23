using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents a 2D transformation applied to a drawing element in a Wordprocessing document.
/// This class provides properties for configuring rotation, flipping, offset, and extents, enabling advanced positioning and sizing of graphical objects.
/// </summary>
public partial class Transform2D : ModelElement
{
    /// <summary>
    /// The rotation angle applied to the drawing element, specified in degrees.
    /// </summary>
    public Int32? Rotation { get => _Rotation; set => UpdateField(ref _Rotation, value, nameof(Rotation)); }

    private Int32? _Rotation;
    /// <summary>
    /// Indicates whether the drawing element is flipped horizontally.
    /// </summary>
    public bool? HorizontalFlip { get => _HorizontalFlip; set => UpdateField(ref _HorizontalFlip, value, nameof(HorizontalFlip)); }

    private bool? _HorizontalFlip;
    /// <summary>
    /// Indicates whether the drawing element is flipped vertically.
    /// </summary>
    public bool? VerticalFlip { get => _VerticalFlip; set => UpdateField(ref _VerticalFlip, value, nameof(VerticalFlip)); }

    private bool? _VerticalFlip;
    /// <summary>
    /// The offset position of the drawing element, specifying the x and y coordinates relative to the parent container.
    /// </summary>
    public Point2DType? Offset { get => _Offset; set => UpdateField(ref _Offset, value, nameof(Offset)); }

    private Point2DType? _Offset;
    /// <summary>
    /// The extents of the drawing element, specifying the width and height.
    /// </summary>
    public PositiveSize2DType? Extents { get => _Extents; set => UpdateField(ref _Extents, value, nameof(Extents)); }

    private PositiveSize2DType? _Extents;
}