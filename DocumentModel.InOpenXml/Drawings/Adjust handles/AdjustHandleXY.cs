namespace DocumentModel.Drawings;
/// <summary>
/// Represents an XY adjust handle, providing guides and limits for horizontal and vertical adjustments of a shape.
/// </summary>
public partial class AdjustHandleXY : ModelElement<DXD.AdjustHandleXY>
{
    /// <summary>
    /// Horizontal adjustment guide, which determines how the X coordinate is adjusted.
    /// </summary>
    public string? XAdjustmentGuide { get => _XAdjustmentGuide; set => UpdateField(ref _XAdjustmentGuide, value, nameof(XAdjustmentGuide)); }

    private string? _XAdjustmentGuide;
    /// <summary>
    /// Minimum allowed value for horizontal adjustment.
    /// </summary>
    public string? MinX { get; set; }
    /// <summary>
    /// Maximum allowed value for horizontal adjustment.
    /// </summary>
    public string? MaxX { get; set; }
    /// <summary>
    /// Vertical adjustment guide, which determines how the Y coordinate is adjusted.
    /// </summary>
    public string? YAdjustmentGuide { get; set; }
    /// <summary>
    /// Minimum allowed value for vertical adjustment.
    /// </summary>
    public string? MinY { get; set; }
    /// <summary>
    /// Maximum allowed value for vertical adjustment.
    /// </summary>
    public string? MaxY { get; set; }
    /// <summary>
    /// Position of the adjust handle as a two-dimensional point.
    /// </summary>
    public AdjustPoint2DType? Position { get; set; }
}