namespace DocumentModel.Drawings;
/// <summary>
///   Represents a command to draw a straight line to a specified point.
/// </summary>
public partial class LineTo : ModelElement<DXD.LineTo>
{
    /// <summary>
    ///   End point of the line.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.LineTo.Point))]
    public AdjustPoint2DType? Point { get => _Point; set => UpdateField(ref _Point, value, nameof(Point)); }

    private AdjustPoint2DType? _Point;
}