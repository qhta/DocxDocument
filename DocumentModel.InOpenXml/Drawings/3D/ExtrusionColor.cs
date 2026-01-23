namespace DocumentModel.Drawings;
/// <summary>
///   Represents the color used for the extrusion of a 3D object, supporting multiple color models.
/// </summary>
public partial class ExtrusionColor : ModelElement<DXD.ExtrusionColor>
{
    /// <summary>
    ///   Extrusion color specified using the RGB color model with percentage values.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ExtrusionColor.RgbColorModelPercentage))]
    public RgbColorModelPercentage? RgbColorModelPercentage { get => _RgbColorModelPercentage; set => UpdateField(ref _RgbColorModelPercentage, value, nameof(RgbColorModelPercentage)); }

    private RgbColorModelPercentage? _RgbColorModelPercentage;
    /// <summary>
    ///   Extrusion color specified using the RGB color model with hexadecimal values.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ExtrusionColor.RgbColorModelHex))]
    public RgbColorModelHex? RgbColorModelHex { get => _RgbColorModelHex; set => UpdateField(ref _RgbColorModelHex, value, nameof(RgbColorModelHex)); }

    private RgbColorModelHex? _RgbColorModelHex;
    /// <summary>
    ///   Extrusion color specified using the hue, saturation, luminance (HSL) color model.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ExtrusionColor.HslColor))]
    public HslColor? HslColor { get => _HslColor; set => UpdateField(ref _HslColor, value, nameof(HslColor)); }

    private HslColor? _HslColor;
    /// <summary>
    ///   Extrusion color specified using a system-defined color.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ExtrusionColor.SystemColor))]
    public SystemColor? SystemColor { get => _SystemColor; set => UpdateField(ref _SystemColor, value, nameof(SystemColor)); }

    private SystemColor? _SystemColor;
    /// <summary>
    ///   Extrusion color specified using a color scheme.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ExtrusionColor.SchemeColor))]
    public SchemeColor? SchemeColor { get => _SchemeColor; set => UpdateField(ref _SchemeColor, value, nameof(SchemeColor)); }

    private SchemeColor? _SchemeColor;
    /// <summary>
    ///   Extrusion color specified using a preset color.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ExtrusionColor.PresetColor))]
    public PresetColor? PresetColor { get => _PresetColor; set => UpdateField(ref _PresetColor, value, nameof(PresetColor)); }

    private PresetColor? _PresetColor;
}