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
    public string? MinRadial { get => _MinRadial; set => UpdateField(ref _MinRadial, value, nameof(MinRadial)); }

    private string? _MinRadial;
    /// <summary>
    /// Maximum allowed value for radial adjustment.
    /// </summary>
    public string? MaxRadial { get => _MaxRadial; set => UpdateField(ref _MaxRadial, value, nameof(MaxRadial)); }

    private string? _MaxRadial;
    /// <summary>
    /// Angle adjustment guide, which determines how the angle is adjusted.
    /// </summary>
    public string? AngleAdjustmentGuide { get => _AngleAdjustmentGuide; set => UpdateField(ref _AngleAdjustmentGuide, value, nameof(AngleAdjustmentGuide)); }

    private string? _AngleAdjustmentGuide;
    /// <summary>
    /// Minimum allowed value for angle adjustment.
    /// </summary>
    public string? MinAngle { get => _MinAngle; set => UpdateField(ref _MinAngle, value, nameof(MinAngle)); }

    private string? _MinAngle;
    /// <summary>
    /// Maximum allowed value for angle adjustment.
    /// </summary>
    public string? MaxAngle { get => _MaxAngle; set => UpdateField(ref _MaxAngle, value, nameof(MaxAngle)); }

    private string? _MaxAngle;
    /// <summary>
    /// Position of the adjust handle as a two-dimensional coordinate.
    /// </summary>
    public AdjustPoint2DType? Position { get => _Position; set => UpdateField(ref _Position, value, nameof(Position)); }

    private AdjustPoint2DType? _Position;
}