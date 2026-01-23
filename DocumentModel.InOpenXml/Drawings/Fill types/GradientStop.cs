namespace DocumentModel.Drawings;
/// <summary>
///   Gradient stops.
/// </summary>
public partial class GradientStop : ModelElement<DXD.GradientStop>
{
    /// <summary>
    ///   Position
    /// </summary>
    public Int32? Position { get => _Position; set => UpdateField(ref _Position, value, nameof(Position)); }

    private Int32? _Position;
    /// <summary>
    ///   RGB Color Model - Percentage Variant.
    /// </summary>
    public RgbColorModelPercentage? RgbColorModelPercentage { get => _RgbColorModelPercentage; set => UpdateField(ref _RgbColorModelPercentage, value, nameof(RgbColorModelPercentage)); }

    private RgbColorModelPercentage? _RgbColorModelPercentage;
    /// <summary>
    ///   RGB Color Model - Hex Variant.
    /// </summary>
    public RgbColorModelHex? RgbColorModelHex { get => _RgbColorModelHex; set => UpdateField(ref _RgbColorModelHex, value, nameof(RgbColorModelHex)); }

    private RgbColorModelHex? _RgbColorModelHex;
    /// <summary>
    ///   Hue, Saturation, Luminance Color Model.
    /// </summary>
    public HslColor? HslColor { get => _HslColor; set => UpdateField(ref _HslColor, value, nameof(HslColor)); }

    private HslColor? _HslColor;
    /// <summary>
    ///   System Color.
    /// </summary>
    public SystemColor? SystemColor { get => _SystemColor; set => UpdateField(ref _SystemColor, value, nameof(SystemColor)); }

    private SystemColor? _SystemColor;
    /// <summary>
    ///   Scheme Color.
    /// </summary>
    public SchemeColor? SchemeColor { get => _SchemeColor; set => UpdateField(ref _SchemeColor, value, nameof(SchemeColor)); }

    private SchemeColor? _SchemeColor;
    /// <summary>
    ///   Preset Color.
    /// </summary>
    public PresetColor? PresetColor { get => _PresetColor; set => UpdateField(ref _PresetColor, value, nameof(PresetColor)); }

    private PresetColor? _PresetColor;
}