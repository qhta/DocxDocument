namespace DocumentModel.Drawings;
/// <summary>
///   Represents a 2D transformation for grouped objects, including rotation, flipping, offset, extents, and child transformation settings.
/// </summary>
public partial class TransformGroup : ModelElement<DXD.TransformGroup>
{
    /// <summary>
    ///   Rotation angle for the group transformation.
    /// </summary>
    public Int32? Rotation { get => _Rotation; set => UpdateField(ref _Rotation, value, nameof(Rotation)); }

    private Int32? _Rotation;
    /// <summary>
    ///   Indicates whether the group is flipped horizontally.
    /// </summary>
    public bool? HorizontalFlip { get; set; }
    /// <summary>
    ///   Indicates whether the group is flipped vertically.
    /// </summary>
    public bool? VerticalFlip { get; set; }
    /// <summary>
    ///   Offset point for the group transformation.
    /// </summary>
    public Point2DType? Offset { get; set; }
    /// <summary>
    ///   Extents (width and height) for the group transformation.
    /// </summary>
    public PositiveSize2DType? Extents { get; set; }
    /// <summary>
    ///   Offset point for child elements within the group.
    /// </summary>
    public Point2DType? ChildOffset { get; set; }
    /// <summary>
    ///   Extents (width and height) for child elements within the group.
    /// </summary>
    public PositiveSize2DType? ChildExtents { get; set; }
}