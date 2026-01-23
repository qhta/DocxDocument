namespace DocumentModel.Drawings;
/// <summary>
/// Defines the color replacement effect for drawing elements.
/// </summary>
public partial class ColorReplacement : ModelElement<DXD.ColorReplacement>, IExtendableElement
{
    /// <summary>
    /// RGB color model - percentage variant.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorReplacement.RgbColorModelPercentage))]
    /// <summary>
    /// RGB color model - percentage variant.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ColorReplacement))]
    public RgbColorModelPercentage? RgbColorModelPercentage { get => _RgbColorModelPercentage; set => UpdateField(ref _RgbColorModelPercentage, value, nameof(RgbColorModelPercentage)); }

    private RgbColorModelPercentage? _RgbColorModelPercentage;
    /// <summary>
    /// RGB color model - hex variant.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorReplacement.RgbColorModelHex))]
    /// <summary>
    /// RGB color model - hex variant.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ColorReplacement))]
    public RgbColorModelHex? RgbColorModelHex { get => _RgbColorModelHex; set => UpdateField(ref _RgbColorModelHex, value, nameof(RgbColorModelHex)); }

    private RgbColorModelHex? _RgbColorModelHex;
    /// <summary>
    /// Hue, saturation, luminance color model.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorReplacement.HslColor))]
    /// <summary>
    /// Hue, saturation, luminance color model.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ColorReplacement))]
    public HslColor? HslColor { get => _HslColor; set => UpdateField(ref _HslColor, value, nameof(HslColor)); }

    private HslColor? _HslColor;
    /// <summary>
    /// System color.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorReplacement.SystemColor))]
    /// <summary>
    /// System color.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ColorReplacement))]
    public SystemColor? SystemColor { get => _SystemColor; set => UpdateField(ref _SystemColor, value, nameof(SystemColor)); }

    private SystemColor? _SystemColor;
    /// <summary>
    /// Scheme color.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorReplacement.SchemeColor))]
    /// <summary>
    /// Scheme color.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ColorReplacement))]
    public SchemeColor? SchemeColor { get => _SchemeColor; set => UpdateField(ref _SchemeColor, value, nameof(SchemeColor)); }

    private SchemeColor? _SchemeColor;
    /// <summary>
    /// Preset color.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorReplacement.PresetColor))]
    /// <summary>
    /// Preset color.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ColorReplacement))]
    public PresetColor? PresetColor { get => _PresetColor; set => UpdateField(ref _PresetColor, value, nameof(PresetColor)); }

    private PresetColor? _PresetColor;
    /// <summary>
    /// List of extension elements.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ColorReplacement))]
    public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

    private ExtensionList? _ExtensionList;
}