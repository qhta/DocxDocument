namespace DocumentModel.Drawings;
/// <summary>
///   Represents a 2D point with X and Y coordinates.
/// </summary>
public partial class Point2DType : ModelElement<DXD.Point2DType>
{
    /// <summary>
    ///   X-axis coordinate of the point.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.Point2DType.X))]
    /// <summary>
    ///   X-axis coordinate of the point.
    /// </summary>
    [OpenXmlElement(typeof(DXD.Point2DType))]
    public Int64? X { get => _X; set => UpdateField(ref _X, value, nameof(X)); }

    private Int64? _X;
    /// <summary>
    ///   Y-axis coordinate of the point.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.Point2DType.Y))]
    /// <summary>
    ///   Y-axis coordinate of the point.
    /// </summary>
    [OpenXmlElement(typeof(DXD.Point2DType))]
    public Int64? Y { get => _Y; set => UpdateField(ref _Y, value, nameof(Y)); }

    private Int64? _Y;
}