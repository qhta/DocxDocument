namespace DocumentModel.Vml;
/// <summary>
///   Defines the Callout Class.
/// </summary>
public partial class Callout : ModelElement<DXVO.Callout>
{
    /// <summary>
    ///   VML Extension Handling Behavior
    /// </summary>
    public ExtensionHandlingBehaviorKind? Extension { get => _Extension; set => UpdateField(ref _Extension, value, nameof(Extension)); }

    private ExtensionHandlingBehaviorKind? _Extension;
    /// <summary>
    ///   Callout toggle
    /// </summary>
    public bool? On { get => _On; set => UpdateField(ref _On, value, nameof(On)); }

    private bool? _On;
    /// <summary>
    ///   Callout type
    /// </summary>
    public string? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }

    private string? _Type;
    /// <summary>
    ///   Callout gap
    /// </summary>
    public string? Gap { get => _Gap; set => UpdateField(ref _Gap, value, nameof(Gap)); }

    private string? _Gap;
    /// <summary>
    ///   Callout angle
    /// </summary>
    public AngleKind? Angle { get => _Angle; set => UpdateField(ref _Angle, value, nameof(Angle)); }

    private AngleKind? _Angle;
    /// <summary>
    ///   Callout automatic drop toggle
    /// </summary>
    public bool? DropAuto { get => _DropAuto; set => UpdateField(ref _DropAuto, value, nameof(DropAuto)); }

    private bool? _DropAuto;
    /// <summary>
    ///   Callout drop position
    /// </summary>
    public string? Drop { get => _Drop; set => UpdateField(ref _Drop, value, nameof(Drop)); }

    private string? _Drop;
    /// <summary>
    ///   Callout drop distance
    /// </summary>
    public string? Distance { get => _Distance; set => UpdateField(ref _Distance, value, nameof(Distance)); }

    private string? _Distance;
    /// <summary>
    ///   Callout length toggle
    /// </summary>
    public bool? LengthSpec { get => _LengthSpec; set => UpdateField(ref _LengthSpec, value, nameof(LengthSpec)); }

    private bool? _LengthSpec;
    /// <summary>
    ///   Callout length
    /// </summary>
    public string? Length { get => _Length; set => UpdateField(ref _Length, value, nameof(Length)); }

    private string? _Length;
    /// <summary>
    ///   Callout accent bar toggle
    /// </summary>
    public bool? AccentBar { get => _AccentBar; set => UpdateField(ref _AccentBar, value, nameof(AccentBar)); }

    private bool? _AccentBar;
    /// <summary>
    ///   Callout text border toggle
    /// </summary>
    public bool? TextBorder { get => _TextBorder; set => UpdateField(ref _TextBorder, value, nameof(TextBorder)); }

    private bool? _TextBorder;
    /// <summary>
    ///   Callout flip x
    /// </summary>
    public bool? MinusX { get => _MinusX; set => UpdateField(ref _MinusX, value, nameof(MinusX)); }

    private bool? _MinusX;
    /// <summary>
    ///   Callout flip y
    /// </summary>
    public bool? MinusY { get => _MinusY; set => UpdateField(ref _MinusY, value, nameof(MinusY)); }

    private bool? _MinusY;
}