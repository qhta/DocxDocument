namespace DocumentModel.Drawings;
/// <summary>
///   Represents a 2D transformation, including rotation, flipping, offset, and extents for a drawing element.
/// </summary>
public partial class Transform2D : ModelElement<DXD.Transform2D>
{
    /// <summary>
    ///   Rotation angle for the transformation.
    /// </summary>
    public Int32? Rotation { get => _Rotation; set => UpdateField(ref _Rotation, value, nameof(Rotation)); }

    private Int32? _Rotation;
    /// <summary>
    ///   Indicates whether the element is flipped horizontally.
    /// </summary>
    public bool? HorizontalFlip { get; set; }
    /// <summary>
    ///   Indicates whether the element is flipped vertically.
    /// </summary>
    public bool? VerticalFlip { get; set; }
    /// <summary>
    ///   Offset point for the transformation.
    /// </summary>
    public Point2DType? Offset { get; set; }
    /// <summary>
    ///   Extents (width and height) for the transformation.
    /// </summary>
    public PositiveSize2DType? Extents { get; set; }
}