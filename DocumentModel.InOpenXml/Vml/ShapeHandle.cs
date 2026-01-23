namespace DocumentModel.Vml;
/// <summary>
///   Shape Handle.
/// </summary>
public partial class ShapeHandle : ModelElement<DXV.ShapeHandle>
{
    /// <summary>
    ///   Handle Position
    /// </summary>
    public string? Position { get => _Position; set => UpdateField(ref _Position, value, nameof(Position)); }

    private string? _Position;
    /// <summary>
    ///   Handle Polar Center
    /// </summary>
    public string? Polar { get => _Polar; set => UpdateField(ref _Polar, value, nameof(Polar)); }

    private string? _Polar;
    /// <summary>
    ///   Handle Coordinate Mapping
    /// </summary>
    public string? Map { get => _Map; set => UpdateField(ref _Map, value, nameof(Map)); }

    private string? _Map;
    /// <summary>
    ///   Invert Handle's X Position
    /// </summary>
    public bool? InvertX { get => _InvertX; set => UpdateField(ref _InvertX, value, nameof(InvertX)); }

    private bool? _InvertX;
    /// <summary>
    ///   Invert Handle's Y Position
    /// </summary>
    public bool? InvertY { get => _InvertY; set => UpdateField(ref _InvertY, value, nameof(InvertY)); }

    private bool? _InvertY;
    /// <summary>
    ///   Handle Inversion Toggle
    /// </summary>
    public bool? Switch { get => _Switch; set => UpdateField(ref _Switch, value, nameof(Switch)); }

    private bool? _Switch;
    /// <summary>
    ///   Handle X Position Range
    /// </summary>
    public string? XRange { get => _XRange; set => UpdateField(ref _XRange, value, nameof(XRange)); }

    private string? _XRange;
    /// <summary>
    ///   Handle Y Position Range
    /// </summary>
    public string? YRange { get => _YRange; set => UpdateField(ref _YRange, value, nameof(YRange)); }

    private string? _YRange;
    /// <summary>
    ///   Handle Polar Radius Range
    /// </summary>
    public string? RadiusRange { get => _RadiusRange; set => UpdateField(ref _RadiusRange, value, nameof(RadiusRange)); }

    private string? _RadiusRange;
}