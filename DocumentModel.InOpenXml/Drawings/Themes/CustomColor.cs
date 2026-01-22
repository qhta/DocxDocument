namespace DocumentModel.Drawings;
/// <summary>
///   Custom color.
/// </summary>
[OpenXmlType(typeof(DXD.CustomColor))]
/// <summary>
///   Custom color.
/// </summary>
public partial class CustomColor : ModelElement<DXD.CustomColor>
{
    /// <summary>
    ///   Name
    /// </summary>
    [OpenXmlProperty(nameof(DXD.CustomColor.Name))]
    public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }

    private string? _Name;
    /// <summary>
    ///   RGB Color Model - Percentage Variant.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.CustomColor.RgbColorModelPercentage))]
    public RgbColorModelPercentage? RgbColorModelPercentage { get; set; }

    /// <summary>
    ///   RGB Color Model - Hex Variant.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.CustomColor.RgbColorModelHex))]
    public RgbColorModelHex? RgbColorModelHex { get; set; }

    /// <summary>
    ///   Hue, Saturation, Luminance Color Model.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.CustomColor.HslColor))]
    public HslColor? HslColor { get; set; }

    /// <summary>
    ///   System Color.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.CustomColor.SystemColor))]
    public SystemColor? SystemColor { get; set; }

    /// <summary>
    ///   Scheme Color.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.CustomColor.SchemeColor))]
    public SchemeColor? SchemeColor { get; set; }

    /// <summary>
    ///   Preset Color.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.CustomColor.PresetColor))]
    public PresetColor? PresetColor { get; set; }
}