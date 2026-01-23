namespace DocumentModel.Drawings;
/// <summary>
/// Represents an XY adjust handle, providing guides and limits for horizontal and vertical adjustments of a shape.
/// </summary>
public partial class AdjustHandleXY : ModelElement<DXD.AdjustHandleXY>
{
    /// <summary>
    /// Horizontal adjustment guide, which determines how the X coordinate is adjusted.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.AdjustHandleXY.XAdjustmentGuide))]
    public string? XAdjustmentGuide { get => _XAdjustmentGuide; set => UpdateField(ref _XAdjustmentGuide, value, nameof(XAdjustmentGuide)); }

    private string? _XAdjustmentGuide;
    /// <summary>
    /// Minimum allowed value for horizontal adjustment.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.AdjustHandleXY.MinX))]
    public string? MinX { get => _MinX; set => UpdateField(ref _MinX, value, nameof(MinX)); }

    private string? _MinX;
    /// <summary>
    /// Maximum allowed value for horizontal adjustment.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.AdjustHandleXY.MaxX))]
    public string? MaxX { get => _MaxX; set => UpdateField(ref _MaxX, value, nameof(MaxX)); }

    private string? _MaxX;
    /// <summary>
    /// Vertical adjustment guide, which determines how the Y coordinate is adjusted.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.AdjustHandleXY.YAdjustmentGuide))]
    public string? YAdjustmentGuide { get => _YAdjustmentGuide; set => UpdateField(ref _YAdjustmentGuide, value, nameof(YAdjustmentGuide)); }

    private string? _YAdjustmentGuide;
    /// <summary>
    /// Minimum allowed value for vertical adjustment.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.AdjustHandleXY.MinY))]
    public string? MinY { get => _MinY; set => UpdateField(ref _MinY, value, nameof(MinY)); }

    private string? _MinY;
    /// <summary>
    /// Maximum allowed value for vertical adjustment.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.AdjustHandleXY.MaxY))]
    public string? MaxY { get => _MaxY; set => UpdateField(ref _MaxY, value, nameof(MaxY)); }

    private string? _MaxY;
    /// <summary>
    /// Position of the adjust handle as a two-dimensional point.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.AdjustHandleXY.Position))]
    public AdjustPoint2DType? Position { get => _Position; set => UpdateField(ref _Position, value, nameof(Position)); }

    private AdjustPoint2DType? _Position;
}