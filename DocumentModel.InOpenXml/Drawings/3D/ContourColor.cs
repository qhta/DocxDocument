namespace DocumentModel.Drawings;
/// <summary>
///   Represents the color used for the contour of a 3D object, supporting multiple color models.
/// </summary>
public partial class ContourColor : ModelElement<DXD.ContourColor>
{
    /// <summary>
    ///   Color specified using the RGB color model with percentage values.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ContourColor.RgbColorModelPercentage))]
    /// <summary>
    ///   Color specified using the RGB color model with percentage values.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ContourColor))]
    public RgbColorModelPercentage? RgbColorModelPercentage { get => _RgbColorModelPercentage; set => UpdateField(ref _RgbColorModelPercentage, value, nameof(RgbColorModelPercentage)); }

    private RgbColorModelPercentage? _RgbColorModelPercentage;
    /// <summary>
    ///   Color specified using the RGB color model with hexadecimal values.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ContourColor.RgbColorModelHex))]
    /// <summary>
    ///   Color specified using the RGB color model with hexadecimal values.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ContourColor))]
    public RgbColorModelHex? RgbColorModelHex { get => _RgbColorModelHex; set => UpdateField(ref _RgbColorModelHex, value, nameof(RgbColorModelHex)); }

    private RgbColorModelHex? _RgbColorModelHex;
    /// <summary>
    ///   Color specified using the Hue, Saturation, Luminance (HSL) color model.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ContourColor.HslColor))]
    /// <summary>
    ///   Color specified using the Hue, Saturation, Luminance (HSL) color model.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ContourColor))]
    public HslColor? HslColor { get => _HslColor; set => UpdateField(ref _HslColor, value, nameof(HslColor)); }

    private HslColor? _HslColor;
    /// <summary>
    ///   Color specified using a system-defined color.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ContourColor.SystemColor))]
    /// <summary>
    ///   Color specified using a system-defined color.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ContourColor))]
    public SystemColor? SystemColor { get => _SystemColor; set => UpdateField(ref _SystemColor, value, nameof(SystemColor)); }

    private SystemColor? _SystemColor;
    /// <summary>
    ///   Color specified using a color scheme.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ContourColor.SchemeColor))]
    /// <summary>
    ///   Color specified using a color scheme.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ContourColor))]
    public SchemeColor? SchemeColor { get => _SchemeColor; set => UpdateField(ref _SchemeColor, value, nameof(SchemeColor)); }

    private SchemeColor? _SchemeColor;
    /// <summary>
    ///   Color specified using a preset color.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ContourColor.PresetColor))]
    /// <summary>
    ///   Color specified using a preset color.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ContourColor))]
    public PresetColor? PresetColor { get => _PresetColor; set => UpdateField(ref _PresetColor, value, nameof(PresetColor)); }

    private PresetColor? _PresetColor;
}