namespace DocumentModel.Drawings;
/// <summary>
/// Represents a two-dimensional adjustment point with X and Y coordinates, used for shape geometry manipulation.
/// </summary>
public partial class AdjustPoint2DType : ModelElement<DXD.AdjustPoint2DType>
{
    /// <summary>
    /// X-coordinate of the adjustment point.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.AdjustPoint2DType.X))]
    /// <summary>
    /// X-coordinate of the adjustment point.
    /// </summary>
    [OpenXmlElement(typeof(DXD.AdjustPoint2DType))]
    public AdjustCoordinate? X { get => _X; set => UpdateField(ref _X, value, nameof(X)); }

    private AdjustCoordinate? _X;
    /// <summary>
    /// Y-coordinate of the adjustment point.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.AdjustPoint2DType.Y))]
    /// <summary>
    /// Y-coordinate of the adjustment point.
    /// </summary>
    [OpenXmlElement(typeof(DXD.AdjustPoint2DType))]
    public AdjustCoordinate? Y { get => _Y; set => UpdateField(ref _Y, value, nameof(Y)); }

    private AdjustCoordinate? _Y;
}