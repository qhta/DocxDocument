namespace DocumentModel.Vml;
/// <summary>
///   Defines the Callout Class.
/// </summary>
public partial class Callout : ModelElement<DXVO.Callout>
{
    /// <summary>
    ///   VML Extension Handling Behavior
    /// </summary>
    [OpenXmlProperty(nameof(DXVO.Callout.Extension))]
    /// <summary>
    ///   VML Extension Handling Behavior
    /// </summary>
    [OpenXmlElement(typeof(DXVO.Callout))]
    public ExtensionHandlingBehaviorKind? Extension { get => _Extension; set => UpdateField(ref _Extension, value, nameof(Extension)); }

    private ExtensionHandlingBehaviorKind? _Extension;
    /// <summary>
    ///   Callout toggle
    /// </summary>
    [OpenXmlProperty(nameof(DXVO.Callout.On))]
    /// <summary>
    ///   Callout toggle
    /// </summary>
    [OpenXmlElement(typeof(DXVO.Callout))]
    public bool? On { get => _On; set => UpdateField(ref _On, value, nameof(On)); }

    private bool? _On;
    /// <summary>
    ///   Callout type
    /// </summary>
    [OpenXmlProperty(nameof(DXVO.Callout.Type))]
    /// <summary>
    ///   Callout type
    /// </summary>
    [OpenXmlElement(typeof(DXVO.Callout))]
    public string? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }

    private string? _Type;
    /// <summary>
    ///   Callout gap
    /// </summary>
    [OpenXmlProperty(nameof(DXVO.Callout.Gap))]
    /// <summary>
    ///   Callout gap
    /// </summary>
    [OpenXmlElement(typeof(DXVO.Callout))]
    public string? Gap { get => _Gap; set => UpdateField(ref _Gap, value, nameof(Gap)); }

    private string? _Gap;
    /// <summary>
    ///   Callout angle
    /// </summary>
    [OpenXmlProperty(nameof(DXVO.Callout.Angle))]
    /// <summary>
    ///   Callout angle
    /// </summary>
    [OpenXmlElement(typeof(DXVO.Callout))]
    public AngleKind? Angle { get => _Angle; set => UpdateField(ref _Angle, value, nameof(Angle)); }

    private AngleKind? _Angle;
    /// <summary>
    ///   Callout automatic drop toggle
    /// </summary>
    [OpenXmlProperty(nameof(DXVO.Callout.DropAuto))]
    /// <summary>
    ///   Callout automatic drop toggle
    /// </summary>
    [OpenXmlElement(typeof(DXVO.Callout))]
    public bool? DropAuto { get => _DropAuto; set => UpdateField(ref _DropAuto, value, nameof(DropAuto)); }

    private bool? _DropAuto;
    /// <summary>
    ///   Callout drop position
    /// </summary>
    [OpenXmlProperty(nameof(DXVO.Callout.Drop))]
    /// <summary>
    ///   Callout drop position
    /// </summary>
    [OpenXmlElement(typeof(DXVO.Callout))]
    public string? Drop { get => _Drop; set => UpdateField(ref _Drop, value, nameof(Drop)); }

    private string? _Drop;
    /// <summary>
    ///   Callout drop distance
    /// </summary>
    [OpenXmlProperty(nameof(DXVO.Callout.Distance))]
    /// <summary>
    ///   Callout drop distance
    /// </summary>
    [OpenXmlElement(typeof(DXVO.Callout))]
    public string? Distance { get => _Distance; set => UpdateField(ref _Distance, value, nameof(Distance)); }

    private string? _Distance;
    /// <summary>
    ///   Callout length toggle
    /// </summary>
    [OpenXmlElement(typeof(DXVO.Callout))]
    public bool? LengthSpec { get => _LengthSpec; set => UpdateField(ref _LengthSpec, value, nameof(LengthSpec)); }

    private bool? _LengthSpec;
    /// <summary>
    ///   Callout length
    /// </summary>
    [OpenXmlProperty(nameof(DXVO.Callout.Length))]
    /// <summary>
    ///   Callout length
    /// </summary>
    [OpenXmlElement(typeof(DXVO.Callout))]
    public string? Length { get => _Length; set => UpdateField(ref _Length, value, nameof(Length)); }

    private string? _Length;
    /// <summary>
    ///   Callout accent bar toggle
    /// </summary>
    [OpenXmlProperty(nameof(DXVO.Callout.AccentBar))]
    /// <summary>
    ///   Callout accent bar toggle
    /// </summary>
    [OpenXmlElement(typeof(DXVO.Callout))]
    public bool? AccentBar { get => _AccentBar; set => UpdateField(ref _AccentBar, value, nameof(AccentBar)); }

    private bool? _AccentBar;
    /// <summary>
    ///   Callout text border toggle
    /// </summary>
    [OpenXmlProperty(nameof(DXVO.Callout.TextBorder))]
    /// <summary>
    ///   Callout text border toggle
    /// </summary>
    [OpenXmlElement(typeof(DXVO.Callout))]
    public bool? TextBorder { get => _TextBorder; set => UpdateField(ref _TextBorder, value, nameof(TextBorder)); }

    private bool? _TextBorder;
    /// <summary>
    ///   Callout flip x
    /// </summary>
    [OpenXmlProperty(nameof(DXVO.Callout.MinusX))]
    /// <summary>
    ///   Callout flip x
    /// </summary>
    [OpenXmlElement(typeof(DXVO.Callout))]
    public bool? MinusX { get => _MinusX; set => UpdateField(ref _MinusX, value, nameof(MinusX)); }

    private bool? _MinusX;
    /// <summary>
    ///   Callout flip y
    /// </summary>
    [OpenXmlProperty(nameof(DXVO.Callout.MinusY))]
    /// <summary>
    ///   Callout flip y
    /// </summary>
    [OpenXmlElement(typeof(DXVO.Callout))]
    public bool? MinusY { get => _MinusY; set => UpdateField(ref _MinusY, value, nameof(MinusY)); }

    private bool? _MinusY;
}