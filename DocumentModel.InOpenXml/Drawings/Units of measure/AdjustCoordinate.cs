namespace DocumentModel.Drawings;
/// <summary>
/// Specifies a position coordinate within the shape bounding box.
/// It should be noted that this coordinate is placed within the shape bounding box using the transform coordinate system
/// which is also called the shape coordinate system, as it encompasses the entire shape.
/// The width and height for this coordinate system are specified within the ext transform element.
/// </summary>
/// <remarks>
/// When specifying a point coordinate in path coordinate space it should be noted that the top left of the coordinate space is x=0, y=0
/// and the coordinate points for x grow to the right and for y grow down.
/// </remarks>
public partial class AdjustCoordinate : ModelElement
{
    /// <summary>
    ///   Value of the coordinate within the shape bounding box.
    /// </summary>
    public Int32? Value { get => _Value; set => UpdateField(ref _Value, value, nameof(Value)); }

    private Int32? _Value;
}