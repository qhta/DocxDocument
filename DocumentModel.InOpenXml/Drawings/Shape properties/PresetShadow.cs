namespace DocumentModel.Drawings;
/// <summary>
///   Represents a preset shadow effect, including type, distance, direction, and color options.
/// </summary>
public partial class PresetShadow : ModelElement<DXD.PresetShadow>
{
    /// <summary>
    ///   Preset shadow type.
    /// </summary>
    public PresetShadowKind? Preset { get => _Preset; set => UpdateField(ref _Preset, value, nameof(Preset)); }

    private PresetShadowKind? _Preset;
    /// <summary>
    ///   Distance to offset the shadow from the object.
    /// </summary>
    public Int64? Distance { get; set; }
    /// <summary>
    ///   Direction angle of the shadow.
    /// </summary>
    public Int32? Direction { get; set; }
    /// <summary>
    ///   Shadow color specified using the RGB color model with percentage values.
    /// </summary>
    public RgbColorModelPercentage? RgbColorModelPercentage { get; set; }
    /// <summary>
    ///   Shadow color specified using the RGB color model with hexadecimal values.
    /// </summary>
    public RgbColorModelHex? RgbColorModelHex { get; set; }
    /// <summary>
    ///   Shadow color specified using the hue, saturation, luminance (HSL) color model.
    /// </summary>
    public HslColor? HslColor { get; set; }
    /// <summary>
    ///   Shadow color specified using a system-defined color.
    /// </summary>
    public SystemColor? SystemColor { get; set; }
    /// <summary>
    ///   Shadow color specified using a color scheme.
    /// </summary>
    public SchemeColor? SchemeColor { get; set; }
    /// <summary>
    ///   Shadow color specified using a preset color.
    /// </summary>
    public PresetColor? PresetColor { get; set; }
}