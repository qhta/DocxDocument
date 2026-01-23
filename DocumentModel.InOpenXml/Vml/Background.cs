namespace DocumentModel.Vml;
/// <summary>
///   Document Background.
/// </summary>
public partial class Background : ModelElement<DXV.Background>
{
    /// <summary>
    ///   Unique Identifier
    /// </summary>
    public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

    private string? _Id;
    /// <summary>
    ///   Shape Fill Toggle
    /// </summary>
    public bool? Filled { get => _Filled; set => UpdateField(ref _Filled, value, nameof(Filled)); }

    private bool? _Filled;
    /// <summary>
    ///   Fill Color
    /// </summary>
    public string? Fillcolor { get => _Fillcolor; set => UpdateField(ref _Fillcolor, value, nameof(Fillcolor)); }

    private string? _Fillcolor;
    /// <summary>
    ///   Black-and-White Mode
    /// </summary>
    public BlackAndWhiteMode? BlackWhiteMode { get => _BlackWhiteMode; set => UpdateField(ref _BlackWhiteMode, value, nameof(BlackWhiteMode)); }

    private BlackAndWhiteMode? _BlackWhiteMode;
    /// <summary>
    ///   Pure Black-and-White Mode
    /// </summary>
    public BlackAndWhiteMode? PureBlackWhiteMode { get => _PureBlackWhiteMode; set => UpdateField(ref _PureBlackWhiteMode, value, nameof(PureBlackWhiteMode)); }

    private BlackAndWhiteMode? _PureBlackWhiteMode;
    /// <summary>
    ///   Normal Black-and-White Mode
    /// </summary>
    public BlackAndWhiteMode? NormalBlackWhiteMode { get => _NormalBlackWhiteMode; set => UpdateField(ref _NormalBlackWhiteMode, value, nameof(NormalBlackWhiteMode)); }

    private BlackAndWhiteMode? _NormalBlackWhiteMode;
    /// <summary>
    ///   Target Screen Size
    /// </summary>
    public ScreenSizeKind? TargetScreenSize { get => _TargetScreenSize; set => UpdateField(ref _TargetScreenSize, value, nameof(TargetScreenSize)); }

    private ScreenSizeKind? _TargetScreenSize;
    /// <summary>
    ///   Fill.
    /// </summary>
    public DMD.Fill? Fill { get => _Fill; set => UpdateField(ref _Fill, value, nameof(Fill)); }

    private DMD.Fill? _Fill;
}