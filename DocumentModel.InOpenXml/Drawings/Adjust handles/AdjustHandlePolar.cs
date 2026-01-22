namespace DocumentModel.Drawings;
/// <summary>
/// Represents a polar adjust handle, providing guides and limits for radial and angular adjustments of a shape.
/// </summary>
public partial class AdjustHandlePolar : ModelElement<DXD.AdjustHandlePolar>
{
    /// <summary>
    /// Radial adjustment guide, which determines how the radial distance is adjusted.
    /// </summary>
    public string? RadialAdjustmentGuide { get => _RadialAdjustmentGuide; set => UpdateField(ref _RadialAdjustmentGuide, value, nameof(RadialAdjustmentGuide)); }

    private string? _RadialAdjustmentGuide;
    /// <summary>
    /// Minimum allowed value for radial adjustment.
    /// </summary>
    public string? MinRadial { get; set; }
    /// <summary>
    /// Maximum allowed value for radial adjustment.
    /// </summary>
    public string? MaxRadial { get; set; }
    /// <summary>
    /// Angle adjustment guide, which determines how the angle is adjusted.
    /// </summary>
    public string? AngleAdjustmentGuide { get; set; }
    /// <summary>
    /// Minimum allowed value for angle adjustment.
    /// </summary>
    public string? MinAngle { get; set; }
    /// <summary>
    /// Maximum allowed value for angle adjustment.
    /// </summary>
    public string? MaxAngle { get; set; }
    /// <summary>
    /// Position of the adjust handle as a two-dimensional coordinate.
    /// </summary>
    public AdjustPoint2DType? Position { get; set; }
}